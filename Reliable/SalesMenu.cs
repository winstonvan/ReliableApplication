using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reliable
{
    public partial class SalesMenu : Form
    {
        public SalesMenu()
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

            SalesCatalogue salesForm = new SalesCatalogue();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();
        }

        private void pricingButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SalesPricingInfo salesForm = new SalesPricingInfo();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            QuoteForm salesForm = new QuoteForm();

            salesForm.Closed += (s, args) => this.Close();

            salesForm.Show();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }
    }
}
