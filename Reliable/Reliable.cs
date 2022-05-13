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

namespace Reliable {
    public partial class Reliable : Form {
        public static string account = null;
        public Reliable() {
            InitializeComponent();
        }
        
        private void Reliable_FormClosing(object sender, FormClosingEventArgs e) {

        }

        private void Reliable_Load(object sender, EventArgs e) {
            menuPanel.Height = 45;
            menuPanel.Width = 146;
            menuPanelTwo.Height = 14;

            if (AccountPriviledges.getAP() == false) {
                AccountsPayable.Visible = false;
            }

            if (AccountPriviledges.getGL() == false) {
                GeneralLedger.Visible = false;
            }

            if (AccountPriviledges.getSales() == false) {
                Sales.Visible = false;
            }

            if (AccountPriviledges.getManage() == false) {
                Management.Visible = false;
            }

            if (AccountPriviledges.getWarehouse() == false) {
                Warehouse.Visible = false;
            }

            if (AccountPriviledges.getAdminFlag() == false) {
                accountManagmentButton.Visible = false;
            }

            FormState.PreviousPage = this;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e) {
            this.Hide();

            PasswordChange passForm = new PasswordChange();

            passForm.Closed += (s, args) => this.Close();

            passForm.Show();
        }

        private void MenuButton_Click(object sender, EventArgs e) {
            if (menuPanelTwo.Height == 14 && AccountPriviledges.getAdminFlag() == true) {
                menuPanelTwo.Visible = false;
                menuPanelTwo.Height = 126;
                menuPanelTransitionTwo.ShowSync(menuPanelTwo);
            } else if (menuPanelTwo.Height == 14 && AccountPriviledges.getAdminFlag() == false) {
                menuPanelTwo.Visible = false;
                menuPanelTwo.Height = 92;
                menuPanelTransitionTwo.ShowSync(menuPanelTwo);
            } else {
                menuPanelTwo.Height = 14;
            }
        }

        private void CompanyInformationButton_Click(object sender, EventArgs e) {
            companyInformationButton.Visible = false;
            companyTransition.ShowSync(companyInformationButton);

            this.Hide();

            CompanyInformation salesForm = new CompanyInformation();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void accountManagmentButton_Click(object sender, EventArgs e) {
            this.Hide();

            Account_Managment newForm = new Account_Managment();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }



        /// <summary>
        /// ////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountsPayable_Click(object sender, EventArgs e) {
            AccountsPayable.Visible = false;
            apButtonTransition.ShowSync(AccountsPayable);

            this.Hide();

            APMenu apForm = new APMenu();

            apForm.Closed += (s, args) => this.Close();

            apForm.Show();
        }

        private void AccountsReceivable_Click(object sender, EventArgs e) {
            this.Hide();

            ARForm newForm = new ARForm();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void GeneralLedger_Click(object sender, EventArgs e) {
            GeneralLedger.Visible = false;
            glTransition.ShowSync(GeneralLedger);

            this.Hide();

            GLListing glForm = new GLListing();

            glForm.Closed += (s, args) => this.Close();

            glForm.Show();
        }

        private void Management_Click(object sender, EventArgs e) {
            this.Hide();

            ManagmentMenu managmentForm = new ManagmentMenu();

            managmentForm.Closed += (s, args) => this.Close();

            managmentForm.Show();
        }

        private void Sales_Click(object sender, EventArgs e) {
            Sales.Visible = false;
            salesTransition.ShowSync(Sales);

            this.Hide();

            SalesMenu salesForm = new SalesMenu();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();
        }

        private void Warehouse_Click(object sender, EventArgs e) {
            this.Hide();

            WarehouseMenu newForm = new WarehouseMenu();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void backPanel_Paint(object sender, PaintEventArgs e) {

        }
    }

    public static class FormState {
        public static Form PreviousPage;
    }
}
