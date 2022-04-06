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
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace Reliable {
    public partial class APImport : Form {

        bool connectRIS = false;
        readonly List<Checks> checkNumbers = new List<Checks>();
        readonly string OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        readonly string OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";
        OleDbConnection connection;

        public APImport() {
            InitializeComponent();
        }

        private void DisconnectFromDatabases() {
            try {
                connection = new OleDbConnection(OLDBEConnect);
                connection.Close();
                connection = new OleDbConnection(OLDBEConnectRIS);
                connection.Close();
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void RMPConnect_Click(object sender, EventArgs e) {
            try {
                this.Cursor = Cursors.WaitCursor;
                connection = new OleDbConnection(OLDBEConnectRIS);
                connection.Close();
                connection = new OleDbConnection(OLDBEConnect);
                connection.Open();
                this.Cursor = Cursors.Default;
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

            OleDbCommand command = new OleDbCommand(QueryBuilder(), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable crossTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(crossTable);

            dataTable.DataSource = null;
            dataTable.Rows.Clear();

            connectRIS = false;
        }

        private void APImport_Load(object sender, EventArgs e) {
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

        private void APImport_FormClosing(object sender, FormClosingEventArgs e) {
            DisconnectFromDatabases();
        }

        private void RISConnect_Click(object sender, EventArgs e) {
            try {
                this.Cursor = Cursors.WaitCursor;

                connection = new OleDbConnection(OLDBEConnect);
                connection.Close();

                connection = new OleDbConnection(OLDBEConnectRIS);
                connection.Open();

                this.Cursor = Cursors.Default;
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = true;
            RISConnect.Enabled = false;

            OleDbCommand command = new OleDbCommand(QueryBuilder(), connection);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command) {
                SelectCommand = command
            };

            DataTable dataTable = new DataTable();


            adapter.Fill(dataTable);

            this.dataTable.DataSource = null;
            this.dataTable.Rows.Clear();

            connectRIS = true;

            this.Cursor = Cursors.Default;
        }

        private string QueryBuilder() {
            string subquery =
                            "SELECT " +
                                "'345000' AS VendorNumber, " +
                                "InvoiceSummary.InvoiceNum as InvoiceNumber, " +
                                "'' AS PONumber, " +
                                "InvoiceSummary.InvoiceDate, " +
                                "InvoiceSummary.TotalDue AS InvoiceAmount, " +
                                "MID(InventoryItems.Field1, 5, 16) AS GLNumber, " +
                                "MID(InvoiceSummary.CustAcct, 5, 16) AS JobNumber, " +
                                "InvoiceDetail.Amount AS DistributionAmount, " +
                                "IIF(ISNULL(InvoiceSummary.CustPONum), '', InvoiceSummary.CustPONum) AS WorkTicketNumber " +
                           "FROM " +
                                "((dbo_vCustomerInvoiceSummary AS InvoiceSummary " +
                                "INNER JOIN dbo_vCustomerInvoiceDetail AS InvoiceDetail ON InvoiceDetail.InvoiceNum = InvoiceSummary.InvoiceNum) " +
                                "INNER JOIN dbo_vCustomerOpenInvoices AS OpenInvoices ON OpenInvoices.InvcNum = InvoiceDetail.InvoiceNum) " +
                                "INNER JOIN dbo_vInventoryItems AS InventoryItems ON InvoiceDetail.ItemCode = InventoryItems.ItemCode " +
                           "WHERE " +
                                "InvoiceDetail.NumShipped <> 0 " +
                                "AND InvoiceSummary.CustAcct LIKE '%rcs%' " +
                           "UNION ALL " +
                           "SELECT " +
                                "'345000' AS VendorNumber, " +
                                "InvoiceSummary.InvoiceNum as InvoiceNumber, " +
                                "'' AS PONumber, " +
                                "InvoiceSummary.InvoiceDate, " +
                                "InvoiceSummary.TotalDue AS InvoiceAmount, " +
                                "'2160' AS GLNumber, " +
                                "'[NONE]' AS JobNumber, " +
                                "InvoiceSummary.SalesTaxAmt AS DistributionAmount, " +
                                "IIF(ISNULL(InvoiceSummary.CustPONum), '', InvoiceSummary.CustPONum) AS WorkTicketNumber " +
                           "FROM " +
                                "(dbo_vCustomerInvoiceSummary AS InvoiceSummary " +
                                "INNER JOIN dbo_vCustomerOpenInvoices AS OpenInvoices ON OpenInvoices.InvcNum = InvoiceSummary.InvoiceNum) " +
                           "WHERE " +
                                "InvoiceSummary.CustAcct LIKE '%rcs%'";

            string query = "SELECT " +
                                "* " +
                           "FROM ( " +
                                subquery +
                           ") AS U " +
                           "ORDER BY " +
                                "U.InvoiceNumber, " +
                                "U.JobNumber";
            return query;
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            
        }

        private void ExportMenuItem_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            if (dataTable.Rows.Count > 0) {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "AP Export File " + DateTime.Now + ".csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK) {
                    if (File.Exists(sfd.FileName)) {
                        try {
                            File.Delete(sfd.FileName);
                        } catch (IOException ex) {
                            fileError = true;
                            MessageBox.Show("Permission denied." + ex.Message);
                        }
                    }
                    if (!fileError) {
                        try {
                            int columnCount = dataTable.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataTable.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++) {
                                columnNames += dataTable.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < dataTable.Rows.Count; i++) {
                                for (int j = 0; j < columnCount; j++) {
                                    outputCsv[i] += dataTable.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully.", "Info");
                        } catch (Exception ex) {
                            MessageBox.Show("Error:" + ex.Message + ".");
                        }
                    }
                }
            } else {
                MessageBox.Show("No record to export.", "Info");
            }

            this.Cursor = Cursors.Default;
        }

        private void ReloadMenuItem_Click(object sender, EventArgs e) {
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

        private void GenerateNotepadTab_Click(object sender, EventArgs e) {

        }

        private void Label1_Click(object sender, EventArgs e) {

        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e) {

        }

        private void Label1_Click_1(object sender, EventArgs e) {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e) {

        }

        private void VendorNumberLabel_Click(object sender, EventArgs e) {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e) {


        }

        private void DateEnd_ValueChanged(object sender, EventArgs e) {

        }

        private void InvoiceNumberLabel_Click(object sender, EventArgs e) {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void workTicketNumberLabel_Click(object sender, EventArgs e) {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
