using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using DataGridViewAutoFilter;
using System.Configuration;
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using Reliable;
using System.Drawing;
using System.Threading;
using Font = iTextSharp.text.Font;

namespace TestProject {

    public partial class CatalogCreatorImportDialog : Form {
        readonly String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Z:\\JMCat\\PCC\\Data\\RELMAP\\Demo.mdb;Jet OLEDB:Database Password=AJguess2ME; Persist Security Info=False;";
        OleDbConnection connection = null;
        CatalogCreator cc;

        public CatalogCreatorImportDialog(CatalogCreator cc) {
            InitializeComponent();
            this.cc = cc;
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ImportButton_Click(object sender, EventArgs e) {
            MessageBox.Show(ImportData.Text);
            if (ImportData.Text == "") {
                return; 
            }

            try {
                string[] data = ImportData.Text.Split('\n');

                OleDbCommand command = new OleDbCommand();
                connection = new OleDbConnection(OLDBEConnect);
                connection.Open();
                string query;
                command.Connection = connection;

                foreach (string itemNo in data) {
                    query = "UPDATE Item SET [IsSelected] = TRUE WHERE [ItemNo] = '" + itemNo + "'";
                    command.CommandText = query;
                    command.ExecuteNonQuery();
                }

                connection.Close();
                this.Hide();
                this.cc.Run();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
