namespace Reliable
{
    partial class WarehouseMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.countSheetsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.showroomLabelsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.warehouseLabelsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.barcodeGeneratorButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.shippingLabelsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 36);
            this.panel1.TabIndex = 2;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(135, 20);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Warehouse Menu";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.BorderRadius = 0;
            this.minimizeButton.ButtonText = "";
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.DisabledColor = System.Drawing.Color.Gray;
            this.minimizeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.minimizeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Iconimage")));
            this.minimizeButton.Iconimage_right = null;
            this.minimizeButton.Iconimage_right_Selected = null;
            this.minimizeButton.Iconimage_Selected = null;
            this.minimizeButton.IconMarginLeft = 0;
            this.minimizeButton.IconMarginRight = 0;
            this.minimizeButton.IconRightVisible = true;
            this.minimizeButton.IconRightZoom = 0D;
            this.minimizeButton.IconVisible = true;
            this.minimizeButton.IconZoom = 50D;
            this.minimizeButton.IsTab = false;
            this.minimizeButton.Location = new System.Drawing.Point(655, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.minimizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.minimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.minimizeButton.selected = false;
            this.minimizeButton.Size = new System.Drawing.Size(31, 30);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeButton.Textcolor = System.Drawing.Color.White;
            this.minimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.BorderRadius = 0;
            this.closeButton.ButtonText = "gfdsg";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.DisabledColor = System.Drawing.Color.Gray;
            this.closeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.closeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("closeButton.Iconimage")));
            this.closeButton.Iconimage_right = null;
            this.closeButton.Iconimage_right_Selected = null;
            this.closeButton.Iconimage_Selected = null;
            this.closeButton.IconMarginLeft = 0;
            this.closeButton.IconMarginRight = 0;
            this.closeButton.IconRightVisible = true;
            this.closeButton.IconRightZoom = 0D;
            this.closeButton.IconVisible = true;
            this.closeButton.IconZoom = 50D;
            this.closeButton.IsTab = false;
            this.closeButton.Location = new System.Drawing.Point(692, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.OnHovercolor = System.Drawing.Color.Red;
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(31, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "gfdsg";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Textcolor = System.Drawing.Color.White;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // countSheetsButton
            // 
            this.countSheetsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.countSheetsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.countSheetsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countSheetsButton.BorderRadius = 0;
            this.countSheetsButton.ButtonText = "Count Sheets";
            this.countSheetsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countSheetsButton.DisabledColor = System.Drawing.Color.Gray;
            this.countSheetsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.countSheetsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("countSheetsButton.Iconimage")));
            this.countSheetsButton.Iconimage_right = null;
            this.countSheetsButton.Iconimage_right_Selected = null;
            this.countSheetsButton.Iconimage_Selected = null;
            this.countSheetsButton.IconMarginLeft = 0;
            this.countSheetsButton.IconMarginRight = 0;
            this.countSheetsButton.IconRightVisible = true;
            this.countSheetsButton.IconRightZoom = 0D;
            this.countSheetsButton.IconVisible = true;
            this.countSheetsButton.IconZoom = 90D;
            this.countSheetsButton.IsTab = false;
            this.countSheetsButton.Location = new System.Drawing.Point(404, 96);
            this.countSheetsButton.Name = "countSheetsButton";
            this.countSheetsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.countSheetsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.countSheetsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.countSheetsButton.selected = false;
            this.countSheetsButton.Size = new System.Drawing.Size(241, 48);
            this.countSheetsButton.TabIndex = 52;
            this.countSheetsButton.Text = "Count Sheets";
            this.countSheetsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countSheetsButton.Textcolor = System.Drawing.Color.White;
            this.countSheetsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countSheetsButton.Click += new System.EventHandler(this.countSheetsButton_Click);
            // 
            // showroomLabelsButton
            // 
            this.showroomLabelsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showroomLabelsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.showroomLabelsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showroomLabelsButton.BorderRadius = 0;
            this.showroomLabelsButton.ButtonText = "Showroom Labels";
            this.showroomLabelsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showroomLabelsButton.DisabledColor = System.Drawing.Color.Gray;
            this.showroomLabelsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.showroomLabelsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("showroomLabelsButton.Iconimage")));
            this.showroomLabelsButton.Iconimage_right = null;
            this.showroomLabelsButton.Iconimage_right_Selected = null;
            this.showroomLabelsButton.Iconimage_Selected = null;
            this.showroomLabelsButton.IconMarginLeft = 0;
            this.showroomLabelsButton.IconMarginRight = 0;
            this.showroomLabelsButton.IconRightVisible = true;
            this.showroomLabelsButton.IconRightZoom = 0D;
            this.showroomLabelsButton.IconVisible = true;
            this.showroomLabelsButton.IconZoom = 90D;
            this.showroomLabelsButton.IsTab = false;
            this.showroomLabelsButton.Location = new System.Drawing.Point(68, 182);
            this.showroomLabelsButton.Name = "showroomLabelsButton";
            this.showroomLabelsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.showroomLabelsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showroomLabelsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.showroomLabelsButton.selected = false;
            this.showroomLabelsButton.Size = new System.Drawing.Size(241, 48);
            this.showroomLabelsButton.TabIndex = 51;
            this.showroomLabelsButton.Text = "Showroom Labels";
            this.showroomLabelsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.showroomLabelsButton.Textcolor = System.Drawing.Color.White;
            this.showroomLabelsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showroomLabelsButton.Click += new System.EventHandler(this.showroomLabelsButton_Click);
            // 
            // warehouseLabelsButton
            // 
            this.warehouseLabelsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.warehouseLabelsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.warehouseLabelsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warehouseLabelsButton.BorderRadius = 0;
            this.warehouseLabelsButton.ButtonText = "Warehouse Labels";
            this.warehouseLabelsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warehouseLabelsButton.DisabledColor = System.Drawing.Color.Gray;
            this.warehouseLabelsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.warehouseLabelsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("warehouseLabelsButton.Iconimage")));
            this.warehouseLabelsButton.Iconimage_right = null;
            this.warehouseLabelsButton.Iconimage_right_Selected = null;
            this.warehouseLabelsButton.Iconimage_Selected = null;
            this.warehouseLabelsButton.IconMarginLeft = 0;
            this.warehouseLabelsButton.IconMarginRight = 0;
            this.warehouseLabelsButton.IconRightVisible = true;
            this.warehouseLabelsButton.IconRightZoom = 0D;
            this.warehouseLabelsButton.IconVisible = true;
            this.warehouseLabelsButton.IconZoom = 90D;
            this.warehouseLabelsButton.IsTab = false;
            this.warehouseLabelsButton.Location = new System.Drawing.Point(68, 96);
            this.warehouseLabelsButton.Name = "warehouseLabelsButton";
            this.warehouseLabelsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.warehouseLabelsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.warehouseLabelsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.warehouseLabelsButton.selected = false;
            this.warehouseLabelsButton.Size = new System.Drawing.Size(241, 48);
            this.warehouseLabelsButton.TabIndex = 50;
            this.warehouseLabelsButton.Text = "Warehouse Labels";
            this.warehouseLabelsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.warehouseLabelsButton.Textcolor = System.Drawing.Color.White;
            this.warehouseLabelsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseLabelsButton.Click += new System.EventHandler(this.warehouseLabelsButton_Click);
            // 
            // barcodeGeneratorButton
            // 
            this.barcodeGeneratorButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.barcodeGeneratorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barcodeGeneratorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.barcodeGeneratorButton.BorderRadius = 0;
            this.barcodeGeneratorButton.ButtonText = "Barcode Generator";
            this.barcodeGeneratorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barcodeGeneratorButton.DisabledColor = System.Drawing.Color.Gray;
            this.barcodeGeneratorButton.Iconcolor = System.Drawing.Color.Transparent;
            this.barcodeGeneratorButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("barcodeGeneratorButton.Iconimage")));
            this.barcodeGeneratorButton.Iconimage_right = null;
            this.barcodeGeneratorButton.Iconimage_right_Selected = null;
            this.barcodeGeneratorButton.Iconimage_Selected = null;
            this.barcodeGeneratorButton.IconMarginLeft = 0;
            this.barcodeGeneratorButton.IconMarginRight = 0;
            this.barcodeGeneratorButton.IconRightVisible = true;
            this.barcodeGeneratorButton.IconRightZoom = 0D;
            this.barcodeGeneratorButton.IconVisible = true;
            this.barcodeGeneratorButton.IconZoom = 90D;
            this.barcodeGeneratorButton.IsTab = false;
            this.barcodeGeneratorButton.Location = new System.Drawing.Point(404, 182);
            this.barcodeGeneratorButton.Name = "barcodeGeneratorButton";
            this.barcodeGeneratorButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barcodeGeneratorButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.barcodeGeneratorButton.OnHoverTextColor = System.Drawing.Color.White;
            this.barcodeGeneratorButton.selected = false;
            this.barcodeGeneratorButton.Size = new System.Drawing.Size(241, 48);
            this.barcodeGeneratorButton.TabIndex = 53;
            this.barcodeGeneratorButton.Text = "Barcode Generator";
            this.barcodeGeneratorButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.barcodeGeneratorButton.Textcolor = System.Drawing.Color.White;
            this.barcodeGeneratorButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeGeneratorButton.Click += new System.EventHandler(this.barcodeGeneratorButton_Click);
            // 
            // shippingLabelsButton
            // 
            this.shippingLabelsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.shippingLabelsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.shippingLabelsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.shippingLabelsButton.BorderRadius = 0;
            this.shippingLabelsButton.ButtonText = "Shipping Labels";
            this.shippingLabelsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shippingLabelsButton.DisabledColor = System.Drawing.Color.Gray;
            this.shippingLabelsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.shippingLabelsButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("shippingLabelsButton.Iconimage")));
            this.shippingLabelsButton.Iconimage_right = null;
            this.shippingLabelsButton.Iconimage_right_Selected = null;
            this.shippingLabelsButton.Iconimage_Selected = null;
            this.shippingLabelsButton.IconMarginLeft = 0;
            this.shippingLabelsButton.IconMarginRight = 0;
            this.shippingLabelsButton.IconRightVisible = true;
            this.shippingLabelsButton.IconRightZoom = 0D;
            this.shippingLabelsButton.IconVisible = true;
            this.shippingLabelsButton.IconZoom = 90D;
            this.shippingLabelsButton.IsTab = false;
            this.shippingLabelsButton.Location = new System.Drawing.Point(68, 267);
            this.shippingLabelsButton.Name = "shippingLabelsButton";
            this.shippingLabelsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.shippingLabelsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.shippingLabelsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.shippingLabelsButton.selected = false;
            this.shippingLabelsButton.Size = new System.Drawing.Size(241, 48);
            this.shippingLabelsButton.TabIndex = 54;
            this.shippingLabelsButton.Text = "Shipping Labels";
            this.shippingLabelsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shippingLabelsButton.Textcolor = System.Drawing.Color.White;
            this.shippingLabelsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shippingLabelsButton.Click += new System.EventHandler(this.shippingLabelsButton_Click);
            // 
            // WarehouseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(735, 358);
            this.Controls.Add(this.shippingLabelsButton);
            this.Controls.Add(this.barcodeGeneratorButton);
            this.Controls.Add(this.countSheetsButton);
            this.Controls.Add(this.showroomLabelsButton);
            this.Controls.Add(this.warehouseLabelsButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarehouseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton showroomLabelsButton;
        private Bunifu.Framework.UI.BunifuFlatButton warehouseLabelsButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton countSheetsButton;
        private Bunifu.Framework.UI.BunifuFlatButton barcodeGeneratorButton;
        private Bunifu.Framework.UI.BunifuFlatButton shippingLabelsButton;
    }
}