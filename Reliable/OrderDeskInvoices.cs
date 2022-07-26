using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using Reliable;
using System.Drawing;

namespace TestProject {

    public partial class OrderDeskInvoices : Form {
        readonly string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        OleDbConnection connection = null;

        public OrderDeskInvoices() {
            InitializeComponent();

            FilterDropdown.Items.Insert(0, new ComboBoxItem("All", "0"));
            FilterDropdown.Items.Insert(1, new ComboBoxItem("Pick", "1"));
            FilterDropdown.Items.Insert(1, new ComboBoxItem("Create", "2"));
            FilterDropdown.SelectedIndex = FilterDropdown.FindString("All");
            PeriodDropdown.SelectedIndex = PeriodDropdown.FindString("Any");
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
            string query = "SELECT " +
                                "Invoices.CustAcct, " +
                                "Invoices.ItemCode, " +
                                "Invoices.InvoiceDate, " +
                                "Invoices.InvoiceNum, " +
                                "Invoices.NumShipped, " +
                                "Invoices.Price, " +
                                "Invoices.ComUnitCost AS Cost, " +
                                "Invoices.CurPricePct AS Margin, " +
                                "Invoices.SysPriceCtrl AS SystemSource, " +
                                "Invoices.CurPriceCtrl AS InvoiceSource " +
                             "FROM ((dbo_vCustomerInvoiceDetail Invoices " +
                                "INNER JOIN dbo_ARCusts Customers ON Invoices.CustAcct = Customers.CustAcct) " +
                                "INNER JOIN dbo_CPMClasses PricingClasses ON Customers.PricingClassID = PricingClasses.PricingClassID) ";
            string condition = "";
            string[] itemNumbers = ItemNumberCheckbox.Checked ? ItemNumberField.Text.Split(',') : new string[0];
            string[] invoiceNumbers = InvoiceNumberCheckbox.Checked ? InvoiceNumberField.Text.Split(',') : new string[0];

            if (PriceClassRadioButton.Checked) {
                if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("Pick")) {
                    for (int i = 0; i < FilterList.CheckedItems.Count; i++) {
                        condition += "PricingClasses.PricingClassDesc = '" + FilterList.CheckedItems[i].ToString().Split('-')[0] + "' ";

                        if (i != FilterList.CheckedItems.Count - 1) {
                            condition += "OR ";
                        }
                    }
                } else if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("Create")) {
                    string[] items = FilterListCreate.Text.Split('\n');
                    for (int i = 0; i < items.Length; i++) {
                        condition += "PricingClasses.PricingClassDesc = '" + items[i].Trim() + "' ";

                        if (i != items.Length - 1) {
                            condition += "OR ";
                        }
                    }
                }
            } else if (CustomerNumberRadioButton.Checked) {
                if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("Pick")) {
                    for (int i = 0; i < FilterList.CheckedItems.Count; i++) {
                        condition += "Invoices.CustAcct = '" + FilterList.CheckedItems[i].ToString().Split(new string[] { " - " }, StringSplitOptions.None)[0] + "' ";

                        if (i != FilterList.CheckedItems.Count - 1) {
                            condition += "OR ";
                        }
                    }
                } else if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("Create")) {
                    string[] items = FilterListCreate.Text.Split('\n');
                    for (int i = 0; i < items.Length; i++) {
                        condition += "Invoices.CustAcct = '" + items[i].Trim() + "' ";

                        if (i != items.Length - 1) {
                            condition += "OR ";
                        }
                    }
                }

            }

            query += condition != "" ? "WHERE (" + condition + ") " : "";

            if (ItemNumberCheckbox.Checked && itemNumbers.Length > 0) {
                string itemNumberCondition = "";

                for (int i = 0; i < itemNumbers.Length; i++) {
                    if (itemNumbers[i] != "") {
                        itemNumberCondition += "ItemCode = '" + itemNumbers[i].Trim() + "'";
                    } else {
                        break;
                    }

                    if (i != itemNumbers.Length - 1) {
                        itemNumberCondition += " OR ";
                    }
                }

                if (itemNumberCondition != "") {
                    if (!query.Contains("WHERE")) {
                        query += "WHERE ";
                    } else {
                        query += "AND ";
                    }
                    query += "(" + itemNumberCondition + ") ";
                }
            }

            if (InvoiceNumberCheckbox.Checked && invoiceNumbers.Length > 0) {
                string invoiceNumberCondition = "";

                for (int i = 0; i < invoiceNumbers.Length; i++) {
                    if (invoiceNumbers[i] != "") {
                        invoiceNumberCondition += "InvoiceNum = '" + invoiceNumbers[i].Trim() + "'";
                    } else {
                        break;
                    }

                    if (i != invoiceNumbers.Length - 1) {
                        invoiceNumberCondition += " OR ";
                    }
                }

                if (invoiceNumberCondition != "") {
                    if (!query.Contains("WHERE")) {
                        query += "WHERE ";
                    } else {
                        query += "AND ";
                    }
                    query += "(" + invoiceNumberCondition + ") ";
                }
            }

            if (PeriodDropdown.Text != "All") {
                string startDate = StartDatePicker.Value.ToString("yyyy-MM-dd");
                string endDate = EndDatePicker.Value.ToString("yyyy-MM-dd");

                if (!query.Contains("WHERE")) {
                    query += "WHERE ";
                } else {
                    query += "AND ";
                }

                query += "InvoiceDate BETWEEN '" + startDate + "' AND '" + endDate + "'";
            }

            //MessageBox.Show(query);
            return query + " ORDER BY Invoices.InvoiceDate DESC";
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

            DataTable.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataTable.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.Cursor = Cursors.Default;
        }

        private void FilterDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            Cursor = Cursors.WaitCursor;

            string query = "";

            if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("All")) {
                FilterList.Visible = true;
                FilterListCreate.Visible = false;
                FilterList.BackColor = Color.DarkGray;
                FilterList.Enabled = false;
            } else if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("Create")) {
                FilterList.Visible = false;
                FilterListCreate.Visible = true;
            } else if (this.FilterDropdown.GetItemText(this.FilterDropdown.SelectedItem).Equals("Pick")) {
                FilterList.Visible = true;
                FilterListCreate.Visible = false;
                FilterList.BackColor = Color.White;
                FilterList.Enabled = true;
                try {
                    if (this.PriceClassRadioButton.Checked) {
                        query = "SELECT PricingClassDesc FROM dbo_CPMClasses ORDER BY PricingClassDesc";
                    } else if (this.CustomerNumberRadioButton.Checked) {
                        query = "SELECT CustomerName, CustAcct FROM dbo_ARCusts ORDER BY CustomerName";
                    }

                    connection = new OleDbConnection(connectionString);
                    OleDbCommand selectCommand = new OleDbCommand(query, connection);
                    OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(selectCommand);
                    DataSet dataSet = new DataSet();
                    oleDbDataAdapter.SelectCommand = selectCommand;
                    oleDbDataAdapter.Fill(dataSet);

                    for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++) {
                        if (this.PriceClassRadioButton.Checked) {
                            FilterList.Items.Add(dataSet.Tables[0].Rows[i]["PricingClassDesc"].ToString());
                        } else if (this.CustomerNumberRadioButton.Checked) {
                            FilterList.Items.Add(dataSet.Tables[0].Rows[i]["CustAcct"].ToString() + " - " + dataSet.Tables[0].Rows[i]["CustomerName"].ToString());
                        } else if (this.NoneRadioButton.Checked) {

                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }

            Cursor = Cursors.Default;
        }

        private void CheckRadioButtons() {
            if (NoneRadioButton.Checked) {
                FilterDropdown.Enabled = false;
                FilterList.Enabled = false;
                FilterListCreate.Enabled = false;
                FilterList.BackColor = Color.DarkGray;
                FilterListCreate.BackColor = Color.DarkGray;
            } else {
                FilterDropdown.Enabled = true;
                FilterList.Enabled = true;
                FilterListCreate.Enabled = true;
                FilterList.BackColor = Color.White;
                FilterListCreate.BackColor = Color.White;
            }
        }

        private void NoneRadioButton_CheckedChanged(object sender, EventArgs e) {
            CheckRadioButtons();
        }

        private void PriceClassRadioButton_CheckedChanged(object sender, EventArgs e) {
            CheckRadioButtons();

            FilterDropdown_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void CustomerNumberRadioButton_CheckedChanged_1(object sender, EventArgs e) {
            CheckRadioButtons();

            FilterDropdown_SelectedIndexChanged(this, EventArgs.Empty);
        }

        private void ItemNumberCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (ItemNumberCheckbox.Checked) {
                ItemNumberField.BackColor = Color.White;
                ItemNumberField.Enabled = true;
            } else {
                ItemNumberField.BackColor = Color.DarkGray;
                ItemNumberField.Enabled = false;
            }
        }

        private void InvoiceNumberCheckbox_CheckedChanged(object sender, EventArgs e) {
            if (InvoiceNumberCheckbox.Checked) {
                InvoiceNumberField.BackColor = Color.White;
                InvoiceNumberField.Enabled = true;
            } else {
                InvoiceNumberField.BackColor = Color.DarkGray;
                InvoiceNumberField.Enabled = false;
            }
        }

        private void ItemNumberCheckbox_MouseMove(object sender, EventArgs e) {
            ItemNumberTooltip.SetToolTip(ItemNumberCheckbox, "Use commas to specify more than one item number."); // you can change the first parameter (textbox3) on any control you wanna focus
        }


        private void InvoiceNumberCheckbox_MouseMove(object sender, EventArgs e) {
            InvoiceNumberTooltip.SetToolTip(InvoiceNumberCheckbox, "Use commas to specify more than one invoice number."); // you can change the first parameter (textbox3) on any control you wanna focus
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void periodDropdown_SelectedIndexChanged(object sender, EventArgs e) {
            DateTime dateTime = default(DateTime);
            DateTime dateTime2 = default(DateTime);
            DateTime date = DateTime.Now.Date;

            if (PeriodDropdown.SelectedItem.ToString() == "All") {
                StartDatePicker.CustomFormat = " ";
                EndDatePicker.CustomFormat = " ";
            } else {
                StartDatePicker.CustomFormat = "  MM/dd/yyyy";
                EndDatePicker.CustomFormat = "  MM/dd/yyyy";

                if (PeriodDropdown.SelectedItem.ToString() == "Today") {
                    StartDatePicker.Value = DateTime.Now;
                    EndDatePicker.Value = DateTime.Now;
                } else if (PeriodDropdown.SelectedItem.ToString() == "Yesterday") {
                    StartDatePicker.Value = DateTime.Now.AddDays(-1.0);
                    EndDatePicker.Value = DateTime.Now.AddDays(-1.0);
                } else if (PeriodDropdown.SelectedItem.ToString() == "This Week") {
                    DayOfWeek dayOfWeek = DateTime.Now.DayOfWeek;
                    int num = (int)(dayOfWeek - 0);
                    dateTime = DateTime.Now.AddDays(-num);
                    dateTime2 = DateTime.Now.AddDays(7 - num);
                    StartDatePicker.Value = dateTime;
                    EndDatePicker.Value = dateTime2;
                } else if (PeriodDropdown.SelectedItem.ToString() == "Last Week") {
                    DayOfWeek dayOfWeek2 = DateTime.Now.DayOfWeek;
                    int num2 = (int)(dayOfWeek2 - 0);
                    dateTime = DateTime.Now.AddDays(-num2 - 7);
                    dateTime2 = DateTime.Now.AddDays(7 - num2 - 8);
                    StartDatePicker.Value = dateTime;
                    EndDatePicker.Value = dateTime2;
                } else if (PeriodDropdown.SelectedItem.ToString() == "This Month") {
                    DateTime value = new DateTime(date.Year, date.Month, 1);
                    DateTime value2 = value.AddMonths(1).AddDays(-1.0);
                    StartDatePicker.Value = value;
                    EndDatePicker.Value = value2;
                } else if (PeriodDropdown.SelectedItem.ToString() == "Last Month") {
                    DateTime value3 = ((date.Month != 1) ? new DateTime(date.Year, date.Month - 1, 1) : new DateTime(date.Year - 1, 12, 1));
                    DateTime value4 = value3.AddMonths(1).AddDays(-1.0);
                    StartDatePicker.Value = value3;
                    EndDatePicker.Value = value4;
                } 
            }
        }

        private void StartDatePicker_Enter(object sender, EventArgs e) {
            PeriodDropdown.SelectedIndex = PeriodDropdown.FindString("Custom");
        }

        private void EndDatePicker_Enter(object sender, EventArgs e) {
            PeriodDropdown.SelectedIndex = PeriodDropdown.FindString("Custom");
        }
    }
}
