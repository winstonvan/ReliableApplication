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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Reliable
{


    public partial class SalesCatalogue : Form
    {

        BaseColor colourBlack = new BaseColor(0, 0, 0);
        BaseColor colourBlue = new BaseColor(0, 0, 255);
        BaseColor colourWhite = new BaseColor(255, 255, 255);
        BaseColor colourGrey = new BaseColor(160, 160, 160);
        BaseColor colourGreyLight = new BaseColor(160, 160, 160);

        bool connectedRIS = false;
        bool headersNeeded = false;

        Label new_Column;

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";

        DataTable catalogueTable = new DataTable();

        OleDbConnection connect = null;
        public SalesCatalogue()
        {
            InitializeComponent();
        }

        private string queryBuilder()
        {

            String query = null;

            query = "SELECT dbo_vCustomerCatalogs.ItemCode, dbo_vCustomerCatalogs.ItemDescription, dbo_vCustomerCatalogs.CustAcct, dbo_vCustomerCatalogs.CustomerName, dbo_vCustomerCatalogs.CatalogCode, dbo_vCustomerCatalogs.JMCatItemFlag, ";

            query += "dbo_vCustomers.PrimaryShipCustomerName, dbo_vCustomers.PrimaryShipAddress1, dbo_vCustomers.PrimaryShipAddress2, dbo_vCustomerCatalogs.PriceUnit, dbo_vInventoryItems.CategoryDescription ";

            query += "FROM ((dbo_vCustomerCatalogs INNER JOIN dbo_vCustomers ON dbo_vCustomers.CustID = dbo_vCustomerCatalogs.CustID) INNER JOIN dbo_vInventoryItems ON dbo_vInventoryItems.ItemCode = dbo_vCustomerCatalogs.ItemCode) ";

            query += "WHERE dbo_vCustomerCatalogs.CatalogCode = '" + customerCodeBox.Text + "' AND dbo_vCustomers.CustAcct = '" + accountNumberCode.Text + "' ORDER BY ";

            if(orderByCombobox.Text == "Item Number")
            {
                query += "dbo_vCustomerCatalogs.ItemCode;";
                headersNeeded = false;
            }

            else if (orderByCombobox.Text == "Item Category")
            {
                query += "dbo_vInventoryItems.CategoryDescription, dbo_vCustomerCatalogs.ItemCode;";
                headersNeeded = true;
            }

            return query;
        }


        private void SalesCatalogue_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            generateCatalogueButton.Visible = false;

            columnTypeBox.Height = 30;
            columnTypeBox.ItemHeight = 30;

            connect = new OleDbConnection(OLDBEConnect);
            connect.Open();
            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

            connectedRIS = false;

            this.Cursor = Cursors.Default;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*The method below is used to generate a pdf file of the required customer catalogue.*/
        private void generateCatalogueButton_Click_1(object sender, EventArgs e)
        {

            generateCatalogueButton.Visible = false;
            buttonTransition.ShowSync(generateCatalogueButton);

            try
            {

                //Obtaine Reliable information from the database in access
                OleDbCommand command1 = new OleDbCommand("SELECT APMail.CompanyName, APMail.AddressOne, APMail.AddressTwo, APMail.Telephone, APMail.TollFree, APMail.Fax FROM APMail;", connect);
                OleDbDataAdapter adapter1 = new OleDbDataAdapter(command1);

                DataTable reliableInfo = new DataTable();

                adapter1.SelectCommand = command1;

                adapter1.Fill(reliableInfo);

                string folderPath = null;

                //Create the folderpath where the customer catalogue will be stored, if it does not already exist.

                if (connectedRIS == false)
                {
                    folderPath = "Z:\\Customer_Catalogues\\RMP\\";
                }
                else
                {
                    folderPath = "Z:\\Customer_Catalogues\\RIS\\";
                }

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                //Name the file in a unque manner such that it is identifiable in the folder where it will be stored
                System.IO.FileStream fs = new FileStream(folderPath + customerCodeBox.Text + "-" + accountNumberCode.Text + "-Catalogue.pdf", FileMode.Create);

                //Dimension the pdf accordingly
                Document myPDF = new Document(PageSize.LETTER, 10f, 10f, 30f, 30f);

                PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

                //Give the pdf proper creators and authors
                myPDF.AddAuthor("Reliable");

                myPDF.AddCreator("This document was created using iTextSharp");

                myPDF.AddSubject(customerCodeBox.Text + " Catalogue");

                myPDF.AddTitle(customerCodeBox.Text + " Catalogue");

                //Open up the pdf for creation
                myPDF.Open();

                PdfContentByte contentByte = write.DirectContent;

                //initialize fonts that will be used within the pdf file
                BaseFont myFontBold = FontFactory.GetFont(BaseFont.HELVETICA_BOLD).BaseFont;
                BaseFont myFontRegular = FontFactory.GetFont(BaseFont.HELVETICA).BaseFont;
                contentByte.SetFontAndSize(myFontBold, 12);          
             
                //A page has the following dimensions: 792 point x 612 point

                //Add header design to the pdf
                contentByte.SetLineWidth(3f);
                contentByte.SetRGBColorStroke(0, 0, 153);
                contentByte.MoveTo(20, 765);
                contentByte.LineTo(580, 765);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

                //Inserting company logo. THe logo could be for RMP or RIS

                if (connectedRIS == false)
                {
                    Bitmap myBitmap = new Bitmap(Properties.Resources.ReliableLogo);

                    System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

                    iTextSharp.text.BaseColor myColour = null;

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                    logo.ScaleToFit(100, 100);
                    logo.SetAbsolutePosition(40, 650);
                    contentByte.AddImage(logo);
                }

                else
                {
                    Bitmap myBitmap = new Bitmap(Properties.Resources.Reliable_Industrial_Grey);

                    System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

                    iTextSharp.text.BaseColor myColour = null;

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                    logo.ScaleToFit(140, 140);
                    logo.SetAbsolutePosition(40, 670);
                    contentByte.AddImage(logo);
                }

                //Creating the header

                contentByte.SetColorFill(colourBlack);

                contentByte.SetFontAndSize(myFontBold, 11);

                float telephoneWidth = 0;

                contentByte.BeginText();

                //Here, we are adding the company contact information. If there is no toll free number, then it is not included.

                if (reliableInfo.Rows[0][4].ToString() == "")
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Telephone: " + reliableInfo.Rows[0][3].ToString() + "   Fax: " + reliableInfo.Rows[0][5].ToString(), 270, 719, 0);
                    telephoneWidth = (270 + (myFontBold.GetWidthPoint("Telephone: " + reliableInfo.Rows[0][3].ToString() + "   Fax: " + reliableInfo.Rows[0][5].ToString(), 11) / 2));

                }
                else
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Telephone: " + reliableInfo.Rows[0][3].ToString() + "   Toll Free: " + reliableInfo.Rows[0][4].ToString() + "   Fax: " + reliableInfo.Rows[0][5].ToString(), 200, 719, 0);
                    telephoneWidth = (200 + (myFontBold.GetWidthPoint("Telephone: " + reliableInfo.Rows[0][3].ToString() + "   Toll Free: " + reliableInfo.Rows[0][4].ToString() + "   Fax: " + reliableInfo.Rows[0][5].ToString(), 11) / 2));
                }

                //Add the company name to the top of the order form

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, reliableInfo.Rows[0][0].ToString().ToUpper() + " ORDER FORM", telephoneWidth, 735, 0);

                /*Below, we are adding four lines that contain a blank that follows them where information can be
                 hand written onto the form. These blanks/areas fopr entry are equally spaced and formatted.*/
                contentByte.SetFontAndSize(myFontBold, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date:", 200, 680, 0);

                contentByte.EndText();

                contentByte.SetLineWidth(1f);
                contentByte.SetRGBColorStroke(0, 0, 0);
                contentByte.MoveTo(230, 679);
                contentByte.LineTo(360, 679);
                contentByte.Stroke();

                contentByte.BeginText();

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Signature:", 380, 680, 0);

                contentByte.EndText();

                contentByte.MoveTo(440, 679);
                contentByte.LineTo(570, 679);
                contentByte.Stroke();

                contentByte.BeginText();

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Ordered By:", 200, 650, 0);

                contentByte.EndText();

                contentByte.SetLineWidth(1f);
                contentByte.SetRGBColorStroke(0, 0, 0);
                contentByte.MoveTo(265, 649);
                contentByte.LineTo(360, 649);
                contentByte.Stroke();

                contentByte.BeginText();

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "PO Number:", 380, 650, 0);

                contentByte.EndText();

                contentByte.MoveTo(445, 649);
                contentByte.LineTo(570, 649);
                contentByte.Stroke();

                float longestWidth = 0;

                string input = catalogueDGV.Rows[0].Cells[3].Value.ToString();
                string condition = "    *";
                string[] output = Regex.Split(input, condition);
                string companyName = output[0];

                //Below, we identify which line of te header is widest. THis allows us to identify where we can centre the information
                //that corresponds to the company for which the order form is created.

                longestWidth = myFontBold.GetWidthPoint("Company: ", 11) + myFontRegular.GetWidthPoint(companyName, 11);

                if (longestWidth < (myFontBold.GetWidthPoint("Account Number: ", 11) + myFontRegular.GetWidthPoint(catalogueDGV.Rows[0].Cells[2].Value.ToString(), 11)))
                {
                    longestWidth = myFontBold.GetWidthPoint("Account Number: ", 11) + myFontRegular.GetWidthPoint(catalogueDGV.Rows[0].Cells[2].Value.ToString(), 11);
                }

                if (longestWidth < (myFontBold.GetWidthPoint(" ", 11) + myFontRegular.GetWidthPoint(catalogueDGV.Rows[0].Cells[7].Value.ToString(),11) + myFontRegular.GetWidthPoint(catalogueDGV.Rows[0].Cells[8].Value.ToString(), 11)))
                {
                    longestWidth = (myFontBold.GetWidthPoint(" ", 11) + myFontRegular.GetWidthPoint(catalogueDGV.Rows[0].Cells[7].Value.ToString(), 11) + myFontRegular.GetWidthPoint(catalogueDGV.Rows[0].Cells[8].Value.ToString(), 11));
                }


                /*Below, the information corresponding to the company that the order form is made out to is added to the document.*/

                iTextSharp.text.Rectangle borderRect = new iTextSharp.text.Rectangle(370 - (longestWidth / 2) - 10, 584, 370 + (longestWidth / 2) + 10, 640);
                borderRect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                borderRect.BorderWidth = 2;
                borderRect.BorderColor = colourBlack;
                contentByte.Rectangle(borderRect);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Company: ", 370 - (longestWidth / 2), 624, 0);

                contentByte.SetFontAndSize(myFontRegular, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[0].Cells[3].Value.ToString(), 370 - (longestWidth / 2) + myFontBold.GetWidthPoint("Company: ", 11), 624, 0);

                contentByte.SetFontAndSize(myFontBold, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Account Number: ", 370 - (longestWidth / 2), 608, 0);

                contentByte.SetFontAndSize(myFontRegular, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[0].Cells[2].Value.ToString(), 370 - (longestWidth / 2) + myFontBold.GetWidthPoint("Account Number: ", 11), 608, 0);

                contentByte.SetFontAndSize(myFontRegular, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[0].Cells[7].Value.ToString() + " " + catalogueDGV.Rows[0].Cells[8].Value.ToString(), 370 - (longestWidth / 2), 592, 0);

                contentByte.EndText();

                contentByte.SetLineWidth(3f);
                contentByte.SetRGBColorStroke(0, 0, 153);
                contentByte.MoveTo(20, 575);
                contentByte.LineTo(580, 575);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

                int pageNumber = 0;

                //Set to true when a new header that corresponds to item category is added to the order form. The header cannot be the first header added.
                bool headerIn = false;

                //This is set to true when we reach to bottom of a column and need to create a new table, whether on the same page, or a new page
                bool skipToNewColumn = false;

                //This is set to true when we are
                bool firstEntry = false;

                //The value below is used to identify whether we are on the first page of the order form. If we are not on the first page of the
                //order form, this becomes true, and the right table is adjusted such that it starts at the top of the page
                bool notFirstPage = true;

                //If the user wants two columns then we use the formatting below

                if (columnTypeBox.Text == "Double-Column")
                {

                    //Set-up the left table header

                    iTextSharp.text.Rectangle tableHeader = new iTextSharp.text.Rectangle(30, 548, 290, 565);
                    tableHeader.BackgroundColor = colourGreyLight;
                    tableHeader.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    tableHeader.BorderWidth = 1;
                    tableHeader.BorderColor = colourBlack;
                    contentByte.Rectangle(tableHeader);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 11);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Code", 40, 552, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Description", 135, 552, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Unit", 260, 552, 0);

                    contentByte.EndText();

                    int bottom = 548;

                    contentByte.SetLineWidth(1);
                    contentByte.MoveTo(103, 565);
                    contentByte.LineTo(103, bottom);
                    contentByte.Stroke();
                    contentByte.MoveTo(250, 565);
                    contentByte.LineTo(250, bottom);
                    contentByte.Stroke();

                    bottom = bottom - 15;

                    contentByte.SetFontAndSize(myFontRegular, 7.5f);

                    //We now made the header of the left table and are preparing to enter inventory items in the left table

                    int i = -1;

                    //If the user is organizing based on item category as opposed to item number, then we keep i = -1 to add the first category
                    if (headersNeeded == false)
                    {
                        i = 0;
                    }

                    for (; i < catalogueDGV.Rows.Count-1; i++)
                    {
                        //Entering the first header column, if it is required, with the category description name
                        if(i == -1 && headersNeeded == true)
                        {
                            iTextSharp.text.Rectangle tableHeadertwo = new iTextSharp.text.Rectangle(30, bottom, 290, bottom + 17);
                            tableHeadertwo.BackgroundColor = colourBlack;
                            tableHeadertwo.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                            tableHeadertwo.BorderWidth = 1;
                            tableHeadertwo.BorderColor = colourBlack;
                            contentByte.Rectangle(tableHeadertwo);

                            contentByte.BeginText();

                            //Add the category name of the first item in the catalogue
                            contentByte.SetColorFill(colourWhite);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, catalogueDGV.Rows[i + 1].Cells[10].Value.ToString(), 160, bottom + 5, 0);
                            contentByte.SetColorFill(colourBlack);

                            contentByte.EndText();

                            bottom = bottom - 15;

                            continue;
                        }

                        //Here, we check to see if the category of the current item is different from the category of the previous item. If the categories are different,
                        //then we need to add the new category name to the file
                        if (i != 0 && headersNeeded == true && (catalogueDGV.Rows[i].Cells[10].Value.ToString() != catalogueDGV.Rows[i-1].Cells[10].Value.ToString()) && headerIn == false && firstEntry == false)
                        {
                            iTextSharp.text.Rectangle tableHeadertwo = new iTextSharp.text.Rectangle(30, bottom, 290, bottom + 15);
                            tableHeadertwo.BackgroundColor = colourBlack;
                            tableHeadertwo.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                            tableHeadertwo.BorderWidth = 1;
                            tableHeadertwo.BorderColor = colourBlack;
                            contentByte.Rectangle(tableHeadertwo);

                            contentByte.BeginText();

                            contentByte.SetColorFill(colourWhite);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, catalogueDGV.Rows[i].Cells[10].Value.ToString(), 160, bottom + 5, 0);
                            contentByte.SetColorFill(colourBlack);

                            contentByte.EndText();

                            bottom = bottom - 15;

                            
                            headerIn = true;

                            //Move to a new table once we reach the bottom of the page
                            if (bottom <= 100)
                            {
                                skipToNewColumn = true;
                                firstEntry = true;
                                
                            }
                            //If we are not moving to a new column, we decrement i so that we also enter the item information for the corresponding item in the proper column
                            else
                            {

                                i--;

                                continue;
                            }
                        }
                        
                        //Reset header-in so that the header will be added if it changes
                        headerIn = false;

                        if (skipToNewColumn == false)
                        {
                            firstEntry = false;

                            contentByte.BeginText();

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[i].Cells[0].Value.ToString(), 33, bottom + 5, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[i].Cells[1].Value.ToString(), 105, bottom + 5, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, catalogueDGV.Rows[i].Cells[9].Value.ToString(), 287, bottom + 5, 0);

                            contentByte.EndText();

                            contentByte.MoveTo(30, bottom + 15);
                            contentByte.LineTo(30, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(103, bottom + 15);
                            contentByte.LineTo(103, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(250, bottom + 15);
                            contentByte.LineTo(250, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(290, bottom + 15);
                            contentByte.LineTo(290, bottom);
                            contentByte.MoveTo(30, bottom);
                            contentByte.LineTo(290, bottom);
                            contentByte.Stroke();
                            bottom = bottom - 15;

                        }

                        if (bottom <= 100)
                        {
                            skipToNewColumn = false;
                            //Set Table Header

                            if (notFirstPage == true)
                            {
                                bottom = 548;
                            }

                            else
                            {
                                bottom = 750;
                            }
                            

                            iTextSharp.text.Rectangle tableHeadertwo = new iTextSharp.text.Rectangle(310, bottom, 570, bottom + 17);
                            tableHeadertwo.BackgroundColor = colourGreyLight;
                            tableHeadertwo.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                            tableHeadertwo.BorderWidth = 1;
                            tableHeadertwo.BorderColor = colourBlack;
                            contentByte.Rectangle(tableHeadertwo);

                            contentByte.BeginText();

                            contentByte.SetFontAndSize(myFontBold, 11);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Code", 320, bottom + 4, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Description", 408, bottom + 4, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Unit", 540, bottom + 4, 0);

                            contentByte.EndText();

                            contentByte.SetLineWidth(1);
                            contentByte.MoveTo(383, bottom + 17);
                            contentByte.LineTo(383, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(530, bottom + 17);
                            contentByte.LineTo(530, bottom);
                            contentByte.Stroke();

                            bottom = bottom - 15;

                            contentByte.SetFontAndSize(myFontRegular, 7.5f);

                            i++;

                            for (; i < catalogueDGV.Rows.Count-1; i++)
                            {
                                //Checking to see if there are headers in the new column
                                if (i != 0 && headersNeeded == true && (catalogueDGV.Rows[i].Cells[10].Value.ToString() != catalogueDGV.Rows[i - 1].Cells[10].Value.ToString()) && headerIn == false && firstEntry == false)
                                {
                                    iTextSharp.text.Rectangle categoryHeader = new iTextSharp.text.Rectangle(310, bottom, 570, bottom + 15);
                                    categoryHeader.BackgroundColor = colourBlack;
                                    categoryHeader.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                                    categoryHeader.BorderWidth = 1;
                                    categoryHeader.BorderColor = colourBlack;
                                    contentByte.Rectangle(categoryHeader);

                                    contentByte.BeginText();

                                    contentByte.SetColorFill(colourWhite);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, catalogueDGV.Rows[i].Cells[10].Value.ToString(), 440, bottom + 5, 0);
                                    contentByte.SetColorFill(colourBlack);

                                    contentByte.EndText();

                                    bottom = bottom - 15;

                                    headerIn = true;

                                    if (bottom <= 100)
                                    {
                                        skipToNewColumn = true;
                                        firstEntry = true;
                                        i--;

                                    }
                                    else
                                    {

                                        i--;

                                        continue;
                                    }
                                }

                                headerIn = false;

                                if (skipToNewColumn == false)
                                {
                                    contentByte.BeginText();

                                    firstEntry = false;

                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[i].Cells[0].Value.ToString(), 313, bottom + 5, 0);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[i].Cells[1].Value.ToString(), 385, bottom + 5, 0);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, catalogueDGV.Rows[i].Cells[9].Value.ToString(), 567, bottom + 5, 0);

                                    contentByte.EndText();

                                    contentByte.MoveTo(310, bottom + 15);
                                    contentByte.LineTo(310, bottom);
                                    contentByte.Stroke();
                                    contentByte.MoveTo(383, bottom + 15);
                                    contentByte.LineTo(383, bottom);
                                    contentByte.Stroke();
                                    contentByte.MoveTo(530, bottom + 15);
                                    contentByte.LineTo(530, bottom);
                                    contentByte.Stroke();
                                    contentByte.MoveTo(570, bottom + 15);
                                    contentByte.LineTo(570, bottom);
                                    contentByte.Stroke();
                                    contentByte.MoveTo(310, bottom);
                                    contentByte.LineTo(570, bottom);
                                    contentByte.Stroke();
                                    bottom = bottom - 15;
                                }

                                if (bottom <= 100)
                                {

                                    contentByte.BeginText();

                                    contentByte.SetFontAndSize(myFontBold, 11);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Comments:", 30, 80, 0);

                                    contentByte.EndText();

                                    contentByte.SetLineWidth(1);
                                    contentByte.MoveTo(95, 80);
                                    contentByte.LineTo(565, 80);
                                    contentByte.Stroke();

                                    contentByte.SetLineWidth(1);
                                    contentByte.MoveTo(30, 60);
                                    contentByte.LineTo(565, 60);
                                    contentByte.Stroke();

                                    contentByte.SetLineWidth(1);
                                    contentByte.MoveTo(30, 40);
                                    contentByte.LineTo(565, 40);
                                    contentByte.Stroke();

                                    pageNumber++;

                                    contentByte.BeginText();

                                    contentByte.SetFontAndSize(myFontRegular, 6);

                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Page " + pageNumber, 560, 20, 0);

                                    contentByte.EndText();

                                    myPDF.NewPage();


                                    notFirstPage = false;

                                    bottom = 750;

                                    //Table Header 3

                                    iTextSharp.text.Rectangle tableHeaderThree = new iTextSharp.text.Rectangle(30, bottom, 290, bottom + 17);
                                    tableHeaderThree.BackgroundColor = colourGreyLight;
                                    tableHeaderThree.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                                    tableHeaderThree.BorderWidth = 1;
                                    tableHeaderThree.BorderColor = colourBlack;
                                    contentByte.Rectangle(tableHeaderThree);

                                    contentByte.BeginText();

                                    contentByte.SetFontAndSize(myFontBold, 11);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Code", 40, bottom + 4, 0);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Description", 135, bottom + 4, 0);
                                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Unit", 260, bottom + 4, 0);

                                    contentByte.EndText();

                                    contentByte.SetLineWidth(1);
                                    contentByte.MoveTo(103, bottom + 17);
                                    contentByte.LineTo(103, bottom);
                                    contentByte.Stroke();
                                    contentByte.MoveTo(250, bottom + 17);
                                    contentByte.LineTo(250, bottom);
                                    contentByte.Stroke();

                                    bottom = bottom - 15;

                                    contentByte.SetFontAndSize(myFontRegular, 7.5f);

                                    skipToNewColumn = false;

                                    break;
                                }
                            }

                        }
                    }

                }

























                else if (columnTypeBox.Text == "Single-Column")
                {

                    iTextSharp.text.Rectangle tableHeaderNew = new iTextSharp.text.Rectangle(30, 548, 570, 565);
                    tableHeaderNew.BackgroundColor = colourGreyLight;
                    tableHeaderNew.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    tableHeaderNew.BorderWidth = 1;
                    tableHeaderNew.BorderColor = colourBlack;
                    contentByte.Rectangle(tableHeaderNew);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 11);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Code", 55, 552, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Description", 270, 552, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Unit", 525, 552, 0);

                    contentByte.EndText();

                    int bottom = 547;

                    contentByte.SetLineWidth(1);
                    contentByte.MoveTo(130, 565);
                    contentByte.LineTo(130, bottom);
                    contentByte.Stroke();
                    contentByte.MoveTo(500, 565);
                    contentByte.LineTo(500, bottom);
                    contentByte.Stroke();

                    bottom = bottom - 18;

                    contentByte.SetFontAndSize(myFontRegular, 11);

                    int i = -1;

                    if(headersNeeded == false)
                    {
                        i = 0;
                    }

                    for (; i < catalogueDGV.Rows.Count-1; i++)
                    {
                        if (i == -1 && headersNeeded == true)
                        {
                            iTextSharp.text.Rectangle tableHeadertwo = new iTextSharp.text.Rectangle(30, bottom, 571, bottom + 18);
                            tableHeadertwo.BackgroundColor = colourBlack;
                            tableHeadertwo.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                            tableHeadertwo.BorderWidth = 0;
                            tableHeadertwo.BorderColor = colourBlack;
                            contentByte.Rectangle(tableHeadertwo);

                            contentByte.BeginText();

                            contentByte.SetColorFill(colourWhite);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, catalogueDGV.Rows[i+1].Cells[10].Value.ToString(), 310, bottom + 5, 0);
                            contentByte.SetColorFill(colourBlack);

                            contentByte.EndText();

                            bottom = bottom - 18;

                            continue;
                        }

                        if (i != 0 && headersNeeded == true && (catalogueDGV.Rows[i].Cells[10].Value.ToString() != catalogueDGV.Rows[i - 1].Cells[10].Value.ToString()) && headerIn == false && firstEntry == false)
                        {
                            iTextSharp.text.Rectangle tableHeadertwo = new iTextSharp.text.Rectangle(30, bottom, 571, bottom + 18);
                            tableHeadertwo.BackgroundColor = colourBlack;
                            tableHeadertwo.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                            tableHeadertwo.BorderWidth = 0;
                            tableHeadertwo.BorderColor = colourBlack;
                            contentByte.Rectangle(tableHeadertwo);

                            contentByte.BeginText();

                            contentByte.SetColorFill(colourWhite);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, catalogueDGV.Rows[i].Cells[10].Value.ToString(), 310, bottom + 5, 0);
                            contentByte.SetColorFill(colourBlack);

                            contentByte.EndText();

                            bottom = bottom - 18;

                            headerIn = true;

                            if (bottom <= 100)
                            {
                                skipToNewColumn = true;
                                firstEntry = true;
                                i--;

                            }
                            else
                            {

                                i--;

                                continue;
                            }
                        }

                        headerIn = false;

                        if (skipToNewColumn == false)
                        {

                            firstEntry = false;

                            contentByte.BeginText();

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[i].Cells[0].Value.ToString(), 35, bottom + 5, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, catalogueDGV.Rows[i].Cells[1].Value.ToString(), 135, bottom + 5, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, catalogueDGV.Rows[i].Cells[9].Value.ToString(), 565, bottom + 5, 0);

                            contentByte.EndText();

                            contentByte.MoveTo(30, bottom + 18);
                            contentByte.LineTo(30, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(130, bottom + 18);
                            contentByte.LineTo(130, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(500, bottom + 18);
                            contentByte.LineTo(500, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(570, bottom + 18);
                            contentByte.LineTo(570, bottom);
                            contentByte.MoveTo(30, bottom);
                            contentByte.LineTo(570, bottom);
                            contentByte.Stroke();
                            bottom = bottom - 18;
                        }

                        if (bottom <= 100)
                        {
                            contentByte.BeginText();

                            contentByte.SetFontAndSize(myFontBold, 11);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Comments:", 30, 80, 0);

                            contentByte.EndText();

                            contentByte.SetLineWidth(1);
                            contentByte.MoveTo(95, 80);
                            contentByte.LineTo(565, 80);
                            contentByte.Stroke();

                            contentByte.SetLineWidth(1);
                            contentByte.MoveTo(30, 60);
                            contentByte.LineTo(565, 60);
                            contentByte.Stroke();

                            contentByte.SetLineWidth(1);
                            contentByte.MoveTo(30, 40);
                            contentByte.LineTo(565, 40);
                            contentByte.Stroke();

                            pageNumber++;

                            contentByte.BeginText();

                            contentByte.SetFontAndSize(myFontRegular, 6);

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Page " + pageNumber, 560, 20, 0);

                            contentByte.EndText();

                            myPDF.NewPage();

                            bottom = 750;

                            //Table Header 3

                            iTextSharp.text.Rectangle tableHeaderThree = new iTextSharp.text.Rectangle(30, bottom, 570, bottom + 18);
                            tableHeaderThree.BackgroundColor = colourGreyLight;
                            tableHeaderThree.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                            tableHeaderThree.BorderWidth = 1;
                            tableHeaderThree.BorderColor = colourBlack;
                            contentByte.Rectangle(tableHeaderThree);

                            contentByte.BeginText();

                            contentByte.SetFontAndSize(myFontBold, 11);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Code", 55, bottom + 4, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item Description", 270, bottom + 4, 0);
                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Unit", 525, bottom + 4, 0);

                            contentByte.EndText();

                            contentByte.SetLineWidth(1);
                            contentByte.MoveTo(130, bottom + 17);
                            contentByte.LineTo(130, bottom);
                            contentByte.Stroke();
                            contentByte.MoveTo(500, bottom + 17);
                            contentByte.LineTo(500, bottom);
                            contentByte.Stroke();

                            bottom = bottom - 18;

                            contentByte.SetFontAndSize(myFontRegular, 11);

                            skipToNewColumn = false;

                        }

                    }
                }

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 11);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Comments:", 30, 80, 0);

                contentByte.EndText();

                contentByte.SetLineWidth(1);
                contentByte.MoveTo(95, 80);
                contentByte.LineTo(565, 80);
                contentByte.Stroke();

                contentByte.SetLineWidth(1);
                contentByte.MoveTo(30, 60);
                contentByte.LineTo(565, 60);
                contentByte.Stroke();

                contentByte.SetLineWidth(1);
                contentByte.MoveTo(30, 40);
                contentByte.LineTo(565, 40);
                contentByte.Stroke();

                pageNumber++;

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontRegular, 6);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Page " + pageNumber, 560, 20, 0);

                contentByte.EndText();

                myPDF.Close();

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                process.StartInfo = startInfo;

                startInfo.FileName = folderPath + customerCodeBox.Text + "-" + accountNumberCode.Text + "-Catalogue.pdf";
                process.Start();

                this.Cursor = Cursors.Default;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                this.Cursor = Cursors.Default;
            }

        }

        private void mainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            FormState.PreviousPage.Show();

            this.Hide();


        }

        private void RMPConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnect);
                connect.Open();

                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

            this.Cursor = Cursors.Default;

            connectedRIS = true;
        }

        private void RISConnect_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Open();

                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = true;
            RISConnect.Enabled = false;

            this.Cursor = Cursors.Default;

            connectedRIS = true;

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private System.Drawing.Rectangle dragBoxFromMouseDown;
        private int rowIndexFromMouseDown;
        private int rowIndexOfItemUnderMouseToDrop;
        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            OleDbCommand command = new OleDbCommand(queryBuilder(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            catalogueTable.Clear();

            adapter.SelectCommand = command;

            adapter.Fill(catalogueTable);

            catalogueDGV.DataSource = catalogueTable;

            catalogueDGV.Columns[1].Width = 250;

            foreach (DataGridViewColumn column in catalogueDGV.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            this.Cursor = Cursors.Default;

            generateCatalogueButton.Visible = true;

        }

        private void upButton_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            int index = catalogueDGV.CurrentCell.RowIndex;

            DataRow[] drArray = catalogueTable.Select();

            DataRow changingRow = catalogueTable.NewRow();

            changingRow.ItemArray = drArray[index].ItemArray;

            catalogueTable.Rows.Remove(drArray[index]);

            catalogueTable.Rows.InsertAt(changingRow, index - 1);

            catalogueDGV.Rows[index + 1].Selected = false;

            catalogueDGV.CurrentCell = catalogueDGV[1, index - 1];

            catalogueDGV.Rows[index - 1].Selected = true;

            this.Cursor = Cursors.Default;

        }

        private void downButton_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            int index = catalogueDGV.CurrentCell.RowIndex;


            DataRow[] drArray = catalogueTable.Select();

            DataRow changingRow = catalogueTable.NewRow();


            changingRow.ItemArray = drArray[index].ItemArray;

            catalogueTable.Rows.Remove(drArray[index]);

            catalogueTable.Rows.InsertAt(changingRow, index + 1);

            if (index - 1 != -1)
            {
                catalogueDGV.Rows[index - 1].Selected = false;
            }

            catalogueDGV.CurrentCell = catalogueDGV[1, index + 1];

            catalogueDGV.Rows[index + 1].Selected = true;

            this.Cursor = Cursors.Default;

        }
    }
}
 