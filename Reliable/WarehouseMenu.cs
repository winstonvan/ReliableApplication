using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reliable {
    public partial class WarehouseMenu : Form {
        public WarehouseMenu() {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void WarehouseLabelsButton_Click(object sender, EventArgs e) {
            this.Hide();

            WarehouseProductLabels newForm = new WarehouseProductLabels();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void ShowroomLabelsButton_Click(object sender, EventArgs e) {
            this.Hide();

            ShowroomLabels newForm = new ShowroomLabels();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void CountSheetsButton_Click(object sender, EventArgs e) {
            this.Hide();

            CountSheets newForm = new CountSheets();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void BarcodeGeneratorButton_Click(object sender, EventArgs e) {
            this.Hide();

            transparentBackgroundCheck newForm = new transparentBackgroundCheck();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void ShippingLabelsButton_Click(object sender, EventArgs e) {
            this.Hide();

            ShippingLabels newForm = new ShippingLabels();

            newForm.Closed += (s, args) => this.Close();

            newForm.Show();
        }

        private void OrderDeskErrorsButton_Click(object sender, EventArgs e) {
            this.Hide();

            OrderDeskErrors orderDeskErrors = new OrderDeskErrors();

            orderDeskErrors.Closed += (s, args) => this.Close();

            orderDeskErrors.Show();
        }
    }
}
