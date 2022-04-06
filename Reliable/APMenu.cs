using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RMP_Inventory_Finder;

namespace Reliable {
    public partial class APMenu : Form {
        public APMenu() {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ApMailButton_Click(object sender, EventArgs e) {
            apMailButton.Visible = false;
            eftMailTransition.ShowSync(apMailButton);

            this.Hide();

            APMailEFT eftMailForm = new APMailEFT();

            eftMailForm.Closed += (s, args) => this.Close();

            eftMailForm.Show();
        }

        private void ApNotePadButton_Click(object sender, EventArgs e) {
            apNotePadButton.Visible = false;
            eftnotepadTransition.ShowSync(apNotePadButton);

            this.Hide();

            EFTNotePad eftNoteForm = new EFTNotePad();

            eftNoteForm.Closed += (s, args) => this.Close();

            eftNoteForm.Show();
        }

        private void APImportButton_Click(object sender, EventArgs e) {
            apImportButton.Visible = false;
            //eftnotepadTransition.ShowSync(apImportButton);

            this.Hide();

            APImport import = new APImport();

            import.Closed += (s, args) => this.Close();

            import.Show();
        }

        private void MainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();
            this.Hide();
        }


    }
}
