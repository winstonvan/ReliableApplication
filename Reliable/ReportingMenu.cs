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

namespace Reliable
{
    public partial class ReportingMenu : Form
    {
        public ReportingMenu()
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

        private void orderFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            OrderDeskInvoices formNew = new OrderDeskInvoices();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void pricingButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            InventoryPricing formNew = new InventoryPricing();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void vendorsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Vendors formNew = new Vendors();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();

            SalesToCustomer formNew = new SalesToCustomer();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmailPayroll formNew = new EmailPayroll();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void manufacturingPriceButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            Manufacturing_Price_Check formNew = new Manufacturing_Price_Check();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void azureMobileDataButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            AzureTableGenerator formNew = new AzureTableGenerator();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }

        private void RebateContractsButton_Click(object sender, EventArgs e) {
            this.Hide();

            RebateContracts formNew = new RebateContracts();

            formNew.Closed += (s, args) => this.Close();

            formNew.Show();
        }
    }

}
