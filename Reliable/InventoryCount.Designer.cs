namespace Reliable
{
    partial class InventoryCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryCount));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.FilterGroup = new System.Windows.Forms.GroupBox();
            this.BinNumberRangeDash = new System.Windows.Forms.Label();
            this.BinNumberList = new System.Windows.Forms.CheckedListBox();
            this.BinNumberRangeEnd = new System.Windows.Forms.TextBox();
            this.BinNumberRangeStart = new System.Windows.Forms.TextBox();
            this.BinNumberCreateField = new System.Windows.Forms.RichTextBox();
            this.subAccountListClear = new System.Windows.Forms.Button();
            this.BinNumberDropdown = new System.Windows.Forms.ComboBox();
            this.WarehouseList = new System.Windows.Forms.CheckedListBox();
            this.majorNumberListClear = new System.Windows.Forms.Button();
            this.BinNumberLabel = new System.Windows.Forms.Label();
            this.WarehouseCreateField = new System.Windows.Forms.RichTextBox();
            this.WarehouseDropdown = new System.Windows.Forms.ComboBox();
            this.WarehouseLabel = new System.Windows.Forms.Label();
            this.IncludeObsoleteAll = new System.Windows.Forms.RadioButton();
            this.IncludeObsoleteWithStock = new System.Windows.Forms.RadioButton();
            this.IncludeObsoleteNo = new System.Windows.Forms.RadioButton();
            this.IncludeObsoleteItems = new System.Windows.Forms.GroupBox();
            this.SortingGroup = new System.Windows.Forms.GroupBox();
            this.SortByItemNumber = new System.Windows.Forms.CheckBox();
            this.SortByBinNumber = new System.Windows.Forms.CheckBox();
            this.MiscellaneousGroup = new System.Windows.Forms.GroupBox();
            this.MiscellaneousAddDatePrinted = new System.Windows.Forms.CheckBox();
            this.MiscellaneousPageNumber = new System.Windows.Forms.CheckBox();
            this.MiscellaneousPageBreak = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FilterGroup.SuspendLayout();
            this.IncludeObsoleteItems.SuspendLayout();
            this.SortingGroup.SuspendLayout();
            this.MiscellaneousGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1001, 36);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(121, 20);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Text = "Inventory Count";
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
            this.minimizeButton.Location = new System.Drawing.Point(921, 3);
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
            this.closeButton.Location = new System.Drawing.Point(958, 3);
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.exportToolStripMenuItem});
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
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.pDFToolStripMenuItem});
            this.exportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
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
            this.queryButton.ImagePosition = 7;
            this.queryButton.ImageZoom = 60;
            this.queryButton.LabelPosition = 27;
            this.queryButton.LabelText = "Query";
            this.queryButton.Location = new System.Drawing.Point(865, 77);
            this.queryButton.Margin = new System.Windows.Forms.Padding(6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(123, 120);
            this.queryButton.TabIndex = 47;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // FilterGroup
            // 
            this.FilterGroup.Controls.Add(this.BinNumberRangeDash);
            this.FilterGroup.Controls.Add(this.BinNumberList);
            this.FilterGroup.Controls.Add(this.BinNumberRangeEnd);
            this.FilterGroup.Controls.Add(this.BinNumberRangeStart);
            this.FilterGroup.Controls.Add(this.BinNumberCreateField);
            this.FilterGroup.Controls.Add(this.subAccountListClear);
            this.FilterGroup.Controls.Add(this.BinNumberDropdown);
            this.FilterGroup.Controls.Add(this.WarehouseList);
            this.FilterGroup.Controls.Add(this.majorNumberListClear);
            this.FilterGroup.Controls.Add(this.BinNumberLabel);
            this.FilterGroup.Controls.Add(this.WarehouseCreateField);
            this.FilterGroup.Controls.Add(this.WarehouseDropdown);
            this.FilterGroup.Controls.Add(this.WarehouseLabel);
            this.FilterGroup.ForeColor = System.Drawing.Color.White;
            this.FilterGroup.Location = new System.Drawing.Point(11, 75);
            this.FilterGroup.Margin = new System.Windows.Forms.Padding(2);
            this.FilterGroup.Name = "FilterGroup";
            this.FilterGroup.Padding = new System.Windows.Forms.Padding(2);
            this.FilterGroup.Size = new System.Drawing.Size(590, 183);
            this.FilterGroup.TabIndex = 67;
            this.FilterGroup.TabStop = false;
            this.FilterGroup.Text = "Filters";
            // 
            // BinNumberRangeDash
            // 
            this.BinNumberRangeDash.ForeColor = System.Drawing.Color.White;
            this.BinNumberRangeDash.Location = new System.Drawing.Point(422, 43);
            this.BinNumberRangeDash.Name = "BinNumberRangeDash";
            this.BinNumberRangeDash.Size = new System.Drawing.Size(35, 23);
            this.BinNumberRangeDash.TabIndex = 72;
            this.BinNumberRangeDash.Text = "-";
            this.BinNumberRangeDash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BinNumberRangeDash.Visible = false;
            // 
            // BinNumberList
            // 
            this.BinNumberList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BinNumberList.CheckOnClick = true;
            this.BinNumberList.FormattingEnabled = true;
            this.BinNumberList.Location = new System.Drawing.Point(301, 46);
            this.BinNumberList.Margin = new System.Windows.Forms.Padding(2);
            this.BinNumberList.Name = "BinNumberList";
            this.BinNumberList.Size = new System.Drawing.Size(278, 90);
            this.BinNumberList.TabIndex = 60;
            // 
            // BinNumberRangeEnd
            // 
            this.BinNumberRangeEnd.Location = new System.Drawing.Point(463, 46);
            this.BinNumberRangeEnd.Name = "BinNumberRangeEnd";
            this.BinNumberRangeEnd.Size = new System.Drawing.Size(117, 20);
            this.BinNumberRangeEnd.TabIndex = 71;
            this.BinNumberRangeEnd.Visible = false;
            // 
            // BinNumberRangeStart
            // 
            this.BinNumberRangeStart.Location = new System.Drawing.Point(303, 46);
            this.BinNumberRangeStart.Name = "BinNumberRangeStart";
            this.BinNumberRangeStart.Size = new System.Drawing.Size(116, 20);
            this.BinNumberRangeStart.TabIndex = 70;
            this.BinNumberRangeStart.Visible = false;
            // 
            // BinNumberCreateField
            // 
            this.BinNumberCreateField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BinNumberCreateField.Location = new System.Drawing.Point(302, 46);
            this.BinNumberCreateField.Margin = new System.Windows.Forms.Padding(2);
            this.BinNumberCreateField.Name = "BinNumberCreateField";
            this.BinNumberCreateField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.BinNumberCreateField.Size = new System.Drawing.Size(278, 90);
            this.BinNumberCreateField.TabIndex = 57;
            this.BinNumberCreateField.Text = "";
            this.BinNumberCreateField.Visible = false;
            // 
            // subAccountListClear
            // 
            this.subAccountListClear.AutoSize = true;
            this.subAccountListClear.BackColor = System.Drawing.SystemColors.Window;
            this.subAccountListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subAccountListClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subAccountListClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.subAccountListClear.Location = new System.Drawing.Point(504, 147);
            this.subAccountListClear.Margin = new System.Windows.Forms.Padding(2);
            this.subAccountListClear.Name = "subAccountListClear";
            this.subAccountListClear.Size = new System.Drawing.Size(75, 25);
            this.subAccountListClear.TabIndex = 58;
            this.subAccountListClear.Text = "Clear";
            this.subAccountListClear.UseVisualStyleBackColor = false;
            // 
            // BinNumberDropdown
            // 
            this.BinNumberDropdown.FormattingEnabled = true;
            this.BinNumberDropdown.Location = new System.Drawing.Point(376, 15);
            this.BinNumberDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.BinNumberDropdown.Name = "BinNumberDropdown";
            this.BinNumberDropdown.Size = new System.Drawing.Size(204, 21);
            this.BinNumberDropdown.TabIndex = 45;
            this.BinNumberDropdown.SelectedIndexChanged += new System.EventHandler(this.BinNumberDropdown_SelectedIndexChanged);
            // 
            // WarehouseList
            // 
            this.WarehouseList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehouseList.CheckOnClick = true;
            this.WarehouseList.FormattingEnabled = true;
            this.WarehouseList.Location = new System.Drawing.Point(11, 46);
            this.WarehouseList.Margin = new System.Windows.Forms.Padding(2);
            this.WarehouseList.Name = "WarehouseList";
            this.WarehouseList.Size = new System.Drawing.Size(278, 90);
            this.WarehouseList.TabIndex = 59;
            // 
            // majorNumberListClear
            // 
            this.majorNumberListClear.AutoSize = true;
            this.majorNumberListClear.BackColor = System.Drawing.SystemColors.Window;
            this.majorNumberListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.majorNumberListClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.majorNumberListClear.ForeColor = System.Drawing.SystemColors.WindowText;
            this.majorNumberListClear.Location = new System.Drawing.Point(214, 147);
            this.majorNumberListClear.Margin = new System.Windows.Forms.Padding(2);
            this.majorNumberListClear.Name = "majorNumberListClear";
            this.majorNumberListClear.Size = new System.Drawing.Size(75, 25);
            this.majorNumberListClear.TabIndex = 49;
            this.majorNumberListClear.Text = "Clear";
            this.majorNumberListClear.UseVisualStyleBackColor = false;
            // 
            // BinNumberLabel
            // 
            this.BinNumberLabel.AutoSize = true;
            this.BinNumberLabel.ForeColor = System.Drawing.Color.White;
            this.BinNumberLabel.Location = new System.Drawing.Point(307, 19);
            this.BinNumberLabel.Name = "BinNumberLabel";
            this.BinNumberLabel.Size = new System.Drawing.Size(62, 13);
            this.BinNumberLabel.TabIndex = 52;
            this.BinNumberLabel.Text = "Bin Number";
            // 
            // WarehouseCreateField
            // 
            this.WarehouseCreateField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WarehouseCreateField.Location = new System.Drawing.Point(11, 46);
            this.WarehouseCreateField.Margin = new System.Windows.Forms.Padding(2);
            this.WarehouseCreateField.Name = "WarehouseCreateField";
            this.WarehouseCreateField.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.WarehouseCreateField.Size = new System.Drawing.Size(278, 90);
            this.WarehouseCreateField.TabIndex = 35;
            this.WarehouseCreateField.Text = "";
            this.WarehouseCreateField.Visible = false;
            // 
            // WarehouseDropdown
            // 
            this.WarehouseDropdown.FormattingEnabled = true;
            this.WarehouseDropdown.Location = new System.Drawing.Point(82, 15);
            this.WarehouseDropdown.Name = "WarehouseDropdown";
            this.WarehouseDropdown.Size = new System.Drawing.Size(207, 21);
            this.WarehouseDropdown.TabIndex = 50;
            this.WarehouseDropdown.SelectedIndexChanged += new System.EventHandler(this.WarehouseDropdown_SelectedIndexChanged);
            // 
            // WarehouseLabel
            // 
            this.WarehouseLabel.AutoSize = true;
            this.WarehouseLabel.ForeColor = System.Drawing.Color.White;
            this.WarehouseLabel.Location = new System.Drawing.Point(9, 19);
            this.WarehouseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WarehouseLabel.Name = "WarehouseLabel";
            this.WarehouseLabel.Size = new System.Drawing.Size(62, 13);
            this.WarehouseLabel.TabIndex = 2;
            this.WarehouseLabel.Text = "Warehouse";
            // 
            // IncludeObsoleteAll
            // 
            this.IncludeObsoleteAll.AutoSize = true;
            this.IncludeObsoleteAll.ForeColor = System.Drawing.Color.White;
            this.IncludeObsoleteAll.Location = new System.Drawing.Point(6, 42);
            this.IncludeObsoleteAll.Name = "IncludeObsoleteAll";
            this.IncludeObsoleteAll.Size = new System.Drawing.Size(109, 17);
            this.IncludeObsoleteAll.TabIndex = 68;
            this.IncludeObsoleteAll.Text = "All Obsolete Items";
            this.IncludeObsoleteAll.UseVisualStyleBackColor = true;
            // 
            // IncludeObsoleteWithStock
            // 
            this.IncludeObsoleteWithStock.AutoSize = true;
            this.IncludeObsoleteWithStock.ForeColor = System.Drawing.Color.White;
            this.IncludeObsoleteWithStock.Location = new System.Drawing.Point(6, 65);
            this.IncludeObsoleteWithStock.Name = "IncludeObsoleteWithStock";
            this.IncludeObsoleteWithStock.Size = new System.Drawing.Size(181, 17);
            this.IncludeObsoleteWithStock.TabIndex = 69;
            this.IncludeObsoleteWithStock.Text = "Only Obsolete Items w/ >0 Stock";
            this.IncludeObsoleteWithStock.UseVisualStyleBackColor = true;
            // 
            // IncludeObsoleteNo
            // 
            this.IncludeObsoleteNo.AutoSize = true;
            this.IncludeObsoleteNo.Checked = true;
            this.IncludeObsoleteNo.ForeColor = System.Drawing.Color.White;
            this.IncludeObsoleteNo.Location = new System.Drawing.Point(6, 19);
            this.IncludeObsoleteNo.Name = "IncludeObsoleteNo";
            this.IncludeObsoleteNo.Size = new System.Drawing.Size(39, 17);
            this.IncludeObsoleteNo.TabIndex = 70;
            this.IncludeObsoleteNo.TabStop = true;
            this.IncludeObsoleteNo.Text = "No";
            this.IncludeObsoleteNo.UseVisualStyleBackColor = true;
            // 
            // IncludeObsoleteItems
            // 
            this.IncludeObsoleteItems.Controls.Add(this.IncludeObsoleteNo);
            this.IncludeObsoleteItems.Controls.Add(this.IncludeObsoleteAll);
            this.IncludeObsoleteItems.Controls.Add(this.IncludeObsoleteWithStock);
            this.IncludeObsoleteItems.ForeColor = System.Drawing.Color.White;
            this.IncludeObsoleteItems.Location = new System.Drawing.Point(615, 75);
            this.IncludeObsoleteItems.Name = "IncludeObsoleteItems";
            this.IncludeObsoleteItems.Size = new System.Drawing.Size(238, 95);
            this.IncludeObsoleteItems.TabIndex = 71;
            this.IncludeObsoleteItems.TabStop = false;
            this.IncludeObsoleteItems.Text = "Include Obsolete Items?";
            // 
            // SortingGroup
            // 
            this.SortingGroup.Controls.Add(this.SortByItemNumber);
            this.SortingGroup.Controls.Add(this.SortByBinNumber);
            this.SortingGroup.ForeColor = System.Drawing.Color.White;
            this.SortingGroup.Location = new System.Drawing.Point(615, 176);
            this.SortingGroup.Name = "SortingGroup";
            this.SortingGroup.Size = new System.Drawing.Size(238, 82);
            this.SortingGroup.TabIndex = 72;
            this.SortingGroup.TabStop = false;
            this.SortingGroup.Text = "Sort By";
            // 
            // SortByItemNumber
            // 
            this.SortByItemNumber.AutoSize = true;
            this.SortByItemNumber.Location = new System.Drawing.Point(6, 43);
            this.SortByItemNumber.Name = "SortByItemNumber";
            this.SortByItemNumber.Size = new System.Drawing.Size(86, 17);
            this.SortByItemNumber.TabIndex = 71;
            this.SortByItemNumber.Text = "Item Number";
            this.SortByItemNumber.UseVisualStyleBackColor = true;
            // 
            // SortByBinNumber
            // 
            this.SortByBinNumber.AutoSize = true;
            this.SortByBinNumber.Location = new System.Drawing.Point(6, 20);
            this.SortByBinNumber.Name = "SortByBinNumber";
            this.SortByBinNumber.Size = new System.Drawing.Size(81, 17);
            this.SortByBinNumber.TabIndex = 70;
            this.SortByBinNumber.Text = "Bin Number";
            this.SortByBinNumber.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousGroup
            // 
            this.MiscellaneousGroup.Controls.Add(this.MiscellaneousAddDatePrinted);
            this.MiscellaneousGroup.Controls.Add(this.MiscellaneousPageNumber);
            this.MiscellaneousGroup.Controls.Add(this.MiscellaneousPageBreak);
            this.MiscellaneousGroup.ForeColor = System.Drawing.Color.White;
            this.MiscellaneousGroup.Location = new System.Drawing.Point(859, 77);
            this.MiscellaneousGroup.Name = "MiscellaneousGroup";
            this.MiscellaneousGroup.Size = new System.Drawing.Size(590, 57);
            this.MiscellaneousGroup.TabIndex = 73;
            this.MiscellaneousGroup.TabStop = false;
            this.MiscellaneousGroup.Text = "Miscellaneous";
            this.MiscellaneousGroup.Visible = false;
            // 
            // MiscellaneousAddDatePrinted
            // 
            this.MiscellaneousAddDatePrinted.AutoSize = true;
            this.MiscellaneousAddDatePrinted.Location = new System.Drawing.Point(6, 43);
            this.MiscellaneousAddDatePrinted.Name = "MiscellaneousAddDatePrinted";
            this.MiscellaneousAddDatePrinted.Size = new System.Drawing.Size(107, 17);
            this.MiscellaneousAddDatePrinted.TabIndex = 72;
            this.MiscellaneousAddDatePrinted.Text = "Add Date Printed";
            this.MiscellaneousAddDatePrinted.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousPageNumber
            // 
            this.MiscellaneousPageNumber.AutoSize = true;
            this.MiscellaneousPageNumber.Location = new System.Drawing.Point(176, 19);
            this.MiscellaneousPageNumber.Name = "MiscellaneousPageNumber";
            this.MiscellaneousPageNumber.Size = new System.Drawing.Size(129, 17);
            this.MiscellaneousPageNumber.TabIndex = 71;
            this.MiscellaneousPageNumber.Text = "Include Page Number";
            this.MiscellaneousPageNumber.UseVisualStyleBackColor = true;
            // 
            // MiscellaneousPageBreak
            // 
            this.MiscellaneousPageBreak.AutoSize = true;
            this.MiscellaneousPageBreak.Location = new System.Drawing.Point(6, 20);
            this.MiscellaneousPageBreak.Name = "MiscellaneousPageBreak";
            this.MiscellaneousPageBreak.Size = new System.Drawing.Size(155, 17);
            this.MiscellaneousPageBreak.TabIndex = 70;
            this.MiscellaneousPageBreak.Text = "Page Break By Bin Number";
            this.MiscellaneousPageBreak.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(842, 355);
            this.dataGridView1.TabIndex = 75;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 634);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1001, 25);
            this.bindingNavigator1.TabIndex = 76;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // InventoryCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1001, 659);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MiscellaneousGroup);
            this.Controls.Add(this.SortingGroup);
            this.Controls.Add(this.IncludeObsoleteItems);
            this.Controls.Add(this.FilterGroup);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarehouseProductLabels";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FilterGroup.ResumeLayout(false);
            this.FilterGroup.PerformLayout();
            this.IncludeObsoleteItems.ResumeLayout(false);
            this.IncludeObsoleteItems.PerformLayout();
            this.SortingGroup.ResumeLayout(false);
            this.SortingGroup.PerformLayout();
            this.MiscellaneousGroup.ResumeLayout(false);
            this.MiscellaneousGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuTileButton queryButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.GroupBox FilterGroup;
        private System.Windows.Forms.CheckedListBox BinNumberList;
        private System.Windows.Forms.RichTextBox BinNumberCreateField;
        private System.Windows.Forms.Button subAccountListClear;
        private System.Windows.Forms.ComboBox BinNumberDropdown;
        private System.Windows.Forms.CheckedListBox WarehouseList;
        private System.Windows.Forms.Button majorNumberListClear;
        private System.Windows.Forms.Label BinNumberLabel;
        private System.Windows.Forms.RichTextBox WarehouseCreateField;
        private System.Windows.Forms.ComboBox WarehouseDropdown;
        private System.Windows.Forms.Label WarehouseLabel;
        private System.Windows.Forms.RadioButton IncludeObsoleteWithStock;
        private System.Windows.Forms.RadioButton IncludeObsoleteAll;
        private System.Windows.Forms.Label BinNumberRangeDash;
        private System.Windows.Forms.TextBox BinNumberRangeEnd;
        private System.Windows.Forms.TextBox BinNumberRangeStart;
        private System.Windows.Forms.RadioButton IncludeObsoleteNo;
        private System.Windows.Forms.GroupBox SortingGroup;
        private System.Windows.Forms.GroupBox IncludeObsoleteItems;
        private System.Windows.Forms.GroupBox MiscellaneousGroup;
        private System.Windows.Forms.CheckBox MiscellaneousAddDatePrinted;
        private System.Windows.Forms.CheckBox MiscellaneousPageNumber;
        private System.Windows.Forms.CheckBox MiscellaneousPageBreak;
        private System.Windows.Forms.CheckBox SortByItemNumber;
        private System.Windows.Forms.CheckBox SortByBinNumber;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
    }
}