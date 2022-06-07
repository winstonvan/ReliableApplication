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

        private void Reliable_Load(object sender, EventArgs e) {
            menuPanel.Height = 45;
            menuPanel.Width = 146;
            menuPanelTwo.Height = 14;

            if (AccountPriviledges.getAP() == false) {
                AccountsPayableButton.Visible = false;
                AccountsPayableButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getAR() == false) {
                AccountsReceivableButton.Visible = false;
                AccountsReceivableButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getCatalogCreator() == false) {
                CatalogCreatorButton.Visible = false;
                CatalogCreatorButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getGL() == false) {
                GeneralLedgerButton.Visible = false;
                GeneralLedgerButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getSales() == false) {
                SalesButton.Visible = false;
                SalesButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getManage() == false) {
                ManagementButton.Visible = false;
                ManagementButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getWarehouse() == false) {
                WarehouseButton.Visible = false;
                WarehouseButtonDisabled.Visible = true;
            }

            if (AccountPriviledges.getAdminFlag() == false) {
                AccountManagementButton.Visible = false;
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
        private void AccountsPayableButton_Click(object sender, EventArgs e) {
            AccountsPayableButton.Visible = false;
            apButtonTransition.ShowSync(AccountsPayableButton);

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
            GeneralLedgerButton.Visible = false;
            glTransition.ShowSync(GeneralLedgerButton);

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
            SalesButton.Visible = false;
            salesTransition.ShowSync(SalesButton);

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
        private void CatalogCreator_Click(object sender, EventArgs e) {
            this.Hide();

            CatalogCreator newForm = new CatalogCreator();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }
    }

    public static class FormState {
        public static Form PreviousPage;
    }
}
