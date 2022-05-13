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

    public partial class ARForm : Form {
        readonly String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        readonly String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";
        bool connectRIS = false;
        OleDbConnection connection = null;

        public ARForm() {
            InitializeComponent();
        }

        private void GLListing_FormClosing(object sender, FormClosingEventArgs e) {
            DisconnectFromDatabases();
        }

        private void DisconnectFromDatabases() {
            try {
                connection = new OleDbConnection(OLDBEConnect);
                connection.Close();
                connection = new OleDbConnection(OLDBEConnectRIS);
                connection.Close();
                connectRMPToolStripMenuItem1.Enabled = true;
                connectRISToolStripMenuItem2.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void Run() {
            this.Cursor = Cursors.WaitCursor;

            if (connectRIS == false) {
                connection = new OleDbConnection(OLDBEConnect);
            } else {
                connection = new OleDbConnection(OLDBEConnectRIS);
            }

            OleDbCommand command = new OleDbCommand(QueryBuilder(), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command) {
                SelectCommand = command
            };

            DataTable table = new DataTable();
            adapter.Fill(table);

            DataColumn dc = new DataColumn(" ", typeof(bool));
            dc.DefaultValue = true;
            table.Columns.Add(dc);
            dc.SetOrdinal(0);

            dataTable.DataSource = table;
            this.Cursor = Cursors.Default;
        }

        private string QueryBuilder() {
            string query = "SELECT " +
                               "t1.GLCashMajorAcct, " +
                               "t1.CustAcct, " +
                               "t1.CustomerName, " +
                               "SWITCH(" +
                                    "t1.PmtGroupDescription='(UnAssigned)', ''," +
                                    "t1.PmtGroupDescription<>'(UnAssigned)', t1.PmtGroupDescription" +
                               ") AS PmtGroupDescription, " +
                               "t1.CheckNum, " +
                               "t1.PmtDate, " +
                               "t1.CheckAmt AS ARM, " +
                               "t2.CheckAmt " +
                           "FROM " +
                               "(" +
                                  "SELECT " +
                                     "a.GLCashMajorAcct, " +
                                     "a.CustAcct, " +
                                     "a.CustomerName, " +
                                     "b.PmtGroupDescription, " +
                                     "a.CheckNum, " +
                                     "a.PmtDate, " +
                                     "a.CheckAmt " +
                                  "FROM " +
                                     "dbo_vCustomerPaymentSummary AS a " +
                                     "INNER JOIN dbo_vCustomers AS b " +
                                     "ON a.CustAcct = b.CustAcct " +
                                  "WHERE " +
                                     "a.PmtDate = '" + DatePicker.Value.ToString("yyyy-MM-dd") + "' " +
                                     "AND a.GLCashMajorAcct = '" + GLNumberField.Text + "' " +
                                  "ORDER BY " +
                                     "a.CheckNum " +
                               ") AS t1 " +
                               "INNER JOIN " +
                               "(" +
                                  "SELECT " +
                                     "c.CheckNum, " +
                                     "SUM(c.CheckAmt) AS CheckAmt " +
                                  "FROM " +
                                     "dbo_vCustomerPaymentSummary AS c " +
                                     "INNER JOIN dbo_vCustomers AS d " +
                                     "ON c.CustAcct = d.CustAcct " +
                                  "WHERE " +
                                      "c.PmtDate= '" + DatePicker.Value.ToString("yyyy-MM-dd") + "' " +
                                      "AND c.GLCashMajorAcct = '" + GLNumberField.Text + "' " +
                                  "GROUP BY " +
                                     "c.CheckNum " +
                                  "ORDER BY " +
                                     "c.CheckNum " +
                               ") AS t2 " +
                               "ON t1.CheckNum = t2.CheckNum;";
            return query;
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
                        phrase = new Phrase("TOTAL: " + GetTotal().ToString("C"), headerFont);
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

        private void ConnectRMPToolStripMenuItem1_Click(object sender, EventArgs e) {
            //    this.Cursor = Cursors.WaitCursor;

            //    connectedRIS = false;
            //    try {
            //        connection = new OleDbConnection(OLDBEConnectRIS);
            //        connection.Close();
            //        connection = new OleDbConnection(OLDBEConnect);
            //        connection.Open();
            //        connectRISToolStripMenuItem2.Enabled = true;
            //        connectRMPToolStripMenuItem1.Enabled = false;
            //    } catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //    columns.Clear();
            //    columns.Add("TransDate");
            //    columns.Add("Major");
            //    columns.Add("SubAcct");
            //    columns.Add("EntryDescription");
            //    columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred");
            //    columns.Add("Dept");
            //    columns.Add("TransSource");
            //    columns.Add("TransType");
            //    columns.Add("GLTransID");
            //    columns.Add("GLEntryID");
            //    try {
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT DeptName, DeptCode FROM dbo_GLDepts;", connection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
            //        DataSet dataSet = new DataSet();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        oleDbDataAdapter.Fill(dataSet);
            //        departmentList.Clear();
            //        departmentList.Add(new ComboBoxItem("(All)", "0"));
            //        departmentBox.Items.Add(departmentList[0]);
            //        for (int i = 1; i < dataSet.Tables[0].Rows.Count + 1; i++) {
            //            departmentList.Add(new ComboBoxItem(dataSet.Tables[0].Rows[i - 1][0].ToString(), dataSet.Tables[0].Rows[i - 1][1].ToString()));
            //            departmentBox.Items.Add(departmentList[i]);
            //        }
            //        departmentBox.Sorted = true;
            //        departmentBox.Text = departmentList[0].department;
            //    } catch (Exception ex2) {
            //        MessageBox.Show(ex2.Message);
            //    }
            //    try {
            //        majorNumberDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
            //        majorNumberDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
            //        majorNumberDropdown.Items.Insert(1, new ComboBoxItem("Create", "2"));
            //        majorNumberDropdown.SelectedIndex = majorNumberDropdown.FindString("All");
            //    } catch (Exception ex3) {
            //        MessageBox.Show(ex3.Message);
            //    }
            //    try {
            //        subAccountDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
            //        subAccountDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
            //        subAccountDropdown.Items.Insert(1, new ComboBoxItem("Create", "2"));
            //        subAccountDropdown.SelectedIndex = subAccountDropdown.FindString("All");
            //    } catch (Exception ex4) {
            //        MessageBox.Show(ex4.Message);
            //    }
            //    majorNumberList.CheckOnClick = true;
            //    subAccountList.CheckOnClick = true;

            //    this.Cursor = Cursors.Default;
            //}

            //private void ConnectRISToolStripMenuItem2_Click(object sender, EventArgs e) {
            //    connectedRIS = true;
            //    try {
            //        connection = new OleDbConnection(OLDBEConnect);
            //        connection.Close();
            //        connection = new OleDbConnection(OLDBEConnectRIS);
            //        Cursor = Cursors.WaitCursor;
            //        connection.Open();
            //        connectRMPToolStripMenuItem1.Enabled = true;
            //        connectRISToolStripMenuItem2.Enabled = false;
            //        Cursor = Cursors.Default;
            //    } catch (Exception ex) {
            //        MessageBox.Show(ex.Message);
            //    }
            //    columns.Clear();
            //    columns.Add("TransDate");
            //    columns.Add("Major");
            //    columns.Add("SubAcct");
            //    columns.Add("EntryDescription");
            //    columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred");
            //    columns.Add("Dept");
            //    columns.Add("TransSource");
            //    columns.Add("TransType");
            //    columns.Add("GLTransID");
            //    columns.Add("GLEntryID");
            //    try {
            //        OleDbCommand selectCommand = new OleDbCommand("SELECT DeptName, DeptCode FROM dbo_GLDepts;", connection);
            //        OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
            //        DataSet dataSet = new DataSet();
            //        oleDbDataAdapter.SelectCommand = selectCommand;
            //        oleDbDataAdapter.Fill(dataSet);
            //        departmentList.Clear();
            //        departmentList.Add(new ComboBoxItem("(All)", "0"));
            //        departmentBox.Items.Add(departmentList[0]);
            //        for (int i = 1; i < dataSet.Tables[0].Rows.Count + 1; i++) {
            //            departmentList.Add(new ComboBoxItem(dataSet.Tables[0].Rows[i - 1][0].ToString(), dataSet.Tables[0].Rows[i - 1][1].ToString()));
            //            departmentBox.Items.Add(departmentList[i]);
            //        }
            //        departmentBox.Sorted = true;
            //        departmentBox.Text = departmentList[0].department;
            //    } catch (Exception ex2) {
            //        MessageBox.Show(ex2.Message);
            //    }

            //    this.Cursor = Cursors.Default;
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
            
        private double GetTotal() {
            double total = 0;
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                if ((bool) dataTable.Rows[i].Cells[0].Value == true) { 
                    total += Convert.ToDouble(dataTable.Rows[i].Cells[7].Value);
                }
            }

            return total;
        }

        private void DataTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dataTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void SelectAllButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < dataTable.Rows.Count; i++) { 
                dataTable.Rows[i].Cells[0].Value= true; 
            }
        }

        private void DeselectAllButton_Click(object sender, EventArgs e) {
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                dataTable.Rows[i].Cells[0].Value = false;
            }
        }

        private void RefreshTotalButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;
            TotalAmount.Text = GetTotal().ToString("C");
            this.Cursor = Cursors.Default;
        }

        private void GlNumberField_Load(object sender, EventArgs e) {
            GLNumberField.Text = "1045";
        }

        private void QueryButton_Click(object sender, EventArgs e) {
            this.Run();
        }
    }
}
