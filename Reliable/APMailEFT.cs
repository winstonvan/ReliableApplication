using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Diagnostics;
using System.Text.RegularExpressions;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Net.Mail;
using System.Net;
using System.Drawing;
using System.Threading;
using Reliable;


namespace RMP_Inventory_Finder
{
    public partial class APMailEFT : Form
    {
        public APMailEFT()
        {
            InitializeComponent();
        }

        bool connectedRIS = false;

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";
        String query = null;

        string risFile = null;

        string rmpFile = null;

        BindingSource myBindingSource = new BindingSource();

        OleDbConnection connect = null;

        List<Checks> checkNumbers = new List<Checks>();

        iTextSharp.text.Rectangle headerOverflow = new iTextSharp.text.Rectangle(20, 1600, 1170, 1625);

        int index = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            connectedRIS = false;

            generatePDFS.Visible = false;

            mailButton.Visible = false;

            try
            {
                this.Cursor = Cursors.WaitCursor;
                connect = new OleDbConnection(OLDBEConnect);
                connect.Open();

                OleDbCommand command = new OleDbCommand("SELECT * FROM APMail", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable additionalInfoTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(additionalInfoTable);

                //Adding information to the additional information page

                creatorName.Text = additionalInfoTable.Rows[0][1].ToString();
                compName.Text = additionalInfoTable.Rows[0][2].ToString();
                compAddressOne.Text = additionalInfoTable.Rows[0][3].ToString();
                compAddressTwo.Text = additionalInfoTable.Rows[0][4].ToString();
                emailText.Text = additionalInfoTable.Rows[0][5].ToString();
                passwordText.Text = additionalInfoTable.Rows[0][6].ToString();
                serverText.Text = additionalInfoTable.Rows[0][7].ToString();
                bccEmail.Text = additionalInfoTable.Rows[0][8].ToString();

                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectFromDatabases();
        }

        private string queryBuilder()
        {

            String query = null;

            query = "SELECT dbo_APPmtDet.InvcNum, dbo_APPmtDet.InvcDate, dbo_APPmtDet.InvcAmt, dbo_APPmtDet.AmtPaid, dbo_APPmtHed.CheckNum, dbo_APPmtHed.CheckDate, ";

            query += "dbo_APPmtHed.PayeeName, dbo_APPmtHed.CheckAmt, dbo_APPmtDet.DiscTaken, dbo_APVendor.CreditComments1, dbo_APVConts.EmailAddress, dbo_APVendor.Address1, ";

            query += "dbo_APVendor.Address2, dbo_APVendor.City, dbo_APVendor.State, dbo_APVendor.Zip, dbo_APPmtHed.PayeeAddress1, dbo_APPmtHed.PayeeAddress2, dbo_APPmtHed.PayeeCity, dbo_APPmtHed.PayeeCountry, dbo_APPmtHed.PayeeState, dbo_APPmtHed.PayeeZip ";

            query += "FROM ((dbo_APPmtDet INNER JOIN dbo_APPmtHed ON dbo_APPmtHed.APPmtID = dbo_APPmtDet.APPmtID) INNER JOIN dbo_APVendor ON dbo_APVendor.VendorID = dbo_APPmtHed.VendorID ) INNER JOIN dbo_APVConts ON dbo_APVConts.VendorID = dbo_APVendor.VendorID ";

            query += "WHERE dbo_APPmtHed.CheckDate = '" + ConvertDateFormatting(dateTimePicker1.Value) + "' AND dbo_APVConts.FirstName = '" + nameText.Text + "' AND dbo_APPmtDet.PostedFlag = '" + postedFlagBox.Text + "' ";

            query += "ORDER BY dbo_APPmtHed.CheckNum;";

            return query;
        }

        private string queryBuilderRegister()
        {

            String query = null;

            query = "SELECT dbo_APVendor.VendorAcct, dbo_APVendor.VendorName, dbo_APPmtHed.CheckNum, dbo_APPmtHed.CheckAmt, dbo_APPmtHed.CheckDate ";

            query += "FROM (dbo_APPmtDet INNER JOIN dbo_APPmtHed ON dbo_APPmtHed.APPmtID = dbo_APPmtDet.APPmtID) INNER JOIN dbo_APVendor ON dbo_APVendor.VendorID = dbo_APPmtHed.VendorID ";

            query += "WHERE dbo_APPmtHed.CheckDate = '" + ConvertDateFormatting(checkRegisterDate.Value) + "' AND dbo_APPmtDet.PostedFlag = '" + checkRegisterFlag.Text + "' ";

            query += "GROUP BY dbo_APVendor.VendorAcct, dbo_APVendor.VendorName, dbo_APPmtHed.CheckNum, dbo_APPmtHed.CheckAmt, dbo_APPmtHed.CheckDate ";

            query += "ORDER BY dbo_APPmtHed.CheckNum;";

            return query;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {

            if (connectedRIS == false)
            {
                connect = new OleDbConnection(OLDBEConnect);
            }

            else
            {
                connect = new OleDbConnection(OLDBEConnectRIS);
            }

            string emailClients = null;

            emailClients = queryBuilder();

            OleDbCommand command = new OleDbCommand(emailClients, connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable searchKeyTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(searchKeyTable);

            emailDGV.DataSource = searchKeyTable;

            checkNumbers.Clear();

            try
            {

                foreach (DataGridViewColumn col in emailDGV.Columns)
                {
                    if (col.HeaderText == "CheckNum")
                    {
                        index = col.Index;
                        break;
                    }
                }

                List<string> checkVals = new List<string>();

                for (int i = 0; i < emailDGV.RowCount - 1; i++)
                {
                    if (checkVals.Contains(emailDGV.Rows[i].Cells[index].Value.ToString()))
                    {
                        continue;
                    }

                    else
                    {
                        checkVals.Add(emailDGV.Rows[i].Cells[index].Value.ToString());
                        checkNumbers.Add(new Checks(emailDGV.Rows[i].Cells[index].Value.ToString(), i, emailDGV.Rows[i].Cells[10].Value.ToString()));
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("There were no entries for the provided data.");
            }

            generatePDFS.Visible = true;

            risFile = "Z:\\EFT\\" + dateTimePicker1.Value.Year.ToString() + "\\" + ConvertDateFormatting(dateTimePicker1.Value) + "\\RIS\\";
            rmpFile = "Z:\\EFT\\" + dateTimePicker1.Value.Year.ToString() + "\\" + ConvertDateFormatting(dateTimePicker1.Value) + "\\RMP\\";
        }

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

        private void generatePDFS_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            LoadingBarForm frm = new LoadingBarForm();
            frm.Show();

            frm.numberOfChecks = checkNumbers.Count;

            frm.SetMaxValue((checkNumbers.Count));

            frm.SetStepValue(1);

            frm.Text = "Creating PDFs...";
            
            string folderPath = null;

            iTextSharp.text.BaseColor colourBlack = new iTextSharp.text.BaseColor(0, 0, 0);
            iTextSharp.text.BaseColor colourBlue = new iTextSharp.text.BaseColor(0, 0, 255);
            iTextSharp.text.BaseColor colourWhite = new iTextSharp.text.BaseColor(255, 255, 255);


            foreach (Checks check in checkNumbers)
            {
                if (connectedRIS == false)
                {
                    folderPath = rmpFile;
                }
                else
                {
                    folderPath = risFile;
                }

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                System.IO.FileStream fs = new FileStream(folderPath + nameText.Text + "-" + check.getNumber() + "-Remittance.pdf", FileMode.Create);

                Document myPDF = new Document(PageSize.LETTER, 10f, 10f, 30f, 30f);

                PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

                myPDF.AddAuthor(creatorName.Text);

                myPDF.AddCreator("This document was created using iTextSharp");

                myPDF.AddSubject("Payment Information");

                myPDF.AddTitle(nameText.Text + "-" + check.getNumber() + "-Remittance");

                myPDF.Open();

                //myPDF.Add(new Paragraph("Payment Info"));

                PdfContentByte contentByte = write.DirectContent;            

                BaseFont myFontBold = FontFactory.GetFont(BaseFont.HELVETICA_BOLD).BaseFont;
                BaseFont myFontRegular = FontFactory.GetFont(BaseFont.HELVETICA).BaseFont;
                contentByte.SetFontAndSize(myFontBold, 12);


                contentByte.SetLineWidth(3f);
                contentByte.SetRGBColorStroke(0, 0, 153);
                contentByte.MoveTo(20, 765);
                contentByte.LineTo(580, 765);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);


                if (connectedRIS == false)
                {
                    Bitmap myBitmap = new Bitmap(Reliable.Properties.Resources.ReliableLogo);

                    System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

                    iTextSharp.text.BaseColor myColour = null;

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                    logo.ScaleToFit(100, 100);
                    logo.SetAbsolutePosition(40, 660);
                    contentByte.AddImage(logo);
                }

                else
                {
                    Bitmap myBitmap = new Bitmap(Reliable.Properties.Resources.Reliable_Industrial_Grey);

                    System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

                    iTextSharp.text.BaseColor myColour = null;

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                    logo.ScaleToFit(100, 100);
                    logo.SetAbsolutePosition(40, 660);
                    contentByte.AddImage(logo);
                }

                //Creating the header

                
                float paymentWidth = myFontBold.GetWidthPoint(nameText.Text + " Payment Advice", 17);
                iTextSharp.text.Rectangle adviceName = new iTextSharp.text.Rectangle(570-paymentWidth-20, 712, 570, 740);
                adviceName.BackgroundColor = colourBlue;
                adviceName.BorderWidth = 0;
                contentByte.Rectangle(adviceName);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 17);
                contentByte.SetColorFill(colourWhite);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, nameText.Text + " Payment Advice", 560, 718, 0);


                //Inserting the company name
                contentByte.SetFontAndSize(myFontBold, 8);
                contentByte.SetColorFill(colourBlack);
                float compLeft = 570 - myFontBold.GetWidthPoint(compName.Text, 8) - paymentWidth - 30;
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, compName.Text, 570 - paymentWidth - 25, 732, 0);

                //Inserting the first address line
                contentByte.SetFontAndSize(myFontRegular, 8);
                float compLeftAddressOne = 570 - myFontRegular.GetWidthPoint(compAddressOne.Text, 8) - paymentWidth - 30;
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, compAddressOne.Text, 570 - paymentWidth - 25, 723, 0);

                //Inserting the second address line
                float compLeftAddressTwo = 570 - myFontRegular.GetWidthPoint(compAddressTwo.Text, 8) - paymentWidth - 30;
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, compAddressTwo.Text, 570 - paymentWidth - 25, 712, 0);

                contentByte.EndText();

                //Check to see the text that is furthest left
                float rectangleLeft = 0;

                if (compLeft <= compLeftAddressOne && compLeft <= compLeftAddressTwo)
                {
                    rectangleLeft = compLeft;
                }
                else if (compLeftAddressOne <= compLeft && compLeftAddressOne <= compLeftAddressTwo)
                {
                    rectangleLeft = compLeftAddressOne;
                }
                else if (compLeftAddressTwo <= compLeftAddressOne && compLeftAddressTwo <= compLeft)
                {
                    rectangleLeft = compLeftAddressTwo;
                }

                //Creat rectangular border for header contents
                iTextSharp.text.Rectangle borderRect = new iTextSharp.text.Rectangle(rectangleLeft, 707, 575, 745);
                borderRect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                borderRect.BorderWidth = 1.5f;
                borderRect.BorderColor = colourBlack;
                contentByte.Rectangle(borderRect);

                contentByte.BeginText();

                //Entering the Date Label
                contentByte.SetFontAndSize(myFontBold, 8);
                contentByte.SetColorFill(colourBlack);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date:", 570- paymentWidth - 20 - (((570 - paymentWidth - 20) - rectangleLeft) / 2), 690, 0);

                //Entering the Date Value
                contentByte.SetFontAndSize(myFontRegular, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, emailDGV.Rows[check.getRow()].Cells[5].Value.ToString(), 575, 690, 0);

                //Entering the EFT Number label
                contentByte.SetFontAndSize(myFontBold, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, nameText.Text + " Number:", 570 - paymentWidth - 20 - (((570 - paymentWidth - 20) - rectangleLeft) / 2), 680, 0);

                //Entering the EFT Number Value
                contentByte.SetFontAndSize(myFontRegular, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, emailDGV.Rows[check.getRow()].Cells[4].Value.ToString(), 575, 680, 0);

                //Entering the Accounting Clerk Label
                contentByte.SetFontAndSize(myFontBold, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Accounting Clerk:", 570 - paymentWidth - 20 - (((570 - paymentWidth - 20) - rectangleLeft) / 2), 670, 0);

                //Entering the Accounting Clerk Value
                contentByte.SetFontAndSize(myFontRegular, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, creatorName.Text, 575, 670, 0);

                //Entering the RMPEmail Label
                contentByte.SetFontAndSize(myFontBold, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Email:", 570 - paymentWidth - 20 - (((570 - paymentWidth - 20)-rectangleLeft) / 2), 660, 0);

                //Entering the RMPEmail Value
                contentByte.SetFontAndSize(myFontRegular, 8);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, "ap@reliableclean.com", 575, 660, 0);

                //Entering the payee information
                contentByte.SetFontAndSize(myFontBold, 12);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, emailDGV.Rows[check.getRow()].Cells[6].Value.ToString(), 40, 628, 0);

                contentByte.SetFontAndSize(myFontRegular, 10);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, emailDGV.Rows[check.getRow()].Cells[16].Value.ToString(), 45, 616, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, emailDGV.Rows[check.getRow()].Cells[17].Value.ToString(), 45, 604, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, emailDGV.Rows[check.getRow()].Cells[18].Value.ToString() + ", " + emailDGV.Rows[check.getRow()].Cells[20].Value.ToString(), 45, 592, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, emailDGV.Rows[check.getRow()].Cells[21].Value.ToString(), 45, 580, 0);

                contentByte.EndText();

                //Entering E-mail information
                Chunk emailName = new Chunk(emailDGV.Rows[check.getRow()].Cells[10].Value.ToString(), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 6));
                contentByte.SetFontAndSize(myFontBold, 6);
                contentByte.SetColorFill(colourBlue);

                contentByte.BeginText();

                ColumnText.ShowTextAligned(contentByte, PdfContentByte.ALIGN_LEFT, new Phrase(emailName), 45, 565, 0);

                contentByte.EndText();

                //Entering Check Number payment
                contentByte.SetFontAndSize(myFontBold, 10);
                contentByte.SetColorFill(colourBlack);
                iTextSharp.text.Rectangle paymentAmountRectangle = new iTextSharp.text.Rectangle(570 - paymentWidth - 20 - (((570 - paymentWidth - 20) - rectangleLeft) / 2) - 5, 566, 575, 582);
                paymentAmountRectangle.BackgroundColor = new iTextSharp.text.BaseColor(100,100,100);
                contentByte.Rectangle(paymentAmountRectangle);

                string myFormat = "$ #,##0.00 ;$ (#,##0.00)";

                contentByte.BeginText();

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Payment Amount:", 570 - paymentWidth - 20 - (((570 - paymentWidth - 20) - rectangleLeft) / 2), 569, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, (Convert.ToDouble(emailDGV.Rows[check.getRow()].Cells[7].Value.ToString()).ToString(myFormat)), 570, 569, 0);

                contentByte.EndText();

                //Set Bordering line
                contentByte.SetLineWidth(3f);
                contentByte.SetRGBColorStroke(0, 0, 153);
                contentByte.MoveTo(20, 548);
                contentByte.LineTo(580, 548);
                contentByte.Stroke();
                contentByte.SetRGBColorStroke(0, 0, 0);

                //Set Table Header
                iTextSharp.text.Rectangle tableHeader = new iTextSharp.text.Rectangle(20, 519, 580, 533);
                tableHeader.BackgroundColor = new iTextSharp.text.BaseColor(100, 100, 100);
                tableHeader.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                tableHeader.BorderWidth = 1;
                tableHeader.BorderColor = colourBlack;
                contentByte.Rectangle(tableHeader);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 10);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Reference Number", 80, 522, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Date", 175, 522, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Gross", 265, 522, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Discount Taken", 385, 522, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Amount Paid", 515, 522, 0);

                contentByte.EndText();

                int bottom = 519;

                contentByte.SetLineWidth(1);
                contentByte.MoveTo(140, 533);
                contentByte.LineTo(140, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(210, 533);
                contentByte.LineTo(210, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(320, 533);
                contentByte.LineTo(320, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(450, 533);
                contentByte.LineTo(450, bottom);
                contentByte.Stroke();

                bottom = bottom - 15;

                //Adding Column Data

                contentByte.SetFontAndSize(myFontRegular, 10);

                double grossSum = 0;
                double discSum = 0;
                double paidSum = 0;

                for (int i = 0; i < emailDGV.RowCount - 1; i++)
                {

                    if (emailDGV.Rows[i].Cells[index].Value.ToString() == check.getNumber())
                    {
                        grossSum += Convert.ToDouble(emailDGV.Rows[i].Cells[2].Value.ToString());
                        discSum += Convert.ToDouble(emailDGV.Rows[i].Cells[8].Value.ToString());
                        paidSum += Convert.ToDouble(emailDGV.Rows[i].Cells[3].Value.ToString());

                        contentByte.BeginText();

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, emailDGV.Rows[i].Cells[0].Value.ToString(), 80, bottom + 3, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, emailDGV.Rows[i].Cells[1].Value.ToString(), 175, bottom + 3, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, (Convert.ToDouble(emailDGV.Rows[i].Cells[2].Value.ToString()).ToString(myFormat)), 320 - 2, bottom + 3, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, (Convert.ToDouble(emailDGV.Rows[i].Cells[8].Value.ToString()).ToString(myFormat)), 450 - 2, bottom + 3, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, (Convert.ToDouble(emailDGV.Rows[i].Cells[3].Value.ToString()).ToString(myFormat)), 580 - 2, bottom + 3, 0);

                        contentByte.EndText();

                        contentByte.MoveTo(20, bottom + 25);
                        contentByte.LineTo(20, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(140, bottom + 25);
                        contentByte.LineTo(140, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(210, bottom + 25);
                        contentByte.LineTo(210, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(320, bottom + 25);
                        contentByte.LineTo(320, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(450, bottom + 25);
                        contentByte.LineTo(450, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(580, bottom + 25);
                        contentByte.LineTo(580, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(20, bottom);
                        contentByte.LineTo(580, bottom);
                        contentByte.Stroke();
                        bottom = bottom - 15;
                    }

                    if (bottom <= 40)
                    {
                        contentByte.BeginText();

                        contentByte.EndText();

                        myPDF.NewPage();

                        contentByte.BeginText();

                        contentByte.EndText();

                        bottom = 720;

                        //Set Table Header
                        iTextSharp.text.Rectangle headerOverflow = new iTextSharp.text.Rectangle(20, 720, 580, 735);
                        headerOverflow.BackgroundColor = new iTextSharp.text.BaseColor(100, 100, 100);
                        headerOverflow.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                        headerOverflow.BorderWidth = 1;
                        headerOverflow.BorderColor = colourBlack;
                        contentByte.Rectangle(headerOverflow);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 10);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Reference Number", 80, 723, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Date", 175, 723, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Gross", 265, 723, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Discount Taken", 385, 723, 0);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Amount Paid", 515, 723, 0);

                        contentByte.EndText();

                        contentByte.SetLineWidth(1);
                        contentByte.MoveTo(140, bottom + 15);
                        contentByte.LineTo(140, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(210, bottom + 15);
                        contentByte.LineTo(210, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(320, bottom + 15);
                        contentByte.LineTo(320, bottom);
                        contentByte.Stroke();
                        contentByte.MoveTo(450, bottom + 15);
                        contentByte.LineTo(450, bottom);
                        contentByte.Stroke();

                        bottom = bottom - 15;

                        contentByte.SetFontAndSize(myFontRegular, 10);


                    }

                }

                iTextSharp.text.Rectangle tableFooter = new iTextSharp.text.Rectangle(20, bottom, 580, bottom + 15);
                tableFooter.BackgroundColor = new iTextSharp.text.BaseColor(100, 100, 100);
                tableFooter.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                tableFooter.BorderWidth = 1;
                tableFooter.BorderColor = colourBlack;
                contentByte.Rectangle(tableFooter);

                contentByte.BeginText();

                contentByte.SetFontAndSize(myFontBold, 10);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "TOTALS:", 80, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, grossSum.ToString(myFormat), 320 - 2, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, discSum.ToString(myFormat), 450 - 2, bottom + 3, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, paidSum.ToString(myFormat), 580 - 2, bottom + 3, 0);

                contentByte.EndText();

                contentByte.MoveTo(140, bottom + 25);
                contentByte.LineTo(140, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(210, bottom + 25);
                contentByte.LineTo(210, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(320, bottom + 25);
                contentByte.LineTo(320, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(450, bottom + 25);
                contentByte.LineTo(450, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(20, bottom);
                contentByte.LineTo(580, bottom);
                contentByte.Stroke();
                bottom = bottom - 15;

                myPDF.Close();

                write.Close();
                //Process process = new Process();
                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //process.StartInfo = startInfo;

                //startInfo.FileName = "C:\\Remittance\\" + ConvertDateFormatting(dateTimePicker1.Value) + "\\" + nameText.Text + "-" + check.getNumber() + "-Remittance.pdf";
                //process.Start();

                frm.IncrementProgressBar();

                Thread.Sleep(1500);

            }

            frm.Close();

            this.Cursor = Cursors.Default;

            mailButton.Visible = true;

        }

        //Sending required e-mails
        private void mailButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            LoadingBarForm frm = new LoadingBarForm();
            frm.Show();

            frm.numberOfChecks = checkNumbers.Count;

            frm.SetMaxValue((checkNumbers.Count));

            frm.SetStepValue(1);

            frm.Text = "Sending E-mails...";

            //string sendEmail = "matt.bert44@gmail.com";


            for (int i = 0; i < checkNumbers.Count; i++)
            {
                string sendEmail = checkNumbers.ElementAt<Checks>(i).getEmail();
                SmtpClient client = new SmtpClient();
                MailMessage message = new MailMessage(emailText.Text, sendEmail);

                try
                {

                    client.Port = 25;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Host = serverText.Text;
                    client.Credentials = new NetworkCredential(emailText.Text, passwordText.Text);
                    client.EnableSsl = false;

                    message.Subject = nameText.Text + " Remittance for " + checkNumbers.ElementAt<Checks>(i).getNumber();

                    message.Bcc.Add(bccEmail.Text);

                    message.Body = "Please see the attached document for Electronic Funds Transfer proof of payment under check number " + checkNumbers.ElementAt<Checks>(i).getNumber() + ".";

                    if (connectedRIS == false)
                    {
                        message.Attachments.Add(new Attachment(rmpFile + nameText.Text + "-" + checkNumbers.ElementAt<Checks>(i).getNumber() + "-Remittance.pdf"));
                    }
                    else
                    {
                        message.Attachments.Add(new Attachment(risFile + nameText.Text + "-" + checkNumbers.ElementAt<Checks>(i).getNumber() + "-Remittance.pdf"));
                    }


                    client.Send(message);

                    client.Dispose();


                }
                catch (Exception)
                {
                    i--;

                    frm.decrementProgressBar();

                    Thread.Sleep(3000);

                }

                frm.IncrementProgressBar();

                Thread.Sleep(3000);

            }

            frm.Close();

            this.Cursor = Cursors.Default;

            MessageBox.Show("E-mails complete. Please ensure that all e-mails have been sent successfully. Unsent e-mails may be caused by illegitimate e-mail addresses.");
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (MessageBox.Show("Are you sure that you would like to save the changes made?", "Save", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {


                string query = "UPDATE APMail SET APMail.AccountingClerk = '" + creatorName.Text + "', APMail.CompanyName = '" + compName.Text + "', APMail.AddressOne = '" + compAddressOne.Text + "', APMail.AddressTwo = '" + compAddressTwo.Text + "', APMail.Email = '" + emailText.Text + "', APMail.Password = '" + passwordText.Text + "', APMail.Server = '" + serverText.Text + "' , APMail.BCC = '" + bccEmail.Text + "' WHERE Key = 1;";


                if (connectedRIS == false)
                {
                    using (connect = new OleDbConnection(OLDBEConnect))
                    {
                        using (var accessUpdateCommand = connect.CreateCommand())
                        {
                            accessUpdateCommand.CommandText = query;

                            accessUpdateCommand.Connection.Open();
                            accessUpdateCommand.ExecuteNonQuery();
                            accessUpdateCommand.Connection.Close();
                        }
                    }
                }
                else
                {
                    using (connect = new OleDbConnection(OLDBEConnectRIS))
                    {
                        using (var accessUpdateCommand = connect.CreateCommand())
                        {
                            accessUpdateCommand.CommandText = query;

                            accessUpdateCommand.Connection.Open();
                            accessUpdateCommand.ExecuteNonQuery();
                            accessUpdateCommand.Connection.Close();
                        }
                    }
                }
            }

            else
            {

            }

            this.Cursor = Cursors.Default;
        }

        private void DisconnectFromDatabases()
        {
            try
            {
                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
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

                OleDbCommand command = new OleDbCommand("SELECT * FROM APMail", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable additionalInfoTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(additionalInfoTable);

                //Adding information to the additional information page

                creatorName.Text = additionalInfoTable.Rows[0][1].ToString();
                compName.Text = additionalInfoTable.Rows[0][2].ToString();
                compAddressOne.Text = additionalInfoTable.Rows[0][3].ToString();
                compAddressTwo.Text = additionalInfoTable.Rows[0][4].ToString();
                emailText.Text = additionalInfoTable.Rows[0][5].ToString();
                passwordText.Text = additionalInfoTable.Rows[0][6].ToString();
                serverText.Text = additionalInfoTable.Rows[0][7].ToString();
                bccEmail.Text = additionalInfoTable.Rows[0][8].ToString();

                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

            generatePDFS.Visible = false;
            mailButton.Visible = false;

            emailDGV.DataSource = null;
            emailDGV.Rows.Clear();

            checkRegisterDGV.DataSource = null;
            checkRegisterDGV.Rows.Clear();

            connectedRIS = false;
        }

        private void RISConnect_Click(object sender, EventArgs e)
        {

            try
            {
                this.Cursor = Cursors.WaitCursor;

                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM APMail", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable additionalInfoTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(additionalInfoTable);

                //Adding information to the additional information page

                creatorName.Text = additionalInfoTable.Rows[0][1].ToString();
                compName.Text = additionalInfoTable.Rows[0][2].ToString();
                compAddressOne.Text = additionalInfoTable.Rows[0][3].ToString();
                compAddressTwo.Text = additionalInfoTable.Rows[0][4].ToString();
                emailText.Text = additionalInfoTable.Rows[0][5].ToString();
                passwordText.Text = additionalInfoTable.Rows[0][6].ToString();
                serverText.Text = additionalInfoTable.Rows[0][7].ToString();
                bccEmail.Text = additionalInfoTable.Rows[0][8].ToString();

                this.Cursor = Cursors.Default;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = true;
            RISConnect.Enabled = false;

            generatePDFS.Visible = false;
            mailButton.Visible = false;

            emailDGV.DataSource = null;
            emailDGV.Rows.Clear();

            checkRegisterDGV.DataSource = null;
            checkRegisterDGV.Rows.Clear();

            connectedRIS = true;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormState.PreviousPage.Show();

            this.Hide();

        }

        //private void pageLayoutTabs_DrawItem(object sender, DrawItemEventArgs e)
        //{
        //    TabPage CurrentTab = pageLayoutTabs.TabPages[e.Index];
        //    System.Drawing.Rectangle ItemRect = pageLayoutTabs.GetTabRect(e.Index);
        //    SolidBrush FillBrush = new SolidBrush(System.Drawing.Color.Red);
        //    SolidBrush TextBrush = new SolidBrush(System.Drawing.Color.White);
        //    StringFormat sf = new StringFormat();
        //    sf.Alignment = StringAlignment.Center;
        //    sf.LineAlignment = StringAlignment.Center;

        //    //If we are currently painting the Selected TabItem we'll
        //    //change the brush colors and inflate the rectangle.
        //    if (System.Convert.ToBoolean(e.State & DrawItemState.Selected))
        //    {
        //        FillBrush.Color = System.Drawing.Color.Black;
        //        TextBrush.Color = System.Drawing.Color.Green;
        //        ItemRect.Inflate(2, 2);
        //    }

        //    //Set up rotation for left and right aligned tabs
        //    if (pageLayoutTabs.Alignment == TabAlignment.Left || pageLayoutTabs.Alignment == TabAlignment.Right)
        //    {
        //        float RotateAngle = 90;
        //        if (pageLayoutTabs.Alignment == TabAlignment.Left)
        //            RotateAngle = 270;
        //        PointF cp = new PointF(ItemRect.Left + (ItemRect.Width / 2), ItemRect.Top + (ItemRect.Height / 2));
        //        e.Graphics.TranslateTransform(cp.X, cp.Y);
        //        e.Graphics.RotateTransform(RotateAngle);
        //        ItemRect = new System.Drawing.Rectangle(-(ItemRect.Height / 2), -(ItemRect.Width / 2), ItemRect.Height, ItemRect.Width);
        //    }

        //    //Next we'll paint the TabItem with our Fill Brush
        //    e.Graphics.FillRectangle(FillBrush, ItemRect);

        //    //Now draw the text.
        //    e.Graphics.DrawString(CurrentTab.Text, e.Font, TextBrush, (RectangleF)ItemRect, sf);

        //    //Reset any Graphics rotation
        //    e.Graphics.ResetTransform();

        //    //Finally, we should Dispose of our brushes.
        //    FillBrush.Dispose();
        //    TextBrush.Dispose();

        //}



        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pageLayoutTabs_DrawItem_1(object sender, DrawItemEventArgs e)
        {




        }

        private void checkRegisterQueryButton_Click(object sender, EventArgs e)
        {
            if (connectedRIS == false)
            {
                connect = new OleDbConnection(OLDBEConnect);
            }

            else
            {
                connect = new OleDbConnection(OLDBEConnectRIS);
            }

            OleDbCommand command = new OleDbCommand(queryBuilderRegister(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable checkRegisterTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(checkRegisterTable);

            checkRegisterDGV.DataSource = checkRegisterTable;

            checkRegisterPDFButton.Visible = true;

            checkRegisterDGV.Columns[3].DefaultCellStyle.Format = "C";

            checkRegisterDGV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void checkRegisterPDFButton_Click(object sender, EventArgs e)
        {

            double total = 0;

            risFile = "Z:\\EFT\\" + checkRegisterDate.Value.Year.ToString() + "\\" + ConvertDateFormatting(checkRegisterDate.Value) + "\\RIS\\";
            rmpFile = "Z:\\EFT\\" + checkRegisterDate.Value.Year.ToString() + "\\" + ConvertDateFormatting(checkRegisterDate.Value) + "\\RMP\\";

            string folderPath = null;

            if (connectedRIS == false)
            {
                folderPath = rmpFile;
            }
            else
            {
                folderPath = risFile;
            }

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            System.IO.FileStream fs = new FileStream(folderPath + "ChequeRegister.pdf", FileMode.Create);

            Document myPDF = new Document(PageSize.LETTER, 10f, 10f, 30f, 30f);

            PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

            myPDF.AddAuthor("Reliable");

            myPDF.AddCreator("This document was created using iTextSharp");

            myPDF.AddSubject("Cheque Register");

            myPDF.AddTitle("Cheque Register");

            myPDF.Open();

            PdfContentByte contentByte = write.DirectContent;

            BaseFont myFontBold = FontFactory.GetFont(BaseFont.HELVETICA_BOLD).BaseFont;
            BaseFont myFontRegular = FontFactory.GetFont(BaseFont.HELVETICA).BaseFont;
            contentByte.SetFontAndSize(myFontBold, 12);

            //Creating the header

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 20);
            contentByte.SetColorFill(new iTextSharp.text.BaseColor(0, 0, 255));

            

            if (connectedRIS == false)
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Reliable Maintenance Products", 300, 735, 0);
            }
            else
            {
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Reliable Industrial Supply", 300, 735, 0);
            }

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cheque Register", 300, 710, 0);

            contentByte.SetColorFill(new iTextSharp.text.BaseColor(0, 0, 0));

            contentByte.SetFontAndSize(myFontRegular, 14);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cheque Date: " + ConvertDateFormatting(checkRegisterDate.Value), 300, 686, 0);

            contentByte.EndText();

            int pageNumber = 0;

            iTextSharp.text.Rectangle tableHeader = new iTextSharp.text.Rectangle(30, 642, 570, 661);
            tableHeader.BackgroundColor = new iTextSharp.text.BaseColor(160, 160, 160);
            tableHeader.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
            tableHeader.BorderWidth = 1;
            tableHeader.BorderColor = new iTextSharp.text.BaseColor(0, 0, 0);
            contentByte.Rectangle(tableHeader);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 12);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "#", 39, 646, 0);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Vendor Account", 99, 646, 0);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Vendor Name", 275, 646, 0);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cheque #", 430, 646, 0);
            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cheque Amount", 515, 646, 0);

            contentByte.EndText();

            int bottom = 642;

            contentByte.SetLineWidth(1);
            contentByte.MoveTo(48, 661);
            contentByte.LineTo(48, bottom);
            contentByte.Stroke();
            contentByte.MoveTo(150, 661);
            contentByte.LineTo(150, bottom);
            contentByte.Stroke();
            contentByte.MoveTo(400, 661);
            contentByte.LineTo(400, bottom);
            contentByte.Stroke();
            contentByte.MoveTo(460, 661);
            contentByte.LineTo(460, bottom);
            contentByte.Stroke();

            bottom = bottom - 17;

            contentByte.SetFontAndSize(myFontRegular, 10);

            int i = 0;

            for (; i < checkRegisterDGV.Rows.Count - 1; i++)
            {

                if(i%2 == 1)
                {
                    iTextSharp.text.Rectangle colourChangeRect = new iTextSharp.text.Rectangle(30, bottom + 1, 570, bottom + 16);
                    colourChangeRect.BackgroundColor = new iTextSharp.text.BaseColor(100, 100, 100);
                    contentByte.Rectangle(colourChangeRect);
                }

                //Total for all cheque values

                total += Convert.ToDouble(checkRegisterDGV.Rows[i].Cells[3].Value.ToString());

                contentByte.BeginText();

                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, (i + 1).ToString(), 39, bottom + 4, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, checkRegisterDGV.Rows[i].Cells[0].Value.ToString(), 50, bottom + 4, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, checkRegisterDGV.Rows[i].Cells[1].Value.ToString(), 152, bottom + 4, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, checkRegisterDGV.Rows[i].Cells[2].Value.ToString(), 430, bottom + 4, 0);
                contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, Convert.ToDouble(checkRegisterDGV.Rows[i].Cells[3].Value.ToString()).ToString("C"), 568, bottom + 4, 0);

                contentByte.EndText();

                contentByte.MoveTo(30, bottom + 17);
                contentByte.LineTo(30, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(48, bottom + 17);
                contentByte.LineTo(48, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(150, bottom + 17);
                contentByte.LineTo(150, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(400, bottom + 17);
                contentByte.LineTo(400, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(460, bottom + 17);
                contentByte.LineTo(460, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(570, bottom + 17);
                contentByte.LineTo(570, bottom);
                contentByte.Stroke();
                contentByte.MoveTo(30, bottom);
                contentByte.LineTo(570, bottom);
                contentByte.Stroke();
                bottom = bottom - 17;

                if (bottom <= 40)
                {
                    contentByte.BeginText();

                    pageNumber++;

                    contentByte.SetFontAndSize(myFontRegular, 10);

                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Page " + pageNumber, 540, 20, 0);

                    contentByte.EndText();

                    myPDF.NewPage();

                    bottom = 750;

                    //Table Header 3

                    iTextSharp.text.Rectangle tableHeaderThree = new iTextSharp.text.Rectangle(30, bottom, 570, bottom + 19);
                    tableHeaderThree.BackgroundColor = new iTextSharp.text.BaseColor(160, 160, 160);
                    tableHeaderThree.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                    tableHeaderThree.BorderWidth = 1;
                    tableHeaderThree.BorderColor = new iTextSharp.text.BaseColor(0, 0, 0);
                    contentByte.Rectangle(tableHeaderThree);

                    contentByte.BeginText();

                    contentByte.SetFontAndSize(myFontBold, 12);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "#", 39, bottom + 4, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Vendor Account", 99, bottom + 4, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Vendor Name", 275, bottom + 4, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cheque #", 430, bottom + 4, 0);
                    contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Cheque Amount", 515, bottom + 4, 0);

                    contentByte.EndText();

                    contentByte.SetLineWidth(1);
                    contentByte.MoveTo(48, bottom + 19);
                    contentByte.LineTo(48, bottom);
                    contentByte.Stroke();
                    contentByte.MoveTo(150, bottom + 19);
                    contentByte.LineTo(150, bottom);
                    contentByte.Stroke();
                    contentByte.MoveTo(400, bottom + 19);
                    contentByte.LineTo(400, bottom);
                    contentByte.Stroke();
                    contentByte.MoveTo(460, bottom + 19);
                    contentByte.LineTo(460, bottom);
                    contentByte.Stroke();

                    bottom = bottom - 17;

                    contentByte.SetFontAndSize(myFontRegular, 10);

                }

            }

            iTextSharp.text.Rectangle totalRect = new iTextSharp.text.Rectangle(30, bottom, 570, bottom + 16);
            totalRect.BackgroundColor = new iTextSharp.text.BaseColor(160, 160, 160);
            totalRect.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
            totalRect.BorderWidth = 1;
            totalRect.BorderColor = new iTextSharp.text.BaseColor(0, 0, 0);
            contentByte.Rectangle(totalRect);

            contentByte.BeginText();

            contentByte.SetFontAndSize(myFontBold, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "TOTAL", 32, bottom + 4, 0);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_RIGHT, total.ToString("C"), 568, bottom + 4, 0);

            pageNumber++;

            contentByte.SetFontAndSize(myFontRegular, 10);

            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Page " + pageNumber, 540, 20, 0);

            contentByte.EndText();

            myPDF.Close();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = folderPath + "ChequeRegister.pdf";
            process.Start();

            this.Cursor = Cursors.Default;


        }
    }




    public class Checks
    {
        private string checkNumber;
        private int checkRow;
        private string email;

        public Checks(string num, int row, string emailNew)
        {
            checkNumber = num;
            checkRow = row;
            email = emailNew;
        }

        public string getNumber()
        {
            return checkNumber;
        }

        public int getRow()
        {
            return checkRow;
        }

        public string getEmail()
        {
            return email;
        }
    }

    
    // Create Form2.
    public class FormNew : Form
    {
        public FormNew()
        {
            Text = "Form2";
        }
    }
}
