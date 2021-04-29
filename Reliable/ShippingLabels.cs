using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;

namespace Reliable
{
    public partial class ShippingLabels : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        OleDbConnection connect = null;
        int pageNumber = 1;
        int fontSize = 12;

        public ShippingLabels()
        {
            InitializeComponent();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            PrintDocument shippingLabel = new PrintDocument();
            PrintPreviewDialog ShippingPreview = new PrintPreviewDialog();
            PrintDialog shippingPrint = new PrintDialog();

            shippingPrint.Document = shippingLabel;

            shippingLabel.DefaultPageSettings.PaperSize = new PaperSize("3 x 4 in", 400, 300);

            /*The solution below is inefficient because it requires that the entire document is re-drawn for each individual copy.
             It would be much more efficient to implement a solution that only changed the page number for re-drawing on each document.*/

            for (int i = 0; i < quantityBox.Value; i++)
            {

                

                shippingLabel.PrinterSettings.PrinterName = "ZDesigner LP 2844-Z";
                    shippingLabel.PrintPage += new PrintPageEventHandler
                       (this.pd_PrintPage);
                    shippingLabel.Print();

                pageNumber++;
            }

            pageNumber = 1;


        }

        //The function below is used to generate the required query string for the data on the shipping labels. This data will be obtained from the dbo_OBOrdHed table in the Step 1 database

        private string queryBuilderOrderInfo()
        {

            String query = null;

            query = "SELECT dbo_OBOrdHed.OrderNum, dbo_OBOrdHed.OrderDate, dbo_OBOrdHed.BillCustomerName, dbo_OBOrdHed.ShipCustomerName, dbo_OBOrdHed.ShipAddress1, dbo_OBOrdHed.ShipAddress2, dbo_OBOrdHed.ShipCity, ";

            query += "dbo_OBOrdHed.ShipState, dbo_OBOrdHed.ShipZip, dbo_OBOrdHed.CustPONum ";

            query += "FROM dbo_OBOrdHed ";

            query += "WHERE dbo_OBOrdHed.OrderNum = '" + OrderNumberBox.Text + "';";

            return query;
        }

        //The function below is used to generate the query string used for obtaining information in relation to company information

        private string queryBuilderCompanyInfo()
        {

            String query = null;

            query = "SELECT dbo_MBBranches.BranchName, dbo_MBBranches.BranchAddress1, dbo_MBBranches.BranchAddress2, dbo_MBBranches.BranchCity, dbo_MBBranches.BranchState, dbo_MBBranches.BranchZip ";

            query += "FROM dbo_MBBranches ";

            query += "WHERE dbo_MBBranches.BranchID = 1";

            return query;
        }

        private void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {

            //Initially, when we click on the print button, we need to query the required data from the database:

            //Connect to the database using the connection string established previously
            connect = new OleDbConnection(OLDBEConnect);

            //Pass the query string with the connection object as a command and source it through the adapter. Used to fill data set
            OleDbCommand command = new OleDbCommand(queryBuilderOrderInfo(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable shippingLabelsTable = new DataTable();

            //Set the SQL statement in the adapter in order to select records from the data source
            adapter.SelectCommand = command;

            adapter.Fill(shippingLabelsTable);

            //We must also generate a query to obtain information on the business.

            command = new OleDbCommand(queryBuilderCompanyInfo(), connect);
            adapter = new OleDbDataAdapter(command);

            DataTable companyInfoTable = new DataTable();

            //Set the SQL statement in the adapter in order to select records from the data source
            adapter.SelectCommand = command;

            adapter.Fill(companyInfoTable);

            //The coordinates at which the text will be placed is in 100ths of an inch units!

            /*Because shipping labels are being printed, the dimensions used are:
             
             Height = 300
             Width = 400*/

            //Below, we are accessing the Reliable Logo from the application resources and adding the Reliable logo to the document to print

            Bitmap myBitmap = new Bitmap(Properties.Resources.ReliableLogo);

            System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

            ev.Graphics.DrawImage(myImage, 30, 13, 83, 83);

            ev.Graphics.DrawLine(new Pen(Color.FromArgb(0, 0, 0), 3), new Point(10, 110), new Point(390, 110));

            //Below, we are adding text the the shipping label

            //First we add the order number to the shipping label, beneath the segmenting line, as well as the order date.
            //First, we get the length of the date string so that we can allign the strings such that the are right-alligned with
            //the right edge of the label

            float width = ev.Graphics.MeasureString(shippingLabelsTable.Rows[0][1].ToString(), new Font("Helvetica", 8)).Width;

            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][0].ToString(), new Font("Helvetica", 8, FontStyle.Regular), Brushes.Black, 385 - (int)width, 120);

            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][1].ToString(), new Font("Helvetica", 8, FontStyle.Regular), Brushes.Black, 385 - (int)width, 135);

            /*Here, we insert the information related to the location of Reliable and other details above the separating line.*/

            ev.Graphics.DrawString(companyInfoTable.Rows[0][0].ToString(), new Font("Helvetica", 10, FontStyle.Regular), Brushes.Black, 120, 20); //Company name

            ev.Graphics.DrawString(companyInfoTable.Rows[0][1].ToString(), new Font("Helvetica", 10, FontStyle.Regular), Brushes.Black, 120, 35); //Company address

            ev.Graphics.DrawString(companyInfoTable.Rows[0][3].ToString() + ", " + companyInfoTable.Rows[0][4].ToString() + " " + companyInfoTable.Rows[0][5].ToString(), new Font("Helvetica", 10, FontStyle.Regular), Brushes.Black, 120, 50); //City, Province, and Postal Code

            //Next, we will inser the PO number for the order

            ev.Graphics.DrawString("PO# " + shippingLabelsTable.Rows[0][9].ToString(), new Font("Helvetica", 10, FontStyle.Regular), Brushes.Black, 120, 90); //PO #

            //Here, we insert the page number of the corresponding shipping label (For number of peices);

            ev.Graphics.DrawString(pageNumber.ToString() + " of " + quantityBox.Value.ToString(), new Font("Helvetica", 20, FontStyle.Regular), Brushes.Black, 280, 175); //Number of peices

            /*Finally, the infromation relating to the billing and shipping customer will be printed on the shipping label.*/

            //Here, we check if the shipping and billing information will intersect with the page number. If it does, then we decrease the font size until no intersection occurs
            while((ev.Graphics.MeasureString(shippingLabelsTable.Rows[0][2].ToString(), new Font("Helvetica", fontSize)).Width + 10 >= 280) || (ev.Graphics.MeasureString(shippingLabelsTable.Rows[0][3].ToString(), new Font("Helvetica", fontSize)).Width + 10 >= 280) || (ev.Graphics.MeasureString(shippingLabelsTable.Rows[0][4].ToString(), new Font("Helvetica", fontSize)).Width + 10 >= 280) || (ev.Graphics.MeasureString(shippingLabelsTable.Rows[0][5].ToString(), new Font("Helvetica", fontSize)).Width + 10 >= 280))
            {
                fontSize--;
            }

            //Check to see whether the billing information needs to be included on the label. The billing information will only be included if it is not the same as the shipping information
            if (shippingLabelsTable.Rows[0][2].ToString() != shippingLabelsTable.Rows[0][3].ToString())
            {
                ev.Graphics.DrawString(shippingLabelsTable.Rows[0][2].ToString(), new Font("Helvetica", fontSize, FontStyle.Regular), Brushes.Black, 10, 120); //Billing Company
            }

            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][3].ToString(), new Font("Helvetica", fontSize, FontStyle.Regular), Brushes.Black, 10, 160); //Shipping Company
            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][4].ToString(), new Font("Helvetica", fontSize, FontStyle.Regular), Brushes.Black, 10, 180); //Shipping Address 1
            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][5].ToString(), new Font("Helvetica", fontSize, FontStyle.Regular), Brushes.Black, 10, 200); //Shipping Address 2

            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][6].ToString(), new Font("Helvetica", 12, FontStyle.Regular), Brushes.Black, 10, 240); //Shipping City
            ev.Graphics.DrawString(shippingLabelsTable.Rows[0][7].ToString() + "  " + shippingLabelsTable.Rows[0][8].ToString(), new Font("Helvetica", 12, FontStyle.Regular), Brushes.Black, 250, 240); //Shipping Province and Postal Code




        }
    }
}
