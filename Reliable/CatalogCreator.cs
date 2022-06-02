using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DataGridViewAutoFilter;
using System.Configuration;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using Reliable;
using System.Drawing;
using System.Threading;
using Font = iTextSharp.text.Font;

namespace TestProject {

    public partial class CatalogCreator : Form {
        readonly String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Z:\\JMCat\\PCC\\Data\\RELMAP\\Demo.mdb;Jet OLEDB:Database Password=AJguess2ME; Persist Security Info=False;";
        OleDbConnection connection = null;

        public CatalogCreator() {
            InitializeComponent();
        }

        private void GLListing_FormClosing(object sender, FormClosingEventArgs e) {
            DisconnectFromDatabases();
        }

        private void DisconnectFromDatabases() {
            try {
                connection = new OleDbConnection(OLDBEConnect);
                connection.Close();
                connectRMPToolStripMenuItem1.Enabled = true;
                connectRISToolStripMenuItem2.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        public void Run() {
            this.Cursor = Cursors.WaitCursor;
            
            connection = new OleDbConnection(OLDBEConnect);

            OleDbCommand command = new OleDbCommand(GetData(false), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command) {
                SelectCommand = command
            };
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            dataTable.DataSource = table1;


            OleDbCommand command2 = new OleDbCommand(GetData(true), connection);
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2) {
                SelectCommand = command2
            };  
            DataTable table2 = new DataTable();
            adapter2.Fill(table2);
            dataTable2.DataSource = table2;

            this.Cursor = Cursors.Default;
        }

        private string GetData(bool selected) {
            string query =  "SELECT " +
                                "ItemNo, " +
                                "ItemGroupName, " +
                                "AttrPack, " +
                                "AttrSize, " +
                                "AttrColor, " +
                                "AttrMisc1, " +
                                "AttrMisc2 " +
                            "FROM " +
                                "ItemGroup INNER JOIN Item " +
                                "ON ItemGroup.ID = Item.ItemGroupID " +
                            "WHERE " +
                                "IsSelected = ";
            if (selected == false) {
                query += "FALSE";
            } else {
                query += "TRUE";
            }
            return query;
        }

        private void CatalogCreator_OnLoad(object sender, EventArgs e) {
            this.Run();
        }

        private void ExcelExportButton_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            SaveFileDialog sfd = new SaveFileDialog();
            string fileName = "AR Report " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".csv";
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = fileName;

            StreamWriter sw = new StreamWriter(sfd.FileName, false);
            //headers    
            for (int i = 1; i < dataTable.Columns.Count; i++) {
                sw.Write(dataTable.Columns[i].HeaderText);
                if (i < dataTable.Columns.Count - 1) {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                for (int j = 1; j < dataTable.Columns.Count; j++) {
                    if (!Convert.IsDBNull(dataTable.Rows[i].Cells[j].Value.ToString())) {
                        string value = dataTable.Rows[i].Cells[j].Value.ToString();
                        if (value.Contains(',')) {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        } else {
                            sw.Write(dataTable.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    if (j < dataTable.Columns.Count - 1) {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }

            sw.Close();
            Process.Start(sfd.FileName);

            Cursor = Cursors.Default;
        }

        //THe function below is used to convert the current data in the DGV into a pdf which can be used by the end user.
        private void PDFExportButton_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            for (int i = 0; i < dataTable.Rows.Count; i++) {
                if (Convert.ToBoolean(dataTable.Rows[i].Cells[0].Value) == true) {
                    break;
                }
            }

            SaveFileDialog sfd = new SaveFileDialog();
            string fileName = "AR Report " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".pdf";
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = fileName;
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK) {
                if (File.Exists(sfd.FileName)) {
                    try {
                        File.Delete(sfd.FileName);
                    } catch (IOException ex) {
                        fileError = true;
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                if (!fileError) {
                    try {
                        FileStream stream = new FileStream(sfd.FileName, FileMode.Create);
                        Document pdfDoc = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 30f, 30f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        PdfPTable pdfTable = new PdfPTable(dataTable.Columns.Count - 1);
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.HeaderRows = 1;

                        //title
                        pdfDoc.AddHeader("123", "456");

                        //header
                        Font headerFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 9);
                        BaseColor blue = new BaseColor(70, 130, 180);
                        BaseColor grey = new BaseColor(125, 125, 125);
                        Phrase phrase = new Phrase();
                        PdfPCell pdfCell;
                        foreach (DataGridViewColumn column in dataTable.Columns) {
                            if (column.HeaderText != " ") {
                                phrase = new Phrase(column.HeaderText, headerFont);
                                pdfCell = new PdfPCell(phrase) {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    VerticalAlignment = Element.ALIGN_CENTER,
                                    Padding = 3,
                                    BackgroundColor = blue
                                };
                                pdfTable.AddCell(pdfCell);
                            }
                        }

                        //body
                        Font rowFont = FontFactory.GetFont(FontFactory.COURIER, 8);
                        foreach (DataGridViewRow row in dataTable.Rows) {
                            if (Convert.ToBoolean(row.Cells[0].Value)) {
                                foreach (DataGridViewCell cell in row.Cells) {
                                    if (cell.ColumnIndex != 0) {
                                        phrase = new Phrase(cell.Value.ToString(), rowFont);
                                        pdfCell = new PdfPCell(phrase) {
                                            HorizontalAlignment = Element.ALIGN_CENTER,
                                            VerticalAlignment = Element.ALIGN_CENTER,
                                            Padding = 3,
                                            BorderColor = grey
                                        };
                                        pdfTable.AddCell(pdfCell);
                                    }
                                }
                            }
                        }

                        //totals
                        PdfPTable pdfTable2 = new PdfPTable(1) {
                            WidthPercentage = 100,
                            HorizontalAlignment = Element.ALIGN_CENTER,
                        };
                        //phrase = new Phrase("TOTAL: " + GetTotal().ToString("C"), headerFont);
                        pdfCell = new PdfPCell(phrase) {
                            HorizontalAlignment = Element.ALIGN_RIGHT,
                            VerticalAlignment = Element.ALIGN_CENTER,
                            Padding = 5,
                            BorderColor = grey,
                            BackgroundColor = grey
                        };
                        pdfTable2.AddCell(pdfCell);

                        //resize columns
                        float[] maxWidths = new float[pdfTable.NumberOfColumns];
                        float cellWidth;
                        string s;
                        for (int i = 0; i < pdfTable.Size; i++) {
                            for (int j = 0; j < pdfTable.NumberOfColumns; j++) {
                                try {
                                    s = pdfTable.GetRow(i).GetCells()[j].Phrase[0].ToString();
                                } catch {
                                    s = "";
                                }
                                cellWidth = rowFont.GetCalculatedBaseFont(true).GetWidthPoint(s, headerFont.CalculatedSize);

                                if (cellWidth > maxWidths[j] - 5) {
                                    maxWidths[j] = cellWidth + 5;
                                }
                            }
                        }
                        pdfTable.SetWidths(maxWidths);

                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Add(pdfTable2);
                        pdfDoc.Close();
                        stream.Close();
                        Process.Start(sfd.FileName);
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            Cursor = Cursors.Default;
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AddButton_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection table = dataTable.SelectedRows;
            OleDbCommand command = new OleDbCommand();
            connection = new OleDbConnection(OLDBEConnect);                    
            connection.Open();

            string itemNo;
            string query;
            if (table.Count != 0) {
                for (int i = 0; i < table.Count; i++) {
                    itemNo = dataTable.SelectedRows[i].Cells["ItemNo"].Value.ToString();
                    query = "UPDATE Item SET [IsSelected] = TRUE WHERE [ItemNo] = '" + itemNo + "'";
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
            this.Run();
        }

        private void RemoveButton_Click(object sender, EventArgs e) {
            DataGridViewSelectedRowCollection table = dataTable2.SelectedRows;
            OleDbCommand command = new OleDbCommand();
            connection = new OleDbConnection(OLDBEConnect);
            connection.Open();

            string itemNo;
            string query;
            if (table.Count != 0) {
                for (int i = 0; i < table.Count; i++) {
                    itemNo = dataTable2 .SelectedRows[i].Cells["ItemNo"].Value.ToString();
                    query = "UPDATE Item SET [IsSelected] = FALSE WHERE [ItemNo] = '" + itemNo + "'";
                    command.Connection = connection;
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
            this.Run();
        }

        private void NotSelectedSearchBar_TextChanged(object sender, EventArgs e) {
            (dataTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemNo LIKE '{0}%' OR ItemGroupName LIKE '{0}%'", NotSelectedSearchbar.Text);
        }

        private void SelectedSearchBar_TextChanged(object sender, EventArgs e) {
            (dataTable2.DataSource as DataTable).DefaultView.RowFilter = string.Format("ItemNo LIKE '{0}%' OR ItemGroupName LIKE '{0}%'", SelectedSearchbar.Text);
        }
        private void ImportButton_Click(object sender, EventArgs e) {
            CatalogCreatorImportDialog dialog = new CatalogCreatorImportDialog(this);
            dialog.Closed += (s, args) => this.Close();
            dialog.Show();
        }

        private void DatabaseList_Load(object sender, EventArgs e) {

        }

        private void DatabaseList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void Instructions_Click(object sender, EventArgs e) {

        }
    }
}
