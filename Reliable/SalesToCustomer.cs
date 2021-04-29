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
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace Reliable
{

    public partial class SalesToCustomer : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        BindingSource myBindingSource = new BindingSource();

        SaveFileDialog saveDialog = new SaveFileDialog();

        OleDbConnection connect = null;
        public SalesToCustomer()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormState.PreviousPage.Show();

            this.Hide();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            connect = new OleDbConnection(OLDBEConnect);


            OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.SelectCommand = command;
            DataTable vendors = new DataTable();

            adapter.Fill(vendors);

            customerSalesDGV.DataSource = vendors;

            customerSalesDGV.Columns[6].DefaultCellStyle.Format = "C";

            customerSalesDGV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            customerSalesDGV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            customerSalesDGV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            customerSalesDGV.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            connect.Close();

        }

        private string QueryBuilder()
        {
            string query = null;

            query = "SELECT ItemCode AS Item_Number, Description, CustPONum AS PO_Number, InvoiceNum AS Invoice_Number, InvoiceDate AS Invoice_Date, QtyShipped AS Quantity_Shipped, Price AS Selling_Price, PriceUnit AS Price_Unit ";

            query += "FROM dbo_vCustomerInvoiceDetail ";

            query += "WHERE InvoiceDate >= '" + ConvertDateFormatting(startDate.Value) + "' AND InvoiceDate <= '" + ConvertDateFormatting(endDate.Value) + "' AND CustAcct = '" + accountNumberBox.Text + "' AND ItemCode IS NOT NULL ORDER BY InvoiceDate;";

            return query;
        }

        private string ConvertDateFormatting(DateTime myDate)
        {
            string newDate = null;
            string tempMonth = null;
            string tempDay = null;


            if (myDate.Month <= 9)
            {
                tempMonth = "0" + myDate.Month.ToString();
            }

            else
            {
                tempMonth = myDate.Month.ToString();
            }



            if (myDate.Day <= 9)
            {
                tempDay = "0" + myDate.Day.ToString();
            }

            else
            {
                tempDay = myDate.Day.ToString();
            }

            newDate = myDate.Year.ToString() + "-" + tempMonth + "-" + tempDay;

            return newDate;
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            int count = 0;

            // Creating an Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Sales to Customer";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < customerSalesDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < customerSalesDGV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                            count = j;

                            switch (count)
                            {

                                case 0:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 15;
                                        break;
                                    }

                                case 1:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 35;
                                        break;
                                    }

                                case 2:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 17;
                                        break;
                                    }

                                case 3:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 15.14;
                                        break;
                                    }

                                case 4:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 11.86;
                                        break;
                                    }

                                case 5:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 16.57;
                                        break;
                                    }

                                case 6:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 11.71;
                                        break;
                                    }

                                case 7:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 9.43;
                                        break;
                                    }

                                default:
                                    {
                                        break;
                                    }
                            }

                        }

                        else
                        {

                            count = j;

                            switch (count)
                            {

                                case 0:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                                        break;
                                    }

                                case 2:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 3:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 4:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 5:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 6:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(customerSalesDGV.Rows[i].Cells[j].Value).ToString("C");
                                        break;
                                    }

                                case 7:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                default:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = customerSalesDGV.Rows[i].Cells[j].Value.ToString();
                                        break;
                                    }
                            }
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

        private void SalesToCustomer_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand("SELECT CustAcct From dbo_vCustomerInvoiceDetail GROUP BY CustAcct ORDER BY CustAcct;", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.SelectCommand = command;
            DataTable customers = new DataTable();

            adapter.Fill(customers);

            //LinkedList<string> vendorList = new LinkedList<string>();

            //foreach(DataRow row in vendors.Rows)
            //{
            //    vendorList.AddLast(row[0].ToString());
            //}

            accountNumberBox.DataSource = customers;

            accountNumberBox.DisplayMember = "CustAcct";

            accountNumberBox.Text = "(Select an Account Number)";

            connect.Close();
        }
    }
}
