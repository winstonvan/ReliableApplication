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

namespace Reliable
{
    public partial class Account_Managment : Form
    {
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;

        bool newAccount = true;
        public Account_Managment()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            //Minimize the current form
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide current form and display menu form ==> Memory useage issues?
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand("SELECT * FROM PasswordTable", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable accountsTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(accountsTable);

            accountsDGV.DataSource = accountsTable;

            newAccount = true;

            this.Cursor = Cursors.Default;

            foreach (DataRow row in accountsTable.Rows)
            {
                if(row[1].ToString() == usernameBox.Text)
                {
                    newAccount = false;

                    MessageBox.Show("An account with this username has already been created.\n\nPlease enter a new username.");
                }
            }

            connect.Open();

            if (newAccount == true)
            {

                if (MessageBox.Show("Are you sure that you would like to create the following account?\n\nUsername: " + usernameBox.Text + "\nPassword: " + passwordBox.Text, "Check", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;

                    string query = "INSERT INTO PasswordTable ([Username], [Password], [AccountsPayable], [GeneralLedger], [Sales], [Management], [Warehouse]) VALUES ('" + usernameBox.Text + "', '" + passwordBox.Text + "', ";

                    if (apBox.Checked == true)
                    {
                        query += "1, ";
                    }
                    else
                    {
                        query += "0, ";
                    }


                    if (glBox.Checked == true)
                    {
                        query += "1, ";
                    }
                    else
                    {
                        query += "0, ";
                    }


                    if (salesBox.Checked == true)
                    {
                        query += "1, ";
                    }
                    else
                    {
                        query += "0, ";
                    }


                    if (managmentBox.Checked == true)
                    {
                        query += "1, ";
                    }
                    else
                    {
                        query += "0, ";
                    }


                    if (warehouseBox.Checked == true)
                    {
                        query += "1); ";
                    }
                    else
                    {
                        query += "0); ";
                    }

                    using (connect)
                    {
                        using (var accessUpdateCommand = connect.CreateCommand())
                        {
                            if (connect.State == ConnectionState.Closed)
                            {
                                connect.Open();
                            }
                            accessUpdateCommand.CommandText = query;
                            accessUpdateCommand.ExecuteNonQuery();
                        }
                    }

                    connect.Close();

                    this.Cursor = Cursors.Default;

                }
            }
        }

        private void existingAccountsTab_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand("SELECT * FROM PasswordTable", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable accountsTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(accountsTable);

            accountsDGV.DataSource = accountsTable;

            this.Cursor = Cursors.Default;
        }

        private void removebutton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (idBox.Text == "1")
            {
                MessageBox.Show("You cannot delete the administrator account.");

            }

            else
            {

                string query = "DELETE * FROM PasswordTable WHERE [ID] = " + idBox.Text + ";";

                connect = new OleDbConnection(OLDBEConnect);

                using (connect)
                {
                    using (var accessUpdateCommand = connect.CreateCommand())
                    {
                        if (connect.State == ConnectionState.Closed)
                        {
                            connect.Open();
                        }
                        accessUpdateCommand.CommandText = query;
                        accessUpdateCommand.ExecuteNonQuery();
                    }
                }


                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand("SELECT * FROM PasswordTable", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable accountsTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(accountsTable);

                accountsDGV.DataSource = accountsTable;
            }

            this.Cursor = Cursors.Default;
        }
    }
}
