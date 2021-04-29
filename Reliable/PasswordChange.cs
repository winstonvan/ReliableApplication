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
    public partial class PasswordChange : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;

        DataTable passwordTable = new DataTable();
        public PasswordChange()
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

        private void risUpdateButton_Click(object sender, EventArgs e)
        {
            if (passBox.Text != passBoxTwo.Text)
            {
                MessageBox.Show("The passwords that you entered did not match.");
            }

            else
            {
                string query = "UPDATE PasswordTable SET PasswordTable.Password = '" + passBox.Text + "' WHERE Username = '" + usernameBox.Text + "';";

                using (connect = new OleDbConnection(OLDBEConnect))
                {
                    using (var accessUpdateCommand = connect.CreateCommand())
                    {
                        accessUpdateCommand.CommandText = query;

                        accessUpdateCommand.Connection.Open();
                        accessUpdateCommand.ExecuteNonQuery();
                        accessUpdateCommand.Connection.Close();
                    }
                }

                MessageBox.Show("The program will now close.");

                this.Close();

            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hide current form and display menu form ==> Memory useage issues?
            FormState.PreviousPage.Show();

            this.Hide();
        }
    }
}
