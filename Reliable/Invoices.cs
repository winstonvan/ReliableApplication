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
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Excel = Microsoft.Office.Interop.Excel;




namespace Reliable
{
    public partial class Invoices : Form
    {

        String ODBCWinTeam = "Provider=sqloledb;Data Source=RMPSRV01;Database=WinTeam;User Id=winteamSQLread;Password=Helmet-Clear;";

        OleDbConnection connect = null;
        IntPtr dMainWidnow = IntPtr.Zero;
        IntPtr positionWindow = IntPtr.Zero;

        
        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {

        }

        private string QueryBuilder()
        {
            //Generate query to get proper invoice data that sums each month ==> watch for leap years
            string query = null;

            string februaryDays = "28";

            if (Convert.ToInt32(yearTextbox.Text) % 4 == 0)
            {
                februaryDays = "29";
            }

            query += "SELECT tblAR_INVOICES.ServiceLocationJobNumber AS 'Job Number', tblAR_CUSTOMERS.CustomerName AS 'Customer Name', SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '01/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '01/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'January', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '02/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '02/" + februaryDays + "/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'February', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '03/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '03/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'March', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '04/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '04/30/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'April', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '05/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '05/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'May', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '06/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '06/30/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'June', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '07/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '07/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'July', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '08/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '08/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'August', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '09/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '09/30/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'September', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '10/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '10/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'October', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '11/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '11/30/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'November', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '12/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '12/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'December', " +
                "SUM(CASE WHEN tblAR_INVOICES.InvoiceDate >= '01/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.InvoiceDate <= '12/31/" + yearTextbox.Text + "' THEN tblAR_INVOICES.RevenueTotal ELSE 0 END) AS 'TOTAL' ";
            query += "FROM dbo.tblAR_INVOICES INNER JOIN dbo.tblAR_CUSTOMERS ON dbo.tblAR_INVOICES.CustomerNumber = dbo.tblAR_CUSTOMERS.CustomerNumber ";
            query += "WHERE dbo.tblAR_INVOICES.InvoiceDate >= '01/01/" + yearTextbox.Text + "' AND tblAR_INVOICES.ServiceLocationJobNumber != '5008' ";
            query += "GROUP BY tblAR_INVOICES.ServiceLocationJobNumber, tblAR_CUSTOMERS.CustomerName ";
            query += "ORDER BY tblAR_INVOICES.ServiceLocationJobNumber;";



            return query;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //Draw data from winteam database pertaining to invoices

            connect = new OleDbConnection(ODBCWinTeam);
            OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.SelectCommand = command;

            DataTable invoicesTable = new DataTable();

            adapter.Fill(invoicesTable);

            invoicesDGV.DataSource = invoicesTable;

            //Format the data in DGV to look quite nice

            invoicesDGV.Columns[1].Width = 180;

            for (int i = 2; i < 15; i++)
            {
                invoicesDGV.Columns[i].DefaultCellStyle.Format = "C";
                invoicesDGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            this.Cursor = Cursors.Default;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //Close the program
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            //Minimize the current window
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Return to main menu form on click by hiding current form and going to new form ==> Memory being used up unnecessarily?
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Exporting the datagridview data to excel!!

            this.Cursor = Cursors.WaitCursor;

            // Creating an Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            SaveFileDialog saveDialog = new SaveFileDialog();


            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Invoices by Year";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < invoicesDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < invoicesDGV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = invoicesDGV.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Gray);
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Font.Bold = true;

                            if (j == 0)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 11;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 1)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 48;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 2)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 3)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 4)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 5)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 6)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 7)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 8)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 9)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 10)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 11)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 12)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 13)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                            else if (j == 14)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14;
                                worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            }

                        }

                        else if (j == 0)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = invoicesDGV.Rows[i].Cells[j].Value.ToString();
                            worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        }

                        else if (j == 2)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 3)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 4)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 5)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 6)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 7)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 8)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 9)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 10)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 11)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 12)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 13)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 14)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(invoicesDGV.Rows[i].Cells[j].Value).ToString("C");
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);
                        }

                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = invoicesDGV.Rows[i].Cells[j].Value.ToString();
                        }

                        worksheet.Cells[cellRowIndex, cellColumnIndex].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[cellRowIndex, cellColumnIndex].Borders.Weight = 2d;

                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                //Getting the location and file name of the excel to save from user. 


                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx";

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                }

            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                excel.Quit();
                worksheet = null;
                excel = null;

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                process.StartInfo = startInfo;

                startInfo.FileName = saveDialog.FileName;
                process.Start();
            }

            this.Cursor = Cursors.Default;
        }
    }

}
