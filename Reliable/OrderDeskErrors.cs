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

namespace Reliable {
    public partial class OrderDeskErrors : Form {
        readonly string OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        readonly string OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";
        OleDbConnection connection;
        bool connectRIS = false;

        public OrderDeskErrors() {
            InitializeComponent();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void Reload() {
            this.Cursor = Cursors.WaitCursor;

            if (connectRIS == false) {
                connection = new OleDbConnection(OLDBEConnect);
            } else {
                connection = new OleDbConnection(OLDBEConnectRIS);
            }

            OleDbCommand command = new OleDbCommand(QueryBuilder(), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command) {
                SelectCommand = command
            };

            DataTable table = new DataTable();
            adapter.Fill(table);
            dataTable.DataSource = table;

            // resize form to fit datagridview
            int width = dataTable.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            dataTable.Width = width + 53;
            this.Width = width + 53;

            this.Cursor = Cursors.Default;
        }

        private void OrderDeskErrors_Load(object sender, EventArgs e) {
            this.Reload();
        }

        private string QueryBuilder() {
            string query = "SELECT " +
                               "OrderDetail.OrderNum, " +
                               "OrderDetail.OrderDate, " +
                               "OrderDetail.BillCustomerName, " +
                               "OrderDetail.ShipCustomerName, " +
                               "OrderDetail.ItemCode, " +
                               "OrderDetail.Description, " +
                               "OrderDetail.NumOrdered, " +
                               "OrderDetail.NumShipped, " +
                               "OrderDetail.NumBO, " +
                               "((OrderDetail.NumBO + OrderDetail.NumShipped) - OrderDetail.NumOrdered) AS Checkfield " +
                           "FROM " +
                               "dbo_vPendingCustomerOrderDetail AS OrderDetail " +
                           "WHERE " +
                               "OrderDetail.NumOrdered <> 0 " +
                               "AND((OrderDetail.NumBO + OrderDetail.NumShipped) - OrderDetail.NumOrdered) <> 0 " +
                               "AND OrderDetail.OrderStatus <> 'quotation' " +
                               "AND OrderDetail.BillCustomerName <> 'WH Transfer Acct - SS Marie WH'";
            return query;
        }

        private void ReloadMenuItem_Click(object sender, EventArgs e) {
            this.Reload();
        }
    }
}
