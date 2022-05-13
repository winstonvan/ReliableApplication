using System;

namespace TestProject {
    partial class ARForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ARForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectRMPToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectRISToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Total = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.dataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerpanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshTotal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DateLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.GLMajorAcctNumLabel = new System.Windows.Forms.Label();
            this.GLNumberField = new System.Windows.Forms.TextBox();
            this.SelectAllButton = new System.Windows.Forms.Button();
            this.DeselectAllButton = new System.Windows.Forms.Button();
            this.RefreshTotalButton = new System.Windows.Forms.Button();
            this.queryButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 44);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1380, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu_Strip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.mainMenuToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rMPToolStripMenuItem,
            this.rISToolStripMenuItem});
            this.databaseToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // rMPToolStripMenuItem
            // 
            this.rMPToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rMPToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectRMPToolStripMenuItem1});
            this.rMPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rMPToolStripMenuItem.Name = "rMPToolStripMenuItem";
            this.rMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rMPToolStripMenuItem.Text = "RMP";
            // 
            // connectRMPToolStripMenuItem1
            // 
            this.connectRMPToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.connectRMPToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.connectRMPToolStripMenuItem1.Name = "connectRMPToolStripMenuItem1";
            this.connectRMPToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.connectRMPToolStripMenuItem1.Text = "Connect";
            // 
            // rISToolStripMenuItem
            // 
            this.rISToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rISToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectRISToolStripMenuItem2});
            this.rISToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rISToolStripMenuItem.Name = "rISToolStripMenuItem";
            this.rISToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rISToolStripMenuItem.Text = "RIS";
            // 
            // connectRISToolStripMenuItem2
            // 
            this.connectRISToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.connectRISToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.connectRISToolStripMenuItem2.Name = "connectRISToolStripMenuItem2";
            this.connectRISToolStripMenuItem2.Size = new System.Drawing.Size(119, 22);
            this.connectRISToolStripMenuItem2.Text = "Connect";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.excelToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pDFToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.PDFExportButton_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.excelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.ExcelExportButton_Click);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.AutoSize = true;
            this.Total.ForeColor = System.Drawing.Color.White;
            this.Total.Location = new System.Drawing.Point(1098, 524);
            this.Total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(41, 16);
            this.Total.TabIndex = 18;
            this.Total.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(80, 311);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 16);
            this.label9.TabIndex = 19;
            // 
            // TotalAmount
            // 
            this.TotalAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalAmount.BackColor = System.Drawing.Color.Silver;
            this.TotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalAmount.Location = new System.Drawing.Point(1147, 521);
            this.TotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(121, 22);
            this.TotalAmount.TabIndex = 25;
            this.TotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataTable
            // 
            this.dataTable.AllowUserToAddRows = false;
            this.dataTable.AllowUserToDeleteRows = false;
            this.dataTable.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable.DoubleBuffered = true;
            this.dataTable.EnableHeadersVisualStyles = false;
            this.dataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.dataTable.HeaderForeColor = System.Drawing.Color.White;
            this.dataTable.Location = new System.Drawing.Point(0, 121);
            this.dataTable.Margin = new System.Windows.Forms.Padding(4);
            this.dataTable.Name = "dataTable";
            this.dataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTable.RowHeadersVisible = false;
            this.dataTable.RowHeadersWidth = 25;
            this.dataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataTable.Size = new System.Drawing.Size(1380, 387);
            this.dataTable.TabIndex = 39;
            this.dataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // headerpanel
            // 
            this.headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.headerpanel.Controls.Add(this.bunifuCustomLabel2);
            this.headerpanel.Controls.Add(this.minimizeButton);
            this.headerpanel.Controls.Add(this.closeButton);
            this.headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerpanel.Location = new System.Drawing.Point(0, 0);
            this.headerpanel.Margin = new System.Windows.Forms.Padding(4);
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1380, 44);
            this.headerpanel.TabIndex = 40;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 11);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(158, 20);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Accounts Receivable";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Active = false;
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
            this.minimizeButton.Location = new System.Drawing.Point(1273, 4);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.minimizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.minimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.minimizeButton.selected = false;
            this.minimizeButton.Size = new System.Drawing.Size(41, 37);
            this.minimizeButton.TabIndex = 13;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeButton.Textcolor = System.Drawing.Color.White;
            this.minimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Active = false;
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
            this.closeButton.Location = new System.Drawing.Point(1323, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.OnHovercolor = System.Drawing.Color.Red;
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(41, 37);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "gfdsg";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Textcolor = System.Drawing.Color.White;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // refreshTotal
            // 
            this.refreshTotal.Active = false;
            this.refreshTotal.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refreshTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.refreshTotal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshTotal.BorderRadius = 0;
            this.refreshTotal.ButtonText = "Refresh Totals";
            this.refreshTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshTotal.DisabledColor = System.Drawing.Color.Gray;
            this.refreshTotal.Iconcolor = System.Drawing.Color.Transparent;
            this.refreshTotal.Iconimage = null;
            this.refreshTotal.Iconimage_right = null;
            this.refreshTotal.Iconimage_right_Selected = null;
            this.refreshTotal.Iconimage_Selected = null;
            this.refreshTotal.IconMarginLeft = 0;
            this.refreshTotal.IconMarginRight = 0;
            this.refreshTotal.IconRightVisible = true;
            this.refreshTotal.IconRightZoom = 0D;
            this.refreshTotal.IconVisible = true;
            this.refreshTotal.IconZoom = 90D;
            this.refreshTotal.IsTab = false;
            this.refreshTotal.Location = new System.Drawing.Point(1277, 813);
            this.refreshTotal.Margin = new System.Windows.Forms.Padding(5);
            this.refreshTotal.Name = "refreshTotal";
            this.refreshTotal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.refreshTotal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refreshTotal.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshTotal.selected = false;
            this.refreshTotal.Size = new System.Drawing.Size(240, 33);
            this.refreshTotal.TabIndex = 42;
            this.refreshTotal.Text = "Refresh Totals";
            this.refreshTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshTotal.Textcolor = System.Drawing.Color.White;
            this.refreshTotal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateLabel.AutoSize = true;
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(15, 75);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(39, 16);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date:";
            // 
            // DatePicker
            // 
            this.DatePicker.CustomFormat = "  MM/dd/yyyy";
            this.DatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePicker.Location = new System.Drawing.Point(15, 94);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(123, 22);
            this.DatePicker.TabIndex = 48;
            // 
            // GLMajorAcctNumLabel
            // 
            this.GLMajorAcctNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GLMajorAcctNumLabel.AutoSize = true;
            this.GLMajorAcctNumLabel.ForeColor = System.Drawing.Color.White;
            this.GLMajorAcctNumLabel.Location = new System.Drawing.Point(176, 75);
            this.GLMajorAcctNumLabel.Name = "GLMajorAcctNumLabel";
            this.GLMajorAcctNumLabel.Size = new System.Drawing.Size(37, 16);
            this.GLMajorAcctNumLabel.TabIndex = 49;
            this.GLMajorAcctNumLabel.Text = "GL #:";
            // 
            // GLNumberField
            // 
            this.GLNumberField.Location = new System.Drawing.Point(176, 94);
            this.GLNumberField.Name = "GLNumberField";
            this.GLNumberField.Size = new System.Drawing.Size(123, 22);
            this.GLNumberField.TabIndex = 50;
            // 
            // SelectAllButton
            // 
            this.SelectAllButton.Location = new System.Drawing.Point(8, 521);
            this.SelectAllButton.Name = "SelectAllButton";
            this.SelectAllButton.Size = new System.Drawing.Size(98, 23);
            this.SelectAllButton.TabIndex = 52;
            this.SelectAllButton.Text = "Select All";
            this.SelectAllButton.UseVisualStyleBackColor = true;
            this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
            // 
            // DeselectAllButton
            // 
            this.DeselectAllButton.Location = new System.Drawing.Point(112, 521);
            this.DeselectAllButton.Name = "DeselectAllButton";
            this.DeselectAllButton.Size = new System.Drawing.Size(98, 23);
            this.DeselectAllButton.TabIndex = 53;
            this.DeselectAllButton.Text = "Deselect All";
            this.DeselectAllButton.UseVisualStyleBackColor = true;
            this.DeselectAllButton.Click += new System.EventHandler(this.DeselectAllButton_Click);
            // 
            // RefreshTotalButton
            // 
            this.RefreshTotalButton.Location = new System.Drawing.Point(1270, 521);
            this.RefreshTotalButton.Name = "RefreshTotalButton";
            this.RefreshTotalButton.Size = new System.Drawing.Size(98, 23);
            this.RefreshTotalButton.TabIndex = 54;
            this.RefreshTotalButton.Text = "Refresh Total";
            this.RefreshTotalButton.UseVisualStyleBackColor = true;
            this.RefreshTotalButton.Click += new System.EventHandler(this.RefreshTotalButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.queryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.queryButton.ForeColor = System.Drawing.SystemColors.Window;
            this.queryButton.Location = new System.Drawing.Point(1262, 75);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(106, 41);
            this.queryButton.TabIndex = 55;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = false;
            this.queryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // ARForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1380, 556);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.RefreshTotalButton);
            this.Controls.Add(this.DeselectAllButton);
            this.Controls.Add(this.SelectAllButton);
            this.Controls.Add(this.GLNumberField);
            this.Controls.Add(this.GLMajorAcctNumLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.refreshTotal);
            this.Controls.Add(this.dataTable);
            this.Controls.Add(this.TotalAmount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ARForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Ledger Listing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GLListing_FormClosing);
            this.Load += new System.EventHandler(this.GlNumberField_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectRMPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectRISToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataTable;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerpanel;
        private Bunifu.Framework.UI.BunifuFlatButton refreshTotal;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox GLNumberField;
        private System.Windows.Forms.Label GLMajorAcctNumLabel;
        private System.Windows.Forms.Button SelectAllButton;
        private System.Windows.Forms.Button DeselectAllButton;
        private System.Windows.Forms.Button RefreshTotalButton;
        private System.Windows.Forms.Button queryButton;
    }
}

