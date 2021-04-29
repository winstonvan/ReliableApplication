namespace TestProject
{
    partial class GLListing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GLListing));
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
            this.majorNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.netChange = new System.Windows.Forms.Label();
            this.beginningBalance = new System.Windows.Forms.Label();
            this.endingBalance = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.departmentBox = new System.Windows.Forms.ComboBox();
            this.accountType = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.accountTypes = new System.Windows.Forms.CheckedListBox();
            this.subAccountsList = new System.Windows.Forms.ListBox();
            this.subAcctText = new System.Windows.Forms.Label();
            this.generateSubAccts = new System.Windows.Forms.Button();
            this.glQueryDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerpanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.queryButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.refreshTotal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glQueryDGV)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1386, 24);
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
            this.connectRMPToolStripMenuItem1.Click += new System.EventHandler(this.connectRMPToolStripMenuItem1_Click);
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
            this.connectRISToolStripMenuItem2.Click += new System.EventHandler(this.connectRISToolStripMenuItem2_Click);
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
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.excelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
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
            // majorNumber
            // 
            this.majorNumber.Location = new System.Drawing.Point(94, 120);
            this.majorNumber.Name = "majorNumber";
            this.majorNumber.Size = new System.Drawing.Size(100, 20);
            this.majorNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Major Number:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(641, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start Date:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1171, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date:";
            // 
            // startDate
            // 
            this.startDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDate.Location = new System.Drawing.Point(576, 96);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 5;
            // 
            // endDate
            // 
            this.endDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDate.Location = new System.Drawing.Point(1102, 96);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 20);
            this.endDate.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1201, 620);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Net Change:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1171, 646);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Beginning Balance:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1183, 672);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ending Balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(1264, 666);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 2);
            this.label10.TabIndex = 20;
            // 
            // netChange
            // 
            this.netChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.netChange.BackColor = System.Drawing.Color.Silver;
            this.netChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.netChange.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.netChange.Location = new System.Drawing.Point(1274, 617);
            this.netChange.Name = "netChange";
            this.netChange.Size = new System.Drawing.Size(91, 18);
            this.netChange.TabIndex = 23;
            this.netChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // beginningBalance
            // 
            this.beginningBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.beginningBalance.BackColor = System.Drawing.Color.Silver;
            this.beginningBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.beginningBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.beginningBalance.Location = new System.Drawing.Point(1274, 643);
            this.beginningBalance.Name = "beginningBalance";
            this.beginningBalance.Size = new System.Drawing.Size(91, 18);
            this.beginningBalance.TabIndex = 24;
            this.beginningBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // endingBalance
            // 
            this.endingBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.endingBalance.BackColor = System.Drawing.Color.Silver;
            this.endingBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.endingBalance.Location = new System.Drawing.Point(1274, 672);
            this.endingBalance.Name = "endingBalance";
            this.endingBalance.Size = new System.Drawing.Size(91, 18);
            this.endingBalance.TabIndex = 25;
            this.endingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Department:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(94, 88);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(121, 21);
            this.departmentBox.TabIndex = 27;
            // 
            // accountType
            // 
            this.accountType.AutoSize = true;
            this.accountType.ForeColor = System.Drawing.Color.White;
            this.accountType.Location = new System.Drawing.Point(12, 231);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(131, 17);
            this.accountType.TabIndex = 32;
            this.accountType.Text = "Include Account Type";
            this.accountType.UseVisualStyleBackColor = true;
            this.accountType.CheckedChanged += new System.EventHandler(this.accountType_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "TOTALS:";
            // 
            // accountTypes
            // 
            this.accountTypes.BackColor = System.Drawing.SystemColors.Control;
            this.accountTypes.FormattingEnabled = true;
            this.accountTypes.Items.AddRange(new object[] {
            "Asset",
            "Liability",
            "Capital",
            "Income",
            "Expense"});
            this.accountTypes.Location = new System.Drawing.Point(149, 212);
            this.accountTypes.Name = "accountTypes";
            this.accountTypes.Size = new System.Drawing.Size(120, 49);
            this.accountTypes.TabIndex = 34;
            this.accountTypes.Visible = false;
            // 
            // subAccountsList
            // 
            this.subAccountsList.FormattingEnabled = true;
            this.subAccountsList.Location = new System.Drawing.Point(94, 150);
            this.subAccountsList.Name = "subAccountsList";
            this.subAccountsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.subAccountsList.Size = new System.Drawing.Size(120, 56);
            this.subAccountsList.Sorted = true;
            this.subAccountsList.TabIndex = 35;
            this.subAccountsList.Visible = false;
            // 
            // subAcctText
            // 
            this.subAcctText.AutoSize = true;
            this.subAcctText.ForeColor = System.Drawing.Color.White;
            this.subAcctText.Location = new System.Drawing.Point(12, 172);
            this.subAcctText.Name = "subAcctText";
            this.subAcctText.Size = new System.Drawing.Size(77, 13);
            this.subAcctText.TabIndex = 36;
            this.subAcctText.Text = "Sub Accounts:";
            this.subAcctText.Visible = false;
            // 
            // generateSubAccts
            // 
            this.generateSubAccts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.generateSubAccts.ForeColor = System.Drawing.Color.White;
            this.generateSubAccts.Location = new System.Drawing.Point(217, 120);
            this.generateSubAccts.Name = "generateSubAccts";
            this.generateSubAccts.Size = new System.Drawing.Size(69, 20);
            this.generateSubAccts.TabIndex = 37;
            this.generateSubAccts.Text = "Check";
            this.generateSubAccts.UseVisualStyleBackColor = false;
            this.generateSubAccts.Click += new System.EventHandler(this.generateSubAccts_Click);
            // 
            // glQueryDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.glQueryDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.glQueryDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glQueryDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.glQueryDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.glQueryDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.glQueryDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.glQueryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.glQueryDGV.DoubleBuffered = true;
            this.glQueryDGV.EnableHeadersVisualStyles = false;
            this.glQueryDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.glQueryDGV.HeaderForeColor = System.Drawing.Color.White;
            this.glQueryDGV.Location = new System.Drawing.Point(0, 267);
            this.glQueryDGV.Name = "glQueryDGV";
            this.glQueryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.glQueryDGV.Size = new System.Drawing.Size(1386, 345);
            this.glQueryDGV.TabIndex = 39;
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
            this.headerpanel.Name = "headerpanel";
            this.headerpanel.Size = new System.Drawing.Size(1386, 36);
            this.headerpanel.TabIndex = 40;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(170, 20);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "General Ledger Listing";
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
            this.minimizeButton.Location = new System.Drawing.Point(1306, 3);
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
            this.closeButton.Location = new System.Drawing.Point(1343, 3);
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
            // queryButton
            // 
            this.queryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.queryButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.queryButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.queryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.queryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryButton.ForeColor = System.Drawing.Color.White;
            this.queryButton.Image = ((System.Drawing.Image)(resources.GetObject("queryButton.Image")));
            this.queryButton.ImagePosition = 2;
            this.queryButton.ImageZoom = 70;
            this.queryButton.LabelPosition = 27;
            this.queryButton.LabelText = "Query";
            this.queryButton.Location = new System.Drawing.Point(626, 138);
            this.queryButton.Margin = new System.Windows.Forms.Padding(6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(123, 120);
            this.queryButton.TabIndex = 41;
            this.queryButton.Click += new System.EventHandler(this.runQuery_Click);
            // 
            // refreshTotal
            // 
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
            this.refreshTotal.Location = new System.Drawing.Point(109, 629);
            this.refreshTotal.Name = "refreshTotal";
            this.refreshTotal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.refreshTotal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refreshTotal.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshTotal.selected = false;
            this.refreshTotal.Size = new System.Drawing.Size(208, 56);
            this.refreshTotal.TabIndex = 42;
            this.refreshTotal.Text = "Refresh Totals";
            this.refreshTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshTotal.Textcolor = System.Drawing.Color.White;
            this.refreshTotal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTotal.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // GLListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1386, 697);
            this.Controls.Add(this.refreshTotal);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.glQueryDGV);
            this.Controls.Add(this.generateSubAccts);
            this.Controls.Add(this.subAcctText);
            this.Controls.Add(this.subAccountsList);
            this.Controls.Add(this.accountTypes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.endingBalance);
            this.Controls.Add(this.beginningBalance);
            this.Controls.Add(this.netChange);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.majorNumber);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GLListing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Ledger Listing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GLListing_FormClosing);
            this.Load += new System.EventHandler(this.GLListing_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glQueryDGV)).EndInit();
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
        private System.Windows.Forms.TextBox majorNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label netChange;
        private System.Windows.Forms.Label beginningBalance;
        private System.Windows.Forms.Label endingBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox departmentBox;
        private System.Windows.Forms.CheckBox accountType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox accountTypes;
        private System.Windows.Forms.ListBox subAccountsList;
        private System.Windows.Forms.Label subAcctText;
        private System.Windows.Forms.Button generateSubAccts;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectRMPToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectRISToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid glQueryDGV;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerpanel;
        private Bunifu.Framework.UI.BunifuTileButton queryButton;
        private Bunifu.Framework.UI.BunifuFlatButton refreshTotal;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

