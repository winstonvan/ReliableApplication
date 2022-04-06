using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Text.RegularExpressions;

namespace Reliable {
    public partial class EFTNotePad : Form {

        bool connectRIS = false;
        readonly List<Checks> checkNumbers = new List<Checks>();
        readonly String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";
        readonly String OLDBEConnectRIS = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1RIS.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;

        public EFTNotePad() {
            InitializeComponent();
        }

        private void DisconnectFromDatabases() {
            try {
                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Close();
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void RMPConnect_Click(object sender, EventArgs e) {
            try {
                this.Cursor = Cursors.WaitCursor;
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnect);
                connect.Open();
                this.Cursor = Cursors.Default;
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

            crossTableDGV.DataSource = null;
            crossTableDGV.Rows.Clear();

            OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable crossTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(crossTable);

            crossTableDGV.DataSource = crossTable;

            textFileDGV.DataSource = null;
            textFileDGV.Rows.Clear();

            connectRIS = false;
        }

        private void EFTNotePad_Load(object sender, EventArgs e) {
            connectRIS = false;

            try {
                this.Cursor = Cursors.WaitCursor;
                connect = new OleDbConnection(OLDBEConnect);
                connect.Open();
                this.Cursor = Cursors.Default;
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = false;
            RISConnect.Enabled = true;

            OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable crossTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(crossTable);

            crossTableDGV.DataSource = crossTable;


        }

        private void EFTNotePad_FormClosing(object sender, FormClosingEventArgs e) {
            DisconnectFromDatabases();
        }

        private void RISConnect_Click_1(object sender, EventArgs e) {
            try {
                this.Cursor = Cursors.WaitCursor;

                connect = new OleDbConnection(OLDBEConnect);
                connect.Close();
                connect = new OleDbConnection(OLDBEConnectRIS);
                connect.Open();

                this.Cursor = Cursors.Default;
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

            RMPConnect.Enabled = true;
            RISConnect.Enabled = false;

            crossTableDGV.DataSource = null;
            crossTableDGV.Rows.Clear();

            OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable crossTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(crossTable);

            crossTableDGV.DataSource = crossTable;

            textFileDGV.DataSource = null;
            textFileDGV.Rows.Clear();

            connectRIS = true;

            this.Cursor = Cursors.Default;
        }

        private void addEntryButton_Click(object sender, EventArgs e) {

            this.Cursor = Cursors.WaitCursor;

            string query = "INSERT INTO EFTCrossTable (EasypayNumber, StepOneNumber) VALUES ('" + easyPayText.Text + "', '" + stepOneText.Text + "');";

            using (connect) {
                using (var accessUpdateCommand = connect.CreateCommand()) {
                    if (connect.State == ConnectionState.Closed) {
                        connect.Open();
                    }
                    accessUpdateCommand.CommandText = query;
                    accessUpdateCommand.ExecuteNonQuery();
                }
            }

            crossTableDGV.DataSource = null;
            crossTableDGV.Rows.Clear();

            if (connectRIS == false) {
                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable crossTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(crossTable);

                crossTableDGV.DataSource = crossTable;
            } else {
                connect = new OleDbConnection(OLDBEConnectRIS);
                OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable crossTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(crossTable);

                crossTableDGV.DataSource = crossTable;
            }

            easyPayText.Text = "";
            stepOneText.Text = "";

            this.Cursor = Cursors.Default;
        }

        private void removebutton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            string query = "DELETE * FROM EFTCrossTable WHERE ID = " + idBox.Text + ";";

            using (connect) {
                using (var accessUpdateCommand = connect.CreateCommand()) {
                    if (connect.State == ConnectionState.Closed) {
                        connect.Open();
                    }
                    accessUpdateCommand.CommandText = query;
                    accessUpdateCommand.ExecuteNonQuery();
                }
            }

            crossTableDGV.DataSource = null;
            crossTableDGV.Rows.Clear();

            if (connectRIS == false) {
                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable crossTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(crossTable);

                crossTableDGV.DataSource = crossTable;
            } else {
                connect = new OleDbConnection(OLDBEConnectRIS);
                OleDbCommand command = new OleDbCommand("SELECT * FROM EFTCrossTable", connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable crossTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(crossTable);

                crossTableDGV.DataSource = crossTable;
            }

            idBox.Text = "";

            this.Cursor = Cursors.Default;
        }


        private void creatTxtFile_Click(object sender, EventArgs e) {
            string folderPath = "Z:\\EFT_Files\\" + ConvertDateFormatting(dateTimePicker1.Value) + "\\";

            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
            }

            if (connectRIS == false) {

                folderPath += "RMP.txt";

            } else {

                folderPath += "RIS.txt";

            }

            File.WriteAllText(folderPath, String.Empty);

            using (StreamWriter sw = new StreamWriter(folderPath, true)) {
                int i = 1;

                foreach (Checks check in checkNumbers) {

                    string myDate = Regex.Replace(textFileDGV.Rows[check.index].Cells[6].Value.ToString(), "-", "");
                    myDate = myDate.Substring(2);
                    sw.WriteLine(i.ToString() + "," + textFileDGV.Rows[check.index].Cells[0].Value.ToString() + "," + textFileDGV.Rows[check.index].Cells[7].Value.ToString() + ",,," + myDate + ",,1,,," + textFileDGV.Rows[check.index].Cells[8].Value.ToString() + ",,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,");
                    i++;
                }
            }

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = folderPath;
            process.Start();

            creatTxtFile.Visible = false;

        }

        private string ConvertDateFormatting(DateTime myDate) {
            string newDate = null;
            string tempMonth = null;
            string tempDay = null;


            if (myDate.Month <= 9) {
                tempMonth = "0" + myDate.Month.ToString();
            } else {
                tempMonth = myDate.Month.ToString();
            }



            if (myDate.Day <= 9) {
                tempDay = "0" + myDate.Day.ToString();
            } else {
                tempDay = myDate.Day.ToString();
            }

            newDate = myDate.Year.ToString() + "-" + tempMonth + "-" + tempDay;

            return newDate;
        }

        private string queryBuilder() {

            String query = null;

            query = "SELECT EFTCrossTable.EasypayNumber, dbo_APPmtDet.InvcNum, dbo_APPmtDet.InvcDate, dbo_APPmtDet.InvcAmt, dbo_APPmtDet.AmtPaid, dbo_APPmtHed.CheckNum, dbo_APPmtHed.CheckDate, ";

            query += "dbo_APPmtHed.PayeeName, dbo_APPmtHed.CheckAmt, dbo_APPmtDet.DiscTaken, dbo_APVendor.CreditComments1, dbo_APVConts.EmailAddress, dbo_APVendor.Address1, ";

            query += "dbo_APVendor.Address2, dbo_APVendor.City, dbo_APVendor.State, dbo_APVendor.Zip, dbo_APPmtHed.PayeeAddress1, dbo_APPmtHed.PayeeAddress2, dbo_APPmtHed.PayeeCity, dbo_APPmtHed.PayeeCountry, dbo_APPmtHed.PayeeState, dbo_APPmtHed.PayeeZip ";

            query += "FROM (((dbo_APPmtDet INNER JOIN dbo_APPmtHed ON dbo_APPmtHed.APPmtID = dbo_APPmtDet.APPmtID) INNER JOIN dbo_APVendor ON dbo_APVendor.VendorID = dbo_APPmtHed.VendorID ) INNER JOIN dbo_APVConts ON dbo_APVConts.VendorID = dbo_APVendor.VendorID) INNER JOIN EFTCrossTable ON EFTCrossTable.StepOneNumber = dbo_APVendor.VendorAcct ";

            query += "WHERE dbo_APPmtHed.CheckDate = '" + ConvertDateFormatting(dateTimePicker1.Value) + "' AND dbo_APPmtDet.PostedFlag = '" + postedFlagBox.Text + "' ";

            query += "ORDER BY dbo_APPmtHed.CheckNum;";

            return query;
        }

        private void queryButton_Click(object sender, EventArgs e) {
            this.Cursor = Cursors.WaitCursor;

            if (connectRIS == false) {
                connect = new OleDbConnection(OLDBEConnect);
                OleDbCommand command = new OleDbCommand(queryBuilder(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable crossTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(crossTable);

                textFileDGV.DataSource = crossTable;

            } else {
                connect = new OleDbConnection(OLDBEConnectRIS);
                OleDbCommand command = new OleDbCommand(queryBuilder(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);

                DataTable crossTable = new DataTable();

                adapter.SelectCommand = command;

                adapter.Fill(crossTable);

                textFileDGV.DataSource = crossTable;

            }

            checkNumbers.Clear();

            int myindex = 0;

            foreach (DataGridViewColumn col in textFileDGV.Columns) {
                if (col.HeaderText == "CheckNum") {
                    myindex = col.Index;
                    break;
                }
            }

            List<string> checkStrings = new List<string>();

            for (int i = 0; i < textFileDGV.RowCount - 1; i++) {
                if (checkStrings.Contains(textFileDGV.Rows[i].Cells[myindex].Value.ToString())) {
                    continue;
                } else {
                    checkStrings.Add(textFileDGV.Rows[i].Cells[myindex].Value.ToString());
                    checkNumbers.Add(new Checks(i, textFileDGV.Rows[i].Cells[myindex].Value.ToString()));

                }
            }

            creatTxtFile.Visible = true;

            this.Cursor = Cursors.Default;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e) {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void crossTableDGV_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    public class Checks {
        public int index;
        public string checkNumber;

        public Checks(int indexNew, string checkNew) {
            index = indexNew;
            checkNumber = checkNew;
        }
    }
}
