using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Diagnostics;
using System.IO;

namespace Reliable
{
    public partial class transparentBackgroundCheck : Form
    {
        public transparentBackgroundCheck()
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

        private void barcodeButton_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Code128Conversion bCode = new Code128Conversion(barcodeBox.Text);
            bCode.ConvertToCode128();

            StringFormat centreAllignment = new StringFormat();

            centreAllignment.Alignment = StringAlignment.Center;

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddFontFile("c:\\windows\\fonts\\code128.ttf");

            Font codeFont = new Font(pfc.Families[0], (float)Convert.ToDouble(fontSizeBox.Text), System.Drawing.FontStyle.Regular, GraphicsUnit.Pixel);

            Image fakeImage = new Bitmap(1, 1); //As we cannot use CreateGraphics() in a class library, so the fake image is used to load the Graphics.
            Graphics graphics = Graphics.FromImage(fakeImage);
            SizeF size = graphics.MeasureString(bCode.GetBarcode(), codeFont);

            Font textFont = new Font("Helvetica", (float)(Convert.ToDouble(fontSizeBox.Text) / 5.0f), System.Drawing.FontStyle.Regular, GraphicsUnit.Pixel);

            Bitmap bmp = new Bitmap((int)size.Width, codeFont.Height + textFont.Height + 5, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);

            //MessageBox.Show((codeFont.Height + (int)(((float)Convert.ToDouble(fontSizeBox.Text)) / 5.0f) + 5).ToString());

           

            graphics.Flush();
            graphics.Dispose();
            fakeImage.Dispose();

            //MessageBox.Show((((float)(Convert.ToDouble(fontSizeBox.Text))) / 5.0f).ToString());

            //MessageBox.Show((codeFont.Height + 5).ToString());

            

            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.TextRenderingHint = TextRenderingHint.SingleBitPerPixelGridFit;

            if(transparentBackCheck.Checked == true)
            {
                g.Clear(Color.Transparent);
            }

            else
            {
                g.Clear(backgroundColour.Color);
            }


            //System.Windows.Forms.TextRenderer.DrawText(g, bCode.GetBarcode(), codeFont, new Point(0, 0), Color.Aqua);
            //System.Windows.Forms.TextRenderer.DrawText(g, barcodeBox.Text, textFont, new Point(bmp.Width / 2, codeFont.Height + 5), Color.Aqua);
            if (transparentTextCheck.Checked == true)
            {
                g.DrawString(bCode.GetBarcode(), codeFont, new SolidBrush(Color.Transparent), 0, 0);
                g.DrawString(barcodeBox.Text, textFont, new SolidBrush(Color.Transparent), bmp.Width / 2, codeFont.Height + 5, centreAllignment);
            }

            else
            {
                g.DrawString(bCode.GetBarcode(), codeFont, new SolidBrush(textColour.Color), 0, 0);
                g.DrawString(barcodeBox.Text, textFont, new SolidBrush(textColour.Color), bmp.Width / 2, codeFont.Height + 5, centreAllignment);
            }
           

            g.Flush();

            string folderPath = "Z:\\Barcodes\\";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            bmp.Save("Z:\\Barcodes\\" + barcodeBox.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);

            graphics.Dispose();
            fakeImage.Dispose();

            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;

            startInfo.FileName = "Z:\\Barcodes\\" + barcodeBox.Text + ".png";
            process.Start();

            this.Cursor = Cursors.Default;

            

        }

        private void GetDimensions(object sender, PaintEventArgs e)
        {
            
        }

        private void backgroundColourButton_Click(object sender, EventArgs e)
        {
            transparentBackCheck.Checked = false;

            backgroundColour.ShowDialog();

            backgroundColourSample.BackgroundImage = null;

            backgroundColourSample.BackColor = backgroundColour.Color;

        }

        private void transparentBackgroundCheck_Load(object sender, EventArgs e)
        {

            Bitmap myBitmap = new Bitmap(Properties.Resources.Transparent);

            System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

            backgroundColourSample.BackgroundImage = myImage;

            backgroundColourSample.BackgroundImageLayout = ImageLayout.Stretch;

            textColourSample.BackColor = Color.Black;

            transparentBackCheck.Checked = true;


        }

        private void textColourButton_Click(object sender, EventArgs e)
        {
            transparentTextCheck.Checked = false;

            textColourSample.BackgroundImage = null;

            textColour.ShowDialog();

            textColourSample.BackColor = textColour.Color;
        }

        private void transparentTextCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transparentTextCheck.Checked == true)
            {
                Bitmap myBitmap = new Bitmap(Properties.Resources.Transparent);

                System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

                textColourSample.BackgroundImage = myImage;

                textColourSample.BackgroundImageLayout = ImageLayout.Stretch;

            }

            else
            {
                textColourSample.BackgroundImage = null;

                textColourSample.BackColor = Color.Black;
            }
            
        }

        private void transparentBackCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (transparentBackCheck.Checked == true)
            {
                Bitmap myBitmap = new Bitmap(Properties.Resources.Transparent);

                System.Drawing.Image myImage = (System.Drawing.Image)myBitmap;

                backgroundColourSample.BackgroundImage = myImage;

                backgroundColourSample.BackgroundImageLayout = ImageLayout.Stretch;
            }

            else
            {
                backgroundColourSample.BackgroundImage = null;

                backgroundColourSample.BackColor = Color.Black;
            }
        }
    }
}
