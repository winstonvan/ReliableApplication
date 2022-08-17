using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Reliable;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Diagnostics;

namespace TestProject {

    public partial class RebateContracts : Form {
        readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        OleDbConnection connection = null;

        public RebateContracts() {
            InitializeComponent();
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

            if (CustomerContractCode.Checked && CustomerContractCodeField.Text != "") {
                query += "WHERE CPMContracts.CPMContractID = " + CustomerContractCodeField.Text + " ";
            }


            query += ") AS RebateGroups ON(RebateGroups.RebateContractID = RebateItems.RebateContractID) " +
                        "WHERE " +
                            "RebateGroups.ContractPricingClassID = RebateGroups.CustDiscClassID " +
                        ") AS RebateItems ON(CPMContractPrices.ItemID = RebateItems.ItemID)) " +
                    "LEFT JOIN dbo_RebateContracts RebateContracts ON(RebateItems.RebateContractID = RebateContracts.RebateContractID)) ";

            string condition = "";
            if (CustomerContractCode.Checked && CustomerContractCodeField.Text != "") {
                condition += "CPMContracts.CPMContractID = " + CustomerContractCodeField.Text + " ";
            }

            if (!IncludeExpiredCheckbox.Checked) {
                if (condition != "") {
                    condition += "AND ";
                }
                condition += "(RebateContracts.ContractExpireDate > FORMAT(DATE(), 'yyyy-mm-dd') OR (RebateContracts.ContractExpireDate IS NULL)) ";
            }

            query += condition != "" ? "WHERE " + condition : "";
            query += "ORDER BY " +
                     "CPMContracts.ContractDesc, " +
                     "RebateContracts.ContractExpireDate, " +
                     "vInventoryItems.ItemCode ";
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
            if (CustomerContractCode.Checked) {
                CustomerContractCodeField.BackColor = Color.White;
                CustomerContractCodeField.Enabled = true;
            } else {
                CustomerContractCodeField.BackColor = Color.DarkGray;
                CustomerContractCodeField.Enabled = false;
            }
        }

        private void RebateContractIdCheckbox_MouseMove(object sender, EventArgs e) {
            ItemNumberTooltip.SetToolTip(CustomerContractCode, "Use commas to specify more than one rebate contract IDs."); // you can change the first parameter (textbox3) on any control you wanna focus
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

        private void mainMenuToolStripMenuItem_Click_2(object sender, EventArgs e) {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            SaveFileDialog sfd = new SaveFileDialog();
            string fileName = "Rebate Contracts Report " + DateTime.Now.ToString("MM-dd-yyyy HH-mm-ss") + ".csv";
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = fileName;

            StreamWriter sw = new StreamWriter(sfd.FileName, false);
            //headers    
            for (int i = 1; i < DataTable.Columns.Count; i++) {
                sw.Write(DataTable.Columns[i].HeaderText);
                if (i < DataTable.Columns.Count - 1) {
                    sw.Write(",");
                }
            }
            sw.Write(sw.NewLine);
            for (int i = 0; i < DataTable.Rows.Count - 1; i++) {
                for (int j = 1; j < DataTable.Columns.Count; j++) {
                    if (!Convert.IsDBNull(DataTable.Rows[i].Cells[j].Value.ToString())) {
                        string value = DataTable.Rows[i].Cells[j].Value.ToString();
                        if (value.Contains(',')) {
                            value = String.Format("\"{0}\"", value);
                            sw.Write(value);
                        } else {
                            sw.Write(DataTable.Rows[i].Cells[j].Value.ToString());
                        }
                    }
                    if (j < DataTable.Columns.Count - 1) {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }

            sw.Close();
            Process.Start(sfd.FileName);

            Cursor = Cursors.Default;
        }
    }
}
