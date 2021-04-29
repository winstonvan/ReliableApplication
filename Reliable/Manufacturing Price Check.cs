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

namespace Reliable
{
    public partial class Manufacturing_Price_Check : Form
    {

        String OLDBEConnect = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=P:\\CSPRACK\\step1.accdb; Persist Security Info=False;";

        OleDbConnection connect = null;
        public Manufacturing_Price_Check()
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

        public string QueryBuilderNoLoad()
        {
            string query = null;

            query += "SELECT dbo_OBOrdHed.OrderNum, dbo_OBOrdDet.Description, dbo_OBOrdDet.QtyShipped, dbo_OBOrdDet.Price, dbo_OBOrdDet.Amount, dbo_OBOrdDet.PubUnitCost, dbo_OBOrdDet.KitControlFlag, dbo_OBOrdDet.KitComponentFlag, dbo_vInventoryItems.PubUnitCost AS PubunitCost_2, dbo_vInventoryItems.AveUnitCost ";
            query += "FROM (dbo_OBOrdHed INNER JOIN dbo_OBOrdDet ON dbo_OBOrdHed.ARInvcID = dbo_OBOrdDet.ARInvcID) INNER JOIN dbo_vInventoryItems ON dbo_OBOrdDet.ItemID = dbo_vInventoryItems.ItemID ";
            query += "WHERE dbo_OBOrdHed.OrderNum = '" + orderNumberBox.Text + "' AND dbo_vInventoryItems.ItemCode <> 'ZLOAD' ";
            query += "ORDER BY dbo_vInventoryItems.ItemCode DESC;";

            return query;
        }

        public string QueryBuilderWithLoadOnly()
        {
            string query = null;

            query += "SELECT dbo_OBOrdHed.OrderNum, dbo_OBOrdDet.Description, dbo_OBOrdDet.QtyShipped, dbo_OBOrdDet.Price, dbo_OBOrdDet.Amount, dbo_OBOrdDet.PubUnitCost, dbo_OBOrdDet.KitControlFlag, dbo_OBOrdDet.KitComponentFlag, dbo_vInventoryItems.PubUnitCost AS PubunitCost_2, dbo_vInventoryItems.AveUnitCost ";
            query += "FROM (dbo_OBOrdHed INNER JOIN dbo_OBOrdDet ON dbo_OBOrdHed.ARInvcID = dbo_OBOrdDet.ARInvcID) INNER JOIN dbo_vInventoryItems ON dbo_OBOrdDet.ItemID = dbo_vInventoryItems.ItemID ";
            query += "WHERE dbo_OBOrdHed.OrderNum = '" + orderNumberBox.Text + "' AND dbo_vInventoryItems.ItemCode = 'ZLOAD' ";
            query += "ORDER BY dbo_vInventoryItems.ItemCode DESC;";

            return query;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            connect = new OleDbConnection(OLDBEConnect);
            OleDbCommand command = new OleDbCommand(QueryBuilderNoLoad(), connect);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            adapter.SelectCommand = command;

            DataTable manufacturingPriceCheckTable = new DataTable();

            adapter.Fill(manufacturingPriceCheckTable);

            command = new OleDbCommand(QueryBuilderWithLoadOnly(), connect);
            adapter = new OleDbDataAdapter(command);

            adapter.SelectCommand = command;

            DataTable zLoadTable = new DataTable();

            adapter.Fill(zLoadTable);

            for (int i =0; i< manufacturingPriceCheckTable.Columns.Count; i++)
            {
                manufacturingDGV.Columns.Add(manufacturingPriceCheckTable.Columns[i].ColumnName, manufacturingPriceCheckTable.Columns[i].ColumnName);

                if (i == 3 || i == 4 || i == 5 || i == 8 || i == 9)
                {
                    manufacturingDGV.Columns[i].ValueType = typeof(double);
                }
                
            }

            for (int i = 0; i < manufacturingPriceCheckTable.Rows.Count; i++)
            {
                manufacturingDGV.Rows.Add(1);

                for (int j = 0; j < manufacturingPriceCheckTable.Columns.Count; j++)
                {
                    if(j == 3 || j == 4 || j == 5 || j == 8 || j == 9)
                    {
                        manufacturingDGV.Rows[i].Cells[j].Value = Convert.ToDouble(manufacturingPriceCheckTable.Rows[i][j].ToString());
                    }

                    else
                    {
                        manufacturingDGV.Rows[i].Cells[j].Value = manufacturingPriceCheckTable.Rows[i][j].ToString();
                    }

                    if (j == 8)
                    {
                        manufacturingDGV.Rows[i].Cells[j].Style.BackColor = Color.SteelBlue;
                    }
                    else if (j == 9)
                    {
                        manufacturingDGV.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }

                }
            }

            if (zLoadTable.Rows.Count > 0)
            {

                manufacturingDGV.Rows.Add(1);

                for (int i = 0; i < zLoadTable.Columns.Count; i++)
                {

                    if (i == 3 || i == 4 || i == 5 || i == 8 || i == 9)
                    {
                        manufacturingDGV.Rows[manufacturingDGV.Rows.Count - 1].Cells[i].Value = Convert.ToDouble(zLoadTable.Rows[0][i].ToString());
                    }

                    else
                    {
                        manufacturingDGV.Rows[manufacturingDGV.Rows.Count - 1].Cells[i].Value = zLoadTable.Rows[0][i].ToString();
                    }

                    if (i == 8)
                    {
                        manufacturingDGV.Rows[manufacturingDGV.Rows.Count - 1].Cells[i].Style.BackColor = Color.SteelBlue;
                    }
                    else if (i == 9)
                    {
                        manufacturingDGV.Rows[manufacturingDGV.Rows.Count - 1].Cells[i].Style.BackColor = Color.Yellow;
                    }
                }
            }

                

            manufacturingDGV.Columns[0].Width = 70;
            manufacturingDGV.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            manufacturingDGV.Columns[2].Width = 80;
            manufacturingDGV.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            manufacturingDGV.Columns[3].Width = 50;
            manufacturingDGV.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            manufacturingDGV.Columns[3].DefaultCellStyle.Format = "C";

            manufacturingDGV.Columns[4].Width = 80;
            manufacturingDGV.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            manufacturingDGV.Columns[4].DefaultCellStyle.Format = "C";

            manufacturingDGV.Columns[5].Width = 90;
            manufacturingDGV.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            manufacturingDGV.Columns[5].DefaultCellStyle.Format = "C";

            manufacturingDGV.Columns[6].Width = 100;
            manufacturingDGV.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            manufacturingDGV.Columns[7].Width = 100;
            manufacturingDGV.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            manufacturingDGV.Columns[8].Width = 100;
            manufacturingDGV.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            manufacturingDGV.Columns[8].DefaultCellStyle.Format = "C";

            manufacturingDGV.Columns[9].Width = 100;
            manufacturingDGV.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            manufacturingDGV.Columns[9].DefaultCellStyle.Format = "C";

            manufacturingDGV.Columns.Add("Based on Published", "Based on Published");

            manufacturingDGV.Columns.Add("Invoice Costing", "Invoice Costing");

            manufacturingDGV.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            manufacturingDGV.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            for (int i = 2; i<manufacturingDGV.RowCount - 1; i++)
            {
                manufacturingDGV.Rows[i].Cells[10].Value = Convert.ToDouble(manufacturingDGV.Rows[i].Cells[8].Value) * Convert.ToDouble(manufacturingDGV.Rows[i].Cells[2].Value);
                manufacturingDGV.Rows[i].Cells[11].Value = Convert.ToDouble(manufacturingDGV.Rows[i].Cells[9].Value) * Convert.ToDouble(manufacturingDGV.Rows[i].Cells[2].Value);
                manufacturingDGV.Rows[i].Cells[10].Style.BackColor = Color.LightSlateGray;
                manufacturingDGV.Rows[i].Cells[11].Style.BackColor = Color.LightSlateGray;
            }

            manufacturingDGV.Rows.Add(2);

            double basedOnPublished = 0;
            double invoiceCosting = 0;

            for(int i = 0; i < manufacturingDGV.RowCount - 3; i++)
            {
                basedOnPublished += Convert.ToDouble(manufacturingDGV.Rows[i].Cells[10].Value);
                invoiceCosting += Convert.ToDouble(manufacturingDGV.Rows[i].Cells[11].Value);
            }

            manufacturingDGV.Rows[manufacturingDGV.RowCount - 3].Cells[10].Value = basedOnPublished;
            manufacturingDGV.Rows[manufacturingDGV.RowCount - 3].Cells[11].Value = invoiceCosting;
            manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[10].Value = basedOnPublished/Math.Abs(Convert.ToDouble(manufacturingDGV.Rows[0].Cells[2].Value));
            manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[11].Value = invoiceCosting/Math.Abs(Convert.ToDouble(manufacturingDGV.Rows[0].Cells[2].Value));

            if(Math.Abs((basedOnPublished / Math.Abs(Convert.ToDouble(manufacturingDGV.Rows[0].Cells[2].Value))) - (invoiceCosting / Math.Abs(Convert.ToDouble(manufacturingDGV.Rows[0].Cells[2].Value)))) < 0.001)
            {
                manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[10].Style.BackColor = Color.Green;
                manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[11].Style.BackColor = Color.Green;
            }
            else
            {
                manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[10].Style.BackColor = Color.LightPink;
                manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[11].Style.BackColor = Color.LightPink;
            }

            manufacturingDGV.Rows[manufacturingDGV.RowCount - 3].Cells[7].Value = "TOTAL";
            manufacturingDGV.Rows[manufacturingDGV.RowCount - 2].Cells[7].Value = "Price Per Litre";

            this.Cursor = Cursors.Default;

        }
    }
}
