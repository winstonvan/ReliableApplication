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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Reliable
{
    public partial class EmailPayroll : Form
    {

        String ODBCWinTeam = "Provider=sqloledb;Data Source=RMPSRV02\\WINTEAM;Database=WinTeam;User Id=winteamSQLread;Password=Helmet-Clear;";

        OleDbConnection connect = null;

        List<byte[]> byteArrayList = new List<byte[]>();
        
        public EmailPayroll()
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

        private string QueryBuilder()
        {
            string query = null;

            query += "SELECT TOP 1 PDF FROM dbo.tblPAY_Checks_PDFs ORDER BY ID DESC;";

            return query;
        }

        private void queryButton_Click(object sender, EventArgs e)
        {



            //using (OleDbConnection connection = new OleDbConnection(ODBCWinTeam))
            //{
            //    connection.Open();
            //    string query = QueryBuilder();
            //    using (OleDbCommand command = new OleDbCommand(query, connection))
            //    {
            //        using (OleDbDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                MessageBox.Show(reader.GetValue(0).GetType().ToString());
            //                byteArrayList.Add((byte[])reader.GetValue(0));
            //            }
            //        }
            //    }
            //}
            OleDbConnection connection = new OleDbConnection(ODBCWinTeam);

            //try
            //{
                
                OleDbCommand cmdSelect = new OleDbCommand(QueryBuilder(), connection);
                //cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                //cmdSelect.Parameters["@ID"].Value = this.editID.Text;

                connection.Open();
                byte[] barrImg = (byte[])cmdSelect.ExecuteScalar();
                string strfn = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strfn,
                                  FileMode.CreateNew, FileAccess.Write);
                fs.Write(barrImg, 0, barrImg.Length);
                fs.Flush();
                fs.Close();
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = strfn;
            process.Start();
            connection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}


            //connect = new OleDbConnection(ODBCWinTeam);
            //OleDbCommand command = new OleDbCommand(QueryBuilder(), connect);
            //OleDbDataAdapter adapter = new OleDbDataAdapter(command);

            //DataTable pdfData = new DataTable();

            //pdfData.Columns.Add("data", typeof(byte[]));

            //adapter.SelectCommand = command;

            //adapter.Fill(pdfData);

            //pdfData.Rows[0][0].GetType().ToString();

            //MessageBox.Show(pdfData.Rows[0][0].GetType().ToString());
            //MessageBox.Show(pdfData.Rows[0][1].GetType().ToString());

            //byte[] byteArrayIn = (byte[])pdfData.Rows[0][1];

            //MessageBox.Show(byteArrayList[0].Length.ToString());

            ////foreach(byte[] cool in byteArrayList)
            ////{
            ////    foreach(byte little in cool)
            ////    {
            ////        MessageBox.Show(little.ToString());
            ////    }
            ////}

            //byte[] check = new byte[8];

            //for(int i = 0; i < 8; i++)
            //{
            //    check[i] = 80;
            //}

            //MessageBox.Show("CHECK Text");

            //System.Drawing.Image newImage = byteArrayToImage(byteArrayList[0]);


        }

        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            System.Drawing.Image img = (System.Drawing.Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }
        //private static string Bytes2HexString(byte[] buffer)
        //{
        //    var hex = new StringBuilder(buffer.Length * 2);
        //    foreach (byte b in buffer)
        //    {
        //        hex.AppendFormat("{0:x2}", b);
        //    }
        //    return hex.ToString();
        //}


    }

    



}

