using System;

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
            this.majorNumberLabel = new System.Windows.Forms.Label();
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
            this.glQueryDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerpanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.queryButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.refreshTotal = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dateRangeGroup = new System.Windows.Forms.GroupBox();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.periodDropdown = new System.Windows.Forms.ComboBox();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.accountGroup = new System.Windows.Forms.GroupBox();
            this.subAccountList = new System.Windows.Forms.CheckedListBox();
            this.subAccountCreateField = new System.Windows.Forms.RichTextBox();
            this.subAccountListClear = new System.Windows.Forms.Button();
            this.subAccountDropdown = new System.Windows.Forms.ComboBox();
            this.majorNumberList = new System.Windows.Forms.CheckedListBox();
            this.majorNumberListClear = new System.Windows.Forms.Button();
            this.subAccountLabel = new System.Windows.Forms.Label();
            this.majorNumberCreateField = new System.Windows.Forms.RichTextBox();
            this.majorNumberDropdown = new System.Windows.Forms.ComboBox();
            this.filterGroup = new System.Windows.Forms.GroupBox();
            this.accountTypes = new System.Windows.Forms.CheckedListBox();
            this.accountTypeCheckbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.glQueryDGV)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.dateRangeGroup.SuspendLayout();
            this.accountGroup.SuspendLayout();
            this.filterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
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
            this.connectRMPToolStripMenuItem1.Click += new System.EventHandler(this.ConnectRMPToolStripMenuItem1_Click);
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
            this.connectRISToolStripMenuItem2.Click += new System.EventHandler(this.ConnectRISToolStripMenuItem2_Click);
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
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.excelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
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
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.MainMenuToolStripMenuItem_Click);
            // 
            // majorNumberLabel
            // 
            this.majorNumberLabel.AutoSize = true;
            this.majorNumberLabel.ForeColor = System.Drawing.Color.White;
            this.majorNumberLabel.Location = new System.Drawing.Point(9, 19);
            this.majorNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.majorNumberLabel.Name = "majorNumberLabel";
            this.majorNumberLabel.Size = new System.Drawing.Size(76, 13);
            this.majorNumberLabel.TabIndex = 2;
            this.majorNumberLabel.Text = "Major Number:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(974, 579);
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
            this.label7.Location = new System.Drawing.Point(944, 605);
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
            this.label8.Location = new System.Drawing.Point(956, 631);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ending Balance:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(1036, 626);
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
            this.netChange.Location = new System.Drawing.Point(1047, 576);
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
            this.beginningBalance.Location = new System.Drawing.Point(1047, 602);
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
            this.endingBalance.Location = new System.Drawing.Point(1047, 631);
            this.endingBalance.Name = "endingBalance";
            this.endingBalance.Size = new System.Drawing.Size(91, 18);
            this.endingBalance.TabIndex = 25;
            this.endingBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(10, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Department:";
            // 
            // departmentBox
            // 
            this.departmentBox.FormattingEnabled = true;
            this.departmentBox.Location = new System.Drawing.Point(76, 69);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(110, 21);
            this.departmentBox.TabIndex = 27;
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
            this.glQueryDGV.Location = new System.Drawing.Point(0, 286);
            this.glQueryDGV.Name = "glQueryDGV";
            this.glQueryDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.glQueryDGV.RowHeadersWidth = 25;
            this.glQueryDGV.Size = new System.Drawing.Size(1150, 280);
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
            this.headerpanel.Size = new System.Drawing.Size(1150, 36);
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
            this.minimizeButton.Location = new System.Drawing.Point(1070, 3);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.closeButton.Location = new System.Drawing.Point(1107, 3);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.queryButton.Location = new System.Drawing.Point(1021, 102);
            this.queryButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(120, 179);
            this.queryButton.TabIndex = 41;
            this.queryButton.Click += new System.EventHandler(this.RunQuery_Click);
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
            this.refreshTotal.Location = new System.Drawing.Point(958, 661);
            this.refreshTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.refreshTotal.Name = "refreshTotal";
            this.refreshTotal.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.refreshTotal.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.refreshTotal.OnHoverTextColor = System.Drawing.Color.White;
            this.refreshTotal.selected = false;
            this.refreshTotal.Size = new System.Drawing.Size(180, 27);
            this.refreshTotal.TabIndex = 42;
            this.refreshTotal.Text = "Refresh Totals";
            this.refreshTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.refreshTotal.Textcolor = System.Drawing.Color.White;
            this.refreshTotal.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshTotal.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dateRangeGroup
            // 
            this.dateRangeGroup.Controls.Add(this.endDatePicker);
            this.dateRangeGroup.Controls.Add(this.startDatePicker);
            this.dateRangeGroup.Controls.Add(this.periodDropdown);
            this.dateRangeGroup.Controls.Add(this.endDateLabel);
            this.dateRangeGroup.Controls.Add(this.startDateLabel);
            this.dateRangeGroup.Controls.Add(this.periodLabel);
            this.dateRangeGroup.ForeColor = System.Drawing.Color.White;
            this.dateRangeGroup.Location = new System.Drawing.Point(9, 98);
            this.dateRangeGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateRangeGroup.Name = "dateRangeGroup";
            this.dateRangeGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateRangeGroup.Size = new System.Drawing.Size(182, 98);
            this.dateRangeGroup.TabIndex = 43;
            this.dateRangeGroup.TabStop = false;
            this.dateRangeGroup.Text = "Date Range";
            // 
            // endDatePicker
            // 
            this.endDatePicker.CustomFormat = "  MM/dd/yyyy";
            this.endDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.endDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDatePicker.Location = new System.Drawing.Point(67, 70);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(111, 20);
            this.endDatePicker.TabIndex = 49;
            // 
            // startDatePicker
            // 
            this.startDatePicker.CustomFormat = "  MM/dd/yyyy";
            this.startDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(67, 43);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(111, 20);
            this.startDatePicker.TabIndex = 48;
            // 
            // periodDropdown
            // 
            this.periodDropdown.FormattingEnabled = true;
            this.periodDropdown.Items.AddRange(new object[] {
            "Yesterday",
            "This Week",
            "Last Week",
            "Next Week",
            "This Month",
            "Last Month",
            "Next Month"});
            this.periodDropdown.Location = new System.Drawing.Point(68, 15);
            this.periodDropdown.Name = "periodDropdown";
            this.periodDropdown.Size = new System.Drawing.Size(110, 21);
            this.periodDropdown.TabIndex = 45;
            this.periodDropdown.SelectedIndexChanged += new System.EventHandler(this.PeriodDropdown_SelectedIndexChanged);
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.ForeColor = System.Drawing.Color.White;
            this.endDateLabel.Location = new System.Drawing.Point(12, 75);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 4;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.ForeColor = System.Drawing.Color.White;
            this.startDateLabel.Location = new System.Drawing.Point(10, 46);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Start Date:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.ForeColor = System.Drawing.Color.White;
            this.periodLabel.Location = new System.Drawing.Point(24, 19);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(40, 13);
            this.periodLabel.TabIndex = 45;
            this.periodLabel.Text = "Period:";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(587, 206);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(6, 6);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // accountGroup
            // 
            this.accountGroup.Controls.Add(this.subAccountList);
            this.accountGroup.Controls.Add(this.subAccountCreateField);
            this.accountGroup.Controls.Add(this.subAccountListClear);
            this.accountGroup.Controls.Add(this.subAccountDropdown);
            this.accountGroup.Controls.Add(this.majorNumberList);
            this.accountGroup.Controls.Add(this.majorNumberListClear);
            this.accountGroup.Controls.Add(this.subAccountLabel);
            this.accountGroup.Controls.Add(this.majorNumberCreateField);
            this.accountGroup.Controls.Add(this.majorNumberDropdown);
            this.accountGroup.Controls.Add(this.majorNumberLabel);
            this.accountGroup.ForeColor = System.Drawing.Color.White;
            this.accountGroup.Location = new System.Drawing.Point(196, 98);
            this.accountGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountGroup.Name = "accountGroup";
            this.accountGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountGroup.Size = new System.Drawing.Size(590, 183);
            this.accountGroup.TabIndex = 50;
            this.accountGroup.TabStop = false;
            this.accountGroup.Text = "Account";
            // 
            // subAccountList
            // 
            this.subAccountList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subAccountList.FormattingEnabled = true;
            this.subAccountList.Location = new System.Drawing.Point(302, 46);
            this.subAccountList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subAccountList.Name = "subAccountList";
            this.subAccountList.Size = new System.Drawing.Size(278, 90);
            this.subAccountList.TabIndex = 60;
            // 
            // subAccountCreateField
            // 
            this.subAccountCreateField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subAccountCreateField.Location = new System.Drawing.Point(302, 46);
            this.subAccountCreateField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subAccountCreateField.Name = "subAccountCreateField";
            this.subAccountCreateField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.subAccountCreateField.Size = new System.Drawing.Size(278, 90);
            this.subAccountCreateField.TabIndex = 57;
            this.subAccountCreateField.Text = "";
            this.subAccountCreateField.Visible = false;
            this.subAccountCreateField.TextChanged += new System.EventHandler(this.SubAccountCreateField_TextChanged);
            // 
            // subAccountListClear
            // 
            this.subAccountListClear.AutoSize = true;
            this.subAccountListClear.BackColor = System.Drawing.SystemColors.Window;
            this.subAccountListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subAccountListClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subAccountListClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.subAccountListClear.Location = new System.Drawing.Point(504, 147);
            this.subAccountListClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subAccountListClear.Name = "subAccountListClear";
            this.subAccountListClear.Size = new System.Drawing.Size(75, 25);
            this.subAccountListClear.TabIndex = 58;
            this.subAccountListClear.Text = "Clear";
            this.subAccountListClear.UseVisualStyleBackColor = false;
            this.subAccountListClear.Click += new System.EventHandler(this.SubAccountListClear_Click);
            // 
            // subAccountDropdown
            // 
            this.subAccountDropdown.FormattingEnabled = true;
            this.subAccountDropdown.Location = new System.Drawing.Point(376, 15);
            this.subAccountDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subAccountDropdown.Name = "subAccountDropdown";
            this.subAccountDropdown.Size = new System.Drawing.Size(204, 21);
            this.subAccountDropdown.TabIndex = 45;
            this.subAccountDropdown.SelectedIndexChanged += new System.EventHandler(this.SubAccountDropdown_SelectedIndexChanged);
            // 
            // majorNumberList
            // 
            this.majorNumberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.majorNumberList.FormattingEnabled = true;
            this.majorNumberList.Location = new System.Drawing.Point(11, 46);
            this.majorNumberList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.majorNumberList.Name = "majorNumberList";
            this.majorNumberList.Size = new System.Drawing.Size(278, 90);
            this.majorNumberList.TabIndex = 59;
            this.majorNumberList.SelectedIndexChanged += new System.EventHandler(this.MajorNumberList_SelectedIndexChanged);
            // 
            // majorNumberListClear
            // 
            this.majorNumberListClear.AutoSize = true;
            this.majorNumberListClear.BackColor = System.Drawing.SystemColors.Window;
            this.majorNumberListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.majorNumberListClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.majorNumberListClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.majorNumberListClear.Location = new System.Drawing.Point(214, 147);
            this.majorNumberListClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.majorNumberListClear.Name = "majorNumberListClear";
            this.majorNumberListClear.Size = new System.Drawing.Size(75, 25);
            this.majorNumberListClear.TabIndex = 49;
            this.majorNumberListClear.Text = "Clear";
            this.majorNumberListClear.UseVisualStyleBackColor = false;
            this.majorNumberListClear.Click += new System.EventHandler(this.MajorNumberListClear_Click);
            // 
            // subAccountLabel
            // 
            this.subAccountLabel.AutoSize = true;
            this.subAccountLabel.ForeColor = System.Drawing.Color.White;
            this.subAccountLabel.Location = new System.Drawing.Point(307, 19);
            this.subAccountLabel.Name = "subAccountLabel";
            this.subAccountLabel.Size = new System.Drawing.Size(72, 13);
            this.subAccountLabel.TabIndex = 52;
            this.subAccountLabel.Text = "Sub Account:";
            // 
            // majorNumberCreateField
            // 
            this.majorNumberCreateField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.majorNumberCreateField.Location = new System.Drawing.Point(11, 46);
            this.majorNumberCreateField.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.majorNumberCreateField.Name = "majorNumberCreateField";
            this.majorNumberCreateField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.majorNumberCreateField.Size = new System.Drawing.Size(278, 90);
            this.majorNumberCreateField.TabIndex = 35;
            this.majorNumberCreateField.Text = "";
            this.majorNumberCreateField.Visible = false;
            // 
            // majorNumberDropdown
            // 
            this.majorNumberDropdown.FormattingEnabled = true;
            this.majorNumberDropdown.Location = new System.Drawing.Point(82, 15);
            this.majorNumberDropdown.Name = "majorNumberDropdown";
            this.majorNumberDropdown.Size = new System.Drawing.Size(207, 21);
            this.majorNumberDropdown.TabIndex = 50;
            this.majorNumberDropdown.SelectedIndexChanged += new System.EventHandler(this.MajorNumberDropdown_SelectedIndexChanged);
            // 
            // filterGroup
            // 
            this.filterGroup.Controls.Add(this.accountTypes);
            this.filterGroup.Controls.Add(this.accountTypeCheckbox);
            this.filterGroup.ForeColor = System.Drawing.Color.White;
            this.filterGroup.Location = new System.Drawing.Point(790, 98);
            this.filterGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterGroup.Name = "filterGroup";
            this.filterGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterGroup.Size = new System.Drawing.Size(222, 183);
            this.filterGroup.TabIndex = 57;
            this.filterGroup.TabStop = false;
            this.filterGroup.Text = "Filters";
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
            this.accountTypes.Location = new System.Drawing.Point(4, 39);
            this.accountTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountTypes.Name = "accountTypes";
            this.accountTypes.Size = new System.Drawing.Size(120, 79);
            this.accountTypes.TabIndex = 34;
            this.accountTypes.Visible = false;
            // 
            // accountTypeCheckbox
            // 
            this.accountTypeCheckbox.AutoSize = true;
            this.accountTypeCheckbox.ForeColor = System.Drawing.Color.White;
            this.accountTypeCheckbox.Location = new System.Drawing.Point(4, 18);
            this.accountTypeCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accountTypeCheckbox.Name = "accountTypeCheckbox";
            this.accountTypeCheckbox.Size = new System.Drawing.Size(131, 17);
            this.accountTypeCheckbox.TabIndex = 32;
            this.accountTypeCheckbox.Text = "Include Account Type";
            this.accountTypeCheckbox.UseVisualStyleBackColor = true;
            this.accountTypeCheckbox.CheckedChanged += new System.EventHandler(this.AccountTypeCheckbox_CheckedChanged);
            // 
            // GLListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1150, 697);
            this.Controls.Add(this.filterGroup);
            this.Controls.Add(this.accountGroup);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateRangeGroup);
            this.Controls.Add(this.refreshTotal);
            this.Controls.Add(this.glQueryDGV);
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
            this.dateRangeGroup.ResumeLayout(false);
            this.dateRangeGroup.PerformLayout();
            this.accountGroup.ResumeLayout(false);
            this.accountGroup.PerformLayout();
            this.filterGroup.ResumeLayout(false);
            this.filterGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.Label majorNumberLabel;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox dateRangeGroup;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.ComboBox periodDropdown;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label periodLabel;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.GroupBox accountGroup;
        private System.Windows.Forms.ComboBox majorNumberDropdown;
        private System.Windows.Forms.ComboBox subAccountDropdown;
        private System.Windows.Forms.Label subAccountLabel;
        private System.Windows.Forms.Button majorNumberListClear;
        private System.Windows.Forms.GroupBox filterGroup;
        private System.Windows.Forms.CheckBox accountTypeCheckbox;
        private System.Windows.Forms.RichTextBox majorNumberCreateField;
        private System.Windows.Forms.CheckedListBox accountTypes;
        private System.Windows.Forms.RichTextBox subAccountCreateField;
        private System.Windows.Forms.Button subAccountListClear;
        private System.Windows.Forms.CheckedListBox majorNumberList;
        private System.Windows.Forms.CheckedListBox subAccountList;
    }
}

