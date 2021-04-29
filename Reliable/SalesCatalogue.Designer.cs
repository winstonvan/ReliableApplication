namespace Reliable
{
    partial class SalesCatalogue
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCatalogue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RMPConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.rISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RISConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerCodeBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.accountNumberCode = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.buttonTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.columnTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.catalogueDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.downButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.upButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.queryButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.generateCatalogueButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.orderByCombobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.buttonTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Catalogue Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.buttonTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(112, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Account Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.buttonTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(130, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Column Type:";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.buttonTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 38);
            this.panel1.TabIndex = 8;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.buttonTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(147, 20);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Order Form Creator";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
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
            this.buttonTransition.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
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
            this.minimizeButton.Location = new System.Drawing.Point(1228, 5);
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
            this.closeButton.ButtonText = "";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransition.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
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
            this.closeButton.Location = new System.Drawing.Point(1265, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.OnHovercolor = System.Drawing.Color.Red;
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(31, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Textcolor = System.Drawing.Color.White;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.buttonTransition.SetDecoration(this.menuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 38);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1308, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseToolStripMenuItem,
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
            this.RMPConnect});
            this.rMPToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rMPToolStripMenuItem.Name = "rMPToolStripMenuItem";
            this.rMPToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rMPToolStripMenuItem.Text = "RMP";
            // 
            // RMPConnect
            // 
            this.RMPConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RMPConnect.ForeColor = System.Drawing.Color.White;
            this.RMPConnect.Name = "RMPConnect";
            this.RMPConnect.Size = new System.Drawing.Size(119, 22);
            this.RMPConnect.Text = "Connect";
            this.RMPConnect.Click += new System.EventHandler(this.RMPConnect_Click);
            // 
            // rISToolStripMenuItem
            // 
            this.rISToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.rISToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RISConnect});
            this.rISToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rISToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.rISToolStripMenuItem.Name = "rISToolStripMenuItem";
            this.rISToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.rISToolStripMenuItem.Text = "RIS";
            // 
            // RISConnect
            // 
            this.RISConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RISConnect.ForeColor = System.Drawing.Color.White;
            this.RISConnect.Name = "RISConnect";
            this.RISConnect.Size = new System.Drawing.Size(119, 22);
            this.RISConnect.Text = "Connect";
            this.RISConnect.Click += new System.EventHandler(this.RISConnect_Click_1);
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click_1);
            // 
            // customerCodeBox
            // 
            this.customerCodeBox.BackColor = System.Drawing.Color.White;
            this.customerCodeBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.customerCodeBox.BorderColorIdle = System.Drawing.Color.Transparent;
            this.customerCodeBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.customerCodeBox.BorderThickness = 3;
            this.customerCodeBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonTransition.SetDecoration(this.customerCodeBox, BunifuAnimatorNS.DecorationType.None);
            this.customerCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.customerCodeBox.ForeColor = System.Drawing.Color.Black;
            this.customerCodeBox.isPassword = false;
            this.customerCodeBox.Location = new System.Drawing.Point(209, 85);
            this.customerCodeBox.Margin = new System.Windows.Forms.Padding(4);
            this.customerCodeBox.Name = "customerCodeBox";
            this.customerCodeBox.Size = new System.Drawing.Size(175, 30);
            this.customerCodeBox.TabIndex = 12;
            this.customerCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // accountNumberCode
            // 
            this.accountNumberCode.BackColor = System.Drawing.Color.White;
            this.accountNumberCode.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.accountNumberCode.BorderColorIdle = System.Drawing.Color.Transparent;
            this.accountNumberCode.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.accountNumberCode.BorderThickness = 3;
            this.accountNumberCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.buttonTransition.SetDecoration(this.accountNumberCode, BunifuAnimatorNS.DecorationType.None);
            this.accountNumberCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.accountNumberCode.ForeColor = System.Drawing.Color.Black;
            this.accountNumberCode.isPassword = false;
            this.accountNumberCode.Location = new System.Drawing.Point(209, 138);
            this.accountNumberCode.Margin = new System.Windows.Forms.Padding(4);
            this.accountNumberCode.Name = "accountNumberCode";
            this.accountNumberCode.Size = new System.Drawing.Size(175, 30);
            this.accountNumberCode.TabIndex = 13;
            this.accountNumberCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // buttonTransition
            // 
            this.buttonTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.buttonTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.buttonTransition.DefaultAnimation = animation1;
            this.buttonTransition.Interval = 1;
            this.buttonTransition.MaxAnimationTime = 500;
            this.buttonTransition.TimeStep = 0.05F;
            // 
            // columnTypeBox
            // 
            this.columnTypeBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Single-Column",
            "Double-Column"});
            this.buttonTransition.SetDecoration(this.columnTypeBox, BunifuAnimatorNS.DecorationType.None);
            this.columnTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTypeBox.FormattingEnabled = true;
            this.columnTypeBox.ItemHeight = 18;
            this.columnTypeBox.Items.AddRange(new object[] {
            "Single-Column",
            "Double-Column"});
            this.columnTypeBox.Location = new System.Drawing.Point(209, 194);
            this.columnTypeBox.Name = "columnTypeBox";
            this.columnTypeBox.Size = new System.Drawing.Size(175, 26);
            this.columnTypeBox.TabIndex = 15;
            this.columnTypeBox.Text = "Single-Column";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.buttonTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Re-order:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.buttonTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 278);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(285, 35);
            this.bunifuSeparator1.TabIndex = 21;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // catalogueDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.catalogueDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.catalogueDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.catalogueDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.catalogueDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.catalogueDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.catalogueDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buttonTransition.SetDecoration(this.catalogueDGV, BunifuAnimatorNS.DecorationType.None);
            this.catalogueDGV.DoubleBuffered = true;
            this.catalogueDGV.EnableHeadersVisualStyles = false;
            this.catalogueDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.catalogueDGV.HeaderForeColor = System.Drawing.Color.White;
            this.catalogueDGV.Location = new System.Drawing.Point(278, 295);
            this.catalogueDGV.Name = "catalogueDGV";
            this.catalogueDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.catalogueDGV.Size = new System.Drawing.Size(1018, 391);
            this.catalogueDGV.TabIndex = 22;
            // 
            // downButton
            // 
            this.downButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.downButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.downButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.downButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransition.SetDecoration(this.downButton, BunifuAnimatorNS.DecorationType.None);
            this.downButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downButton.ForeColor = System.Drawing.Color.White;
            this.downButton.Image = ((System.Drawing.Image)(resources.GetObject("downButton.Image")));
            this.downButton.ImagePosition = 0;
            this.downButton.ImageZoom = 70;
            this.downButton.LabelPosition = 27;
            this.downButton.LabelText = "";
            this.downButton.Location = new System.Drawing.Point(65, 523);
            this.downButton.Margin = new System.Windows.Forms.Padding(6);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(137, 104);
            this.downButton.TabIndex = 19;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.upButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.upButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.upButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransition.SetDecoration(this.upButton, BunifuAnimatorNS.DecorationType.None);
            this.upButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upButton.ForeColor = System.Drawing.Color.White;
            this.upButton.Image = ((System.Drawing.Image)(resources.GetObject("upButton.Image")));
            this.upButton.ImagePosition = 0;
            this.upButton.ImageZoom = 70;
            this.upButton.LabelPosition = 27;
            this.upButton.LabelText = "";
            this.upButton.Location = new System.Drawing.Point(65, 390);
            this.upButton.Margin = new System.Windows.Forms.Padding(6);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(137, 104);
            this.upButton.TabIndex = 18;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // queryButton
            // 
            this.queryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.queryButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.queryButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.queryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransition.SetDecoration(this.queryButton, BunifuAnimatorNS.DecorationType.None);
            this.queryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryButton.ForeColor = System.Drawing.Color.White;
            this.queryButton.Image = ((System.Drawing.Image)(resources.GetObject("queryButton.Image")));
            this.queryButton.ImagePosition = 2;
            this.queryButton.ImageZoom = 70;
            this.queryButton.LabelPosition = 27;
            this.queryButton.LabelText = "Query";
            this.queryButton.Location = new System.Drawing.Point(582, 84);
            this.queryButton.Margin = new System.Windows.Forms.Padding(6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(145, 139);
            this.queryButton.TabIndex = 17;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // generateCatalogueButton
            // 
            this.generateCatalogueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.generateCatalogueButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.generateCatalogueButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.generateCatalogueButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTransition.SetDecoration(this.generateCatalogueButton, BunifuAnimatorNS.DecorationType.None);
            this.generateCatalogueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.generateCatalogueButton.ForeColor = System.Drawing.Color.White;
            this.generateCatalogueButton.Image = ((System.Drawing.Image)(resources.GetObject("generateCatalogueButton.Image")));
            this.generateCatalogueButton.ImagePosition = 10;
            this.generateCatalogueButton.ImageZoom = 65;
            this.generateCatalogueButton.LabelPosition = 26;
            this.generateCatalogueButton.LabelText = "Generate Order Form";
            this.generateCatalogueButton.Location = new System.Drawing.Point(930, 84);
            this.generateCatalogueButton.Margin = new System.Windows.Forms.Padding(6);
            this.generateCatalogueButton.Name = "generateCatalogueButton";
            this.generateCatalogueButton.Size = new System.Drawing.Size(147, 139);
            this.generateCatalogueButton.TabIndex = 14;
            this.generateCatalogueButton.Click += new System.EventHandler(this.generateCatalogueButton_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.buttonTransition.SetDecoration(this.contextMenuStrip1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // orderByCombobox
            // 
            this.orderByCombobox.AutoCompleteCustomSource.AddRange(new string[] {
            "Single-Column",
            "Double-Column"});
            this.buttonTransition.SetDecoration(this.orderByCombobox, BunifuAnimatorNS.DecorationType.None);
            this.orderByCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByCombobox.FormattingEnabled = true;
            this.orderByCombobox.ItemHeight = 18;
            this.orderByCombobox.Items.AddRange(new object[] {
            "Item Number",
            "Item Category"});
            this.orderByCombobox.Location = new System.Drawing.Point(209, 246);
            this.orderByCombobox.Name = "orderByCombobox";
            this.orderByCombobox.Size = new System.Drawing.Size(175, 26);
            this.orderByCombobox.TabIndex = 24;
            this.orderByCombobox.Text = "Item Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.buttonTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Order By:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // SalesCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1308, 698);
            this.Controls.Add(this.orderByCombobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.catalogueDGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.columnTypeBox);
            this.Controls.Add(this.generateCatalogueButton);
            this.Controls.Add(this.accountNumberCode);
            this.Controls.Add(this.customerCodeBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.buttonTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesCatalogue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogue Generator";
            this.Load += new System.EventHandler(this.SalesCatalogue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RMPConnect;
        private System.Windows.Forms.ToolStripMenuItem rISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RISConnect;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox accountNumberCode;
        private Bunifu.Framework.UI.BunifuMetroTextbox customerCodeBox;
        private Bunifu.Framework.UI.BunifuTileButton generateCatalogueButton;
        private BunifuAnimatorNS.BunifuTransition buttonTransition;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ComboBox columnTypeBox;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuTileButton downButton;
        private Bunifu.Framework.UI.BunifuTileButton upButton;
        private Bunifu.Framework.UI.BunifuTileButton queryButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid catalogueDGV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox orderByCombobox;
        private System.Windows.Forms.Label label5;
    }
}