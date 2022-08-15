using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Reliable;
using System.Drawing;

namespace TestProject {

    public partial class RebateContracts : Form {
        readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        OleDbConnection connection = null;

        public RebateContracts() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void GLListing_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                connection = new OleDbConnection(connectionString);
                connection.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private string QueryBuilder() {
            string query = "" +
                "SELECT " +
                    "IIF(RebateContracts.ContractCode IS NULL, '', RebateContracts.ContractCode) AS RebateContractCode, " +
                    "IIF(RebateContracts.ContractDesc IS NULL, '', RebateContracts.ContractDesc) AS RebateContractDesc, " +
                    "IIF(RebateContracts.ContractStartDate IS NULL, '', RebateContracts.ContractStartDate) As RebateStartDate, " +
                    "IIF(RebateContracts.ContractExpireDate IS NULL, '', RebateContracts.ContractExpireDate) AS RebateExpiryDate, " +
                    "IIF(RebateItems.RebateCost IS NULL, 0, RebateItems.RebateCost * 1.05) AS RebateCost, " +
                    "CPMContracts.ContractDesc, " +
                    "vInventoryItems.SubCatDescription, " +
                    "CPMContractPrices.CPMContractID, " +
                    "vInventoryItems.ItemCode, " +
                    "vInventoryItems.ItemDescription, " +
                    "vInventoryItems.SupplierName, " +
                    "vInventoryItems.SupplierPartNum, " +
                    "CPMContractPrices.ContractPrice AS CurrentContractPrice, " +
                    "vInventoryItems.PubUnitCost AS PubUnitCost, " +
                    "CPMContractPrices.RenewalPrice, " +
                    "CPMContractPrices.CalcPriceMargin, " +
                    "CPMContractPrices.CalcPriceChgCtl, " +
                    "CPMContractPrices.CalcedRenewalPriceMargin, " +
                    "vInventoryItems.LastUnitCost, " +
                    "vInventoryItems.AveUnitCost, " +
                    "vInventoryItems.PubUnitCost " +
                "FROM " +
                    "((((dbo_CPMContractPrices CPMContractPrices " +
                    "INNER JOIN dbo_CPMContracts CPMContracts ON(CPMContracts.CPMContractID = CPMContractPrices.CPMContractID)) " +
                    "INNER JOIN dbo_vInventoryItems vInventoryItems ON(vInventoryItems.ItemID = CPMContractPrices.ItemID)) " +
                    "LEFT JOIN ( " +
                        "SELECT " +
                            "RebateItems.RebateContractID, " +
                            "RebateItems.ItemID, " +
                            "RebateItems.RebateCost, " +
                            "RebateGroups.CustDiscClassID, " +
                            "RebateGroups.CustID " +
                        "FROM " +
                            "dbo_RebateItems RebateItems " +
                            "LEFT JOIN (SELECT " +
                                            "RebateGroups.RebateContractID, " +
                                            "RebateGroups.CustDiscClassID, " +
                                            "RebateGroups.CustID, " +
                                            "CPMContracts.ContractPricingClassID " +
                                        "FROM " +
                                            "dbo_RebateGroups RebateGroups " +
                                            "LEFT JOIN dbo_CPMContracts CPMContracts ON (RebateGroups.CustDiscClassID = CPMContracts.ContractPricingClassID) ";

            if (RebateContractIdCheckbox.Checked && RebateContractIdField.Text != "") {
                query += "WHERE CPMContracts.CPMContractID = " + RebateContractIdField.Text + " ";
            }


            query += ") AS RebateGroups ON(RebateGroups.RebateContractID = RebateItems.RebateContractID) " +
                        "WHERE " +
                            "RebateGroups.ContractPricingClassID = RebateGroups.CustDiscClassID " +
                        ") AS RebateItems ON(CPMContractPrices.ItemID = RebateItems.ItemID)) " +
                    "LEFT JOIN dbo_RebateContracts RebateContracts ON(RebateItems.RebateContractID = RebateContracts.RebateContractID)) ";

            string condition = "";
            if (RebateContractIdCheckbox.Checked && RebateContractIdField.Text != "") {
                condition += "CPMContracts.CPMContractID = " + RebateContractIdField.Text + " ";
            }

            if (!IncludeExpiredCheckbox.Checked) {
                if (condition != "") {
                    condition += "AND ";
                }
                condition += "((RebateContracts.ContractExpireDate > FORMAT(DATE(), 'yyyy/mm/dd') OR RebateContracts.ContractExpireDate IS NULL)) ";
            }

            query += condition != "" ? "WHERE " + condition : "";
            query += "ORDER BY vInventoryItems.ItemCode ";

            return query;
        }

        private void QueryButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            OleDbCommand command = new OleDbCommand(QueryBuilder(), new OleDbConnection(connectionString));
            OleDbDataAdapter adapter = new OleDbDataAdapter(command) {
                SelectCommand = command
            };

            DataTable table = new DataTable();
            adapter.Fill(table);

            DataTable.DataSource = table;

            //DataTable.AutoResizeColumns();
            DataTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
            DataTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataTable.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.Cursor = Cursors.Default;
        }


        private void RebateContractIdCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (RebateContractIdCheckbox.Checked) {
                RebateContractIdField.BackColor = Color.White;
                RebateContractIdField.Enabled = true;
            } else {
                RebateContractIdField.BackColor = Color.DarkGray;
                RebateContractIdField.Enabled = false;
            }
        }

        private void RebateContractIdCheckbox_MouseMove(object sender, EventArgs e) {
            ItemNumberTooltip.SetToolTip(RebateContractIdCheckbox, "Use commas to specify more than one rebate contract IDs."); // you can change the first parameter (textbox3) on any control you wanna focus
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainMenuToolStripMenuItem_Click_1(object sender, EventArgs e) {
            FormState.PreviousPage.Show();
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
