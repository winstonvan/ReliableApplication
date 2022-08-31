using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Text.RegularExpressions;
using TestProject;

namespace Reliable {
    public partial class InventoryCount : Form {
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        DataTable table = new DataTable();


        OleDbConnection connection = null;

        static int totalRecords = 0;
        static int pageSize = 15;

        public InventoryCount() {
            InitializeComponent();
            WarehouseDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
            WarehouseDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
            WarehouseDropdown.Items.Insert(1, new ComboBoxItem("Create", "2"));
            WarehouseDropdown.SelectedIndex = WarehouseDropdown.FindString("All");
            BinNumberDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
            BinNumberDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
            BinNumberDropdown.Items.Insert(1, new ComboBoxItem("Range", "2"));
            BinNumberDropdown.Items.Insert(1, new ComboBoxItem("Create", "3"));
            BinNumberDropdown.SelectedIndex = WarehouseDropdown.FindString("All");
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)  {
            List<Record> records = new List<Record>();
            int offset;

            try {
                offset = (int)bindingSource1.Current;
            } catch (Exception) { 
                offset = 0;
            }

            if (MiscellaneousPageBreak.Checked) {
                string[] current, previous;
                int pageCounter = 0;
                int binNumberGroupCounter = 0;
                for (int i = 0; i < totalRecords; i++) {
                    current = table.Rows[i]["BinNumber"].ToString().Split('-'); 
                    previous = table.Rows[i - 1]["BinNumber"].ToString().Split('-');

                    if (current[1] == previous[1]) { 
                        pageCounter++;
                    }

                    //if (current[1] == )
                }
                } else {
                for (int i = offset; i < offset + pageSize && i < totalRecords; i++) {
                    records.Add(new Record {
                        ItemCode = table.Rows[i]["ItemCode"].ToString(),
                        ItemDescription = table.Rows[i]["ItemDescription"].ToString(),
                        Comments2 = table.Rows[i]["Comments2"].ToString(),
                        StockOnHand = table.Rows[i]["StockOnHand"].ToString(),
                        ObsoleteFlag = table.Rows[i]["ObsoleteFlag"].ToString(),
                        ItemType = table.Rows[i]["ItemType"].ToString(),
                        BinNumber = table.Rows[i]["BinNumber"].ToString(),
                        Notes = table.Rows[i]["Notes"].ToString(),
                    });
                }
            }

            dataGridView1.DataSource = records;
        }

        class Record {
            public string ItemCode { get; set; }
            public string ItemDescription { get; set; }
            public string Comments2 { get; set; }
            public string StockOnHand { get; set; }
            public string ObsoleteFlag { get; set; }
            public string ItemType { get; set; }
            public string BinNumber { get; set; }
            public string Notes { get; set; }
        }

        class PageOffsetList : System.ComponentModel.IListSource {
            public bool ContainsListCollection { get; protected set; }

            public System.Collections.IList GetList() {
                // Return a list of page offsets based on "totalRecords" and "pageSize"
                var pageOffsets = new List<int>();
                for (int offset = 0; offset < totalRecords; offset += pageSize)
                    pageOffsets.Add(offset);
                return pageOffsets;
            }
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private string queryBuilder() {
            return "";
        }

        private void queryButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            dataGridView1.ClearSelection();

            string query = "" +
                "SELECT " +
                    "vInventoryItems.ItemCode, " +
                    "IIF(vInventoryItems.ItemDescription + vInventoryItems.ItemExtendedDescription = '', '', vInventoryItems.ItemDescription + vInventoryItems.ItemExtendedDescription, ) As ItemDescription, " +
                    "IIF(vInventoryItems.Comments2 = '', '', vInventoryItems.Comments2) AS Comments2, " +
                    "vInventoryItems.StockOnHand, " +
                    "vInventoryItems.ObsoleteFlag, " +
                    "vInventoryItems.ItemType, " +
                    "IIF(ICWHBals.BinNumber = '', '', ICWHBals.BinNumber) AS BinNumber, " +
                    "IIF(ICItems.ItemNotes = '', '', ICItems.ItemNotes) AS Notes " +
                    "" +
                "FROM " +
                    "(((dbo_vInventoryItems vInventoryItems " +
                    "INNER JOIN dbo_ICWHBals ICWHBals ON(ICWHBals.ItemID = vInventoryItems.ItemID)) " +
                    "INNER JOIN dbo_ICWhouse ICWhouse ON(ICWhouse.WHID = ICWHBals.WHID)) " +
                    "INNER JOIN dbo_ICItems ICItems ON(ICItems.ItemID = vInventoryItems.ItemID)) ";

            // OBSOLETE ITEMS
            string condition = "";
            if (IncludeObsoleteAll.Checked) {
                query += "WHERE (vInventoryItems.ObsoleteFlag = 'Y' OR vInventoryItems.ObsoleteFlag = 'N') ";
            } else if (IncludeObsoleteWithStock.Checked) { 
                query += "WHERE (vInventoryItems.StocKOnHand > 0) ";
            } else { 
                query += "WHERE (vInventoryItems.ObsoleteFlag <> 'Y') ";
            }

            // WAREHOUSE
            condition = "";
            if (WarehouseDropdown.Text == "Pick") {
                for (int i = 0; i < WarehouseList.CheckedItems.Count; i++) {
                    condition += "ICWhouse.WHID = " + WarehouseList.CheckedItems[i].ToString().Split('-')[0];

                    if (i != WarehouseList.CheckedItems.Count - 1) {
                        condition += " OR ";
                    }
                }
            } else if (WarehouseDropdown.Text == "Create") {
                string[] items = WarehouseCreateField.Text.Split('\n');
                for (int i = 0; i < items.Length; i++) {
                    condition += "ICWhouse.WHID = " + items[i].Trim();

                    if (i != items.Length - 1) {
                        condition += " OR ";
                    }
                }
            }

            query += condition == "" ? "" : "AND (" +  condition +  ") ";

            // BIN NUMBER
            condition = "";
            if (BinNumberDropdown.Text == "Pick") {
                for (int i = 0; i < BinNumberList.CheckedItems.Count; i++) {
                    condition += "ICWHBals.BinNumber = '" + BinNumberList.CheckedItems[i].ToString() + "' ";

                    if (i != BinNumberList.CheckedItems.Count - 1) {
                        condition += "OR ";
                    }
                }
            } else if (BinNumberDropdown.Text == "Create") {
                string[] items = BinNumberCreateField.Text.Split('\n');
                for (int i = 0; i < items.Length; i++) {
                    condition += "ICWHBals.BinNumber = '" + items[i].Trim() + "' ";

                    if (i != items.Length - 1) {
                        condition += "OR ";
                    }
                }
            }

            query += condition == "" ? "" : "AND (" + condition + ") ";


            if (SortByBinNumber.Checked || MiscellaneousPageBreak.Checked) {
                query += query.Contains("ORDER BY ") ? ", ICWHBals.BinNumber" : "ORDER BY ICWHBals.BinNumber";
            }

            if (SortByItemNumber.Checked) {
                query += query.Contains("ORDER BY ") ? ", vInventoryItems.ItemCode" : "ORDER BY vInventoryItems.ItemCode";
            }


            connection = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand(query, connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command) {
                SelectCommand = command
            };

            table.Clear();
            adapter.Fill(table);

            dataGridView1.DataSource = table;
            totalRecords = table.Rows.Count;

            bindingNavigator1.BindingSource = bindingSource1;
            bindingSource1.CurrentChanged += new System.EventHandler(bindingSource1_CurrentChanged);
            bindingSource1.DataSource = new PageOffsetList();

            this.Cursor = Cursors.Default;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void WarehouseDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            List<string> WarehouseIds = new List<string>();
            List<string> WarehouseDescs = new List<string>();

            if (WarehouseDropdown.Text == "All") {
                WarehouseList.Visible = true;
                WarehouseList.BackColor = Color.DarkGray;
            } else if (WarehouseDropdown.Text == "Create") {
                WarehouseCreateField.Visible = true;
                WarehouseList.Visible = false;
            } else if (WarehouseDropdown.Text == "Pick") {
                WarehouseList.Visible = true;
                WarehouseList.BackColor = Color.White;
                WarehouseCreateField.Visible = false;

                try {
                    WarehouseIds.Clear();
                    WarehouseDescs.Clear();
                    WarehouseList.Items.Clear();
                    connection = new OleDbConnection(OLDBEConnect);
                    OleDbCommand selectCommand = new OleDbCommand("SELECT WHID, WHDescription FROM dbo_ICWhouse ORDER BY WHID", connection);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.SelectCommand = selectCommand;
                    oleDbDataAdapter.Fill(dataSet);
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                        if (dataSet.Tables[0].Rows[i][0].ToString() == "") {
                            WarehouseIds.Add("IS NULL");
                            WarehouseDescs.Add("IS NULL");
                            WarehouseList.Items.Add("");
                        } else {
                            WarehouseIds.Add(dataSet.Tables[0].Rows[i][0].ToString());
                            WarehouseDescs.Add(dataSet.Tables[0].Rows[i][1].ToString());
                            WarehouseList.Items.Add(WarehouseIds[i] + " - " + WarehouseDescs[i]);
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BinNumberDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            if (BinNumberDropdown.Text == "All") {
                BinNumberList.Visible = true;
                BinNumberList.BackColor = Color.DarkGray;
                BinNumberCreateField.Visible = false;
                BinNumberRangeStart.Visible = false;
                BinNumberRangeEnd.Visible = false;
                BinNumberRangeDash.Visible = false;
            } else if (BinNumberDropdown.Text == "Create") {
                BinNumberList.Visible = false;
                BinNumberCreateField.Visible = true;
                BinNumberRangeStart.Visible = false;
                BinNumberRangeEnd.Visible = false;
                BinNumberRangeDash.Visible = false;
            } else if (BinNumberDropdown.Text == "Range") {
                BinNumberList.Visible = false;
                BinNumberCreateField.Visible = false;
                BinNumberRangeStart.Visible = true;
                BinNumberRangeEnd.Visible = true;
                BinNumberRangeDash.Visible = true;
            } else if (BinNumberDropdown.Text == "Pick") {
                BinNumberList.Visible = true;
                BinNumberCreateField.Visible = false;
                BinNumberList.BackColor = Color.White;
                BinNumberRangeStart.Visible = false;
                BinNumberRangeEnd.Visible = false;
                BinNumberRangeDash.Visible = false;
                try {
                    BinNumberList.Items.Clear();
                    string command = "" +
                                     "SELECT " +
                                        "DISTINCT BinNumber " +
                                     "FROM " +
                                        "dbo_ICWHBals " +
                                     "WHERE " +
                                        "BinNumber IS NOT NULL " +
                                        "AND BinNumber <> ''" +
                                     "ORDER BY " +
                                        "BinNumber ";
                    connection = new OleDbConnection(OLDBEConnect);
                    OleDbCommand selectCommand = new OleDbCommand(command, connection);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.SelectCommand = selectCommand;
                    oleDbDataAdapter.Fill(dataSet);
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                        if (dataSet.Tables[0].Rows[i][0].ToString() == "") {
                            BinNumberList.Items.Add("");
                        } else {
                            BinNumberList.Items.Add(dataSet.Tables[0].Rows[i]["BinNumber"].ToString());
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            SaveFileDialog sfd = new SaveFileDialog();
            string fileName = "Rebate Contracts Report " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".csv";
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = fileName;

            StreamWriter sw = new StreamWriter(sfd.FileName, false);
            //headers    
            for (int i = 1; i < table.Columns.Count; i++) {
                sw.Write(table.Columns[i].ColumnName);
                if (i < table.Columns.Count - 1) {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            for (int i = 0; i < table.Rows.Count - 1; i++) {
                for (int j = 1; j < table.Columns.Count; j++) {
                    if (!Convert.IsDBNull(table.Rows[i][j].ToString())) {
                        string value = table.Rows[i][j].ToString();
                        if (value.Contains(',')) {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        } else {
                            sw.Write(table.Rows[i][j].ToString());
                        }
                    }
                    if (j < dataGridView1.Columns.Count - 1) {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }

            sw.Close();
            Process.Start(sfd.FileName);

            Cursor = Cursors.Default;
        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            SaveFileDialog sfd = new SaveFileDialog();
            string fileName = "Inventory Count " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".pdf";
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
                        FileStream stream = new FileStream(sfd.FileName, FileMode.Create);
                        Document pdfDoc = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 30f, 30f);
                        PdfWriter.GetInstance(pdfDoc, stream);

                        PdfPTable pdfTable = new PdfPTable(table.Columns.Count);
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                        pdfTable.HeaderRows = 1;

                        //header
                        iTextSharp.text.Font headerFont = FontFactory.GetFont(FontFactory.COURIER_BOLD, 9);
                        BaseColor blue = new BaseColor(70, 130, 180);
                        BaseColor grey = new BaseColor(125, 125, 125);
                        Phrase phrase = new Phrase();
                        PdfPCell pdfCell;
                        foreach (DataColumn column in table.Columns) {
                            phrase = new Phrase(column.ColumnName, headerFont);
                            pdfCell = new PdfPCell(phrase) {
                                HorizontalAlignment = Element.ALIGN_CENTER,
                                VerticalAlignment = Element.ALIGN_CENTER,
                                Padding = 3,
                                BackgroundColor = blue
                            };
                            pdfTable.AddCell(pdfCell);
                        }

                        //body
                        iTextSharp.text.Font rowFont = FontFactory.GetFont(FontFactory.COURIER, 8);
                        for (int i = 0; i < table.Rows.Count; i++) {
                            for (int j = 0; j < table.Columns.Count; j++) {
                            
                            phrase = new Phrase(table.Rows[i][j].ToString(), rowFont);
                                pdfCell = new PdfPCell(phrase) {
                                    HorizontalAlignment = Element.ALIGN_CENTER,
                                    VerticalAlignment = Element.ALIGN_CENTER,
                                    Padding = 3,
                                    BorderColor = grey
                                };
                                pdfTable.AddCell(pdfCell);

                            //if (i != table.Rows.Count - 1) {
                            //    string[] current = table.Rows[i]["BinNumber"].ToString().Split('-');
                            //    string[] next = table.Rows[i + 1]["BinNumber"].ToString().Split('-');
                            //    int currentLength = current.Length;
                            //    int nextLength = next.Length;

                            //    if (currentLength > 0 && nextLength > 0) {
                            //        if (current[0] == next[0]) {
                            //            if (currentLength >= 2 && nextLength >= 2) {
                            //                if (current[1] == next[1]) {
                            //                    break;
                            //                }
                            //            }
                            //        }
                            //    }

                            //    pdfDoc.Open();
                            //    pdfDoc.Add(pdfTable);
                            //    pdfDoc.NewPage();

                            //    pdfTable = new PdfPTable(table.Columns.Count);
                            //    pdfTable.WidthPercentage = 100;
                            //    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
                            //    pdfTable.HeaderRows = 1;
                            //}
                        }
                    }

                        //resize columns
                        var total = 0;
                        int columns = table.Columns.Count;
                        var widths = new int[columns];
                        string[] headers = new string[columns];

                        for (int i = 0; i < columns; i++) {
                            headers[i] = table.Columns[i].ColumnName;
                        }


                        for (int i = 0; i < columns; i++) {
                            var w = headerFont.GetCalculatedBaseFont(true).GetWidth(headers[i]);
                            total += w;
                            widths[i] = w;
                        }

                        var result = new float[columns];
                        for (int i = 0; i < columns; i++) {
                            result[i] = (float)widths[i] / total * 100;
                        }


                        pdfTable.SetWidths(result);

                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                        Process.Start(sfd.FileName);
                    
                }
            }

            Cursor = Cursors.Default;
        }
    }
}
