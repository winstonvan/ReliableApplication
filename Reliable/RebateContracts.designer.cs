using System;
using System.Windows.Forms;

namespace TestProject {
    partial class RebateContracts {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RebateContracts));
            this.DataTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerpanel = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RebateContractIdCheckbox = new System.Windows.Forms.CheckBox();
            this.RebateContractIdField = new System.Windows.Forms.TextBox();
            this.ItemNumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.InvoiceNumberTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.IncludeExpiredCheckbox = new System.Windows.Forms.CheckBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.headerpanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.DoubleBuffered = true;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DataTable.HeaderForeColor = System.Drawing.Color.White;
            this.DataTable.Location = new System.Drawing.Point(0, 129);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataTable.RowHeadersWidth = 25;
            this.DataTable.Size = new System.Drawing.Size(1036, 566);
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
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(152, 20);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Order Desk Invoices";
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
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // RebateContractIdCheckbox
            // 
            this.RebateContractIdCheckbox.AutoSize = true;
            this.RebateContractIdCheckbox.ForeColor = System.Drawing.Color.White;
            this.RebateContractIdCheckbox.Location = new System.Drawing.Point(12, 72);
            this.RebateContractIdCheckbox.Name = "RebateContractIdCheckbox";
            this.RebateContractIdCheckbox.Size = new System.Drawing.Size(116, 17);
            this.RebateContractIdCheckbox.TabIndex = 83;
            this.RebateContractIdCheckbox.Text = "Rebate Contract Id";
            this.RebateContractIdCheckbox.UseVisualStyleBackColor = true;
            this.RebateContractIdCheckbox.CheckedChanged += new System.EventHandler(this.RebateContractIdCheckbox_CheckedChanged);
            this.RebateContractIdCheckbox.MouseHover += new System.EventHandler(this.RebateContractIdCheckbox_MouseMove);
            // 
            // RebateContractIdField
            // 
            this.RebateContractIdField.BackColor = System.Drawing.Color.DarkGray;
            this.RebateContractIdField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RebateContractIdField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.RebateContractIdField.Location = new System.Drawing.Point(134, 69);
            this.RebateContractIdField.Name = "RebateContractIdField";
            this.RebateContractIdField.Size = new System.Drawing.Size(79, 20);
            this.RebateContractIdField.TabIndex = 82;
            // 
            // IncludeExpiredCheckbox
            // 
            this.IncludeExpiredCheckbox.AutoSize = true;
            this.IncludeExpiredCheckbox.ForeColor = System.Drawing.Color.White;
            this.IncludeExpiredCheckbox.Location = new System.Drawing.Point(12, 95);
            this.IncludeExpiredCheckbox.Name = "IncludeExpiredCheckbox";
            this.IncludeExpiredCheckbox.Size = new System.Drawing.Size(147, 17);
            this.IncludeExpiredCheckbox.TabIndex = 84;
            this.IncludeExpiredCheckbox.Text = "Include Expired Contracts";
            this.IncludeExpiredCheckbox.UseVisualStyleBackColor = true;
            // 
            // QueryButton
            // 
            this.QueryButton.AutoSize = true;
            this.QueryButton.BackColor = System.Drawing.SystemColors.Window;
            this.QueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.QueryButton.Location = new System.Drawing.Point(949, 72);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(2);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(75, 25);
            this.QueryButton.TabIndex = 49;
            this.QueryButton.Text = "Query";
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
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
            this.menuStrip1.TabIndex = 85;
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
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click_1);
            // 
            // RebateContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1036, 697);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.IncludeExpiredCheckbox);
            this.Controls.Add(this.QueryButton);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.RebateContractIdCheckbox);
            this.Controls.Add(this.RebateContractIdField);
            this.Controls.Add(this.headerpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RebateContracts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "General Ledger Listing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GLListing_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.headerpanel.ResumeLayout(false);
            this.headerpanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataTable;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel headerpanel;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private CheckBox RebateContractIdCheckbox;
        private TextBox RebateContractIdField;
        private ToolTip ItemNumberTooltip;
        private ToolTip InvoiceNumberTooltip;
        private CheckBox IncludeExpiredCheckbox;
        private Button QueryButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}

