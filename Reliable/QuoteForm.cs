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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace Reliable
{

    
    public partial class QuoteForm : Form
    {
        bool jmFlag = false;

        BaseColor colourBlack = new BaseColor(0, 0, 0);
        BaseColor colourBlue = new BaseColor(0, 0, 255);
        BaseColor colourWhite = new BaseColor(255, 255, 255);
        BaseColor colourGrey = new BaseColor(160, 160, 160);
        BaseColor colourGreyLight = new BaseColor(100, 100, 100);
        
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        String ODBCJMCat = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Z:\\JMCat\\PCC\\Data\\RELMAP\\PrintCatalogDefaultV3_RELMAP.mdb;Jet OLEDB:Database Password=AJguess2ME;";

        String ODBCStep1 = "Provider=sqloledb;Server=10.10.10.7;Database=ReliableONDB;User Id=query;Password=Helmet-Clear;";

        DataTable quoteData = new DataTable();

        OleDbConnection connect = null;

        List<string> itemIDList = new List<string>();

        List<string> itemCodeList = new List<string>();

        List<int> descriptionLinesToAdd = new List<int>();

        int pageNumber;
        public QuoteForm()
        {
            InitializeComponent();
        }

        public string FixBase64ForImage(string Image)
        {
            System.Text.StringBuilder sbText = new System.Text.StringBuilder(Image, Image.Length);

            sbText.Replace("\r\n", String.Empty);

            sbText.Replace(" ", String.Empty);

            return sbText.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private string QueryBuilder()
        {

            string query = null;

            query += "SELECT dbo_vPendingCustomerOrderSummary.OrderNum, dbo_vPendingCustomerOrderSummary.OrderDate, dbo_vPendingCustomerOrderSummary.Terms, dbo_vPendingCustomerOrderSummary.BillCustomerName, "; //3
            query += "dbo_vPendingCustomerOrderSummary.BillAddress1, dbo_vPendingCustomerOrderSummary.BillAddress2, dbo_vPendingCustomerOrderSummary.BillCity, dbo_vPendingCustomerOrderSummary.BillState, "; //7
            query += "dbo_vPendingCustomerOrderSummary.BillZip, dbo_vPendingCustomerOrderSummary.ShipCustomerName, dbo_vPendingCustomerOrderSummary.ShipAddress1, dbo_vPendingCustomerOrderSummary.ShipAddress2, "; //11
            query += "dbo_vPendingCustomerOrderSummary.ShipCity, dbo_vPendingCustomerOrderSummary.ShipState, dbo_vPendingCustomerOrderSummary.ShipZip, dbo_vPendingCustomerOrderSummary.SalesmanName, "; //15
            query += "dbo_vPendingCustomerOrderSummary.WHCode, dbo_vPendingCustomerOrderSummary.FOB, dbo_vPendingCustomerOrderDetail.ItemCode, dbo_vPendingCustomerOrderDetail.Description, "; //19
            query += "dbo_vPendingCustomerOrderDetail.Price, dbo_vPendingCustomerOrderDetail.PriceUnit, dbo_ICWhouse.WHShipName, dbo_ICWhouse.WHShipAddress1, dbo_ICWhouse.WHShipCity, dbo_ICWhouse.WHShipZip, ";//25
            query += "dbo_ICWhouse.WHShipTelephone, dbo_ICItems.WebCatMfgrCode, dbo_ICItems.WebCatPartNum, dbo_ICItems.ItemID, dbo_ICWhouse.WHShipState, dbo_ICItems.Comments2, dbo_vPendingCustomerOrderDetail.LineType, dbo_vPendingCustomerOrderDetail.LineNum, dbo_vSalesreps.UserLoginName, dbo_SYUsers.UserFirstName, dbo_SYUsers.UserLastName, dbo_SYUsers.EmailAddress ";//37

            query += "FROM ((((dbo_vPendingCustomerOrderSummary INNER JOIN dbo_vPendingCustomerOrderDetail ON dbo_vPendingCustomerOrderSummary.OrderNum = dbo_vPendingCustomerOrderDetail.OrderNum) INNER JOIN dbo_ICWhouse ON dbo_ICWhouse.WHCode = dbo_vPendingCustomerOrderSummary.WHCode) INNER JOIN dbo_ICItems ON dbo_ICItems.ItemCode = dbo_vPendingCustomerOrderDetail.ItemCode) INNER JOIN dbo_vSalesreps ON dbo_vSalesreps.SalesRepName = dbo_vPendingCustomerOrderSummary.SalesmanName) INNER JOIN dbo_SYUsers ON dbo_SYUsers.UserLoginName = dbo_vSalesreps.UserLoginName ";

            query += "WHERE dbo_vPendingCustomerOrderSummary.OrderNum = '" + quoteNumberBox.Text + "' AND (dbo_vPendingCustomerOrderDetail.LineType = 'I' OR dbo_vPendingCustomerOrderDetail.LineType = 'S' OR dbo_vPendingCustomerOrderDetail.LineType = 'N' OR dbo_vPendingCustomerOrderDetail.LineType = 'K' OR dbo_vPendingCustomerOrderDetail.LineType = 'L' OR dbo_vPendingCustomerOrderDetail.LineType = 'M' OR dbo_vPendingCustomerOrderDetail.LineType = 'P') AND dbo_vPendingCustomerOrderDetail.CurPriceCtrl <> 'Kit' ";

            query += "GROUP BY dbo_vPendingCustomerOrderSummary.OrderNum, dbo_vPendingCustomerOrderSummary.OrderDate, dbo_vPendingCustomerOrderSummary.Terms, dbo_vPendingCustomerOrderSummary.BillCustomerName, "; //3
            query += "dbo_vPendingCustomerOrderSummary.BillAddress1, dbo_vPendingCustomerOrderSummary.BillAddress2, dbo_vPendingCustomerOrderSummary.BillCity, dbo_vPendingCustomerOrderSummary.BillState, "; //7
            query += "dbo_vPendingCustomerOrderSummary.BillZip, dbo_vPendingCustomerOrderSummary.ShipCustomerName, dbo_vPendingCustomerOrderSummary.ShipAddress1, dbo_vPendingCustomerOrderSummary.ShipAddress2, "; //11
            query += "dbo_vPendingCustomerOrderSummary.ShipCity, dbo_vPendingCustomerOrderSummary.ShipState, dbo_vPendingCustomerOrderSummary.ShipZip, dbo_vPendingCustomerOrderSummary.SalesmanName, "; //15
            query += "dbo_vPendingCustomerOrderSummary.WHCode, dbo_vPendingCustomerOrderSummary.FOB, dbo_vPendingCustomerOrderDetail.ItemCode, dbo_vPendingCustomerOrderDetail.Description, "; //19
            query += "dbo_vPendingCustomerOrderDetail.Price, dbo_vPendingCustomerOrderDetail.PriceUnit, dbo_ICWhouse.WHShipName, dbo_ICWhouse.WHShipAddress1, dbo_ICWhouse.WHShipCity, dbo_ICWhouse.WHShipZip, ";//25
            query += "dbo_ICWhouse.WHShipTelephone, dbo_ICItems.WebCatMfgrCode, dbo_ICItems.WebCatPartNum, dbo_ICItems.ItemID, dbo_ICWhouse.WHShipState, dbo_ICItems.Comments2, dbo_vPendingCustomerOrderDetail.LineType, dbo_vPendingCustomerOrderDetail.LineNum, dbo_vSalesreps.UserLoginName, dbo_SYUsers.UserFirstName, dbo_SYUsers.UserLastName, dbo_SYUsers.EmailAddress ";//37

            query += "ORDER BY dbo_vPendingCustomerOrderDetail.LineNum;";

            return query;
        }

        private string QueryBuilderSnapNotes()
        {

            string query = null;

            query = "SELECT NoteText, AttachToItemID FROM dbo.SNAPNotes WHERE ";

            itemIDList.Clear();

            foreach (DataRow row in quoteData.Rows)
            {
                itemIDList.Add(row[29].ToString());
            }

            if (itemIDList.Count != 0)
            {

                for (int i = 0; i < itemIDList.Count; i++)
                {

                    if (i == itemIDList.Count - 1)
                    {
                        query += "dbo.SNAPNotes.AttachToItemID = '" + itemIDList[i].ToString() + "';";

                    }

                    else
                    {
                        query += "dbo.SNAPNotes.AttachToItemID = " + itemIDList[i].ToString() + " OR ";
                    }

                }

            }


            return query;
        }

        private string QueryBuilderJMDescription()
        {


            string query = null;

            itemCodeList.Clear();

            foreach (DataRow row in quoteData.Rows)
            {

                itemCodeList.Add(row[18].ToString());

            }


            query = "SELECT Item.ItemGroupID, ItemGroup.JMTProdNameWeb, ItemGroup.BaseDescription, ItemGroup.ExtendedDescription, Item.ItemNo, Item.JMTPhotoFileName FROM Item INNER JOIN ItemGroup ON Item.ItemGroupID = ItemGroup.ID WHERE ";


            if (itemCodeList.Count != 0)
            {
                for (int i = 0; i < itemCodeList.Count; i++)
                {

                    if (i == itemCodeList.Count - 1)
                    {
                        query += "Item.ItemNo = '" + itemCodeList[i].ToString() + "';";

                        break;
                    }

                    else
                    {
                        query += "Item.ItemNo = '" + itemCodeList[i].ToString() + "' OR ";
                    }

                }

            }


            return query;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {


            this.Cursor = Cursors.WaitCursor;

            quoteData.Clear();

            //Developing connection to the databse and querying the required items

            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            adapter.SelectCommand = command;

            adapter.Fill(quoteData);

            connect.Close();

            //Querying the step1 database to get the snapnotes information on the inventory items

            connect = new OleDbConnection(ODBCStep1);
            command = new OleDbCommand(QueryBuilderSnapNotes(), connect);
            adapter = new OleDbDataAdapter(command);

            DataTable snapNotes = new DataTable();

            adapter.Fill(snapNotes);

            connect.Close();

            connect = new OleDbConnection(OLDBEConnect);
            command = new OleDbCommand("SELECT * FROM APMail", connect);
            adapter = new OleDbDataAdapter(command);

            DataTable companyInfoTable = new DataTable();

            adapter.Fill(companyInfoTable);

            connect.Close();

            //Getting required data from the JMCatalogue database

            connect = new OleDbConnection(ODBCJMCat);
            command = new OleDbCommand(QueryBuilderJMDescription(), connect);
            adapter = new OleDbDataAdapter(command);

            DataTable jmDescription = new DataTable();

            adapter.Fill(jmDescription);

            connect.Close();

            //Get the additional description lines from the database
            connect = new OleDbConnection(OLDBEConnect);
            command = new OleDbCommand("SELECT LineNum, Description FROM dbo_vPendingCustomerOrderDetail WHERE OrderNum = '" + quoteNumberBox.Text + "' AND LineType = 'D' ORDER BY LineNum;", connect);
            adapter = new OleDbDataAdapter(command);

            DataTable descriptionLinesTable = new DataTable();

            adapter.Fill(descriptionLinesTable);

            connect.Close();

            string folderPath = "Z:\\Quotes\\" + quoteData.Rows[0][35].ToString() + " " + quoteData.Rows[0][36].ToString() + "\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            System.IO.FileStream fs = new FileStream(folderPath + quoteData.Rows[0][3].ToString() + "-" + quoteData.Rows[0][0].ToString() + ".pdf", FileMode.Create);

            Document myPDF = new Document(PageSize.LETTER, 10f, 10f, 30f, 30f);

            PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

            myPDF.AddAuthor(quoteData.Rows[0][35].ToString() + " " + quoteData.Rows[0][36].ToString());

            myPDF.AddCreator("This document was created using iTextSharp");

            myPDF.AddSubject(quoteData.Rows[0][0].ToString());

            myPDF.AddTitle(quoteData.Rows[0][3].ToString() + " Quote");

            myPDF.Open();

            PdfContentByte contentByte = write.DirectContent;

            //GetUPCA();

            BaseFont myFontBold = FontFactory.GetFont(BaseFont.HELVETICA_BOLD).BaseFont;
            BaseFont myFontRegular = FontFactory.GetFont(BaseFont.HELVETICA).BaseFont;
            BaseFont myFontItalicized = FontFactory.GetFont(BaseFont.HELVETICA_OBLIQUE).BaseFont;



            iTextSharp.text.Rectangle quoteRectangle = new iTextSharp.text.Rectangle(0, 0, 30, 800);
            quoteRectangle.BackgroundColor = new iTextSharp.text.BaseColor(0, 102, 255);
            quoteRectangle.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
            quoteRectangle.BorderWidth = 0;
            quoteRectangle.BorderColor = colourBlack;
            contentByte.Rectangle(quoteRectangle);

            //contentByte.SetRGBColorStroke(0, 102, 255);
            //contentByte.SetLineWidth(1);
            //contentByte.MoveTo(30, 791.5f);
            //contentByte.LineTo(620, 791.5f);
            //contentByte.Stroke();
            //contentByte.SetRGBColorStroke(0, 0, 0);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 20);

            contentByte.SetColorFill(colourWhite);

            contentByte.SetCharacterSpacing(20);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "QUOTATION", 23, 400, 90);

            contentByte.SetCharacterSpacing(0);

            contentByte.EndText();

            Bitmap myBitmap = new Bitmap(Properties.Resources.ReliableLong);

            System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

            iTextSharp.text.BaseColor myColour = null;

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

            logo.ScaleToFit(300, 100);
            logo.SetAbsolutePosition(40, 705);
            contentByte.AddImage(logo);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 10);

            contentByte.SetColorFill(colourBlue);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, companyInfoTable.Rows[0][2].ToString(), 580, 765, 0);

            contentByte.SetFontAndSize(myFontRegular, 8);

            contentByte.SetColorFill(new BaseColor(100, 100, 100));

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, companyInfoTable.Rows[0][13].ToString(), 580, 755, 0);

            contentByte.SetFontAndSize(myFontRegular, 8);

            contentByte.SetColorFill(colourBlack);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, quoteData.Rows[0][23].ToString(), 580, 737, 0);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, quoteData.Rows[0][24].ToString() + ", " + quoteData.Rows[0][30].ToString() + "   " + quoteData.Rows[0][25].ToString(), 580, 728, 0);

            if (quoteData.Rows[0][26].ToString() != "")
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Telephone: " + quoteData.Rows[0][26].ToString(), 580, 719, 0);
            }

            else
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Telephone: " + companyInfoTable.Rows[0][9].ToString(), 580, 719, 0);
            }

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Toll Free: " + companyInfoTable.Rows[0][10].ToString(), 580, 710, 0);

            contentByte.EndText();

            //contentByte.SetRGBColorStroke(0, 102, 255);
            //contentByte.SetLineWidth(1);
            //contentByte.MoveTo(30, 697);
            //contentByte.LineTo(620, 697);
            //contentByte.Stroke();
            //contentByte.SetRGBColorStroke(0, 0, 0);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 9);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Sell To:", 40, 678, 0);

            contentByte.SetFontAndSize(myFontRegular, 9);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][3].ToString(), 40, 665, 0);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][4].ToString(), 40, 655, 0);

            if(quoteData.Rows[0][5].ToString() != "")
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][5].ToString(), 40, 645, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][6].ToString() + ", " + quoteData.Rows[0][7].ToString() + "   " + quoteData.Rows[0][8].ToString(), 40, 635, 0);
            }

            else
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][6].ToString() + ", " + quoteData.Rows[0][7].ToString() + "   " + quoteData.Rows[0][8].ToString(), 40, 645, 0);
            }

            contentByte.SetFontAndSize(myFontBold, 9);

            if (shipToCheckbox.Checked == true)
            {

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Ship To:", 250, 678, 0);

                contentByte.SetFontAndSize(myFontRegular, 9);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][9].ToString(), 250, 665, 0);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][10].ToString(), 250, 655, 0);

                if (quoteData.Rows[0][11].ToString() != "")
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][11].ToString(), 250, 645, 0);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][12].ToString() + ", " + quoteData.Rows[0][13].ToString() + "   " + quoteData.Rows[0][14].ToString(), 250, 635, 0);
                }

                else
                {
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][12].ToString() + ", " + quoteData.Rows[0][13].ToString() + "   " + quoteData.Rows[0][14].ToString(), 250, 645, 0);
                }

            }

            contentByte.SetFontAndSize(myFontBold, 9);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date:", 480, 665, 0);

            contentByte.SetFontAndSize(myFontRegular, 9);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, quoteData.Rows[0][1].ToString(), 580, 665, 0);

            contentByte.SetFontAndSize(myFontBold, 9);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Quote #:", 480, 655, 0);

            contentByte.SetFontAndSize(myFontRegular, 9);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, quoteData.Rows[0][0].ToString(), 580, 655, 0);


            //Quote notice identifying who the quote is addressing

            if (attentionNameBox.Text != "")
            {

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Dear " + attentionNameBox.Text + ",", 40, 605, 0);

            }

            if (attentionEmailBox.Text != "")
            {
                contentByte.SetFontAndSize(myFontRegular, 7);
                contentByte.SetColorFill(new BaseColor(100, 100, 100));
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, attentionEmailBox.Text, 40, 597, 0);
            }

            contentByte.SetFontAndSize(myFontRegular, 9);
            contentByte.SetColorFill(colourBlack);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "It is a pleasure to submit the following quotation for your consideration.", 40, 577, 0);

            contentByte.EndText();

            int bottom = 562;

            pageNumber = 1;

            for (int i = 0; i < quoteData.Rows.Count; i++)
            {
                bool snapFlag = false; //Flags the item to identify whether or not it has snapnote information
                int snapIndex = 0;
                jmFlag = false; //identifies whether the item is in JM Catalogue
                int jmIndex = 0;

                for (int j = 0; j < jmDescription.Rows.Count; j++)
                {

                    if (jmDescription.Rows[j][4].ToString() == (quoteData.Rows[i][18].ToString()))
                    {
                        jmFlag = true;
                        jmIndex = jmDescription.Rows.IndexOf(jmDescription.Rows[j]);
                        break;
                    }
                }

                if (jmFlag == true)
                {
                    //First, Calculate where the next bottom will be:

                    for (int j = 0; j < snapNotes.Rows.Count; j++)
                    {
                        if (snapNotes.Rows[j][1].ToString() == quoteData.Rows[i][29].ToString())
                        {
                            snapIndex = snapNotes.Rows.IndexOf(snapNotes.Rows[j]);
                            snapFlag = true;
                            break;
                        }
                    }

                    int bottomForChecking = bottom;

                    float paymentWidth = 0;
                    int numberOfLinesLessOne = 0;

                    if (jmDescription.Rows[jmIndex][2].ToString() != "")
                    {

                        paymentWidth = myFontRegular.GetWidthPoint(jmDescription.Rows[jmIndex][2].ToString() + " " + jmDescription.Rows[jmIndex][3].ToString(), 8);

                        numberOfLinesLessOne = (int)(paymentWidth / 440.0);

                        bottomForChecking = bottomForChecking - 40 - (numberOfLinesLessOne * 9) - 25;

                    }

                    else if (snapFlag == true)
                    {

                        float descriptionWidth = myFontRegular.GetWidthPoint(snapNotes.Rows[snapIndex][0].ToString(), 8);

                        int numberOfLinesDescriptionLessOne = (int)(descriptionWidth / 440.0);

                        bottomForChecking = bottom - 40 - (numberOfLinesDescriptionLessOne * 9) - 25;

                    }

                    else
                    {
                        bottomForChecking = bottom - 40 - 25;
                    }

                    bottomForChecking = bottomForChecking - 10;

                    int pictureY = ((bottom - bottomForChecking) / 2);

                    if (bottomForChecking < 35)
                    {

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 8);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page " + pageNumber.ToString(), 590, 11, 0);

                        contentByte.SetFontAndSize(myFontRegular, 10);

                        contentByte.SetColorFill(new BaseColor(150, 150, 150));

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Our mission is to be a clients' only choice in providing", 300, 15, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "complete solutions for their cleaning & maintenance needs", 300, 4, 0);

                        contentByte.EndText();

                        contentByte.SetRGBColorStroke(100, 100, 100);
                        contentByte.SetLineWidth(1);
                        contentByte.MoveTo(30, 30);
                        contentByte.LineTo(620, 30);
                        contentByte.Stroke();
                        contentByte.SetRGBColorStroke(0, 0, 0);

                        myPDF.NewPage();


                        contentByte.Rectangle(quoteRectangle);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 20);

                        contentByte.SetColorFill(colourWhite);

                        contentByte.SetCharacterSpacing(20);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "QUOTATION", 23, 400, 90);

                        contentByte.SetCharacterSpacing(0);

                        contentByte.SetColorFill(colourBlack);

                        contentByte.EndText();

                        bottom = 750;

                        pageNumber++;

                    }

                    contentByte.SetRGBColorStroke(160, 160, 160);
                    contentByte.SetLineWidth(1);
                    contentByte.MoveTo(30, bottom);
                    contentByte.LineTo(620, bottom);
                    contentByte.Stroke();
                    contentByte.SetRGBColorStroke(0, 0, 0);



                    //Create the row for the product in the quote:

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 11);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, jmDescription.Rows[jmIndex][1].ToString().ToUpper(), 40, bottom - 17, 0);

                    contentByte.SetFontAndSize(myFontBold, 11);

                    contentByte.SetColorFill(new BaseColor(0, 102, 255));

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Convert.ToDouble(quoteData.Rows[i][20].ToString()).ToString("C") + "/" + quoteData.Rows[i][21].ToString(), 480, bottom - 17, 0);

                    contentByte.SetColorFill(colourBlack);

                    contentByte.EndText();

                    //If the JMDescription exists, add it to the quotation line

                    if (jmDescription.Rows[jmIndex][2].ToString() != "")
                    {
                        contentByte.BeginText();

                        paymentWidth = myFontRegular.GetWidthPoint(jmDescription.Rows[jmIndex][2].ToString() + " " + jmDescription.Rows[jmIndex][3].ToString(), 8);

                        numberOfLinesLessOne = (int)(paymentWidth / 440.0);

                        Paragraph description = new Paragraph(9, jmDescription.Rows[jmIndex][2].ToString() + " " + jmDescription.Rows[jmIndex][3].ToString());

                        description.Font = FontFactory.GetFont(BaseFont.HELVETICA, 8);

                        ColumnText columnText = new ColumnText(contentByte);
                        columnText.FilledWidth = 440;
                        columnText.SetSimpleColumn(40, bottom - 40 - ((numberOfLinesLessOne) * 9), 480, bottom - 40 + 9);
                        columnText.AddElement(description);

                        bottom = bottom - 40 - ((numberOfLinesLessOne) * 9) - 25;

                        columnText.Go();

                        contentByte.EndText();

                    }

                    else if (snapFlag == true)
                    {
                        contentByte.BeginText();

                        float descriptionWidth = myFontRegular.GetWidthPoint(snapNotes.Rows[snapIndex][0].ToString(), 8);

                        int numberOfLinesDescriptionLessOne = (int)(descriptionWidth / 440.0);

                        Paragraph description = new Paragraph(9, snapNotes.Rows[snapIndex][0].ToString());

                        description.Font = FontFactory.GetFont(BaseFont.HELVETICA, 8);

                        ColumnText columnText = new ColumnText(contentByte);
                        columnText.FilledWidth = 440;
                        columnText.SetSimpleColumn(40, bottom - 40 - ((numberOfLinesDescriptionLessOne) * 9), 480, bottom - 40 + 9);
                        columnText.AddElement(description);

                        columnText.Go();

                        bottom = bottom - 40 - (numberOfLinesDescriptionLessOne * 9) - 25;

                        contentByte.EndText();

                    }

                    else
                    {
                        bottom = bottom - 40 - 25;
                    }

                    contentByte.BeginText();

                    contentByte.EndText();

                    contentByte.BeginText();

                    contentByte.SetColorFill(new BaseColor(100, 100, 100));

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    float lineWidth = myFontRegular.GetWidthPoint("Item #: ", 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item #: ", 40, bottom, 0);

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[i][18].ToString(), 40 + lineWidth, bottom, 0);

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[i][31].ToString(), 200, bottom, 0);

                    contentByte.SetColorFill(colourBlack);

                    contentByte.EndText();

                    bottom = bottom - 10;

                    string input = quoteData.Rows[i][28].ToString();
                    string condition = "  *";
                    string[] output = Regex.Split(input, condition);
                    string partNum = output[0];

                    string inputOld = quoteData.Rows[i][18].ToString();
                    string conditionOld = "- *";
                    string[] outputOld = Regex.Split(inputOld, conditionOld);
                    string oldImage = null;

                    for (int q = 0; q < outputOld.Length; q++)
                    {

                        if (q == outputOld.Length - 1)
                        {
                            break;
                        }

                        else if (q == outputOld.Length - 2)
                        {
                            oldImage += outputOld[q];
                        }

                        else if (q < outputOld.Length - 2)
                        {
                            oldImage += outputOld[q] + "-";
                        }

                    }

                    if (File.Exists("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + quoteData.Rows[i][27].ToString() + "\\" + jmDescription.Rows[jmIndex][5].ToString()))
                    {

                        System.Drawing.Image myImageNew = (System.Drawing.Image.FromFile("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + quoteData.Rows[i][27].ToString() + "\\" + jmDescription.Rows[jmIndex][5].ToString()));

                        float ratio = (float)myImageNew.Height / (float)myImageNew.Width;

                        iTextSharp.text.BaseColor newColour = null;

                        iTextSharp.text.Image logoNew = iTextSharp.text.Image.GetInstance(myImageNew, newColour);

                        if (ratio >= 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            logoNew.SetAbsolutePosition(545 - ((((pictureY * 2) - 20) / ratio) / 2), bottom + 10);

                            contentByte.AddImage(logoNew);
                        }

                        if (ratio < 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            logoNew.SetAbsolutePosition(545 - (((pictureY * 2) - 20) / 2), bottom + 10);

                            contentByte.AddImage(logoNew);
                        }
                    }

                    else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                    {
                        System.Drawing.Image myImageNew = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                        float ratio = (float)myImageNew.Height / (float)myImageNew.Width;

                        iTextSharp.text.BaseColor newColour = null;

                        iTextSharp.text.Image logoNew = iTextSharp.text.Image.GetInstance(myImageNew, newColour);

                        if (ratio >= 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            logoNew.SetAbsolutePosition(545 - ((((pictureY * 2) - 20) / ratio) / 2), bottom + 10);

                            contentByte.AddImage(logoNew);
                        }

                        if (ratio < 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            float height = ((pictureY * 2) - 20) * ratio;

                            float yPosition = bottom + (((pictureY*2) - height) / 2);

                            logoNew.SetAbsolutePosition(545 - (((pictureY * 2) - 20) / 2), yPosition);

                            contentByte.AddImage(logoNew);
                        }


                    }


                }

                else
                {

                    for (int j = 0; j < snapNotes.Rows.Count; j++)
                    {

                        if (snapNotes.Rows[j][1].ToString() == quoteData.Rows[i][29].ToString())
                        {
                            snapIndex = snapNotes.Rows.IndexOf(snapNotes.Rows[j]);
                            snapFlag = true;
                            break;
                        }
                    }

                    int bottomForChecking = bottom;

                    if (snapFlag == true)
                    {

                        float descriptionWidth = myFontRegular.GetWidthPoint(snapNotes.Rows[snapIndex][0].ToString(), 8);

                        int numberOfLinesDescriptionLessOne = (int)(descriptionWidth / 440.0);

                        bottomForChecking = bottom - 40 - (numberOfLinesDescriptionLessOne * 9) - 25;

                    }

                    else
                    {
                        bottomForChecking = bottom - 40 - 25;
                    }

                    bottomForChecking = bottomForChecking - 10;

                    int pictureY = ((bottom - bottomForChecking) / 2);

                    if (bottomForChecking < 35)
                    {

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 8);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page " + pageNumber.ToString(), 590, 11, 0);

                        contentByte.SetFontAndSize(myFontRegular, 10);

                        contentByte.SetColorFill(new BaseColor(150, 150, 150));

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Our mission is to be a clients' only choice in providing", 300, 15, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "complete solutions for their cleaning & maintenance needs", 300, 4, 0);

                        contentByte.EndText();

                        contentByte.SetRGBColorStroke(100, 100, 100);
                        contentByte.SetLineWidth(1);
                        contentByte.MoveTo(30, 30);
                        contentByte.LineTo(620, 30);
                        contentByte.Stroke();
                        contentByte.SetRGBColorStroke(0, 0, 0);

                        myPDF.NewPage();


                        contentByte.Rectangle(quoteRectangle);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 20);

                        contentByte.SetColorFill(colourWhite);

                        contentByte.SetCharacterSpacing(20);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "QUOTATION", 23, 400, 90);

                        contentByte.SetCharacterSpacing(0);

                        contentByte.SetColorFill(colourBlack);

                        contentByte.EndText();

                        bottom = 750;

                        pageNumber++;

                    }

                    contentByte.SetRGBColorStroke(160, 160, 160);
                    contentByte.SetLineWidth(1);
                    contentByte.MoveTo(30, bottom);
                    contentByte.LineTo(620, bottom);
                    contentByte.Stroke();
                    contentByte.SetRGBColorStroke(0, 0, 0);

                    //Create the row for the product in the quote:

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 11);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[i][19].ToString().ToUpper(), 40, bottom - 17, 0);

                    contentByte.SetFontAndSize(myFontBold, 11);

                    contentByte.SetColorFill(new BaseColor(0, 102, 255));

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Convert.ToDouble(quoteData.Rows[i][20].ToString()).ToString("C") + "/" + quoteData.Rows[i][21].ToString(), 480, bottom - 17, 0);

                    contentByte.SetColorFill(colourBlack);

                    contentByte.EndText();

                    //Check to see what description lines are below the Special items:

                    descriptionLinesToAdd.Clear();

                    if (quoteData.Rows[i][32].ToString() == "S")
                    {

                        string descriptionSpecial = null;

                        for (int q = 0; q < descriptionLinesTable.Rows.Count; q++)
                        {
                            //Is the description line number greater than the special item line number?
                            if ((Convert.ToInt32(descriptionLinesTable.Rows[q][0].ToString()) > Convert.ToInt32(quoteData.Rows[i][33].ToString())))
                            {

                                //Checks if the description line number is only one greater than the line before it or if it is one greater than the special item line number
                                if(q == 0 && (Convert.ToInt32(descriptionLinesTable.Rows[q][0].ToString()) - 1 == Convert.ToInt32(quoteData.Rows[i][33].ToString())))
                                {
                                    descriptionSpecial += descriptionLinesTable.Rows[q][1].ToString() + " ";
                                }

                                else if ((Convert.ToInt32(descriptionLinesTable.Rows[q][0].ToString()) - 1 == Convert.ToInt32(descriptionLinesTable.Rows[q - 1][0].ToString())) || (Convert.ToInt32(descriptionLinesTable.Rows[q][0].ToString()) - 1 == Convert.ToInt32(quoteData.Rows[i][33].ToString())))
                                {

                                    descriptionSpecial += descriptionLinesTable.Rows[q][1].ToString() + " ";
                                }

                                else
                                {
                                    break;
                                }

                            }
                        }

                        //If the descriptionSpecial string received string values, it will be printed in the description area on the pdf
                        if (descriptionSpecial != null)
                        {
                            contentByte.BeginText();

                            float descriptionWidth = myFontRegular.GetWidthPoint(descriptionSpecial, 8);

                            int numberOfLinesDescriptionLessOne = (int)(descriptionWidth / 440.0);

                            Paragraph description = new Paragraph(9, descriptionSpecial);

                            description.Font = FontFactory.GetFont(BaseFont.HELVETICA, 8);

                            ColumnText columnText = new ColumnText(contentByte);
                            columnText.FilledWidth = 440;
                            columnText.SetSimpleColumn(40, bottom - 40 - ((numberOfLinesDescriptionLessOne) * 9), 480, bottom - 40 + 9);
                            columnText.AddElement(description);

                            columnText.Go();

                            bottom = bottom - 40 - (numberOfLinesDescriptionLessOne * 9) - 25;

                            contentByte.EndText();
                        }

                        //leave a gap if no data was provided

                        else
                        {
                            bottom = bottom - 40 - 25;
                        }
                    }

                    else if (snapFlag == true)
                    {
                        contentByte.BeginText();

                        float descriptionWidth = myFontRegular.GetWidthPoint(snapNotes.Rows[snapIndex][0].ToString(), 8);

                        int numberOfLinesDescriptionLessOne = (int)(descriptionWidth / 440.0);

                        Paragraph description = new Paragraph(9, snapNotes.Rows[snapIndex][0].ToString());

                        description.Font = FontFactory.GetFont(BaseFont.HELVETICA, 8);

                        ColumnText columnText = new ColumnText(contentByte);
                        columnText.FilledWidth = 440;
                        columnText.SetSimpleColumn(40, bottom - 40 - ((numberOfLinesDescriptionLessOne) * 9), 480, bottom - 40 + 9);
                        columnText.AddElement(description);

                        columnText.Go();

                        bottom = bottom - 40 - (numberOfLinesDescriptionLessOne * 9) - 25;

                        contentByte.EndText();

                    }

                    else
                    {
                        bottom = bottom - 40 - 25;
                    }

                    contentByte.BeginText();

                    contentByte.SetColorFill(new BaseColor(100, 100, 100));

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    float lineWidth = myFontRegular.GetWidthPoint("Item #: ", 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Item #: ", 40, bottom, 0);

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[i][18].ToString(), 40 + lineWidth, bottom, 0);

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[i][31].ToString(), 200, bottom, 0);

                    contentByte.SetColorFill(colourBlack);

                    contentByte.EndText();

                    bottom = bottom - 10;

                    string input = quoteData.Rows[i][28].ToString();
                    string condition = "  *";
                    string[] output = Regex.Split(input, condition);
                    string partNum = output[0];

                    string inputOld = quoteData.Rows[i][18].ToString();
                    string conditionOld = "- *";
                    string[] outputOld = Regex.Split(inputOld, conditionOld);
                    string oldImage = null;


                    for (int q = 0; q < outputOld.Length; q++)
                    {

                        if (q == outputOld.Length - 1)
                        {
                            break;
                        }

                        else if (q == outputOld.Length - 2)
                        {
                            oldImage += outputOld[q];

                        }

                        else if (q < outputOld.Length - 2)
                        {
                            oldImage += outputOld[q] + "-";
                        }

                    }

                    if (File.Exists("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + quoteData.Rows[i][27].ToString() + "\\" + quoteData.Rows[i][27].ToString() + partNum + ".jpg"))
                    {

                        System.Drawing.Image myImageNew = (System.Drawing.Image.FromFile("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + quoteData.Rows[i][27].ToString() + "\\" + quoteData.Rows[i][27].ToString() + partNum + ".jpg"));

                        float ratio = (float)myImageNew.Height / (float)myImageNew.Width;

                        iTextSharp.text.BaseColor newColour = null;

                        iTextSharp.text.Image logoNew = iTextSharp.text.Image.GetInstance(myImageNew, newColour);

                        if (ratio >= 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            logoNew.SetAbsolutePosition(545 - ((((pictureY * 2) - 20) / ratio) / 2), bottom + 10);

                            contentByte.AddImage(logoNew);
                        }

                        if (ratio < 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            logoNew.SetAbsolutePosition(545 - (((pictureY * 2) - 20) / 2), bottom + 10);

                            contentByte.AddImage(logoNew);
                        }
                    }

                    else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                    {
                        System.Drawing.Image myImageNew = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                        float ratio = (float)myImageNew.Height / (float)myImageNew.Width;

                        iTextSharp.text.BaseColor newColour = null;

                        iTextSharp.text.Image logoNew = iTextSharp.text.Image.GetInstance(myImageNew, newColour);

                        if (ratio >= 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            logoNew.SetAbsolutePosition(545 - ((((pictureY * 2) - 20) / ratio) / 2), bottom + 10);

                            contentByte.AddImage(logoNew);
                        }

                        if (ratio < 1)
                        {
                            logoNew.ScaleToFit((pictureY * 2) - 20, ((pictureY * 2) - 20));

                            float height = ((pictureY * 2) - 20) * ratio;

                            float yPosition = bottom + (((pictureY * 2) - height)/2);

                            logoNew.SetAbsolutePosition(545 - (((pictureY * 2) - 20) / 2), yPosition);

                            contentByte.AddImage(logoNew);
                        }
                    }

                }

                contentByte.SetRGBColorStroke(160, 160, 160);
                contentByte.SetLineWidth(1);
                contentByte.MoveTo(30, bottom);
                contentByte.LineTo(620, bottom);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

            }

            if(bottom - 80 < 35)
            {
                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 8);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page " + pageNumber.ToString(), 590, 11, 0);

                contentByte.SetFontAndSize(myFontRegular, 10);

                contentByte.SetColorFill(new BaseColor(150, 150, 150));

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Our mission is to be a clients' only choice in providing", 300, 15, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "complete solutions for their cleaning & maintenance needs", 300, 4, 0);

                contentByte.EndText();

                contentByte.SetRGBColorStroke(100, 100, 100);
                contentByte.SetLineWidth(1);
                contentByte.MoveTo(30, 30);
                contentByte.LineTo(620, 30);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

                myPDF.NewPage();

                contentByte.Rectangle(quoteRectangle);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 20);

                contentByte.SetColorFill(colourWhite);

                contentByte.SetCharacterSpacing(20);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "QUOTATION", 23, 400, 90);

                contentByte.SetCharacterSpacing(0);

                contentByte.SetColorFill(colourBlack);

                contentByte.EndText();

                bottom = 775;

                pageNumber++;
            }

            bottom = bottom - 25;

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontItalicized, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteValidityBox.Text, 40, bottom, 0);

            contentByte.SetFontAndSize(myFontBold, 10);



            float footerLineWidth = myFontBold.GetWidthPoint("Terms: ", 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Terms: ", 40, bottom - 22, 0);

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][2].ToString(), 40 + footerLineWidth, bottom - 22, 0);



            footerLineWidth = myFontBold.GetWidthPoint("FOB: ", 10);

            contentByte.SetFontAndSize(myFontBold, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "FOB: ", 40, bottom - 33, 0);

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, fobBox.Text, 40 + footerLineWidth, bottom - 33, 0);



            contentByte.SetFontAndSize(myFontItalicized, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "All prices are subject to applicable taxes.", 40, bottom - 55, 0);

            bottom = bottom - 55;

            contentByte.EndText();

            if (bottom - 77 < 35)
            {
                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 8);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page " + pageNumber.ToString(), 590, 11, 0);

                contentByte.SetFontAndSize(myFontRegular, 10);

                contentByte.SetColorFill(new BaseColor(150, 150, 150));

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Our mission is to be a clients' only choice in providing", 300, 15, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "complete solutions for their cleaning & maintenance needs", 300, 4, 0);

                contentByte.EndText();

                contentByte.SetRGBColorStroke(100, 100, 100);
                contentByte.SetLineWidth(1);
                contentByte.MoveTo(30, 30);
                contentByte.LineTo(620, 30);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

                myPDF.NewPage();

                contentByte.Rectangle(quoteRectangle);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 20);

                contentByte.SetColorFill(colourWhite);

                contentByte.SetCharacterSpacing(20);

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "QUOTATION", 23, 400, 90);

                contentByte.SetCharacterSpacing(0);

                contentByte.SetColorFill(colourBlack);

                contentByte.EndText();

                bottom = 775;

                pageNumber++;
            }

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Should you require any additional information, please do not hesitate to contact me at your convenience.", 40, bottom - 22, 0);


            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][35].ToString() + " " + quoteData.Rows[0][36].ToString(), 40, bottom - 44, 0);

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Cleaning Specialist", 40, bottom - 55, 0);

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, companyInfoTable.Rows[0][2].ToString(), 40, bottom - 66, 0);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, quoteData.Rows[0][37].ToString(), 40, bottom - 77, 0);

            contentByte.SetFontAndSize(myFontBold, 8);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "Page " + pageNumber.ToString(), 590, 11, 0);

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.SetColorFill(new BaseColor(150, 150, 150));

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Our mission is to be a clients' only choice in providing", 300, 15, 0);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "complete solutions for their cleaning & maintenance needs", 300, 4, 0);

            contentByte.SetColorFill(colourBlack);

            contentByte.EndText();

            contentByte.SetRGBColorStroke(100, 100, 100);
            contentByte.SetLineWidth(1);
            contentByte.MoveTo(30, 30);
            contentByte.LineTo(620, 30);
            contentByte.Stroke();
            contentByte.SetRGBColorStroke(0, 0, 0);

            myPDF.Close();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = folderPath + quoteData.Rows[0][3].ToString() + "-" + quoteData.Rows[0][0].ToString() + ".pdf";
            process.Start();

            this.Cursor = Cursors.Default;

        }
    }
}

            
