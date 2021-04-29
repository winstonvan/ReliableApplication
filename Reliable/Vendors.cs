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
    public partial class Vendors : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        BindingSource myBindingSource = new BindingSource();

        SaveFileDialog saveDialog = new SaveFileDialog();

        OleDbConnection connect = null;
        public Vendors()
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

                worksheet.Name = "Vendor Pricing";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;

                //Loop through each row and read value from each column. 
                for (int i = -1; i < vendorsDGV.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < vendorsDGV.Columns.Count; j++)
                    {
                        // Excel index starts from 1,1. As first Row would have the Column headers, adding a condition check. 
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Columns[j].HeaderText;
                            worksheet.Cells[cellRowIndex, cellColumnIndex].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                            count = j;

                            switch (count) {

                                case 0:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 17;
                                        break;
                                    }

                                case 1:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 35;
                                        break;
                                    }

                                case 2:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 20;
                                        break;
                                    }

                                case 3:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 15;
                                        break;
                                    }

                                case 4:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 13.14;
                                        break;
                                    }

                                case 5:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 15;
                                        break;
                                    }

                                case 6:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 17.14;
                                        break;
                                    }

                                case 7:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 12.14;
                                        break;
                                    }

                                case 8:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 14.14;
                                        break;
                                    }

                                case 9:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 25.57;
                                        break;
                                    }

                                case 10:
                                    {
                                        worksheet.Columns[cellColumnIndex].ColumnWidth = 8.71;
                                        break;
                                    }

                                default:
                                    {
                                        break;
                                    }
                            }

                        }

                        else {

                            count = j;

                            switch (count)
                            {

                                case 0:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                                        break;
                                    }

                                case 2:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                                        break;
                                    }

                                case 3:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 4:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 6:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Rows[i].Cells[j].Value.ToString();
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 7:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(vendorsDGV.Rows[i].Cells[j].Value).ToString("C");
                                        break;
                                    }

                                case 8:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(vendorsDGV.Rows[i].Cells[j].Value).ToString("C");
                                        break;
                                    }

                                case 9:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(vendorsDGV.Rows[i].Cells[j].Value).ToString(@"#.00\%");
                                        worksheet.Cells[cellRowIndex, cellColumnIndex].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        break;
                                    }

                                case 10:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = Convert.ToDouble(vendorsDGV.Rows[i].Cells[j].Value).ToString("C");
                                        break;
                                    }

                                default:
                                    {
                                        worksheet.Cells[cellRowIndex, cellColumnIndex] = vendorsDGV.Rows[i].Cells[j].Value.ToString();
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

        private void queryButton_Click(object sender, EventArgs e)
        {
            connect = new OleDbConnection(OLDBEConnect);

            if (allVendorsBox.Checked == false)
            {
                OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable vendors = new DataTable();

                adapter.Fill(vendors);

                vendorsDGV.DataSource = vendors;
            }

            else
            {
                OleDbCommand command = new OleDbCommand(QueryBuilderTwo(), connect);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.SelectCommand = command;
                DataTable vendors = new DataTable();

                adapter.Fill(vendors);

                vendorsDGV.DataSource = vendors;
            }

            vendorsDGV.Columns[9].DefaultCellStyle.Format = @"#.00\%";

            vendorsDGV.Columns[7].DefaultCellStyle.Format = "C";

            vendorsDGV.Columns[8].DefaultCellStyle.Format = "C";

            vendorsDGV.Columns[10].DefaultCellStyle.Format = "C";

            vendorsDGV.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            vendorsDGV.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            vendorsDGV.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            vendorsDGV.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            connect.Close();
        }

        private void Vendors_Load(object sender, EventArgs e)
        {
            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand("SELECT SupplierName From dbo_vInventoryItems GROUP BY SupplierName ORDER BY SupplierName;", connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            adapter.SelectCommand = command;
            DataTable vendors = new DataTable();

            adapter.Fill(vendors);

            //LinkedList<string> vendorList = new LinkedList<string>();

            //foreach(DataRow row in vendors.Rows)
            //{
            //    vendorList.AddLast(row[0].ToString());
            //}

            vendorsBox.DataSource = vendors;

            vendorsBox.DisplayMember = "SupplierName";

            connect.Close();
        }

        private string QueryBuilder()
        {
            string query = null;

            query = "SELECT ItemCode AS Item_Number, ItemDescription AS Description, SupplierPartNum AS Vendor_Part_Number, StockUnit AS Item_Stock_Unit, PurchUnit AS Purchase_Unit, Comments2 AS Packaging, PurchStockMult AS Purchase_Multiple, LastPOCost AS Last_PO_Cost, PubUnitCost AS Published_Cost, PubCostPct AS Published_Cost_Percentage, ListPrice As List_Price ";

            query += "FROM dbo_vInventoryItems ";

            query += "WHERE SupplierName = '" + vendorsBox.Text + "' ORDER BY ItemCode;";

            return query;
        }

        private string QueryBuilderTwo()
        {
            string query = null;

            query = "SELECT ItemCode AS Item_Number, ItemDescription AS Description, SupplierPartNum AS Vendor_Part_Number, StockUnit AS Item_Stock_Unit, PurchUnit AS Purchase_Unit, Comments2 AS Packaging, PurchStockMult AS Purchase_Multiple, LastPOCost AS Last_PO_Cost, PubUnitCost AS Published_Cost, PubCostPct AS Published_Cost_Percentage, ListPrice As List_Price, SupplierAcct AS Supplier_Account, SupplierName AS Supplier_Name ";

            query += "FROM dbo_vInventoryItems ";

            query += "ORDER BY SupplierName;";

            return query;
        }

    }

}
