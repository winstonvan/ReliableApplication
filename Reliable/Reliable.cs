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
    public partial class Reliable : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;

        public static string account = null;
        public Reliable()
        {
            InitializeComponent();
        }

        private void Reliable_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Reliable_Load(object sender, EventArgs e)
        {
            menuPanel.Height = 45;
            menuPanel.Width = 146;
            menuPanelTwo.Height = 14;
            
            if(AccountPriviledges.getAP() == false)
            {
                accountsPayableButton.Visible = false;
            }

            if (AccountPriviledges.getGL() == false)
            {
                generalLedgerButton.Visible = false;
            }

            if (AccountPriviledges.getSales() == false)
            {
                salesNewButton.Visible = false;
            }

            if (AccountPriviledges.getManage() == false)
            {
                managmentButton.Visible = false;
            }

            if (AccountPriviledges.getWarehouse() == false)
            {
                warehouseButton.Visible = false;
            }

            if(AccountPriviledges.getAdminFlag() == false)
            {
                accountManagmentButton.Visible = false;
            }

            FormState.PreviousPage = this;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            PasswordChange passForm = new PasswordChange();

            passForm.Closed += (s, args) => this.Close();

            passForm.Show();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if(menuPanelTwo.Height == 14 && AccountPriviledges.getAdminFlag() == true)
            {
                menuPanelTwo.Visible = false;
                menuPanelTwo.Height = 126;
                menuPanelTransitionTwo.ShowSync(menuPanelTwo);
            }

            else if(menuPanelTwo.Height == 14 && AccountPriviledges.getAdminFlag() == false)
            {
                menuPanelTwo.Visible = false;
                menuPanelTwo.Height = 92;
                menuPanelTransitionTwo.ShowSync(menuPanelTwo);
            }

            else
            {
                menuPanelTwo.Height = 14;
            }
        }

        private void accountsPayableButton_Click(object sender, EventArgs e)
        {

            accountsPayableButton.Visible = false;
            apButtonTransition.ShowSync(accountsPayableButton);

            this.Hide();

            APMenu apForm = new APMenu();

            apForm.Closed += (s, args) => this.Close();

            apForm.Show();

        }

        private void generalLedgerButton_Click(object sender, EventArgs e)
        {
            generalLedgerButton.Visible = false;
            glTransition.ShowSync(generalLedgerButton);

            this.Hide();

            GLListing glForm = new GLListing();

            glForm.Closed += (s, args) => this.Close();

            glForm.Show();

        }

        private void salesNewButton_Click(object sender, EventArgs e)
        {
            salesNewButton.Visible = false;
            salesTransition.ShowSync(salesNewButton);

            this.Hide();

            SalesMenu salesForm = new SalesMenu();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();

        }

        private void companyInformationButton_Click(object sender, EventArgs e)
        {
            companyInformationButton.Visible = false;
            companyTransition.ShowSync(companyInformationButton);

            this.Hide();

            CompanyInformation salesForm = new CompanyInformation();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void managmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManagmentMenu managmentForm = new ManagmentMenu();

            managmentForm.Closed += (s, args) => this.Close();

            managmentForm.Show();
        }

        private void warehouseButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            WarehouseMenu newForm = new WarehouseMenu();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void accountManagmentButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Account_Managment newForm = new Account_Managment();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }
    }

    public static class FormState
    {
        public static Form PreviousPage;
    }
}
