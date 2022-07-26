using System;
using System.Windows.Forms;

namespace TestProject
{
    partial class OrderDeskInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDeskInvoices));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.DataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerpanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FilterListCreate = new System.Windows.Forms.RichTextBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.periodLabel = new System.Windows.Forms.Label();
            this.PeriodDropdown = new System.Windows.Forms.ComboBox();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FilterList = new System.Windows.Forms.CheckedListBox();
            this.FilterDropdown = new System.Windows.Forms.ComboBox();
            this.NoneRadioButton = new System.Windows.Forms.RadioButton();
            this.PriceClassRadioButton = new System.Windows.Forms.RadioButton();
            this.DateGroup = new System.Windows.Forms.GroupBox();
            this.FiltersGroup = new System.Windows.Forms.GroupBox();
            this.InvoiceNumberCheckbox = new System.Windows.Forms.CheckBox();
            this.InvoiceNumberField = new System.Windows.Forms.TextBox();
            this.CustomerNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.ItemNumberCheckbox = new System.Windows.Forms.CheckBox();
            this.ItemNumberField = new System.Windows.Forms.TextBox();
            this.ItemNumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.InvoiceNumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.DateGroup.SuspendLayout();
            this.FiltersGroup.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu_Strip";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 19;
            // 
            // DataTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.DoubleBuffered = true;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DataTable.HeaderForeColor = System.Drawing.Color.White;
            this.DataTable.Location = new System.Drawing.Point(0, 395);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataTable.RowHeadersWidth = 25;
            this.DataTable.Size = new System.Drawing.Size(1036, 300);
            this.DataTable.TabIndex = 39;
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
            this.headerpanel.Size = new System.Drawing.Size(1036, 36);
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
            this.bunifuCustomLabel2.Text = "Order Desk Invoices";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FilterListCreate
            // 
            this.FilterListCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilterListCreate.Location = new System.Drawing.Point(90, 42);
            this.FilterListCreate.Margin = new System.Windows.Forms.Padding(2);
            this.FilterListCreate.Name = "FilterListCreate";
            this.FilterListCreate.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.FilterListCreate.Size = new System.Drawing.Size(278, 150);
            this.FilterListCreate.TabIndex = 67;
            this.FilterListCreate.Text = "";
            this.FilterListCreate.Visible = false;
            // 
            // QueryButton
            // 
            this.QueryButton.AutoSize = true;
            this.QueryButton.BackColor = System.Drawing.SystemColors.Window;
            this.QueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.QueryButton.Location = new System.Drawing.Point(527, 352);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(2);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(75, 25);
            this.QueryButton.TabIndex = 49;
            this.QueryButton.Text = "Query";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // endDateLabel
            // 
            this.endDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.ForeColor = System.Drawing.Color.White;
            this.endDateLabel.Location = new System.Drawing.Point(7, 73);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(55, 13);
            this.endDateLabel.TabIndex = 75;
            this.endDateLabel.Text = "End Date:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.ForeColor = System.Drawing.Color.White;
            this.startDateLabel.Location = new System.Drawing.Point(5, 45);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(58, 13);
            this.startDateLabel.TabIndex = 74;
            this.startDateLabel.Text = "Start Date:";
            // 
            // periodLabel
            // 
            this.periodLabel.AutoSize = true;
            this.periodLabel.ForeColor = System.Drawing.Color.White;
            this.periodLabel.Location = new System.Drawing.Point(19, 17);
            this.periodLabel.Name = "periodLabel";
            this.periodLabel.Size = new System.Drawing.Size(40, 13);
            this.periodLabel.TabIndex = 76;
            this.periodLabel.Text = "Period:";
            // 
            // PeriodDropdown
            // 
            this.PeriodDropdown.FormattingEnabled = true;
            this.PeriodDropdown.Items.AddRange(new object[] {
            "All",
            "Yesterday",
            "This Week",
            "Last Week",
            "This Month",
            "Last Month",
            "Custom"});
            this.PeriodDropdown.Location = new System.Drawing.Point(66, 15);
            this.PeriodDropdown.Name = "PeriodDropdown";
            this.PeriodDropdown.Size = new System.Drawing.Size(110, 21);
            this.PeriodDropdown.TabIndex = 71;
            this.PeriodDropdown.SelectedIndexChanged += new System.EventHandler(this.periodDropdown_SelectedIndexChanged);
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.BackColor = System.Drawing.Color.DarkGray;
            this.EndDatePicker.CustomFormat = "  MM/dd/yyyy";
            this.EndDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndDatePicker.Location = new System.Drawing.Point(65, 69);
            this.EndDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(111, 20);
            this.EndDatePicker.TabIndex = 73;
            this.EndDatePicker.Enter += new System.EventHandler(this.EndDatePicker_Enter);
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.BackColor = System.Drawing.Color.DarkGray;
            this.StartDatePicker.CustomFormat = "  MM/dd/yyyy";
            this.StartDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(65, 42);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(2);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(111, 20);
            this.StartDatePicker.TabIndex = 72;
            this.StartDatePicker.Enter += new System.EventHandler(this.StartDatePicker_Enter);
            // 
            // FilterList
            // 
            this.FilterList.BackColor = System.Drawing.Color.DarkGray;
            this.FilterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilterList.CheckOnClick = true;
            this.FilterList.Enabled = false;
            this.FilterList.FormattingEnabled = true;
            this.FilterList.Location = new System.Drawing.Point(90, 42);
            this.FilterList.Margin = new System.Windows.Forms.Padding(2);
            this.FilterList.Name = "FilterList";
            this.FilterList.Size = new System.Drawing.Size(278, 150);
            this.FilterList.TabIndex = 66;
            // 
            // FilterDropdown
            // 
            this.FilterDropdown.BackColor = System.Drawing.Color.White;
            this.FilterDropdown.Enabled = false;
            this.FilterDropdown.FormattingEnabled = true;
            this.FilterDropdown.Location = new System.Drawing.Point(90, 16);
            this.FilterDropdown.Name = "FilterDropdown";
            this.FilterDropdown.Size = new System.Drawing.Size(279, 21);
            this.FilterDropdown.TabIndex = 65;
            this.FilterDropdown.SelectedIndexChanged += new System.EventHandler(this.FilterDropdown_SelectedIndexChanged);
            // 
            // NoneRadioButton
            // 
            this.NoneRadioButton.AutoSize = true;
            this.NoneRadioButton.Checked = true;
            this.NoneRadioButton.ForeColor = System.Drawing.Color.White;
            this.NoneRadioButton.Location = new System.Drawing.Point(6, 15);
            this.NoneRadioButton.Name = "NoneRadioButton";
            this.NoneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.NoneRadioButton.TabIndex = 78;
            this.NoneRadioButton.TabStop = true;
            this.NoneRadioButton.Text = "None";
            this.NoneRadioButton.UseVisualStyleBackColor = true;
            this.NoneRadioButton.CheckedChanged += new System.EventHandler(this.NoneRadioButton_CheckedChanged);
            // 
            // PriceClassRadioButton
            // 
            this.PriceClassRadioButton.AutoSize = true;
            this.PriceClassRadioButton.ForeColor = System.Drawing.Color.White;
            this.PriceClassRadioButton.Location = new System.Drawing.Point(6, 33);
            this.PriceClassRadioButton.Name = "PriceClassRadioButton";
            this.PriceClassRadioButton.Size = new System.Drawing.Size(77, 17);
            this.PriceClassRadioButton.TabIndex = 79;
            this.PriceClassRadioButton.Text = "Price Class";
            this.PriceClassRadioButton.UseVisualStyleBackColor = true;
            this.PriceClassRadioButton.CheckedChanged += new System.EventHandler(this.PriceClassRadioButton_CheckedChanged);
            // 
            // DateGroup
            // 
            this.DateGroup.Controls.Add(this.startDateLabel);
            this.DateGroup.Controls.Add(this.StartDatePicker);
            this.DateGroup.Controls.Add(this.EndDatePicker);
            this.DateGroup.Controls.Add(this.PeriodDropdown);
            this.DateGroup.Controls.Add(this.endDateLabel);
            this.DateGroup.Controls.Add(this.periodLabel);
            this.DateGroup.ForeColor = System.Drawing.Color.White;
            this.DateGroup.Location = new System.Drawing.Point(18, 79);
            this.DateGroup.Name = "DateGroup";
            this.DateGroup.Size = new System.Drawing.Size(187, 100);
            this.DateGroup.TabIndex = 80;
            this.DateGroup.TabStop = false;
            this.DateGroup.Text = "Date";
            // 
            // FiltersGroup
            // 
            this.FiltersGroup.Controls.Add(this.InvoiceNumberCheckbox);
            this.FiltersGroup.Controls.Add(this.FilterList);
            this.FiltersGroup.Controls.Add(this.InvoiceNumberField);
            this.FiltersGroup.Controls.Add(this.CustomerNumberRadioButton);
            this.FiltersGroup.Controls.Add(this.ItemNumberCheckbox);
            this.FiltersGroup.Controls.Add(this.NoneRadioButton);
            this.FiltersGroup.Controls.Add(this.ItemNumberField);
            this.FiltersGroup.Controls.Add(this.PriceClassRadioButton);
            this.FiltersGroup.Controls.Add(this.FilterDropdown);
            this.FiltersGroup.Controls.Add(this.FilterListCreate);
            this.FiltersGroup.ForeColor = System.Drawing.Color.White;
            this.FiltersGroup.Location = new System.Drawing.Point(220, 79);
            this.FiltersGroup.Name = "FiltersGroup";
            this.FiltersGroup.Size = new System.Drawing.Size(382, 268);
            this.FiltersGroup.TabIndex = 81;
            this.FiltersGroup.TabStop = false;
            this.FiltersGroup.Text = "Filters";
            // 
            // InvoiceNumberCheckbox
            // 
            this.InvoiceNumberCheckbox.AutoSize = true;
            this.InvoiceNumberCheckbox.ForeColor = System.Drawing.Color.White;
            this.InvoiceNumberCheckbox.Location = new System.Drawing.Point(11, 233);
            this.InvoiceNumberCheckbox.Name = "InvoiceNumberCheckbox";
            this.InvoiceNumberCheckbox.Size = new System.Drawing.Size(71, 17);
            this.InvoiceNumberCheckbox.TabIndex = 86;
            this.InvoiceNumberCheckbox.Text = "Invoice #";
            this.InvoiceNumberCheckbox.UseVisualStyleBackColor = true;
            this.InvoiceNumberCheckbox.CheckedChanged += new System.EventHandler(this.InvoiceNumberCheckbox_CheckedChanged);
            this.InvoiceNumberCheckbox.MouseHover += new System.EventHandler(this.InvoiceNumberCheckbox_MouseMove);
            // 
            // InvoiceNumberField
            // 
            this.InvoiceNumberField.BackColor = System.Drawing.Color.DarkGray;
            this.InvoiceNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InvoiceNumberField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.InvoiceNumberField.Location = new System.Drawing.Point(90, 232);
            this.InvoiceNumberField.Name = "InvoiceNumberField";
            this.InvoiceNumberField.Size = new System.Drawing.Size(79, 20);
            this.InvoiceNumberField.TabIndex = 85;
            // 
            // CustomerNumberRadioButton
            // 
            this.CustomerNumberRadioButton.AutoSize = true;
            this.CustomerNumberRadioButton.ForeColor = System.Drawing.Color.White;
            this.CustomerNumberRadioButton.Location = new System.Drawing.Point(6, 51);
            this.CustomerNumberRadioButton.Name = "CustomerNumberRadioButton";
            this.CustomerNumberRadioButton.Size = new System.Drawing.Size(79, 17);
            this.CustomerNumberRadioButton.TabIndex = 80;
            this.CustomerNumberRadioButton.Text = "Customer #";
            this.CustomerNumberRadioButton.UseVisualStyleBackColor = true;
            this.CustomerNumberRadioButton.CheckedChanged += new System.EventHandler(this.CustomerNumberRadioButton_CheckedChanged_1);
            // 
            // ItemNumberCheckbox
            // 
            this.ItemNumberCheckbox.AutoSize = true;
            this.ItemNumberCheckbox.ForeColor = System.Drawing.Color.White;
            this.ItemNumberCheckbox.Location = new System.Drawing.Point(11, 210);
            this.ItemNumberCheckbox.Name = "ItemNumberCheckbox";
            this.ItemNumberCheckbox.Size = new System.Drawing.Size(56, 17);
            this.ItemNumberCheckbox.TabIndex = 83;
            this.ItemNumberCheckbox.Text = "Item #";
            this.ItemNumberCheckbox.UseVisualStyleBackColor = true;
            this.ItemNumberCheckbox.CheckedChanged += new System.EventHandler(this.ItemNumberCheckbox_CheckedChanged);
            this.ItemNumberCheckbox.MouseHover += new System.EventHandler(this.ItemNumberCheckbox_MouseMove);
            // 
            // ItemNumberField
            // 
            this.ItemNumberField.BackColor = System.Drawing.Color.DarkGray;
            this.ItemNumberField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemNumberField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ItemNumberField.Location = new System.Drawing.Point(90, 209);
            this.ItemNumberField.Name = "ItemNumberField";
            this.ItemNumberField.Size = new System.Drawing.Size(79, 20);
            this.ItemNumberField.TabIndex = 82;
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
            this.minimizeButton.Location = new System.Drawing.Point(956, 3);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.closeButton.Location = new System.Drawing.Point(993, 3);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
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
            // 
            // OrderDeskInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1036, 697);
            this.Controls.Add(this.FiltersGroup);
            this.Controls.Add(this.DateGroup);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderDeskInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Ledger Listing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GLListing_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.DateGroup.ResumeLayout(false);
            this.DateGroup.PerformLayout();
            this.FiltersGroup.ResumeLayout(false);
            this.FiltersGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataTable;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerpanel;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Label endDateLabel;
        private Label startDateLabel;
        private Label periodLabel;
        private ComboBox PeriodDropdown;
        private DateTimePicker EndDatePicker;
        private DateTimePicker StartDatePicker;
        private ComboBox FilterDropdown;
        private CheckedListBox FilterList;
        private RichTextBox FilterListCreate;
        private Button QueryButton;
        private GroupBox FiltersGroup;
        private RadioButton NoneRadioButton;
        private RadioButton PriceClassRadioButton;
        private GroupBox DateGroup;
        private RadioButton CustomerNumberRadioButton;
        private CheckBox ItemNumberCheckbox;
        private TextBox ItemNumberField;
        private CheckBox InvoiceNumberCheckbox;
        private TextBox InvoiceNumberField;
        private ToolTip ItemNumberTooltip;
        private ToolTip InvoiceNumberTooltip;
    }
}

