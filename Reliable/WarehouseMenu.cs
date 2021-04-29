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
    public partial class WarehouseMenu : Form
    {
        public WarehouseMenu()
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

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void warehouseLabelsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            WarehouseProductLabels newForm = new WarehouseProductLabels();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void showroomLabelsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShowroomLabels newForm = new ShowroomLabels();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void countSheetsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            CountSheets newForm = new CountSheets();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void barcodeGeneratorButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            transparentBackgroundCheck newForm = new transparentBackgroundCheck();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void shippingLabelsButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            ShippingLabels newForm = new ShippingLabels();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }
    }
}
