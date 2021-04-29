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


//Currently developing method to calculate beginning and ending balance using hidden cells


namespace TestProject
{

    public partial class GLListing : Form
    {
        bool connectedRIS = false;

        //Below are the connection strings that are used to connect to the database using Object linking and embedding database, API
        //It allows access to data from a variety of sources in a cosistent manner
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";

        //String used to store the query passed to MS access
        String query = null;

        //Encapsulates the data source for the winform that it will be used in
        BindingSource myBindingSource = new BindingSource();

        //Represents a connection to a data source that can be opened or closed
        OleDbConnection connect = null;

        //Create the required lists that will be used in the form
        List<ComboBoxItem> departmentList = new List<ComboBoxItem>();

        List<string> subAccts = new List<string>();

        List<string> columns = new List<string>();

        //Initialize integers that will be used in the form
        int descriptionCol = 0;
        int subAcctCol = 0;
        int debCred = 0;

        //Initializes the form with its attributes
        public GLListing()
        {
            InitializeComponent();
        }


        //This function is triggered by the OnClick event handler for the Run Query Button on the form
        private void runQuery_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            //Decide whether or not to include the account type as a column in the query

            if (accountType.Checked == true)
            {
                if (columns.Contains("AcctType") == true)
                {

                    columns.RemoveAt(columns.LastIndexOf("AcctType"));

                }

                columns.Add("AcctType");
            }

            else if (accountType.Checked == false)
            {

                if (columns.Contains("AcctType") == true)
                {

                    columns.RemoveAt(columns.LastIndexOf("AcctType"));

                }

            }

            //Set the string using the QueryBuilder functions, passing the columns desired and the table desired
            query = QueryBuilder(columns, "dbo_vGLAccountHistory");

            //Pass the form's DGV and the query string to the run query function
            RunQuery(glQueryDGV, query);

            //Obtain the net change in debits vs credits for the period provided.
            netChange.Text = SumColumn(4).ToString("C");

            //Obtain the beginning and ending balance for the entire GLL data
            query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange\n" + "FROM dbo_vGLAccountHistory\n" + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + ConvertDateFormatting(startDate.Value.AddDays(-1)) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "';";
            RunSingleQuery(beginningBalance);
            query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange\n" + "FROM dbo_vGLAccountHistory\n" + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + ConvertDateFormatting(endDate.Value) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "';";
            RunSingleQuery(endingBalance);
            this.Cursor = Cursors.Default;
        }






        //Runs initial interface set-up when the application is loaded

        private void GLListing_Load(object sender, EventArgs e)
        {

            connectRMPToolStripMenuItem1.PerformClick();

            
        }

        //Disconnect form the database when the form is closed

        private void GLListing_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectFromDatabases();
        }

        //Query that is run and used to obtain the GLL data
        private void RunQuery(DataGridView myGrid, string query)
        {

            try
            {
                //A binding source is required for the use of a drop-down filter list in the DataGridView
                myBindingSource.Filter = null;

                OleDbCommand command = new OleDbCommand(query, connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable myTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(myTable);

                //Here, we need to adjust the data such that we subtract the credits from the debits in the data table, before importing the information in the datagridview!
                //
                //



                //
                //
                //
                ///////////////////////////////////////////////////////////////////////////////////////+



                DataView myDataView = myTable.DefaultView;

                myBindingSource.DataSource = myDataView;

                myGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);

                myGrid.DataSource = myBindingSource;

                if (myGrid.DataSource == null) return;

                //In the for loop below, we identify which columns will require a drop-down filter

                foreach (DataGridViewColumn col in myGrid.Columns)
                {

                    if (col.HeaderCell.Value.ToString() == "EntryDescription")
                    {
                        descriptionCol = col.Index;
                    }

                    else if (col.HeaderCell.Value.ToString() == "DebCred")
                    {
                        debCred = col.Index;
                    }

                    else if (col.HeaderCell.Value.ToString() == "SubAcct")
                    {
                        subAcctCol = col.Index;
                        continue;
                    }

                    else if (col.HeaderCell.Value.ToString() == "AcctType")
                    {
                        continue;
                    }

                    col.HeaderCell = new DataGridViewAutoFilterColumnHeaderCell(col.HeaderCell);

                }

                //Setting the format for particular columns in the DGV

                myGrid.AutoResizeColumns();

                myGrid.Columns[debCred].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                myGrid.Columns[debCred].DefaultCellStyle.Format = ("C");
                myGrid.Columns[debCred].Width = 100;

                myGrid.Columns[descriptionCol].Width = 210;

                myGrid.Columns[subAcctCol].Width = 85;

            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //The query function below is used to run the query necessary for obtaining the beginning and ending balances of the GLL
        private void RunSingleQuery(Label myLabel)
        {

            OleDbCommand command = new OleDbCommand(query, connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable myTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(myTable);

            if (myTable.Rows[0].IsNull(0))
            {
                myLabel.Text = "";
            }

            else
            {
                double valueString = myTable.Rows[0].Field<double>(0);

                double valDouble = Convert.ToDouble(valueString);

                valDouble = Math.Round(valDouble, 2);

                myLabel.Text = valDouble.ToString("C");
            }

        }

        //The function below is used to convert date formatting provided by C# to the date formatting required in SQL queries

        private string ConvertDateFormatting(DateTime myDate)
        {
            string newDate = null;
            string tempMonth = null;
            string tempDay = null;


            if (myDate.Month <= 9)
            {
                tempMonth = "0" + myDate.Month.ToString();
            }

            else
            {
                tempMonth = myDate.Month.ToString();
            }



            if (myDate.Day <= 9)
            {
                tempDay = "0" + myDate.Day.ToString();
            }

            else
            {
                tempDay = myDate.Day.ToString();
            }

            newDate = myDate.Year.ToString() + "-" + tempMonth + "-" + tempDay;

            return newDate;
        }


        //This function converts the string form of the date back into the date form.

        private DateTime RevertDateFormatting(string myDate)
        {
            string tempYear = null;
            string tempMonth = null;
            string tempDay = null;

            tempYear = myDate[0].ToString() + myDate[1].ToString() + myDate[2].ToString() + myDate[3].ToString();

            tempMonth = myDate[5].ToString() + myDate[6].ToString();

            tempDay = myDate[8].ToString() + myDate[9].ToString();

            DateTime finalDate = new DateTime(Convert.ToInt32(tempYear), Convert.ToInt32(tempMonth), Convert.ToInt32(tempDay));

            return finalDate;
        }


        //SumColumn is used to sum all entries in a given column and return that sum

        private double SumColumn(int columnNumber)
        {
            double sum = 0;
            for (int i = 0; i < glQueryDGV.Rows.Count-1; i++)
            {
              
                sum += (double)glQueryDGV.Rows[i].Cells[columnNumber].Value;
          
            }

            return sum;
        }

        //The following function is used to develop queries based on the input provided:
        //This function builds the main query that is used to fill the DGV. The query is a complex query which requires adjustment
        //based in the selection of sub accounts, account types, major numbers, etc.

        private string QueryBuilder(List<string> columns, string tableName)
        {
            string query = null;

            query = "SELECT ";

            foreach(string col in columns)
            {

                if (columns.Last<string>() == col)
                {
                    query += col + " ";
                    break;
                }

                query += col + ", ";

                
            }

            query += "FROM " + tableName + " ";

            query += "WHERE " + tableName + "." + "TransDate BETWEEN '" + ConvertDateFormatting(startDate.Value) + "' AND '" + ConvertDateFormatting(endDate.Value) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "' ";


            if (((ComboBoxItem)departmentBox.SelectedItem).value == "0")
            {
                
            }

            else if (((ComboBoxItem)departmentBox.SelectedItem).value == "")
            {
                query += "AND Dept IS NULL ";
            }

            else
            {
                query += "AND Dept = '" + ((ComboBoxItem)departmentBox.SelectedItem).value + "' ";
            }

            if (accountTypes.Visible == true) {

                int i = 0;

                foreach (string acct in accountTypes.CheckedItems)
                {
                    if (i == 0)
                    {
                        query += "AND (AcctType = '" + acct.First<char>() + "' ";
                    }

                    else
                    {
                        query += "OR AcctType = '" + acct.First<char>() + "' ";
                    }

                    if(i == accountTypes.CheckedItems.Count - 1)
                    {

                        query += ") ";
                    }

                    i++;
                    
                }

            }

            int z = 0;

            foreach (string acct in subAccountsList.SelectedItems)
            {

                if(acct == "(All)")
                {
                    break;
                }

                if (z == 0)
                {

                    if (acct == "")
                    {
                        query += "AND (SubAcct IS NULL ";
                    }

                    else
                    {
                        query += "AND (SubAcct = '" + acct + "' ";
                    }
                }

                else
                { 

                    if (acct == "")
                    {
                        query += "OR SubAcct IS NULL ";
                    }

                    else
                    {
                        query += "OR SubAcct = '" + acct + "' ";
                    }
                }

                if (z == subAccountsList.SelectedItems.Count - 1)
                {

                    query += ") ";
                }

                z++;

            }

            query += "ORDER BY dbo_vGLAccountHistory.TransDate ASC;";

            return query;
        }

        private void accountType_CheckedChanged(object sender, EventArgs e)
        {
            if(accountType.Checked == true)
            {
                accountTypes.Visible = true;
            }

            else if (accountType.Checked == false)
            {
                accountTypes.Visible = false;
            }
        }

        //This code is used to generate the sub accounts when the check box is selected

        private void generateSubAccts_Click(object sender, EventArgs e)
        {
            

            try
            {
                subAccts.Clear();

                subAccountsList.Items.Clear();

                OleDbCommand command = new OleDbCommand("SELECT SubAcct FROM dbo_vGLAccountHistory WHERE Major = '" + majorNumber.Text + "' GROUP BY SubAcct;", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataSet myDataSet = new DataSet();

                adapter.SelectCommand = command;

                adapter.Fill(myDataSet);

                subAccts.Add(("(All)"));

                subAccountsList.Items.Add(subAccts[0]);

                for (int i = 1; i < myDataSet.Tables[0].Rows.Count + 1; i++)
                {

                    if(myDataSet.Tables[0].Rows[i - 1][0].ToString() == "")
                    {
                        subAccts.Add("IS NULL");
                        subAccountsList.Items.Add("");
                        continue;
                    }

                    subAccts.Add((myDataSet.Tables[0].Rows[i - 1][0].ToString()));

                    subAccountsList.Items.Add(subAccts[i]);

                }

                subAccountsList.Sorted = true;

                subAccountsList.Visible = true;

                subAcctText.Visible = true;
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }


        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            // Creating an Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "General Ledger Listing for " + majorNumber.Text;

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = 0; i < glQueryDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < glQueryDGV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = glQueryDGV.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = glQueryDGV.Rows[i].Cells[j].Value.ToString();
                        }

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                for (int j = 0; j < glQueryDGV.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    if (glQueryDGV.Columns[j].HeaderText == "EntryDescription")
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = "TOTALS:";
                    }

                    else if (j == glQueryDGV.Columns.Count - 2)
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = "CHANGE:";
                    }
                    else if (j == glQueryDGV.Columns.Count - 1)
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = netChange.Text.ToString();
                    }

                }

                cellRowIndex++;

                for (int j = 0; j < glQueryDGV.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    if (j == glQueryDGV.Columns.Count - 2)
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = "BEGINNING BALANCE:";
                    }
                    else if (j == glQueryDGV.Columns.Count - 1)
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = beginningBalance.Text.ToString();
                    }

                }

                cellRowIndex++;

                for (int j = 0; j < glQueryDGV.Columns.Count; j++)
                {
                    // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                    if (j == glQueryDGV.Columns.Count - 2)
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = "ENDING BALANCE:";
                    }
                    else if (j == glQueryDGV.Columns.Count - 1)
                    {
                        worksheet.Cells[cellRowIndex, j + 1] = endingBalance.Text.ToString();
                    }

                }

                //Getting the location and file name of the excel to save from user. 

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                }

            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                excel.Quit();
                worksheet = null;
                excel = null;
            }

            this.Cursor = Cursors.Default;



        }

        //THe function below is used to convert the current data in the DGV into a pdf which can be used by the end user.
        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            string folderPath = null;

            iTextSharp.text.BaseColor colourBlack = new iTextSharp.text.BaseColor(0, 0, 0);
            iTextSharp.text.BaseColor colourBlue = new iTextSharp.text.BaseColor(70, 130, 180);
            iTextSharp.text.BaseColor colourWhite = new iTextSharp.text.BaseColor(255, 255, 255);
            iTextSharp.text.BaseColor colourGreyLight = new iTextSharp.text.BaseColor(200, 200, 200);
            iTextSharp.text.BaseColor colourGreyDark = new iTextSharp.text.BaseColor(125, 125, 125);
            

            //Identify the filepath used to store the pdf
            if (connectedRIS == false)
            {
                folderPath = "Z:\\GLListings\\RMP\\";
            }
            else
            {
                folderPath = "Z:\\GLListings\\RIS\\";
            }

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            //Setup the name of the pdf and initialize meta-data for the pdf, such as teh author name, subject, etc.

            System.IO.FileStream fs = new FileStream(folderPath + "GeneralLedger-" + majorNumber.Text + ".pdf", FileMode.Create);

            Document myPDF = new Document(PageSize.LETTER.Rotate(), 10f, 10f, 30f, 30f);

            PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

            myPDF.AddAuthor("Reliable");

            myPDF.AddCreator("This document was created using iTextSharp");

            myPDF.AddSubject(majorNumber.Text);

            myPDF.AddTitle("General Ledger Listing");

            myPDF.Open();

            PdfContentByte contentByte = write.DirectContent;

            BaseFont myFontBold = FontFactory.GetFont(BaseFont.COURIER_BOLD).BaseFont;
            BaseFont myFontRegular = FontFactory.GetFont(BaseFont.COURIER).BaseFont;

            //Creat rectangular border for header contents

            int outerX = 0;

            if (accountType.Checked == true)
            {
                outerX = 697;
            }
            else
            {
                outerX = 652;
            }

            iTextSharp.text.Rectangle borderRect = new iTextSharp.text.Rectangle(20, 573, outerX, 590);
            borderRect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
            borderRect.BackgroundColor = colourBlue;
            borderRect.BorderWidth = 1f;
            borderRect.BorderColor = colourBlack;
            contentByte.Rectangle(borderRect);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 10);

            int left = 25;

            for(int i = 0; i<glQueryDGV.Columns.Count; i++)
            {
                if(i == 0)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Date", left + 22, 578, 0);

                    left += 50;
                }
                else if (i == 1)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Columns[i].HeaderText, left + 18, 578, 0);

                    left += 37;
                }
                else if (i == 2)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Sub Account", left + 37, 578, 0);

                    left += 75;
                }
                else if (i == 3)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Entry Description", left + 100, 578, 0);

                    left += 200;
                }
                else if (i == 4)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Columns[i].HeaderText, left + 37, 578, 0);

                    left += 75;
                }
                else if (i == 5)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Columns[i].HeaderText, left + 15, 578, 0);

                    left += 30;
                }
                else if (i == 6)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "TS", left + 15, 578, 0);

                    left += 30;
                }
                else if (i == 7)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "TT", left + 15, 578, 0);

                    left += 30;
                }
                else if (i == 8)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "GLTID", left + 25, 578, 0);

                    left += 50;
                }
                else if (i == 9)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "GLEID", left +25, 578, 0);

                    left += 50;
                }
                else if (i == 10)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "AType", left+ 22, 578, 0);

                    left += 30;
                }
                
            }


            contentByte.EndText();

            contentByte.SetLineWidth(1);
            contentByte.MoveTo(75, 590);
            contentByte.LineTo(75, 573);
            contentByte.Stroke();
            contentByte.MoveTo(112, 590);
            contentByte.LineTo(112, 573);
            contentByte.Stroke();
            contentByte.MoveTo(187, 590);
            contentByte.LineTo(187, 573);
            contentByte.Stroke();
            contentByte.MoveTo(387, 590);
            contentByte.LineTo(387, 573);
            contentByte.Stroke();
            contentByte.MoveTo(462, 590);
            contentByte.LineTo(462, 573);
            contentByte.Stroke();
            contentByte.MoveTo(492, 590);
            contentByte.LineTo(492, 573);
            contentByte.Stroke();
            contentByte.MoveTo(522, 590);
            contentByte.LineTo(522, 573);
            contentByte.Stroke();
            contentByte.MoveTo(552, 590);
            contentByte.LineTo(552, 573);
            contentByte.Stroke();
            contentByte.MoveTo(602, 590);
            contentByte.LineTo(602, 573);
            contentByte.Stroke();
            contentByte.MoveTo(652, 590);
            contentByte.LineTo(652, 573);
            contentByte.Stroke();

            int bottom = 561;

            int pageCount = 1;

            for(int i = 0; i < glQueryDGV.RowCount - 1; i++)
            {

                iTextSharp.text.Rectangle rowRectangle = new iTextSharp.text.Rectangle(20, bottom, outerX, bottom + 12);
                rowRectangle.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER;
                if (i % 2 == 0)
                {
                    rowRectangle.BackgroundColor = colourWhite;
                }
                else
                {
                    rowRectangle.BackgroundColor = colourGreyLight;
                }
                rowRectangle.BorderWidth = 1f;
                rowRectangle.BorderColor = colourBlack;
                contentByte.Rectangle(rowRectangle);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontRegular, 8);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[0].Value.ToString(), 47, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[1].Value.ToString(), 93, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[2].Value.ToString(), 149, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, glQueryDGV.Rows[i].Cells[3].Value.ToString(), 188, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Convert.ToDouble(glQueryDGV.Rows[i].Cells[4].Value.ToString()).ToString("C"), 461, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[5].Value.ToString(), 476, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[6].Value.ToString(), 506, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[7].Value.ToString(), 536, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[8].Value.ToString(), 586, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[9].Value.ToString(), 636, bottom + 3, 0);

                if (accountType.Checked == true)
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Rows[i].Cells[10].Value.ToString(), 681, bottom + 3, 0);
                }

                contentByte.EndText();

                contentByte.SetLineWidth(1);
                contentByte.SetRGBColorStroke(100, 100, 100);
                contentByte.MoveTo(75, bottom+12);
                contentByte.LineTo(75, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(112, bottom + 12);
                contentByte.LineTo(112, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(187, bottom + 12);
                contentByte.LineTo(187, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(387, bottom + 12);
                contentByte.LineTo(387, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(462, bottom + 12);
                contentByte.LineTo(462, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(492, bottom + 12);
                contentByte.LineTo(492, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(522, bottom + 12);
                contentByte.LineTo(522, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(552, bottom + 12);
                contentByte.LineTo(552, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(602, bottom + 12);
                contentByte.LineTo(602, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(652, bottom + 12);
                contentByte.LineTo(652, bottom);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

                bottom = bottom - 12;

                if (bottom <= 30)
                {
                    contentByte.SetLineWidth(1);
                    contentByte.SetRGBColorStroke(100, 100, 100);
                    contentByte.MoveTo(20, bottom + 12);
                    contentByte.LineTo(outerX, bottom + 12);
                    contentByte.Stroke();
                    contentByte.SetRGBColorStroke(0, 0, 0);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontRegular, 7);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page: " + pageCount.ToString(), 772, 15, 0);

                    contentByte.EndText();

                    pageCount++;

                    myPDF.NewPage();
                    bottom = 561;

                    iTextSharp.text.Rectangle newBorderRect = new iTextSharp.text.Rectangle(20, 573, outerX, 590);
                    newBorderRect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    newBorderRect.BackgroundColor = colourBlue;
                    newBorderRect.BorderWidth = 1f;
                    newBorderRect.BorderColor = colourBlack;
                    contentByte.Rectangle(newBorderRect);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 10);

                    left = 25;

                    for (int q = 0; q < glQueryDGV.Columns.Count; q++)
                    {
                        if (q == 0)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Date", left + 22, 578, 0);

                            left += 50;
                        }
                        else if (q == 1)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Columns[q].HeaderText, left + 18, 578, 0);

                            left += 37;
                        }
                        else if (q == 2)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Sub Account", left + 37, 578, 0);

                            left += 75;
                        }
                        else if (q == 3)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Entry Description", left + 100, 578, 0);

                            left += 200;
                        }
                        else if (q == 4)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Columns[q].HeaderText, left + 37, 578, 0);

                            left += 75;
                        }
                        else if (q == 5)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, glQueryDGV.Columns[q].HeaderText, left + 15, 578, 0);

                            left += 30;
                        }
                        else if (q == 6)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "TS", left + 15, 578, 0);

                            left += 30;
                        }
                        else if (q == 7)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "TT", left + 15, 578, 0);

                            left += 30;
                        }
                        else if (q == 8)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "GLTID", left + 25, 578, 0);

                            left += 50;
                        }
                        else if (q == 9)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "GLEID", left + 25, 578, 0);

                            left += 50;
                        }
                        else if (q == 10)
                        {
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "AType", left + 22, 578, 0);

                            left += 30;
                        }

                    }


                    contentByte.EndText();

                    contentByte.SetLineWidth(1);
                    contentByte.MoveTo(75, 590);
                    contentByte.LineTo(75, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(112, 590);
                    contentByte.LineTo(112, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(187, 590);
                    contentByte.LineTo(187, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(387, 590);
                    contentByte.LineTo(387, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(462, 590);
                    contentByte.LineTo(462, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(492, 590);
                    contentByte.LineTo(492, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(522, 590);
                    contentByte.LineTo(522, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(552, 590);
                    contentByte.LineTo(552, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(602, 590);
                    contentByte.LineTo(602, 573);
                    contentByte.Stroke();
                    contentByte.MoveTo(652, 590);
                    contentByte.LineTo(652, 573);
                    contentByte.Stroke();
                } 

            }

            bottom = bottom + 12;

            if(bottom - 36 <= 10)
            {
                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontRegular, 7);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page: " + pageCount.ToString(), 772, 15, 0);

                contentByte.EndText();

                pageCount++;

                myPDF.NewPage();
            }

            iTextSharp.text.Rectangle endRect = new iTextSharp.text.Rectangle(20, bottom - 36, outerX, bottom);
            endRect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
            endRect.BackgroundColor = colourGreyLight;
            endRect.BorderWidth = 1f;
            endRect.BorderColor = colourBlack;
            contentByte.Rectangle(endRect);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 8);

            if (accountType.Checked == true)
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "TOTALS:", 386, bottom - 9, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "CHANGE:", 628, bottom - 9, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, netChange.Text, 771, bottom - 9, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "BEGINNING:", 628, bottom - 21, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, beginningBalance.Text, 771, bottom - 21, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "ENDING:", 628, bottom - 33, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, endingBalance.Text, 771, bottom - 33, 0);

                contentByte.EndText();

                contentByte.SetLineWidth(1);
                contentByte.MoveTo(387, bottom);
                contentByte.LineTo(387, bottom - 12);
                contentByte.MoveTo(462, bottom);
                contentByte.LineTo(462, bottom - 12);
                contentByte.MoveTo(537, bottom);
                contentByte.LineTo(537, bottom - 12);
                contentByte.MoveTo(627, bottom);
                contentByte.LineTo(627, bottom - 36);
                contentByte.Stroke();
                contentByte.MoveTo(20, bottom - 12);
                contentByte.LineTo(772, bottom - 12);
                contentByte.Stroke();
                contentByte.MoveTo(20, bottom - 24);
                contentByte.LineTo(772, bottom - 24);
                contentByte.Stroke();
            }
            else
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "TOTALS:", 386, bottom - 9, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "CHANGE:", 598, bottom - 9, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, netChange.Text, 726, bottom - 9, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "BEGINNING:", 598, bottom - 21, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, beginningBalance.Text, 726, bottom - 21, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "ENDING:", 598, bottom - 33, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, endingBalance.Text, 726, bottom - 33, 0);

                contentByte.EndText();

                contentByte.SetLineWidth(1);
                contentByte.MoveTo(387, bottom);
                contentByte.LineTo(387, bottom - 12);
                contentByte.MoveTo(462, bottom);
                contentByte.LineTo(462, bottom - 12);
                contentByte.MoveTo(537, bottom);
                contentByte.LineTo(537, bottom - 12);
                contentByte.MoveTo(597, bottom);
                contentByte.LineTo(597, bottom - 36);
                contentByte.Stroke();
                contentByte.MoveTo(20, bottom - 12);
                contentByte.LineTo(727, bottom - 12);
                contentByte.Stroke();
                contentByte.MoveTo(20, bottom - 24);
                contentByte.LineTo(727, bottom - 24);
                contentByte.Stroke();
            }

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontRegular, 7);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page: " + pageCount.ToString(), 772, 15, 0);

            contentByte.EndText();

            pageCount++;

            myPDF.Close();

            write.Close();
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = folderPath + "GeneralLedger-" + majorNumber.Text + ".pdf";
            process.Start();

            this.Cursor = Cursors.Default;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            netChange.Text = (SumColumn(4)).ToString("C");

            //This section below of the refresh function is used to format the bindingsource filter string so that it correctly identifies fields that are numbers, as numbers and not text.
            if (!String.IsNullOrWhiteSpace(myBindingSource.Filter))
            {
                string input = myBindingSource.Filter;
                string condition = "'| ";
                string[] output = Regex.Split(input, condition);
                string output1 = myBindingSource.Filter;

                for (int i = 0; i < output.Length - 1; i++)
                {
                    if (output[i] == "[GLTransID]=")
                    {
                        string input1 = output1;
                        string regex1 = "\\[GLTransID\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[GLTransID]=" + output[i + 1]);

                    }

                    else if (output[i] == "[Debit]=")
                    {
                        string input1 = output1;
                        string regex1 = "\\[Debit\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[DebitAmount]=" + output[i + 1]);

                    }

                    else if (output[i] == "[Credit]=")
                    {
                        string input1 = output1;
                        string regex1 = "\\[Credit\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[CreditAmount]=" + output[i + 1]);

                    }

                    else if (output[i] == "[GLEntryID]=")
                    {
                        string input1 = output1;
                        string regex1 = "\\[GLEntryID\\]='" + output[i + 1] + "'";
                        output1 = Regex.Replace(input1, regex1, "[GLEntryID]=" + output[i + 1]);

                    }

                }

                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange\n" + "FROM dbo_vGLAccountHistory\n" + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + ConvertDateFormatting(startDate.Value.AddDays(-1)) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "' AND " + output1 + ";";
                RunSingleQuery(beginningBalance);
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange\n" + "FROM dbo_vGLAccountHistory\n" + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + ConvertDateFormatting(endDate.Value) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "' AND " + output1 + ";";
                RunSingleQuery(endingBalance);

            }

            else
            {
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange\n" + "FROM dbo_vGLAccountHistory\n" + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + ConvertDateFormatting(startDate.Value.AddDays(-1)) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "';";
                RunSingleQuery(beginningBalance);
                query = "SELECT (SUM(IIF(ISNULL(DebitAmount),0,DebitAmount)) - SUM(IIF(ISNULL(CreditAmount),0,CreditAmount))) AS NetChange\n" + "FROM dbo_vGLAccountHistory\n" + "WHERE dbo_vGLAccountHistory.TransDate BETWEEN '01-01-0001' AND '" + ConvertDateFormatting(endDate.Value) + "' AND dbo_vGLAccountHistory.Major = '" + majorNumber.Text + "';";
                RunSingleQuery(endingBalance);
            }

            this.Cursor = Cursors.Default;


        }

        private void connectRMPToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            connectedRIS = false;

            try
            {
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnect);
                this.Cursor = Cursors.WaitCursor;
                connect.Open();
                connectRISToolStripMenuItem2.Enabled = true;
                connectRMPToolStripMenuItem1.Enabled = false;
                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            columns.Clear();

            //Instead of modifying table, we can query the difference of debit and credit values here

            //Here, we select the columns required from the GLL table in the database for the query
            columns.Add("TransDate");
            columns.Add("Major");
            columns.Add("SubAcct");
            columns.Add("EntryDescription");
            columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred"); //This is the column to check here
            columns.Add("Dept");
            columns.Add("TransSource");
            columns.Add("TransType");
            columns.Add("GLTransID");
            columns.Add("GLEntryID");


            try
            {

                OleDbCommand command = new OleDbCommand("SELECT DeptName, DeptCode FROM dbo_GLDepts;", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataSet myDataSet = new DataSet();

                adapter.SelectCommand = command;

                adapter.Fill(myDataSet);

                departmentList.Clear();

                departmentList.Add(new ComboBoxItem("(All)", "0"));

                departmentBox.Items.Add(departmentList[0]);

                for (int i = 1; i < myDataSet.Tables[0].Rows.Count + 1; i++)
                {

                    departmentList.Add(new ComboBoxItem(myDataSet.Tables[0].Rows[i - 1][0].ToString(), myDataSet.Tables[0].Rows[i - 1][1].ToString()));

                    departmentBox.Items.Add(departmentList[i]);


                }

                departmentBox.Sorted = true;

                departmentBox.Text = departmentList[0].department;


            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void connectRISToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            connectedRIS = true;

            try
            {
                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                this.Cursor = Cursors.WaitCursor;
                connect.Open();
                connectRMPToolStripMenuItem1.Enabled = true;
                connectRISToolStripMenuItem2.Enabled = false;
                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            columns.Clear();

            //Here, we select the columns required from the GLL table in the database for the query

            columns.Add("TransDate");
            columns.Add("Major");
            columns.Add("SubAcct");
            columns.Add("EntryDescription");
            columns.Add("IIF(ISNULL((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount))),0,((IIF(ISNULL(DebitAmount),0,DebitAmount))-(IIF(ISNULL(CreditAmount),0,CreditAmount)))) AS DebCred"); //This is the column to check here
            columns.Add("Dept");
            columns.Add("TransSource");
            columns.Add("TransType");
            columns.Add("GLTransID");
            columns.Add("GLEntryID");


            try
            {

                OleDbCommand command = new OleDbCommand("SELECT DeptName, DeptCode FROM dbo_GLDepts;", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataSet myDataSet = new DataSet();

                adapter.SelectCommand = command;

                adapter.Fill(myDataSet);

                departmentList.Clear();

                departmentList.Add(new ComboBoxItem("(All)", "0"));

                departmentBox.Items.Add(departmentList[0]);

                for (int i = 1; i < myDataSet.Tables[0].Rows.Count + 1; i++)
                {

                    departmentList.Add(new ComboBoxItem(myDataSet.Tables[0].Rows[i - 1][0].ToString(), myDataSet.Tables[0].Rows[i - 1][1].ToString()));

                    departmentBox.Items.Add(departmentList[i]);


                }

                departmentBox.Sorted = true;

                departmentBox.Text = departmentList[0].department;


            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void DisconnectFromDatabases()
        {
            try
            {
                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Close();
                connectRMPToolStripMenuItem1.Enabled = true;
                connectRISToolStripMenuItem2.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    public class ComboBoxItem
    {
        public string department;
        public string value;

        public ComboBoxItem(string Name, string Value)
        {
            this.department = Name;
            this.value = Value;
        }

        public override string ToString()
        {
            return this.department;

        }

    }

    

}
