using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProject;
using System.Data.OleDb;

namespace Reliable
{
    public partial class PasswordForm : Form
    {
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;

        DataTable passwordTable = new DataTable();

        public bool cancel = false;
        public PasswordForm()
        {
            InitializeComponent();
        }


        private void PasswordForm_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            this.ActiveControl = usernameBox;
            connect = new OleDbConnection(OLDBEConnect);
            connect.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM PasswordTable", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            adapter.SelectCommand = command;

            adapter.Fill(passwordTable);

            connect.Close();

            this.Cursor = Cursors.Default;
        }

        private void okayButton_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in passwordTable.Rows)
            {
                if (usernameBox.Text == row[1].ToString() && passwordBox.Text == row[2].ToString())
                {
                    if(row[1].ToString() == "admin")
                    {
                        AccountPriviledges.setAdminFlag(true);
                    }
                    else
                    {
                        AccountPriviledges.setAdminFlag(false);
                    }

                    if (row[3].ToString() == "1")
                    {
                        AccountPriviledges.setAP(true);
                    }
                    else
                    {
                        AccountPriviledges.setAP(false);
                    }

                    if (row[4].ToString() == "1")
                    {
                        AccountPriviledges.setGL(true);
                    }
                    else
                    {
                        AccountPriviledges.setGL(false);
                    }

                    if (row[5].ToString() == "1")
                    {
                        AccountPriviledges.setSales(true);
                    }
                    else
                    {
                        AccountPriviledges.setSales(false);
                    }

                    if (row[6].ToString() == "1")
                    {
                        AccountPriviledges.setManage(true);
                    }
                    else
                    {
                        AccountPriviledges.setManage(false);
                    }

                    if (row[7].ToString() == "1")
                    {
                        AccountPriviledges.setWarehouse(true);
                    }
                    else
                    {
                        AccountPriviledges.setWarehouse(false);
                    }

                    cancel = true;

                    this.Hide();

                    Reliable menu = new Reliable();

                    menu.Closed += (s, args) => this.Close();

                    menu.Show();

                }

            }

            if (cancel == false)
            {

                MessageBox.Show("The entered username and/or password was incorrect.");

            }

        }

        private void PasswordForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                okayButton.PerformClick();
            }

            if (e.KeyChar == (char)Keys.Tab)
            {
                passwordBox.SelectAll();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reliable_FormClosing(object sender, FormClosingEventArgs e)
        {

            DisconnectFromDatabases();

            Application.Exit();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
