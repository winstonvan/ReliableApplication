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
using System.Threading;
using System.Diagnostics;

namespace Reliable
{
    public partial class SalesPricingInfo : Form
    {
        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        BindingSource myBindingSource = new BindingSource();

        SaveFileDialog saveDialog = new SaveFileDialog();

        OleDbConnection connect = null;
        public SalesPricingInfo()
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

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            connect = new OleDbConnection(OLDBEConnect);

            connect.Open();

            OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            DataTable myTable = new DataTable();

            adapter.SelectCommand = command;

            adapter.Fill(myTable);

            inventoryPricingDGV.DataSource = myTable;

            inventoryPricingDGV.Columns[1].Width = 180;

            inventoryPricingDGV.Columns[2].Width = 158;

            inventoryPricingDGV.Columns[3].Width = 140;

            inventoryPricingDGV.Columns[8].Width = 70;


            inventoryPricingDGV.Columns[5].DefaultCellStyle.Format = "C";

            inventoryPricingDGV.Columns[6].DefaultCellStyle.Format = "C";

            inventoryPricingDGV.Columns[7].DefaultCellStyle.Format = "C";

            inventoryPricingDGV.Columns[8].DefaultCellStyle.Format = "C";

            inventoryPricingDGV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            inventoryPricingDGV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            inventoryPricingDGV.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            inventoryPricingDGV.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            inventoryPricingDGV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //decimal value = 0;

            //foreach (DataGridViewRow row in inventoryPricingDGV.Rows)
            //{
            //    if (row.Cells[7].Value.ToString() != "")
            //    {
            //        value = Convert.ToDecimal(row.Cells[7].Value.ToString()) / (decimal)100.00;
            //        row.Cells[7].Value = value.ToString("#0.##%");
            //    }
            //}

            connect.Close();

            this.Cursor = Cursors.Default;
        }

        private string QueryBuilder()
        {
            string query = null;

            query = "SELECT ItemCode AS Item_Number, ItemDescription  AS Description, SupplierName AS Vendor, SupplierPartNum AS Vendor_Part_Number, PriceUnit AS Unit_Measure, StdUnitCost AS Standard_Cost, LastPOCost AS Last_PO_Cost, PubUnitCost AS Published_Cost, ListPrice As List_Price ";

            query += "FROM dbo_vInventoryItems ";

            query += "WHERE ";

            for (int i = 0; i < itemNumbersBox.Lines.Length; i++)
            {

                if (i == 0)
                {
                    query += "ItemCode LIKE '" + itemNumbersBox.Lines[i] + "-%' ";
                }

                else
                {
                    query += "OR ItemCode LIKE '" + itemNumbersBox.Lines[i] + "-%' ";
                }

            }

            query += "ORDER BY ItemCode ASC;";

            return query;
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            // Creating an Excel object. 
            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "Inventory Pricing";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < inventoryPricingDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < inventoryPricingDGV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = inventoryPricingDGV.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                            if (j == 0)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 17;
                            }

                            else if (j == 1)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 35;
                            }

                            else if (j == 2)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 25;
                            }

                            else if (j == 3)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 20;
                            }

                            else if (j == 4)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 12.86;
                            }

                            else if (j == 5)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 13.14;
                            }

                            else if (j == 6)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 12.14;
                            }

                            else if (j == 7)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 14.14;
                            }

                            else if (j == 8)
                            {
                                worksheet.Columns[cellColumnIndex].ColumnWidth = 8.71;
                            }

                        }

                        else if (j == 0)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = inventoryPricingDGV.Rows[i].Cells[j].Value.ToString();
                            worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        }

                        else if (j == 5)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(inventoryPricingDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 6)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(inventoryPricingDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 7)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(inventoryPricingDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else if (j == 8)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(inventoryPricingDGV.Rows[i].Cells[j].Value).ToString("C");
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = inventoryPricingDGV.Rows[i].Cells[j].Value.ToString();
                        }

                        worksheet.Cells[cellRowIndex, cellColumnIndex].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                        worksheet.Cells[cellRowIndex, cellColumnIndex].Borders.Weight = 2d;

                        if (j == 3)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                        }

                        else if (j == 4)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        }

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

