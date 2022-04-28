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
    public partial class WarehouseProductLabels : Form
    {
        BaseColor colourBlack = new BaseColor(0, 0, 0);
        BaseColor colourBlue = new BaseColor(0, 0, 255);
        BaseColor colourWhite = new BaseColor(255, 255, 255);
        BaseColor colourGrey = new BaseColor(160, 160, 160);
        BaseColor colourGreyLight = new BaseColor(100, 100, 100);

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        DataTable itemTable = new DataTable();

        OleDbConnection connect = null;

        List<string> locationsList = new List<string>();

        string[] left = { "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y" };
        string[] innerLeft = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        string[] innerRight = { "@", "A", "B", "C", "D", "E", "F", "G", "H", "I" };
        string[] right = { "`", "a", "b", "c", "d", "e", "f", "g", "h", "i" };
        string[] codeArray = { " ", "!", "\"", "#", "$", "%", "&", "'", "(", ")", "*", "+", ",", "-", ".", "/", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", ":", ";", "<", "=", ">", "?", "@", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "[", "\\", "]", "^", "_", "`", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "{", "|", "}", "~", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê"};

        List<int> barcodeSum = new List<int>();

        int sum = 0;

        string barcode = null;

        string theBarcode = null;
        public WarehouseProductLabels()
        {
            InitializeComponent();
        }
        public static iTextSharp.text.Font GetUPCA()
        {
            var fontName = "UPCA";
            if (!FontFactory.IsRegistered(fontName))
            {
                var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\UPCA.ttf";
                FontFactory.Register(fontPath);
            }
            return FontFactory.GetFont(fontName, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private string queryBuilder()
        {

            String query = null;

            string[] itemsArray = itemNumbersBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            query = "SELECT dbo_ICItems.ItemCode, dbo_ICItems.ItemDescription, dbo_ICItems.SupplierPartNum, dbo_ICWHBals.BinNumber, dbo_ICItems.SupplierUPCCode, dbo_ICItems.WebCatMfgrCode, dbo_ICItems.WebCatPartNum ";

            query += "FROM (dbo_ICItems INNER JOIN dbo_ICWHBals ON dbo_ICItems.ItemID = dbo_ICWHBals.ItemID) ";

            for(int i = 0; i < itemsArray.Length; i++)
            {
                if (i == 0)
                {
                    if (itemsArray.Length == 1)
                    {
                        query += "WHERE (dbo_ICItems.ItemCode = '" + itemsArray[i].ToString();
                    }

                    else
                    {
                        query += "WHERE (dbo_ICItems.ItemCode = '" + itemsArray[i].ToString() + "' OR dbo_ICItems.ItemCode = '";
                    }
                }

                else if(i != itemsArray.Length - 1)
                {
                    query += itemsArray[i].ToString() + "' OR dbo_ICItems.ItemCode = '";
                }

                else
                {
                    query += itemsArray[i].ToString();
                }
                
            }

            query += "') AND dbo_ICWHBals.WHID = 1 ";

            query += "ORDER BY dbo_ICItems.ItemCode;";

            return query;
        }

        private string QueryBuilderAllLocationsInWarehouse()
        {
            string query = null;

            query += "SELECT dbo_ICWHBals.ItemID ";

            query += "FROM dbo_ICWHBals ";

            query += "WHERE dbo_ICWHBals.WHID = 116 ";

            query += "ORDER BY dbo_ICWHBals.WHID DESC;";

            return query;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            itemTable.Clear();

            string[] itemsArray = itemNumbersBox.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            if (printLocationCheckbox.Checked == false)
            {

                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand(queryBuilder(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.SelectCommand = command;

                adapter.Fill(itemTable);

            }

            else
            {

                String query = null;

                query = "SELECT dbo_ICItems.ItemCode, dbo_ICItems.ItemDescription, dbo_ICItems.SupplierPartNum, dbo_ICWHBals.BinNumber, dbo_ICItems.SupplierUPCCode, dbo_ICItems.WebCatMfgrCode, dbo_ICItems.WebCatPartNum ";

                query += "FROM (dbo_ICItems INNER JOIN dbo_ICWHBals ON dbo_ICItems.ItemID = dbo_ICWHBals.ItemID) ";

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
                            query += "WHERE (dbo_ICWHBals.BinNumber = '" + itemLocationsSelected[q].ToString();
                        }

                        else
                        {
                            query += "WHERE (dbo_ICWHBals.BinNumber = '" + itemLocationsSelected[q].ToString() + "' OR dbo_ICWHBals.BinNumber = '";
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

                query += "') AND dbo_ICWHBals.WHID = 1 ";

                query += "ORDER BY dbo_ICWHBals.BinNumber ASC;";

                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand(query, connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                adapter.SelectCommand = command;

                adapter.Fill(itemTable);

            }

            string folderPath = "Z:\\Warehouse Labels\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            System.IO.FileStream fs = new FileStream(folderPath + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + "WarehouseLabels.pdf", FileMode.Create);

            Document myPDF = new Document(PageSize.LETTER, 10f, 10f, 30f, 30f);

            PdfWriter write = PdfWriter.GetInstance(myPDF, fs);

            myPDF.AddAuthor("Reliable");

            myPDF.AddCreator("This document was created using iTextSharp");

            myPDF.AddSubject("Warehouse Labels");

            myPDF.AddTitle("Warehouse Labels");

            myPDF.Open();

            PdfContentByte contentByte = write.DirectContent;

            //GetUPCA();

            BaseFont myFontBold = FontFactory.GetFont(BaseFont.HELVETICA_BOLD).BaseFont;
            BaseFont myFontRegular = FontFactory.GetFont(BaseFont.HELVETICA).BaseFont;
            BaseFont codeFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\code128.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

            int i = 0;

            int j = 0;

            for (; i < itemTable.Rows.Count; i++)
            {

                if (itemTable.Rows[i][0].ToString() != "")
                {
                    Code128Conversion bCode = new Code128Conversion(itemTable.Rows[i][4].ToString());

                    bCode.ConvertToCode128();

                    theBarcode = bCode.GetBarcode();

                    j = i % 4;

                    if (j == 0)
                    {

                        iTextSharp.text.Rectangle border = new iTextSharp.text.Rectangle(83, 395, 307, 769);
                        border.BackgroundColor = colourWhite;
                        border.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                        border.BorderWidth = 1;
                        border.BorderColor = colourBlack;
                        contentByte.Rectangle(border);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 30);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][0].ToString(), 118, 582, 90);

                        contentByte.SetFontAndSize(myFontBold, 15);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][1].ToString(), 138, 582, 90);

                        contentByte.SetFontAndSize(myFontBold, 30);

                        string inputNew = itemTable.Rows[i][2].ToString();
                        string conditionNew = "    *";
                        string[] outputNew = Regex.Split(inputNew, conditionNew);
                        string partNumNew = outputNew[0];

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, partNumNew, 173, 582, 90);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][3].ToString(), 208, 582, 90);

                        if (itemTable.Rows[i][4].ToString() != "0" && itemTable.Rows[i][4].ToString() != "")
                        {
                            contentByte.SetFontAndSize(codeFont, 35);

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, theBarcode, 287, 405, 90);

                            float barcodeWidth = codeFont.GetWidthPoint(theBarcode, 35);

                            contentByte.SetFontAndSize(myFontRegular, 10);

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][4].ToString(), 299, 405 + (barcodeWidth / 2), 90);
                        }

                        contentByte.EndText();

                        string inputOld = itemTable.Rows[i][0].ToString();
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


                        if (itemTable.Rows[i][5].ToString() != "")
                        {

                            string input = itemTable.Rows[i][6].ToString();
                            string condition = "  *";
                            string[] output = Regex.Split(input, condition);
                            string partNum = output[0];


                            if (File.Exists("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString() + partNum + ".jpg"))
                            {

                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString() + partNum + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(218, 668);
                                contentByte.AddImage(logo);
                            }

                            else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                            {
                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(218, 668);
                                contentByte.AddImage(logo);
                            }

                        }

                        else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                        {
                            System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                            iTextSharp.text.BaseColor myColour = null;

                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                            logo.ScaleToFit(81, 81);
                            logo.RotationDegrees = 90;
                            logo.SetAbsolutePosition(218, 668);
                            contentByte.AddImage(logo);
                        }


                    }

                    else if (j == 1)
                    {

                        iTextSharp.text.Rectangle border = new iTextSharp.text.Rectangle(83, 21, 307, 395);
                        border.BackgroundColor = colourWhite;
                        border.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                        border.BorderWidth = 1;
                        border.BorderColor = colourBlack;
                        contentByte.Rectangle(border);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 30);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][0].ToString(), 118, 208, 90);

                        contentByte.SetFontAndSize(myFontBold, 15);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][1].ToString(), 138, 208, 90);

                        contentByte.SetFontAndSize(myFontBold, 30);

                        string inputNew = itemTable.Rows[i][2].ToString();
                        string conditionNew = "    *";
                        string[] outputNew = Regex.Split(inputNew, conditionNew);
                        string partNumNew = outputNew[0];

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, partNumNew, 173, 208, 90);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][3].ToString(), 208, 208, 90);


                        if (itemTable.Rows[i][4].ToString() != "0" && itemTable.Rows[i][4].ToString() != "")
                        {
                            contentByte.SetFontAndSize(codeFont, 35);


                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, theBarcode, 287, 31, 90);

                            float barcodeWidth = codeFont.GetWidthPoint(theBarcode, 35);

                            contentByte.SetFontAndSize(myFontRegular, 10);

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][4].ToString(), 299, 31 + (barcodeWidth / 2), 90);

                        }

                        contentByte.EndText();

                        string inputOld = itemTable.Rows[i][0].ToString();
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

                        if (itemTable.Rows[i][5].ToString() != "")
                        {

                            string input = itemTable.Rows[i][6].ToString();
                            string condition = "  *";
                            string[] output = Regex.Split(input, condition);
                            string partNum = output[0];

                            if (File.Exists("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString() + partNum + ".jpg"))
                            {

                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString().ToLower() + partNum + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(218, 294);
                                contentByte.AddImage(logo);
                            }

                            else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                            {
                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(218, 294);
                                contentByte.AddImage(logo);
                            }

                        }

                        else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                        {
                            System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                            iTextSharp.text.BaseColor myColour = null;

                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                            logo.ScaleToFit(81, 81);
                            logo.RotationDegrees = 90;
                            logo.SetAbsolutePosition(218, 294);
                            contentByte.AddImage(logo);
                        }
                    }

                    else if (j == 2)
                    {

                        iTextSharp.text.Rectangle border = new iTextSharp.text.Rectangle(307, 395, 531, 769);
                        border.BackgroundColor = colourWhite;
                        border.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                        border.BorderWidth = 1;
                        border.BorderColor = colourBlack;
                        contentByte.Rectangle(border);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 30);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][0].ToString(), 342, 582, 90);

                        contentByte.SetFontAndSize(myFontBold, 15);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][1].ToString(), 362, 582, 90);

                        contentByte.SetFontAndSize(myFontBold, 30);

                        string inputNew = itemTable.Rows[i][2].ToString();
                        string conditionNew = "    *";
                        string[] outputNew = Regex.Split(inputNew, conditionNew);
                        string partNumNew = outputNew[0];

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, partNumNew, 397, 582, 90);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][3].ToString(), 432, 582, 90);

                        if (itemTable.Rows[i][4].ToString() != "0" && itemTable.Rows[i][4].ToString() != "")
                        {

                            contentByte.SetFontAndSize(codeFont, 35);


                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, theBarcode, 511, 405, 90);

                            float barcodeWidth = codeFont.GetWidthPoint(theBarcode, 35);

                            contentByte.SetFontAndSize(myFontRegular, 10);

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][4].ToString(), 523, 405 + (barcodeWidth / 2), 90);
                        }

                        contentByte.EndText();

                        string inputOld = itemTable.Rows[i][0].ToString();
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

                        if (itemTable.Rows[i][5].ToString() != "")
                        {
                            string input = itemTable.Rows[i][6].ToString();
                            string condition = "  *";
                            string[] output = Regex.Split(input, condition);
                            string partNum = output[0];

                            if (File.Exists("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString() + partNum + ".jpg"))
                            {

                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString().ToLower() + partNum + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(442, 668);
                                contentByte.AddImage(logo);
                            }

                            else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                            {
                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(442, 668);
                                contentByte.AddImage(logo);
                            }

                        }

                        else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                        {
                            System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                            iTextSharp.text.BaseColor myColour = null;

                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                            logo.ScaleToFit(81, 81);
                            logo.RotationDegrees = 90;
                            logo.SetAbsolutePosition(442, 668);
                            contentByte.AddImage(logo);
                        }
                    }

                    else if (j == 3)
                    {

                        iTextSharp.text.Rectangle border = new iTextSharp.text.Rectangle(307, 21, 531, 395);
                        border.BackgroundColor = colourWhite;
                        border.Border = iTextSharp.text.Rectangle.LEFT_BORDER | iTextSharp.text.Rectangle.RIGHT_BORDER | iTextSharp.text.Rectangle.TOP_BORDER | iTextSharp.text.Rectangle.BOTTOM_BORDER;
                        border.BorderWidth = 1;
                        border.BorderColor = colourBlack;
                        contentByte.Rectangle(border);

                        contentByte.BeginText();

                        contentByte.SetFontAndSize(myFontBold, 30);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][0].ToString(), 342, 208, 90);

                        contentByte.SetFontAndSize(myFontBold, 15);

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][1].ToString(), 362, 208, 90);

                        contentByte.SetFontAndSize(myFontBold, 30);

                        string inputNew = itemTable.Rows[i][2].ToString();
                        string conditionNew = "    *";
                        string[] outputNew = Regex.Split(inputNew, conditionNew);
                        string partNumNew = outputNew[0];

                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, partNumNew, 397, 208, 90);
                        contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][3].ToString(), 432, 208, 90);


                        if (itemTable.Rows[i][4].ToString() != "0" && itemTable.Rows[i][4].ToString() != "")
                        {

                            contentByte.SetFontAndSize(codeFont, 35);


                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_LEFT, theBarcode, 511, 31, 90);

                            float barcodeWidth = codeFont.GetWidthPoint(theBarcode, 35);

                            contentByte.SetFontAndSize(myFontRegular, 10);

                            contentByte.ShowTextAligned(PdfContentByte.ALIGN_CENTER, itemTable.Rows[i][4].ToString(), 523, 31 + (barcodeWidth / 2), 90);
                        }

                        contentByte.EndText();

                        string inputOld = itemTable.Rows[i][0].ToString();
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

                        if (itemTable.Rows[i][5].ToString() != "")
                        {

                            string input = itemTable.Rows[i][6].ToString();
                            string condition = "  *";
                            string[] output = Regex.Split(input, condition);
                            string partNum = output[0];

                            if (File.Exists("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString() + partNum + ".jpg"))
                            {

                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\PCC\\Product Photos\\JM Tech\\Print RGB\\" + itemTable.Rows[i][5].ToString() + "\\" + itemTable.Rows[i][5].ToString().ToLower() + partNum + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(442, 294);
                                contentByte.AddImage(logo);
                            }

                            else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                            {
                                System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                                iTextSharp.text.BaseColor myColour = null;

                                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                                logo.ScaleToFit(81, 81);
                                logo.RotationDegrees = 90;
                                logo.SetAbsolutePosition(442, 294);
                                contentByte.AddImage(logo);
                            }

                        }

                        else if (File.Exists("Z:\\JMCat\\225\\" + oldImage + ".jpg"))
                        {
                            System.Drawing.Image myImage = (System.Drawing.Image.FromFile("Z:\\JMCat\\225\\" + oldImage + ".jpg"));

                            iTextSharp.text.BaseColor myColour = null;

                            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(myImage, myColour);

                            logo.ScaleToFit(81, 81);
                            logo.RotationDegrees = 90;
                            logo.SetAbsolutePosition(442, 294);
                            contentByte.AddImage(logo);
                        }

                        myPDF.NewPage();

                    }

                }

                else
                {

                }

            }

            myPDF.Close();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = folderPath + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + DateTime.Today.Day.ToString() + "-" + "WarehouseLabels.pdf";
            process.Start();

            this.Cursor = Cursors.Default;

        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void itemNumbersBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(printLocationCheckbox.Checked == true)
            {
                this.Cursor = Cursors.WaitCursor;

                itemNumbersBox.Visible = false;
                locationsListbox.Visible = true;
                label1.Visible = false;

                string query = null;

                query += "SELECT dbo_ICWHBals.BinNumber ";

                query += "FROM dbo_ICWHBals ";

                query += "WHERE dbo_ICWHBals.WHID = 1 ";

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

        private void WarehouseProductLabels_Load(object sender, EventArgs e)
        {
            itemNumbersBox.Visible = true;
            locationsListbox.Visible = false;
            label1.Visible = true;
        }
    }
}
