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
    public partial class CompanyInformation : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";
        OleDbConnection connect = null;
        public CompanyInformation()
        {
            InitializeComponent();
        }

        private void CompanyInformation_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;

            RMPPanel.Width = 0;
            RISPanel.Width = 0;

            connect = new OleDbConnection(OLDBEConnect);
            connect.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM APMail", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable RMPInfoTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(RMPInfoTable);

            //Adding information to the additional information page

            RMPCompanyName.Text = RMPInfoTable.Rows[0][2].ToString();
            RMPAddressOne.Text = RMPInfoTable.Rows[0][3].ToString();
            RMPAddressTwo.Text = RMPInfoTable.Rows[0][4].ToString();
            RMPTelephone.Text = RMPInfoTable.Rows[0][9].ToString();
            RMPTollFree.Text = RMPInfoTable.Rows[0][10].ToString();
            RMPFax.Text = RMPInfoTable.Rows[0][11].ToString();
            RMPWebsite.Text = RMPInfoTable.Rows[0][13].ToString();

            connect.Close();

            connect = new OleDbConnection(OLDBEConnectRIS);
            connect.Open();

            command = new OleDbCommand("SELECT * FROM APMail", connect);
            adapter = new OleDbDataAdapter(command);

            DataTable RISInfoTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(RISInfoTable);

            //Adding information to the additional information page

            RISCompanyName.Text = RISInfoTable.Rows[0][2].ToString();
            RISAddressOne.Text = RISInfoTable.Rows[0][3].ToString();
            RISAddressTwo.Text = RISInfoTable.Rows[0][4].ToString();
            RISTelephone.Text = RISInfoTable.Rows[0][9].ToString();
            RISTollFree.Text = RISInfoTable.Rows[0][10].ToString();
            RISFax.Text = RISInfoTable.Rows[0][11].ToString();
            RISWebsite.Text = RISInfoTable.Rows[0][13].ToString();

            connect.Close();

            this.Cursor = Cursors.Default;
        }



        private void rmpMenuButton_Click(object sender, EventArgs e)
        {
            if (RMPPanel.Width == 0)
            {
                risMenuButton.Visible = false;

                RMPPanel.Visible = false;

                RMPPanel.Width = 528;

                RMPTransition.ShowSync(RMPPanel);

            }

            else
            {

                risMenuButton.Visible = true;

                RMPPanel.Width = 0;

            }
        }

        private void risMenuButton_Click(object sender, EventArgs e)
        {
            if (RISPanel.Width == 0)
            {

                rmpMenuButton.Visible = false;

                RISPanel.Visible = false;

                RISPanel.Width = 528;

                RISTransition.ShowSync(RISPanel);

            }

            else
            {

                rmpMenuButton.Visible = true;

                RISPanel.Width = 0;

            }
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormState.PreviousPage.Show();

            this.Hide();
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
            if (MessageBox.Show("Are you sure that you would like to update the RIS data with the changes made?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string query = "UPDATE APMail SET APMail.CompanyName = '" + RISCompanyName.Text + "', APMail.AddressOne = '" + RISAddressOne.Text + "', APMail.AddressTwo = '" + RISAddressTwo.Text + "', APMail.Telephone = '" + RISTelephone.Text + "', APMail.TollFree = '" + RISTollFree.Text + "', APMail.Fax = '" + RISFax.Text + "', APMail.Website = '" + RISWebsite.Text + "' WHERE Key = 1;";

                using (connect = new OleDbConnection(OLDBEConnectRIS))
                {
                    using (var accessUpdateCommand = connect.CreateCommand())
                    {
                        accessUpdateCommand.CommandText = query;

                        accessUpdateCommand.Connection.Open();
                        accessUpdateCommand.ExecuteNonQuery();
                        accessUpdateCommand.Connection.Close();
                    }
                }


            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you would like to update the RMP data with the changes made?", "Update", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string query = "UPDATE APMail SET APMail.CompanyName = '" + RMPCompanyName.Text + "', APMail.AddressOne = '" + RMPAddressOne.Text + "', APMail.AddressTwo = '" + RMPAddressTwo.Text + "', APMail.Telephone = '" + RMPTelephone.Text + "', APMail.TollFree = '" + RMPTollFree.Text + "', APMail.Fax = '" + RMPFax.Text + "', APMail.Website = '" + RMPWebsite.Text + "' WHERE Key = 1;";

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


            }
        }
    }
}
