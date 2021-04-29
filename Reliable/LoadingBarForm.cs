using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMP_Inventory_Finder
{
    public partial class LoadingBarForm : Form
    {

        public int numberOfChecks;
        public int count;
        public LoadingBarForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void IncrementProgressBar()
        {
            progressBar1.PerformStep();
        }

        public void SetStepValue(int step)
        {
            progressBar1.Step = step;
        }

        public void SetMaxValue(int max)
        {
            progressBar1.Maximum = max;
        }

        public void decrementProgressBar()
        {
            progressBar1.Step = -(progressBar1.Step);

            progressBar1.PerformStep();

            progressBar1.Step = -(progressBar1.Step);
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
