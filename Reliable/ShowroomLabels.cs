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

namespace Reliable
{
    public partial class ShowroomLabels : Form
    {

        //Creating colours to be used in the labels
        BaseColor colourBlack = new BaseColor(0, 0, 0);
        BaseColor colourBlue = new BaseColor(0, 0, 255);
        BaseColor colourWhite = new BaseColor(255, 255, 255);
        BaseColor colourGrey = new BaseColor(160, 160, 160);
        BaseColor colourGreyLight = new BaseColor(100, 100, 100);
        BaseColor colourRed = new BaseColor(255, 0, 0);

        //Use a list to store the items that the user enters for labels
        List<string> locationsList = new List<string>();

        DataTable itemNumbersTableWHSR = new DataTable();

        //COnnection string used to connect to the MS access database
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        //Create object linking and embedding database connection object used to establish connection with the access database
        OleDbConnection connect = null;

        public ShowroomLabels()
        {
            InitializeComponent();
        }

        //Event used to close the winform on button click

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Event used to minimize the winform on button click

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Event used to return to the main menu when the toolbar item is clicked

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        /*Within the queybuilder function, the query that is to be used in order to obtain the required label data from the MS Access database
         is created.*/

        private string QueryBuilder()
        {
            //Obtain the items that the user enetered in the item-numbers textbox. The items must be on separate lines within the textbox
            string[] itemsArray = itemNumbersBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            string query = null;

            //Select the required columns of information from the ICItems and ICWHBals tables in the access databse
            query += "SELECT dbo_ICItems.ItemID, dbo_ICItems.ItemCode, dbo_ICItems.ItemDescription, dbo_ICItems.ListPrice, dbo_ICItems.SupplierUPCCode, dbo_ICWHBals.BinNumber, dbo_ICWHBals.WHID ";

            //Inner join the required tables based on the ItemID field
            query += "FROM dbo_ICItems INNER JOIN dbo_ICWHBals ON dbo_ICItems.ItemID = dbo_ICWHBals.ItemID ";

            //Set selection criteria such that the warehouse ID corresponds to give the data from the showroom product and the main warehous product (Each item will be listed twice)
            query += "WHERE (dbo_ICWHBals.WHID = 1) AND ";

            //Add filtering criteria to the query such that only the items the user listed are searched for
            for (int i = 0; i < itemsArray.Length; i++)
            {
                if (i == 0)
                {
                    if (itemsArray.Length == 1)
                    {
                        query += "(dbo_ICItems.ItemCode = '" + itemsArray[i].ToString();
                    }

                    else
                    {
                        query += "(dbo_ICItems.ItemCode = '" + itemsArray[i].ToString() + "' OR dbo_ICItems.ItemCode = '";
                    }
                }

                else if (i != itemsArray.Length - 1)
                {
                    query += itemsArray[i].ToString() + "' OR dbo_ICItems.ItemCode = '";
                }

                else
                {
                    query += itemsArray[i].ToString();
                }

            }

            query += "') ";

            //Set arbitrary ortering for the items in the list

            query += "ORDER BY dbo_ICItems.ItemCode, dbo_ICWHBals.WHID DESC;";

            return query;
        }

        //Query used to list out all items based on thye locations selected in the locations listbox
        private string QueryBuilderAllItemsInShowroom()
        {
            string query = null;

            query += "SELECT dbo_ICWHBals.ItemID ";

            query += "FROM dbo_ICWHBals WHERE ";

            List<string> itemLocationsSelected = new List<string>();

            foreach (object location in locationsListbox.SelectedItems)
            {
                itemLocationsSelected.Add(location.ToString());

            }

            for (int q = 0; q < itemLocationsSelected.Count; q++)
            {
                if (q == 0)
                {
                    if (itemLocationsSelected.Count == 1)
                    {
                        query += "(dbo_ICWHBals.BinNumber = '" + itemLocationsSelected[q].ToString();
                    }

                    else
                    {
                        query += "(dbo_ICWHBals.BinNumber = '" + itemLocationsSelected[q].ToString() + "' OR dbo_ICWHBals.BinNumber = '";
                    }
                }

                else if (q != itemLocationsSelected.Count - 1)
                {
                    query += itemLocationsSelected[q].ToString() + "' OR dbo_ICWHBals.BinNumber = '";
                }

                else
                {
                    query += itemLocationsSelected[q].ToString();
                }

            }

            query += "') ";

            query += "ORDER BY dbo_ICWHBals.WHID DESC;";

            return query;
        }



        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            itemNumbersTableWHSR.Clear();

            //If the query is based on items selected in the locations listbox, then a separate query is run

            if (locationsCheckbox.Checked == true)
            {

                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand(QueryBuilderAllItemsInShowroom(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable itemNumbersForLocationsTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(itemNumbersForLocationsTable);

                connect.Close();

                string query = null;

                //Set up query using the same criteria as the query builder, however, the query builder does not
                //take any input paramteres, so we need to recreate the function here, except using a separate list/table

                query += "SELECT dbo_ICItems.ItemID, dbo_ICItems.ItemCode, dbo_ICItems.ItemDescription, dbo_ICItems.ListPrice, dbo_ICItems.SupplierUPCCode, dbo_ICWHBals.BinNumber, dbo_ICWHBals.WHID ";

                query += "FROM dbo_ICItems INNER JOIN dbo_ICWHBals ON dbo_ICItems.ItemID = dbo_ICWHBals.ItemID ";

                query += "WHERE (dbo_ICWHBals.WHID = 116 OR dbo_ICWHBals.WHID = 1) AND ";

                for (int q = 0; q < itemNumbersForLocationsTable.Rows.Count; q++)
                {
                    if (q == 0)
                    {
                        if (itemNumbersForLocationsTable.Rows.Count == 1)
                        {
                            query += "(dbo_ICItems.ItemID = " + itemNumbersForLocationsTable.Rows[q][0].ToString();
                        }

                        else
                        {
                            query += "(dbo_ICItems.ItemID = " + itemNumbersForLocationsTable.Rows[q][0].ToString() + " OR dbo_ICItems.ItemID = ";
                        }
                    }

                    else if (q != itemNumbersForLocationsTable.Rows.Count - 1)
                    {
                        query += itemNumbersForLocationsTable.Rows[q][0].ToString() + " OR dbo_ICItems.ItemID = ";
                    }

                    else
                    {
                        query += itemNumbersForLocationsTable.Rows[q][0].ToString();
                    }

                }

                query += ") ";

                query += "ORDER BY dbo_ICWHBals.BinNumber ASC;";

                //Open up a connection to the datavse, run the query, and then store the results in a datatable
                //The results of the query will be a list of the items and the required information in relation to those
                //item in the showroom. Each item is listed twice.
                connect.Open();
                command = new OleDbCommand(query, connect);
                adapter = new OleDbDataAdapter(command);

                adapter.SelectCommand = command;

                adapter.Fill(itemNumbersTableWHSR);

                connect.Close();

            }

            else
            {
                //If item numbers are manually entered into the textbox, then the query is built based on the item numbers

                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.SelectCommand = command;

                adapter.Fill(itemNumbersTableWHSR);

                connect.Close();
            }

            //Create a folder path in which the showroom labels pdf will be stored. The new directory will only be created if
            //the directory does not already exist.

            string folderPath = "Z:\\Showroom Labels\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }



            /*Create a new filestream object to store the pdf of the showroom labels. The filestream object will be named using the current date to make the file unique.*/

            string fileName = folderPath + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + DateTime.Today.Minute.ToString() + "-" + "ShowroomLabels.pdf";

            System.IO.FileStream fs = new FileStream(fileName, FileMode.Create);

            //Create the pdf document with appropriate margins
            Document myPDF = new Document(PageSize.LETTER, 10f, 10f, 30f, 30f);

            //Initiate the writing to the pdf document and add the appropriate information in relation to the author and creator
            PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

            myPDF.AddAuthor("Reliable");

            myPDF.AddCreator("This document was created using iTextSharp");

            myPDF.AddSubject("Showroom Labels");

            myPDF.AddTitle("Showroom Labels");

            //Open the pdf and begin writing to it
            myPDF.Open();

            PdfContentByte contentByte = write.DirectContent;

            //initialize fonts to use in the  pdf document

            BaseFont myFontBold = FontFactory.GetFont(BaseFont.HELVETICA_BOLD).BaseFont;
            BaseFont myFontRegular = FontFactory.GetFont(BaseFont.HELVETICA).BaseFont;
            BaseFont codeFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\LibreBarcode128-Regular.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            //Counter for the loop of inserting labels on the pdf

            int i = 0;

            //Identifying the top of the pdf document, which decreases in each successive loop
            int bottom = 753;

            //Increment i by two because each item is double listed
            /*When the labels are created, we take into account the idea that 72 points = 1 inch. The label dimensions are as follows:
             Height = 1.8cm = 51 point
             Width = 10.1cm = 286 point
             
             A page has the following dimensions: 792 point x 612 point
             
             Therefore each page will contain 28 labels with top and bottom margins of 39 point and
             left and right margins of 20 point*/

            MessageBox.Show(itemNumbersTableWHSR.Rows.Count.ToString());

            for (; i < itemNumbersTableWHSR.Rows.Count; i = i + 2)
            {


                    //If i % 4 is 0 then the label is on the left of the paper
                if (i % 4 == 0 || (locationsCheckbox.Checked == false && i%2 == 0))
                {

                    iTextSharp.text.Rectangle border = new iTextSharp.text.Rectangle(20, bottom - 51, 306, bottom);
                    border.BackgroundColor = colourWhite;
                    border.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    border.BorderWidth = 1;
                    border.BorderColor = colourBlack;
                    contentByte.Rectangle(border);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 12);

                    //Place the description of the item at the top of the label, and centred. It is 5 points from the top of the label

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemNumbersTableWHSR.Rows[i][2].ToString(), 163, bottom - 14, 0);

                    contentByte.SetFontAndSize(myFontBold, 7);

                    //Place the item number below the description, with 2 points of spacing

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemNumbersTableWHSR.Rows[i][1].ToString(), 163, bottom - 22, 0);

                    //Set the required font attributes for the price at the bottom right of the label, it is in the right third

                    contentByte.SetColorFill(colourRed);
                    contentByte.SetFontAndSize(myFontBold, 18);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Convert.ToDouble(itemNumbersTableWHSR.Rows[i][3].ToString()).ToString("C"), 286, bottom - 38, 0);

                    contentByte.SetColorFill(colourBlack);
                    contentByte.SetFontAndSize(myFontRegular, 6);

                    //Here we are placing the location of the item (bin number) underneath the price

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemNumbersTableWHSR.Rows[i][5].ToString(), 286 - myFontBold.GetWidthPoint(Convert.ToDouble(itemNumbersTableWHSR.Rows[i][3].ToString()).ToString("C"), 18)/2, bottom - 47, 0);

                    //Finally, we are placing the barcode on the label

                    if (itemNumbersTableWHSR.Rows[i][4].ToString() != "")
                    {

                        Code128Conversion bCode = new Code128Conversion(itemNumbersTableWHSR.Rows[i][4].ToString());

                        bCode.ConvertToCode128();

                        contentByte.SetColorFill(colourBlack);
                        contentByte.SetFontAndSize(codeFont, 28);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, bCode.GetBarcode(), 30, bottom - 48, 0);
                    }

                    contentByte.EndText();

                }

                //If i % 4 is 2 then the label is on the right of the paper
                else if (i % 4 == 2 || (locationsCheckbox.Checked == false && i % 2 == 1))
                {

                    iTextSharp.text.Rectangle border = new iTextSharp.text.Rectangle(306, bottom - 51, 592, bottom);
                    border.BackgroundColor = colourWhite;
                    border.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    border.BorderWidth = 1;
                    border.BorderColor = colourBlack;
                    contentByte.Rectangle(border);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 12);

                    //Place the description of the item at the top of the label, and centred. It is 5 points from the top of the label

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemNumbersTableWHSR.Rows[i][2].ToString(), 449, bottom - 14, 0);

                    contentByte.SetFontAndSize(myFontBold, 7);

                    //Place the item number below the description, with 2 points of spacing

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemNumbersTableWHSR.Rows[i][1].ToString(), 449, bottom - 22, 0);

                    //Set the required font attributes for the price at the bottom right of the label, it is in the right third

                    contentByte.SetColorFill(colourRed);
                    contentByte.SetFontAndSize(myFontBold, 18);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Convert.ToDouble(itemNumbersTableWHSR.Rows[i][3].ToString()).ToString("C"), 572, bottom - 38, 0);

                    contentByte.SetColorFill(colourBlack);
                    contentByte.SetFontAndSize(myFontRegular, 6);

                    //Here we are placing the location of the item (bin number) underneath the price

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemNumbersTableWHSR.Rows[i][5].ToString(), 572 - (myFontBold.GetWidthPoint(Convert.ToDouble(itemNumbersTableWHSR.Rows[i][3].ToString()).ToString("C"), 18)/2), bottom - 47, 0);

                    //Finally, we are placing the barcode and its associated numeric value on the label

                    if (itemNumbersTableWHSR.Rows[i][4].ToString() != "")
                    {

                        Code128Conversion bCode = new Code128Conversion(itemNumbersTableWHSR.Rows[i][4].ToString());

                        bCode.ConvertToCode128();

                        contentByte.SetColorFill(colourBlack);
                        contentByte.SetFontAndSize(codeFont, 28);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, bCode.GetBarcode(), 316, bottom - 48, 0);
                    }

                    contentByte.EndText();

                    bottom = bottom - 51;

                }

                if (bottom <= 39)
                {
                    myPDF.NewPage();

                    bottom = 753;
                }

                if (locationsCheckbox.Checked == false)
                {
                    i = i - 1;

                    MessageBox.Show(i.ToString());
                }


            }

            myPDF.Close();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = fileName;
            process.Start();

            this.Cursor = Cursors.Default;
        }
    
        private void ShowroomLabels_Load(object sender, EventArgs e)
        {
            itemNumbersBox.Visible = true;
            locationsListbox.Visible = false;
            label1.Visible = true;
        }

        private void allShowroomBox_CheckedChanged(object sender, EventArgs e)
        {
            if (locationsCheckbox.Checked == true)
            {
                this.Cursor = Cursors.WaitCursor;

                itemNumbersBox.Visible = false;
                locationsListbox.Visible = true;
                label1.Visible = false;

                string query = null;

                query += "SELECT dbo_ICWHBals.BinNumber ";

                query += "FROM dbo_ICWHBals ";

                query += "WHERE dbo_ICWHBals.WHID = 116 ";

                query += "GROUP BY dbo_ICWHBals.BinNumber ";

                query += "ORDER BY dbo_ICWHBals.BinNumber ASC;";

                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand(query, connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable locationsTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(locationsTable);

                locationsList.Clear();

                foreach (DataRow row in locationsTable.Rows)
                {
                    locationsList.Add(row[0].ToString());
                }

                locationsListbox.DataSource = locationsList;

                connect.Close();

                this.Cursor = Cursors.Default;

            }

            else
            {
                itemNumbersBox.Visible = true;
                locationsListbox.Visible = false;
                label1.Visible = true;
            }
        }
    }
}
