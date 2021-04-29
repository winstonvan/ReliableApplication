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

namespace Reliable
{
    public partial class CountSheets : Form
    {

        BaseColor colourBlack = new BaseColor(0, 0, 0);
        BaseColor colourBlue = new BaseColor(0, 0, 255);
        BaseColor colourWhite = new BaseColor(255, 255, 255);
        BaseColor colourGrey = new BaseColor(160, 160, 160);
        BaseColor colourGreyLight = new BaseColor(100, 100, 100);
        BaseColor colourRed = new BaseColor(255, 0, 0);

        List<string> warehouseList = new List<string>();

        List<string> whidList = new List<string>();

        DataTable itemNumbersTableWHSR = new DataTable();

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;
        public CountSheets()
        {
            InitializeComponent();
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

        private void CountSheets_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string query = null;

            query += "SELECT dbo_ICWhouse.WHDescription, dbo_ICWhouse.WHID ";

            query += "FROM dbo_ICWhouse ";

            query += "ORDER BY dbo_ICWhouse.WHID ASC;";

            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand(query, connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable locationsTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(locationsTable);

            warehouseList.Clear();

            foreach (DataRow row in locationsTable.Rows)
            {
                warehouseList.Add(row[0].ToString());
            }

            whidList.Clear();

            foreach (DataRow row in locationsTable.Rows)
            {
                whidList.Add(row[1].ToString());
            }

            warehouseNamesBox.DataSource = warehouseList;

            connect.Close();

            this.Cursor = Cursors.Default;
        }
    }
}
