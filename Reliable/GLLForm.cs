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

namespace TestProject {

    public partial class GLListing : Form {
        bool connectedRIS = false;
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";
        String query = null;
        BindingSource myBindingSource = new BindingSource();
        OleDbConnection connection = null;
        List<ComboBoxItem> departmentList = new List<ComboBoxItem>();
        List<string> columns = new List<string>();
        private List<string> majorAccts = new List<string>();
        private List<string> majorAcctsDesc = new List<string>();
        private List<string> subAccts = new List<string>();
        private List<string> subAcctsDesc = new List<string>();
        int descriptionCol = 0;
        int subAcctCol = 0;
        int debCred = 0;

        public GLListing() {
            InitializeComponent();
        }
        private void RunQuery_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            if (accountTypeCheckbox.Checked) {
                if (columns.Contains("AcctType")) {
                    columns.RemoveAt(columns.LastIndexOf("AcctType"));
                }
                columns.Add("AcctType");
            } else if (!accountTypeCheckbox.Checked && columns.Contains("AcctType")) {
                columns.RemoveAt(columns.LastIndexOf("AcctType"));
            }

            query = QueryBuilder(columns, "dbo_vGLAccountHistory");
            RunQuery(glQueryDGV, query);
            netChange.Text = SumColumn(4).ToString("C");

            if (!(majorNumberDropdown.SelectedItem.ToString() == "All")) {
                string condition = "";
                if (majorNumberDropdown.SelectedItem.ToString() == "Create") {
                    string[] majorNumbers = majorNumberCreateField.Text.Split('\n');
                    for (int i = 0; i < majorNumbers.Length; i++) {
                        condition += "Major = '" + majorNumbers[i] + "' ";

                        if (i != majorNumbers.Length - 1) {
                            condition += "OR ";
                        }
                    }
                } else if (majorNumberDropdown.SelectedItem.ToString() == "Pick") {
                    for (int i = 0; i < majorNumberList.CheckedItems.Count; i++) {
                        condition += "Major = '" + majorNumberList.CheckedItems[i].ToString().Split('-')[0] + "' ";

                        if (i != majorNumberList.CheckedItems.Count - 1) {
                            condition += "OR ";
                        }
                    }
                }
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + startDatePicker.Value.AddDays(-1).ToString("MM-dd-yyyy") + "' AND " + condition;
                RunSingleQuery(beginningBalance);
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + endDatePicker.Value.ToString("MM-dd-yyyy") + "' AND " + condition;
                RunSingleQuery(endingBalance);
            } else {
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + startDatePicker.Value.AddDays(-1).ToString("MM-dd-yyyy") + "'";
                RunSingleQuery(beginningBalance);
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + endDatePicker.Value.ToString("MM-dd-yyyy") + "'";
                RunSingleQuery(endingBalance);
            }
            Cursor = Cursors.Default;
        }

        private void GLListing_Load(object sender, EventArgs e) {
            connectRMPToolStripMenuItem1.PerformClick();
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

        private void RunQuery(DataGridView myGrid, string query) {
            try {
                myBindingSource.Filter = null;
                OleDbCommand selectCommand = new OleDbCommand(query, connection);
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                oleDbDataAdapter.SelectCommand = selectCommand;
                oleDbDataAdapter.Fill(dataTable);
                DataView defaultView = dataTable.DefaultView;
                myBindingSource.DataSource = defaultView;
                myGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                myGrid.DataSource = myBindingSource;
                if (myGrid.DataSource == null) {
                    return;
                }
                foreach (DataGridViewColumn column in myGrid.Columns) {
                    if (column.HeaderCell.Value.ToString() == "EntryDescription") {
                        descriptionCol = column.Index;
                    } else if (column.HeaderCell.Value.ToString() == "DebCred") {
                        debCred = column.Index;
                    } else {
                        if (column.HeaderCell.Value.ToString() == "SubAcct") {
                            subAcctCol = column.Index;
                            continue;
                        }
                        if (column.HeaderCell.Value.ToString() == "AcctType") {
                            continue;
                        }
                    }
                    column.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(column.HeaderCell);
                }
                myGrid.AutoResizeColumns();
                myGrid.Columns[debCred].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                myGrid.Columns[debCred].DefaultCellStyle.Format = "C";
                myGrid.Columns[debCred].Width = 100;
                myGrid.Columns[descriptionCol].Width = 210;
                myGrid.Columns[subAcctCol].Width = 85;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        //The query function below is used to run the query necessary for obtaining the beginning and ending balances of the GLL
        private void RunSingleQuery(Label myLabel) {
            OleDbCommand selectCommand = new OleDbCommand(query, connection);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
            DataTable dataTable = new DataTable();
            oleDbDataAdapter.SelectCommand = selectCommand;
            oleDbDataAdapter.Fill(dataTable);
            if (dataTable.Rows[0].IsNull(0)) {
                myLabel.Text = "";
                return;
            }
            double value = dataTable.Rows[0].Field<double>(0);
            double value2 = Convert.ToDouble(value);
            myLabel.Text = Math.Round(value2, 2).ToString("C");
        }

        private string ConvertDateFormatting(DateTime myDate) {
            string month = ((myDate.Month > 9) ? myDate.Month.ToString() : ("0" + myDate.Month));
            string day = ((myDate.Day > 9) ? myDate.Day.ToString() : ("0" + myDate.Day));
            return myDate.Year + "-" + month + "-" + day;
        }

        private double SumColumn(int columnNumber) {
            double num = 0.0;
            for (int i = 0; i < glQueryDGV.Rows.Count - 1; i++) {
                num += (double)glQueryDGV.Rows[i].Cells[columnNumber].Value;
            }
            return num;
        }

        private string QueryBuilder(List<string> columns, string tableName) {
            string query = "SELECT ";

            columns.Clear();
            columns.Add("TransDate");
            columns.Add("Major");
            columns.Add("SubAcct");
            columns.Add("EntryDescription");
            columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred");
            columns.Add("Dept");
            columns.Add("TransSource");
            columns.Add("TransType");
            columns.Add("GLTransID");
            columns.Add("GLEntryID");

            // add columns to SELECT clause
            foreach (string column in columns) {
                if (columns.Last() == column) {
                    query += column + " ";
                    break;
                }
                query = query + column + ", ";
            }

            // add table name to FROM clause
            query += "FROM " + tableName + " ";
            if (!(majorNumberDropdown.SelectedItem.ToString() == "All")) {
                string condition = "";
                if (majorNumberDropdown.SelectedItem.ToString() == "Create") {
                    string[] majorNumbers = majorNumberCreateField.Text.Split('\n');
                    for (int i = 0; i < majorNumbers.Length; i++) {
                        condition += "Major = '" + majorNumbers[i] + "' ";

                        if (i != majorNumbers.Length - 1) {
                            condition += "OR ";
                        }
                    }
                } else if (majorNumberDropdown.SelectedItem.ToString() == "Pick") {
                    for (int i = 0; i < majorNumberList.CheckedItems.Count; i++) {
                        condition += "Major = '" + majorNumberList.CheckedItems[i].ToString().Split('-')[0] + "' ";

                        if (i != majorNumberList.CheckedItems.Count - 1) {
                            condition += "OR ";
                        }
                    }
                }
                query += "WHERE (" + condition + ") ";
            }
            if (!(((ComboBoxItem)departmentBox.SelectedItem).value == "0")) {
                query = ((!(((ComboBoxItem)departmentBox.SelectedItem).value == "")) ? (query + "AND Dept = '" + ((ComboBoxItem)departmentBox.SelectedItem).value + "' ") : (query + "AND Dept IS NULL "));
            }
            if (accountTypes.Visible) {
                int num = 0;
                foreach (string type in accountTypes.CheckedItems) {
                    query = ((num != 0) ? (query + "OR AcctType = '" + type.First() + "' ") : (query + "AND (AcctType = '" + type.First() + "' "));
                    if (num == accountTypes.CheckedItems.Count - 1) {
                        query += ") ";
                    }
                    num++;
                }
            }
            if (!(subAccountDropdown.SelectedItem.ToString() == "All")) {
                string condition = "";
                if (subAccountDropdown.SelectedItem.ToString() == "Create") {
                    string[] subAccounts = subAccountCreateField.Text.Split('\n');
                    for (int i = 0; i < subAccounts.Length; i++) {
                        condition += "SubAcct = '" + subAccounts[i] + "' ";

                        if (i != subAccounts.Length - 1) {
                            condition += "OR ";
                        }
                    }
                } else if (subAccountDropdown.SelectedItem.ToString() == "Pick") {
                    for (int i = 0; i < subAccountList.CheckedItems.Count; i++) {
                        condition += "SubAcct = '" + subAccountList.CheckedItems[i].ToString() + "' ";

                        if (i != subAccountList.CheckedItems.Count - 1) {
                            condition += "OR ";
                        }
                    }
                }
                query += "AND (" + condition + ") ";
            }

            if (majorNumberDropdown.SelectedItem.ToString() == "All" && subAccountDropdown.SelectedItem.ToString() == "All") {
                query += "WHERE ";
            } else {
                query += "AND ";
            }
            query += "(TransDate BETWEEN '" + startDatePicker.Value.Date.ToString("yyyy-MM-dd") + "' AND '" + endDatePicker.Value.Date.ToString("yyyy-MM-dd") + "') " +
                    "ORDER BY TransDate ";

            return query;
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel._Application application = (Microsoft.Office.Interop.Excel.Application)Activator.CreateInstance(System.Runtime.InteropServices.Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
            Microsoft.Office.Interop.Excel._Workbook workbook = application.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            try {
                worksheet = (dynamic)workbook.ActiveSheet;
                worksheet.Name = "General Ledger Listing for ";
                int num = 1;
                int num2 = 1;
                for (int i = 0; i < glQueryDGV.Rows.Count - 1; i++) {
                    for (int j = 0; j < glQueryDGV.Columns.Count; j++) {
                        if (num == 1) {
                            worksheet.Cells[num, num2] = glQueryDGV.Columns[j].HeaderText;
                        } else {
                            worksheet.Cells[num, num2] = glQueryDGV.Rows[i].Cells[j].Value.ToString();
                        }
                        num2++;
                    }
                    num2 = 1;
                    num++;
                }
                for (int k = 0; k < glQueryDGV.Columns.Count; k++) {
                    if (glQueryDGV.Columns[k].HeaderText == "EntryDescription") {
                        worksheet.Cells[num, k + 1] = "TOTALS:";
                    } else if (k == glQueryDGV.Columns.Count - 2) {
                        worksheet.Cells[num, k + 1] = "CHANGE:";
                    } else if (k == glQueryDGV.Columns.Count - 1) {
                        worksheet.Cells[num, k + 1] = netChange.Text.ToString();
                    }
                }
                num++;
                for (int l = 0; l < glQueryDGV.Columns.Count; l++) {
                    if (l == glQueryDGV.Columns.Count - 2) {
                        worksheet.Cells[num, l + 1] = "BEGINNING BALANCE:";
                    } else if (l == glQueryDGV.Columns.Count - 1) {
                        worksheet.Cells[num, l + 1] = beginningBalance.Text.ToString();
                    }
                }
                num++;
                for (int m = 0; m < glQueryDGV.Columns.Count; m++) {
                    if (m == glQueryDGV.Columns.Count - 2) {
                        worksheet.Cells[num, m + 1] = "ENDING BALANCE:";
                    } else if (m == glQueryDGV.Columns.Count - 1) {
                        worksheet.Cells[num, m + 1] = endingBalance.Text.ToString();
                    }
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel\u00a0files\u00a0(*.xlsx)|*.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                application.Quit();
                worksheet = null;
                application = null;
            }
            Cursor = Cursors.Default;
        }

        //THe function below is used to convert the current data in the DGV into a pdf which can be used by the end user.
        private void pDFToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;
            string text = null;
            BaseColor borderColor = new BaseColor(0, 0, 0);
            BaseColor backgroundColor = new BaseColor(70, 130, 180);
            BaseColor backgroundColor2 = new BaseColor(255, 255, 255);
            BaseColor backgroundColor3 = new BaseColor(200, 200, 200);
            BaseColor baseColor = new BaseColor(125, 125, 125);
            text = (connectedRIS ? "Z:\\GLListings\\RIS\\" : "Z:\\GLListings\\RMP\\");
            if (!Directory.Exists(text)) {
                Directory.CreateDirectory(text);
            }
            FileStream os = new FileStream(text + "GeneralLedger " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".pdf", FileMode.Create);
            Document document = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 30f, 30f);
            PdfWriter instance = PdfWriter.GetInstance(document, os);
            document.AddAuthor("Reliable");
            document.AddCreator("This document was created using iTextSharp");
            document.AddTitle("General Ledger Listing");
            document.Open();
            PdfContentByte directContent = instance.DirectContent;
            BaseFont baseFont = FontFactory.GetFont("Courier-Bold").BaseFont;
            BaseFont baseFont2 = FontFactory.GetFont("Courier").BaseFont;
            int num = 0;
            num = ((!accountTypeCheckbox.Checked) ? 652 : 697);
            iTextSharp.text.Rectangle rectangle = new iTextSharp.text.Rectangle(20f, 573f, num, 590f);
            rectangle.Border = 15;
            rectangle.BackgroundColor = backgroundColor;
            rectangle.BorderWidth = 1f;
            rectangle.BorderColor = borderColor;
            directContent.Rectangle(rectangle);
            directContent.BeginText();
            directContent.SetFontAndSize(baseFont, 10f);
            int num2 = 25;
            for (int i = 0; i < glQueryDGV.Columns.Count; i++) {
                switch (i) {
                    case 0:
                        directContent.ShowTextAligned(1, "Date", num2 + 22, 578f, 0f);
                        num2 += 50;
                        break;
                    case 1:
                        directContent.ShowTextAligned(1, glQueryDGV.Columns[i].HeaderText, num2 + 18, 578f, 0f);
                        num2 += 37;
                        break;
                    case 2:
                        directContent.ShowTextAligned(1, "Sub Account", num2 + 37, 578f, 0f);
                        num2 += 75;
                        break;
                    case 3:
                        directContent.ShowTextAligned(1, "Entry Description", num2 + 100, 578f, 0f);
                        num2 += 200;
                        break;
                    case 4:
                        directContent.ShowTextAligned(1, glQueryDGV.Columns[i].HeaderText, num2 + 37, 578f, 0f);
                        num2 += 75;
                        break;
                    case 5:
                        directContent.ShowTextAligned(1, glQueryDGV.Columns[i].HeaderText, num2 + 15, 578f, 0f);
                        num2 += 30;
                        break;
                    case 6:
                        directContent.ShowTextAligned(1, "TS", num2 + 15, 578f, 0f);
                        num2 += 30;
                        break;
                    case 7:
                        directContent.ShowTextAligned(1, "TT", num2 + 15, 578f, 0f);
                        num2 += 30;
                        break;
                    case 8:
                        directContent.ShowTextAligned(1, "GLTID", num2 + 25, 578f, 0f);
                        num2 += 50;
                        break;
                    case 9:
                        directContent.ShowTextAligned(1, "GLEID", num2 + 25, 578f, 0f);
                        num2 += 50;
                        break;
                    case 10:
                        directContent.ShowTextAligned(1, "AType", num2 + 22, 578f, 0f);
                        num2 += 30;
                        break;
                }
            }
            directContent.EndText();
            directContent.SetLineWidth(1f);
            directContent.MoveTo(75f, 590f);
            directContent.LineTo(75f, 573f);
            directContent.Stroke();
            directContent.MoveTo(112f, 590f);
            directContent.LineTo(112f, 573f);
            directContent.Stroke();
            directContent.MoveTo(187f, 590f);
            directContent.LineTo(187f, 573f);
            directContent.Stroke();
            directContent.MoveTo(387f, 590f);
            directContent.LineTo(387f, 573f);
            directContent.Stroke();
            directContent.MoveTo(462f, 590f);
            directContent.LineTo(462f, 573f);
            directContent.Stroke();
            directContent.MoveTo(492f, 590f);
            directContent.LineTo(492f, 573f);
            directContent.Stroke();
            directContent.MoveTo(522f, 590f);
            directContent.LineTo(522f, 573f);
            directContent.Stroke();
            directContent.MoveTo(552f, 590f);
            directContent.LineTo(552f, 573f);
            directContent.Stroke();
            directContent.MoveTo(602f, 590f);
            directContent.LineTo(602f, 573f);
            directContent.Stroke();
            directContent.MoveTo(652f, 590f);
            directContent.LineTo(652f, 573f);
            directContent.Stroke();
            int num3 = 561;
            int num4 = 1;
            for (int j = 0; j < glQueryDGV.RowCount - 1; j++) {
                iTextSharp.text.Rectangle rectangle2 = new iTextSharp.text.Rectangle(20f, num3, num, num3 + 12);
                rectangle2.Border = 12;
                if (j % 2 == 0) {
                    rectangle2.BackgroundColor = backgroundColor2;
                } else {
                    rectangle2.BackgroundColor = backgroundColor3;
                }
                rectangle2.BorderWidth = 1f;
                rectangle2.BorderColor = borderColor;
                directContent.Rectangle(rectangle2);
                directContent.BeginText();
                directContent.SetFontAndSize(baseFont2, 8f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[0].Value.ToString(), 47f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[1].Value.ToString(), 93f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[2].Value.ToString(), 149f, num3 + 3, 0f);
                directContent.ShowTextAligned(0, glQueryDGV.Rows[j].Cells[3].Value.ToString(), 188f, num3 + 3, 0f);
                directContent.ShowTextAligned(2, Convert.ToDouble(glQueryDGV.Rows[j].Cells[4].Value.ToString()).ToString("C"), 461f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[5].Value.ToString(), 476f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[6].Value.ToString(), 506f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[7].Value.ToString(), 536f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[8].Value.ToString(), 586f, num3 + 3, 0f);
                directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[9].Value.ToString(), 636f, num3 + 3, 0f);
                if (accountTypeCheckbox.Checked) {
                    directContent.ShowTextAligned(1, glQueryDGV.Rows[j].Cells[10].Value.ToString(), 681f, num3 + 3, 0f);
                }
                directContent.EndText();
                directContent.SetLineWidth(1f);
                directContent.SetRGBColorStroke(100, 100, 100);
                directContent.MoveTo(75f, num3 + 12);
                directContent.LineTo(75f, num3);
                directContent.Stroke();
                directContent.MoveTo(112f, num3 + 12);
                directContent.LineTo(112f, num3);
                directContent.Stroke();
                directContent.MoveTo(187f, num3 + 12);
                directContent.LineTo(187f, num3);
                directContent.Stroke();
                directContent.MoveTo(387f, num3 + 12);
                directContent.LineTo(387f, num3);
                directContent.Stroke();
                directContent.MoveTo(462f, num3 + 12);
                directContent.LineTo(462f, num3);
                directContent.Stroke();
                directContent.MoveTo(492f, num3 + 12);
                directContent.LineTo(492f, num3);
                directContent.Stroke();
                directContent.MoveTo(522f, num3 + 12);
                directContent.LineTo(522f, num3);
                directContent.Stroke();
                directContent.MoveTo(552f, num3 + 12);
                directContent.LineTo(552f, num3);
                directContent.Stroke();
                directContent.MoveTo(602f, num3 + 12);
                directContent.LineTo(602f, num3);
                directContent.Stroke();
                directContent.MoveTo(652f, num3 + 12);
                directContent.LineTo(652f, num3);
                directContent.Stroke();
                directContent.SetRGBColorStroke(0, 0, 0);
                num3 -= 12;
                if (num3 > 30) {
                    continue;
                }
                directContent.SetLineWidth(1f);
                directContent.SetRGBColorStroke(100, 100, 100);
                directContent.MoveTo(20f, num3 + 12);
                directContent.LineTo(num, num3 + 12);
                directContent.Stroke();
                directContent.SetRGBColorStroke(0, 0, 0);
                directContent.BeginText();
                directContent.SetFontAndSize(baseFont2, 7f);
                directContent.ShowTextAligned(2, "Page: " + num4, 772f, 15f, 0f);
                directContent.EndText();
                num4++;
                document.NewPage();
                num3 = 561;
                iTextSharp.text.Rectangle rectangle3 = new iTextSharp.text.Rectangle(20f, 573f, num, 590f);
                rectangle3.Border = 15;
                rectangle3.BackgroundColor = backgroundColor;
                rectangle3.BorderWidth = 1f;
                rectangle3.BorderColor = borderColor;
                directContent.Rectangle(rectangle3);
                directContent.BeginText();
                directContent.SetFontAndSize(baseFont, 10f);
                num2 = 25;
                for (int k = 0; k < glQueryDGV.Columns.Count; k++) {
                    switch (k) {
                        case 0:
                            directContent.ShowTextAligned(1, "Date", num2 + 22, 578f, 0f);
                            num2 += 50;
                            break;
                        case 1:
                            directContent.ShowTextAligned(1, glQueryDGV.Columns[k].HeaderText, num2 + 18, 578f, 0f);
                            num2 += 37;
                            break;
                        case 2:
                            directContent.ShowTextAligned(1, "Sub Account", num2 + 37, 578f, 0f);
                            num2 += 75;
                            break;
                        case 3:
                            directContent.ShowTextAligned(1, "Entry Description", num2 + 100, 578f, 0f);
                            num2 += 200;
                            break;
                        case 4:
                            directContent.ShowTextAligned(1, glQueryDGV.Columns[k].HeaderText, num2 + 37, 578f, 0f);
                            num2 += 75;
                            break;
                        case 5:
                            directContent.ShowTextAligned(1, glQueryDGV.Columns[k].HeaderText, num2 + 15, 578f, 0f);
                            num2 += 30;
                            break;
                        case 6:
                            directContent.ShowTextAligned(1, "TS", num2 + 15, 578f, 0f);
                            num2 += 30;
                            break;
                        case 7:
                            directContent.ShowTextAligned(1, "TT", num2 + 15, 578f, 0f);
                            num2 += 30;
                            break;
                        case 8:
                            directContent.ShowTextAligned(1, "GLTID", num2 + 25, 578f, 0f);
                            num2 += 50;
                            break;
                        case 9:
                            directContent.ShowTextAligned(1, "GLEID", num2 + 25, 578f, 0f);
                            num2 += 50;
                            break;
                        case 10:
                            directContent.ShowTextAligned(1, "AType", num2 + 22, 578f, 0f);
                            num2 += 30;
                            break;
                    }
                }
                directContent.EndText();
                directContent.SetLineWidth(1f);
                directContent.MoveTo(75f, 590f);
                directContent.LineTo(75f, 573f);
                directContent.Stroke();
                directContent.MoveTo(112f, 590f);
                directContent.LineTo(112f, 573f);
                directContent.Stroke();
                directContent.MoveTo(187f, 590f);
                directContent.LineTo(187f, 573f);
                directContent.Stroke();
                directContent.MoveTo(387f, 590f);
                directContent.LineTo(387f, 573f);
                directContent.Stroke();
                directContent.MoveTo(462f, 590f);
                directContent.LineTo(462f, 573f);
                directContent.Stroke();
                directContent.MoveTo(492f, 590f);
                directContent.LineTo(492f, 573f);
                directContent.Stroke();
                directContent.MoveTo(522f, 590f);
                directContent.LineTo(522f, 573f);
                directContent.Stroke();
                directContent.MoveTo(552f, 590f);
                directContent.LineTo(552f, 573f);
                directContent.Stroke();
                directContent.MoveTo(602f, 590f);
                directContent.LineTo(602f, 573f);
                directContent.Stroke();
                directContent.MoveTo(652f, 590f);
                directContent.LineTo(652f, 573f);
                directContent.Stroke();
            }
            num3 += 12;
            if (num3 - 36 <= 10) {
                directContent.BeginText();
                directContent.SetFontAndSize(baseFont2, 7f);
                directContent.ShowTextAligned(2, "Page: " + num4, 772f, 15f, 0f);
                directContent.EndText();
                num4++;
                document.NewPage();
            }
            iTextSharp.text.Rectangle rectangle4 = new iTextSharp.text.Rectangle(20f, num3 - 36, num, num3);
            rectangle4.Border = 15;
            rectangle4.BackgroundColor = backgroundColor3;
            rectangle4.BorderWidth = 1f;
            rectangle4.BorderColor = borderColor;
            directContent.Rectangle(rectangle4);
            directContent.BeginText();
            directContent.SetFontAndSize(baseFont, 8f);
            if (accountTypeCheckbox.Checked) {
                directContent.ShowTextAligned(2, "TOTALS:", 386f, num3 - 9, 0f);
                directContent.ShowTextAligned(0, "CHANGE:", 628f, num3 - 9, 0f);
                directContent.ShowTextAligned(2, netChange.Text, 771f, num3 - 9, 0f);
                directContent.ShowTextAligned(0, "BEGINNING:", 628f, num3 - 21, 0f);
                directContent.ShowTextAligned(2, beginningBalance.Text, 771f, num3 - 21, 0f);
                directContent.ShowTextAligned(0, "ENDING:", 628f, num3 - 33, 0f);
                directContent.ShowTextAligned(2, endingBalance.Text, 771f, num3 - 33, 0f);
                directContent.EndText();
                directContent.SetLineWidth(1f);
                directContent.MoveTo(387f, num3);
                directContent.LineTo(387f, num3 - 12);
                directContent.MoveTo(462f, num3);
                directContent.LineTo(462f, num3 - 12);
                directContent.MoveTo(537f, num3);
                directContent.LineTo(537f, num3 - 12);
                directContent.MoveTo(627f, num3);
                directContent.LineTo(627f, num3 - 36);
                directContent.Stroke();
                directContent.MoveTo(20f, num3 - 12);
                directContent.LineTo(772f, num3 - 12);
                directContent.Stroke();
                directContent.MoveTo(20f, num3 - 24);
                directContent.LineTo(772f, num3 - 24);
                directContent.Stroke();
            } else {
                directContent.ShowTextAligned(2, "TOTALS:", 386f, num3 - 9, 0f);
                directContent.ShowTextAligned(0, "CHANGE:", 598f, num3 - 9, 0f);
                directContent.ShowTextAligned(2, netChange.Text, 726f, num3 - 9, 0f);
                directContent.ShowTextAligned(0, "BEGINNING:", 598f, num3 - 21, 0f);
                directContent.ShowTextAligned(2, beginningBalance.Text, 726f, num3 - 21, 0f);
                directContent.ShowTextAligned(0, "ENDING:", 598f, num3 - 33, 0f);
                directContent.ShowTextAligned(2, endingBalance.Text, 726f, num3 - 33, 0f);
                directContent.EndText();
                directContent.SetLineWidth(1f);
                directContent.MoveTo(387f, num3);
                directContent.LineTo(387f, num3 - 12);
                directContent.MoveTo(462f, num3);
                directContent.LineTo(462f, num3 - 12);
                directContent.MoveTo(537f, num3);
                directContent.LineTo(537f, num3 - 12);
                directContent.MoveTo(597f, num3);
                directContent.LineTo(597f, num3 - 36);
                directContent.Stroke();
                directContent.MoveTo(20f, num3 - 12);
                directContent.LineTo(727f, num3 - 12);
                directContent.Stroke();
                directContent.MoveTo(20f, num3 - 24);
                directContent.LineTo(727f, num3 - 24);
                directContent.Stroke();
            }
            directContent.BeginText();
            directContent.SetFontAndSize(baseFont2, 7f);
            directContent.ShowTextAligned(2, "Page: " + num4, 772f, 15f, 0f);
            directContent.EndText();
            num4++;
            document.Close();
            instance.Close();
            Process process = new Process();
            ProcessStartInfo processStartInfo2 = (process.StartInfo = new ProcessStartInfo());
            processStartInfo2.FileName = text + "GeneralLedger " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".pdf";
            process.Start();
            Cursor = Cursors.Default;
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            netChange.Text = (SumColumn(4)).ToString("C");

            //This section below of the refresh function is used to format the bindingsource filter string so that it correctly identifies fields that are numbers, as numbers and not text.
            if (!String.IsNullOrWhiteSpace(myBindingSource.Filter)) {
                string input = myBindingSource.Filter;
                string condition = "'| ";
                string[] output = Regex.Split(input, condition);
                string output1 = myBindingSource.Filter;

                for (int i = 0; i < output.Length - 1; i++) {
                    if (output[i] == "[GLTransID]=") {
                        string input1 = output1;
                        string regex1 = "\\[GLTransID\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[GLTransID]=" + output[i + 1]);

                    } else if (output[i] == "[Debit]=") {
                        string input1 = output1;
                        string regex1 = "\\[Debit\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[DebitAmount]=" + output[i + 1]);

                    } else if (output[i] == "[Credit]=") {
                        string input1 = output1;
                        string regex1 = "\\[Credit\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[CreditAmount]=" + output[i + 1]);

                    } else if (output[i] == "[GLEntryID]=") {
                        string input1 = output1;
                        string regex1 = "\\[GLEntryID\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[GLEntryID]=" + output[i + 1]);
                    }
                }

                if (!(majorNumberDropdown.SelectedItem.ToString() == "All")) {
                    condition = "";
                    if (majorNumberDropdown.SelectedItem.ToString() == "Create") {
                        string[] majorNumbers = majorNumberCreateField.Text.Split('\n');
                        for (int i = 0; i < majorNumbers.Length; i++) {
                            condition += "Major = '" + majorNumbers[i] + "' ";

                            if (i != majorNumbers.Length - 1) {
                                condition += "OR ";
                            }
                        }
                    } else if (majorNumberDropdown.SelectedItem.ToString() == "Pick") {
                        for (int i = 0; i < majorNumberList.CheckedItems.Count; i++) {
                            condition += "Major = '" + majorNumberList.CheckedItems[i].ToString().Split('-')[0] + " ";

                            if (i != majorNumberList.CheckedItems.Count - 1) {
                                condition += "OR ";
                            }
                        }
                    }
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + startDatePicker.Value.AddDays(-1).ToString("MM-dd-yyyy") + "' AND " + condition + "' AND " + output1;
                    RunSingleQuery(beginningBalance);
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + endDatePicker.Value.ToString("MM-dd-yyyy") + "' AND " + condition + "' AND " + output1;
                    RunSingleQuery(endingBalance);
                } else {
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + startDatePicker.Value.AddDays(-1).ToString("MM-dd-yyyy") + "' AND " + output1;
                    RunSingleQuery(beginningBalance);
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + endDatePicker.Value.ToString("MM-dd-yyyy") + "' AND " + output1;
                    RunSingleQuery(endingBalance);
                }
            } else {
                if (!(majorNumberDropdown.SelectedItem.ToString() == "All")) {
                    string condition = "";
                    if (majorNumberDropdown.SelectedItem.ToString() == "Create") {
                        string[] majorNumbers = majorNumberCreateField.Text.Split('\n');
                        for (int i = 0; i < majorNumbers.Length; i++) {
                            condition += "Major = '" + majorNumbers[i] + "' ";

                            if (i != majorNumbers.Length - 1) {
                                condition += "OR ";
                            }
                        }
                    } else if (majorNumberDropdown.SelectedItem.ToString() == "Pick") {
                        for (int i = 0; i < majorNumberList.CheckedItems.Count; i++) {
                            condition += "Major = '" + majorNumberList.CheckedItems[i].ToString().Split('-')[0] + " ";

                            if (i != majorNumberList.CheckedItems.Count - 1) {
                                condition += "OR ";
                            }
                        }
                    }
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + startDatePicker.Value.AddDays(-1).ToString("MM-dd-yyyy") + "' AND " + condition;
                    RunSingleQuery(beginningBalance);
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + endDatePicker.Value.ToString("MM-dd-yyyy") + "' AND " + condition;
                    RunSingleQuery(endingBalance);
                } else {
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange " + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + startDatePicker.Value.AddDays(-1).ToString("MM-dd-yyyy") + "'";
                    RunSingleQuery(beginningBalance);
                    query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange" + "FROM dbo_vGLAccountHistory " + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + endDatePicker.Value.ToString("MM-dd-yyyy") + "'";
                    RunSingleQuery(endingBalance);
                }
            }

            this.Cursor = Cursors.Default;  
        }
        private void ConnectRMPToolStripMenuItem1_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            connectedRIS = false;
            try {
                connection = new OleDbConnection(OLDBEConnectRIS);
                connection.Close();
                connection = new OleDbConnection(OLDBEConnect);
                connection.Open();
                connectRISToolStripMenuItem2.Enabled = true;
                connectRMPToolStripMenuItem1.Enabled = false;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            columns.Clear();
            columns.Add("TransDate");
            columns.Add("Major");
            columns.Add("SubAcct");
            columns.Add("EntryDescription");
            columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred");
            columns.Add("Dept");
            columns.Add("TransSource");
            columns.Add("TransType");
            columns.Add("GLTransID");
            columns.Add("GLEntryID");
            try {
                OleDbCommand selectCommand = new OleDbCommand("SELECT DeptName, DeptCode FROM dbo_GLDepts;", connection);
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                DataSet dataSet = new DataSet();
                oleDbDataAdapter.SelectCommand = selectCommand;
                oleDbDataAdapter.Fill(dataSet);
                departmentList.Clear();
                departmentList.Add(new ComboBoxItem("(All)", "0"));
                departmentBox.Items.Add(departmentList[0]);
                for (int i = 1; i < dataSet.Tables[0].Rows.Count + 1; i++) {
                    departmentList.Add(new ComboBoxItem(dataSet.Tables[0].Rows[i - 1][0].ToString(), dataSet.Tables[0].Rows[i - 1][1].ToString()));
                    departmentBox.Items.Add(departmentList[i]);
                }
                departmentBox.Sorted = true;
                departmentBox.Text = departmentList[0].department;
            } catch (Exception ex2) {
                MessageBox.Show(ex2.Message);
            }
            try {
                majorNumberDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
                majorNumberDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
                majorNumberDropdown.Items.Insert(1, new ComboBoxItem("Create", "2"));
                majorNumberDropdown.SelectedIndex = majorNumberDropdown.FindString("All");
            } catch (Exception ex3) {
                MessageBox.Show(ex3.Message);
            }
            try {
                subAccountDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
                subAccountDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
                subAccountDropdown.Items.Insert(1, new ComboBoxItem("Create", "2"));
                subAccountDropdown.SelectedIndex = subAccountDropdown.FindString("All");
            } catch (Exception ex4) {
                MessageBox.Show(ex4.Message);
            }
            majorNumberList.CheckOnClick = true;
            subAccountList.CheckOnClick = true;

            this.Cursor = Cursors.Default;
        }

        private void ConnectRISToolStripMenuItem2_Click(object sender, EventArgs e) {
            connectedRIS = true;
            try {
                connection = new OleDbConnection(OLDBEConnect);
                connection.Close();
                connection = new OleDbConnection(OLDBEConnectRIS);
                Cursor = Cursors.WaitCursor;
                connection.Open();
                connectRMPToolStripMenuItem1.Enabled = true;
                connectRISToolStripMenuItem2.Enabled = false;
                Cursor = Cursors.Default;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            columns.Clear();
            columns.Add("TransDate");
            columns.Add("Major");
            columns.Add("SubAcct");
            columns.Add("EntryDescription");
            columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred");
            columns.Add("Dept");
            columns.Add("TransSource");
            columns.Add("TransType");
            columns.Add("GLTransID");
            columns.Add("GLEntryID");
            try {
                OleDbCommand selectCommand = new OleDbCommand("SELECT DeptName, DeptCode FROM dbo_GLDepts;", connection);
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                DataSet dataSet = new DataSet();
                oleDbDataAdapter.SelectCommand = selectCommand;
                oleDbDataAdapter.Fill(dataSet);
                departmentList.Clear();
                departmentList.Add(new ComboBoxItem("(All)", "0"));
                departmentBox.Items.Add(departmentList[0]);
                for (int i = 1; i < dataSet.Tables[0].Rows.Count + 1; i++) {
                    departmentList.Add(new ComboBoxItem(dataSet.Tables[0].Rows[i - 1][0].ToString(), dataSet.Tables[0].Rows[i - 1][1].ToString()));
                    departmentBox.Items.Add(departmentList[i]);
                }
                departmentBox.Sorted = true;
                departmentBox.Text = departmentList[0].department;
            } catch (Exception ex2) {
                MessageBox.Show(ex2.Message);
            }

            this.Cursor = Cursors.Default;
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

        private void SubAccountList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void SubAccountDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            if (subAccountDropdown.SelectedIndex.Equals(0)) {
                subAccountList.Visible = true;
                subAccountCreateField.Visible = false;
                subAccountList.BackColor = Color.DarkGray;
                subAccountList.Enabled = false;
            } else if (subAccountDropdown.SelectedIndex.Equals(1)) {
                subAccountList.Visible = false;
                subAccountCreateField.Visible = true;
            } else {
                if (!subAccountDropdown.SelectedIndex.Equals(2)) {
                    return;
                }
                subAccountList.Visible = true;
                subAccountCreateField.Visible = false;
                subAccountList.BackColor = Color.White;
                subAccountList.Enabled = true;
                try {
                    foreach (object checkedItem in majorNumberList.CheckedItems) {
                        query = query + "Major = '" + checkedItem.ToString().Split('-')[0] + "' OR ";
                    }
                    if (query != null) {
                        query = query.Remove(query.Length - 2, 2);
                    }
                    OleDbCommand selectCommand = new OleDbCommand("SELECT SubAcct, AccountTitle FROM dbo_vGLAccountHistory WHERE" + query + " ORDER BY SubAcct", connection);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.SelectCommand = selectCommand;
                    oleDbDataAdapter.Fill(dataSet);
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                        if (dataSet.Tables[0].Rows[i][0].ToString() == "") {
                            subAccts.Add(dataSet.Tables[0].Rows[i][1].ToString());
                        } else {
                            subAccts.Add(dataSet.Tables[0].Rows[i][0].ToString());
                        }
                        subAccountList.Items.Add(subAccts[i]);
                    }
                } catch (Exception) {
                }
            }
        }

        private void MajorNumberDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            if (majorNumberDropdown.SelectedIndex.Equals(0)) {
                majorNumberList.Visible = true;
                majorNumberCreateField.Visible = false;
                majorNumberList.BackColor = Color.DarkGray;
                majorNumberList.Enabled = false;
            } else if (majorNumberDropdown.SelectedIndex.Equals(1)) {
                majorNumberList.Visible = false;
                majorNumberCreateField.Visible = true;
            } else if (majorNumberDropdown.SelectedIndex.Equals(2)) {
                majorNumberList.Visible = true;
                majorNumberCreateField.Visible = false;
                majorNumberList.BackColor = Color.White;
                majorNumberList.Enabled = true;
                try {
                    majorAccts.Clear();
                    majorAcctsDesc.Clear();
                    majorNumberList.Items.Clear();
                    OleDbCommand selectCommand = new OleDbCommand("SELECT DISTINCT Major, AccountTitle FROM dbo_vGLAccountHistory ORDER BY Major, AccountTitle", connection);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.SelectCommand = selectCommand;
                    oleDbDataAdapter.Fill(dataSet);
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                        if (dataSet.Tables[0].Rows[i][0].ToString() == "") {
                            majorAccts.Add("IS NULL");
                            majorAcctsDesc.Add("IS NULL");
                            majorNumberList.Items.Add("");
                        } else {
                            majorAccts.Add(dataSet.Tables[0].Rows[i][0].ToString());
                            majorAcctsDesc.Add(dataSet.Tables[0].Rows[i][1].ToString());
                            majorNumberList.Items.Add(majorAccts[i] + " - " + majorAcctsDesc[i]);
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            SubAccountDropdown_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void AccountTypeCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (accountTypeCheckbox.Checked) {
                accountTypes.Visible = true;
            } else if (!accountTypeCheckbox.Checked) {
                accountTypes.Visible = false;
            }
        }

        private void SubAccountCreateField_TextChanged(object sender, EventArgs e) {
            if (subAccountDropdown.SelectedIndex.Equals(0)) {
                subAccountList.Visible = true;
                subAccountCreateField.Visible = false;
                subAccountList.BackColor = Color.DarkGray;
                subAccountList.Enabled = false;
            } else if (subAccountDropdown.SelectedIndex.Equals(1)) {
                subAccountList.Visible = false;
                subAccountCreateField.Visible = true;
            } else {
                if (!subAccountDropdown.SelectedIndex.Equals(2)) {
                    return;
                }
                subAccountList.Visible = true;
                subAccountCreateField.Visible = false;
                subAccountList.BackColor = Color.White;
                subAccountList.Enabled = true;
                try {
                    foreach (object checkedItem in majorNumberList.CheckedItems) {
                        query = query + " Major = '" + checkedItem.ToString().Split('-')[0] + "' OR";
                    }
                    if (query != null) {
                        query = query.Remove(query.Length - 2, 2);
                    }
                    OleDbCommand selectCommand = new OleDbCommand("SELECT SubAcct, AccountTitle FROM dbo_vGLAccountHistory WHERE" + query + " ORDER BY SubAcct", connection);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.SelectCommand = selectCommand;
                    oleDbDataAdapter.Fill(dataSet);
                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                        if (dataSet.Tables[0].Rows[i][0].ToString() == "") {
                            subAccts.Add(dataSet.Tables[0].Rows[i][1].ToString());
                        } else {
                            subAccts.Add(dataSet.Tables[0].Rows[i][0].ToString());
                        }
                        subAccountList.Items.Add(subAccts[i]);
                    }
                } catch (Exception) {
                }
            }
        }

        private void MajorNumberListClear_Click(object sender, EventArgs e) {
            for (int i = 0; i < majorNumberList.Items.Count; i++) {
                majorNumberList.SetItemChecked(i, false);
            }
            majorNumberCreateField.Clear();
        }

        private void SubAccountListClear_Click(object sender, EventArgs e) {
            for (int i = 0; i < subAccountList.Items.Count; i++) {
                subAccountList.SetItemChecked(i, false);
            }
            subAccountCreateField.Clear();
        }

        private void MajorNumberList_SelectedIndexChanged(object sender, EventArgs e) {
            string condition = "";

            if (subAccountDropdown.SelectedItem.ToString() != "Pick") {
                return;
            }

            subAccountList.Items.Clear();
            subAccts.Clear();
            try {
                for (int i = 0; i < majorNumberList.CheckedItems.Count; i++) {
                    condition += "Major = '" + majorNumberList.CheckedItems[i].ToString().Split('-')[0] + "' ";

                    if (i != majorNumberList.CheckedItems.Count - 1) {
                        condition += "OR ";
                    }
                }
                string query = "SELECT SubAcct FROM dbo_vGLAccountHistory WHERE " + condition + " GROUP BY SubAcct ORDER BY SubAcct";
                OleDbCommand selectCommand = new OleDbCommand(query, connection);
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand) {
                    SelectCommand = selectCommand
                };
                DataSet dataSet = new DataSet();
                oleDbDataAdapter.Fill(dataSet);
                for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                    if (dataSet.Tables[0].Rows[i][0].ToString() == "") {
                        subAccts.Add("IS NULL");
                        continue;
                    }
                    subAccts.Add(dataSet.Tables[0].Rows[i][0].ToString());
                    subAccountList.Items.Add(subAccts[i]);
                }
            } catch (Exception) {
            }
        }

        private void PeriodDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            DateTime dateTime = default(DateTime);
            DateTime dateTime2 = default(DateTime);
            DateTime date = DateTime.Now.Date;
            if (periodDropdown.SelectedItem.ToString() == "Yesterday") {
                startDatePicker.Value = DateTime.Now.AddDays(-1.0);
                endDatePicker.Value = DateTime.Now.AddDays(-1.0);
            } else if (periodDropdown.SelectedItem.ToString() == "This Week") {
                DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
                int num = (int)(dayOfWeek - 0);
                dateTime = DateTime.Now.AddDays(-num);
                dateTime2 = DateTime.Now.AddDays(7 - num);
                startDatePicker.Value = dateTime;
                endDatePicker.Value = dateTime2;
            } else if (periodDropdown.SelectedItem.ToString() == "Last Week") {
                DayOfWeek dayOfWeek2 = DateTime.Now.DayOfWeek;
                int num2 = (int)(dayOfWeek2 - 0);
                dateTime = DateTime.Now.AddDays(-num2 - 7);
                dateTime2 = DateTime.Now.AddDays(7 - num2 - 8);
                startDatePicker.Value = dateTime;
                endDatePicker.Value = dateTime2;
            } else if (periodDropdown.SelectedItem.ToString() == "Next Week") {
                DayOfWeek dayOfWeek3 = DateTime.Now.DayOfWeek;
                int num3 = (int)(dayOfWeek3 - 0);
                dateTime = DateTime.Now.AddDays(-num3 + 7);
                dateTime2 = DateTime.Now.AddDays(-num3 + 13);
                startDatePicker.Value = dateTime;
                endDatePicker.Value = dateTime2;
            } else if (periodDropdown.SelectedItem.ToString() == "This Month") {
                DateTime value = new DateTime(date.Year, date.Month, 1);
                DateTime value2 = value.AddMonths(1).AddDays(-1.0);
                startDatePicker.Value = value;
                endDatePicker.Value = value2;
            } else if (periodDropdown.SelectedItem.ToString() == "Last Month") {
                DateTime value3 = ((date.Month != 1) ? new DateTime(date.Year, date.Month - 1, 1) : new DateTime(date.Year - 1, 12, 1));
                DateTime value4 = value3.AddMonths(1).AddDays(-1.0);
                startDatePicker.Value = value3;
                endDatePicker.Value = value4;
            } else if (periodDropdown.SelectedItem.ToString() == "Next Month") {
                DateTime value5 = new DateTime(date.Year, date.Month + 1, 1);
                DateTime value6 = value5.AddMonths(1).AddDays(-1.0);
                startDatePicker.Value = value5;
                endDatePicker.Value = value6;
            }
        }
    }

    public class ComboBoxItem {
        public string department;
        public string value;

        public ComboBoxItem(string Name, string Value) {
            this.department = Name;
            this.value = Value;
        }

        public override string ToString() {
            return this.department;

        }
    }
}
