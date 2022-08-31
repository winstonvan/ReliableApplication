﻿namespace Reliable
{
    partial class ReportingMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Managment = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderDeskInvoicesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.RebateContractsButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.InventoryCountButton = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1.Controls.Add(this.Managment);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 36);
            this.panel1.TabIndex = 1;
            // 
            // Managment
            // 
            this.Managment.AutoSize = true;
            this.Managment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managment.ForeColor = System.Drawing.Color.White;
            this.Managment.Location = new System.Drawing.Point(12, 9);
            this.Managment.Name = "Managment";
            this.Managment.Size = new System.Drawing.Size(94, 20);
            this.Managment.TabIndex = 16;
            this.Managment.Text = "Managment";
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
            this.minimizeButton.Location = new System.Drawing.Point(213, 3);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.minimizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.minimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.minimizeButton.selected = false;
            this.minimizeButton.Size = new System.Drawing.Size(31, 30);
            this.minimizeButton.TabIndex = 14;
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
            this.closeButton.ButtonText = "";
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
            this.closeButton.Location = new System.Drawing.Point(250, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.OnHovercolor = System.Drawing.Color.Red;
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(31, 30);
            this.closeButton.TabIndex = 2;
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
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 50;
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
            // OrderDeskInvoicesButton
            // 
            this.OrderDeskInvoicesButton.Active = false;
            this.OrderDeskInvoicesButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OrderDeskInvoicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrderDeskInvoicesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderDeskInvoicesButton.BorderRadius = 0;
            this.OrderDeskInvoicesButton.ButtonText = "Order Desk Invoices";
            this.OrderDeskInvoicesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OrderDeskInvoicesButton.DisabledColor = System.Drawing.Color.Gray;
            this.OrderDeskInvoicesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.OrderDeskInvoicesButton.Iconimage = null;
            this.OrderDeskInvoicesButton.Iconimage_right = null;
            this.OrderDeskInvoicesButton.Iconimage_right_Selected = null;
            this.OrderDeskInvoicesButton.Iconimage_Selected = null;
            this.OrderDeskInvoicesButton.IconMarginLeft = 0;
            this.OrderDeskInvoicesButton.IconMarginRight = 0;
            this.OrderDeskInvoicesButton.IconRightVisible = true;
            this.OrderDeskInvoicesButton.IconRightZoom = 0D;
            this.OrderDeskInvoicesButton.IconVisible = true;
            this.OrderDeskInvoicesButton.IconZoom = 135D;
            this.OrderDeskInvoicesButton.IsTab = false;
            this.OrderDeskInvoicesButton.Location = new System.Drawing.Point(33, 79);
            this.OrderDeskInvoicesButton.Name = "OrderDeskInvoicesButton";
            this.OrderDeskInvoicesButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrderDeskInvoicesButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OrderDeskInvoicesButton.OnHoverTextColor = System.Drawing.Color.White;
            this.OrderDeskInvoicesButton.selected = false;
            this.OrderDeskInvoicesButton.Size = new System.Drawing.Size(226, 71);
            this.OrderDeskInvoicesButton.TabIndex = 6;
            this.OrderDeskInvoicesButton.Text = "Order Desk Invoices";
            this.OrderDeskInvoicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrderDeskInvoicesButton.Textcolor = System.Drawing.Color.White;
            this.OrderDeskInvoicesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDeskInvoicesButton.Click += new System.EventHandler(this.orderFormButton_Click);
            // 
            // RebateContractsButton
            // 
            this.RebateContractsButton.Active = false;
            this.RebateContractsButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RebateContractsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RebateContractsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RebateContractsButton.BorderRadius = 0;
            this.RebateContractsButton.ButtonText = "Rebate Contracts";
            this.RebateContractsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RebateContractsButton.DisabledColor = System.Drawing.Color.Gray;
            this.RebateContractsButton.Iconcolor = System.Drawing.Color.Transparent;
            this.RebateContractsButton.Iconimage = null;
            this.RebateContractsButton.Iconimage_right = null;
            this.RebateContractsButton.Iconimage_right_Selected = null;
            this.RebateContractsButton.Iconimage_Selected = null;
            this.RebateContractsButton.IconMarginLeft = 0;
            this.RebateContractsButton.IconMarginRight = 0;
            this.RebateContractsButton.IconRightVisible = true;
            this.RebateContractsButton.IconRightZoom = 0D;
            this.RebateContractsButton.IconVisible = true;
            this.RebateContractsButton.IconZoom = 135D;
            this.RebateContractsButton.IsTab = false;
            this.RebateContractsButton.Location = new System.Drawing.Point(33, 171);
            this.RebateContractsButton.Name = "RebateContractsButton";
            this.RebateContractsButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.RebateContractsButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.RebateContractsButton.OnHoverTextColor = System.Drawing.Color.White;
            this.RebateContractsButton.selected = false;
            this.RebateContractsButton.Size = new System.Drawing.Size(226, 71);
            this.RebateContractsButton.TabIndex = 51;
            this.RebateContractsButton.Text = "Rebate Contracts";
            this.RebateContractsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RebateContractsButton.Textcolor = System.Drawing.Color.White;
            this.RebateContractsButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RebateContractsButton.Click += new System.EventHandler(this.RebateContractsButton_Click);
            // 
            // InventoryCountButton
            // 
            this.InventoryCountButton.Active = false;
            this.InventoryCountButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.InventoryCountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.InventoryCountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InventoryCountButton.BorderRadius = 0;
            this.InventoryCountButton.ButtonText = "Inventory Count";
            this.InventoryCountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InventoryCountButton.DisabledColor = System.Drawing.Color.Gray;
            this.InventoryCountButton.Iconcolor = System.Drawing.Color.Transparent;
            this.InventoryCountButton.Iconimage = null;
            this.InventoryCountButton.Iconimage_right = null;
            this.InventoryCountButton.Iconimage_right_Selected = null;
            this.InventoryCountButton.Iconimage_Selected = null;
            this.InventoryCountButton.IconMarginLeft = 0;
            this.InventoryCountButton.IconMarginRight = 0;
            this.InventoryCountButton.IconRightVisible = true;
            this.InventoryCountButton.IconRightZoom = 0D;
            this.InventoryCountButton.IconVisible = true;
            this.InventoryCountButton.IconZoom = 135D;
            this.InventoryCountButton.IsTab = false;
            this.InventoryCountButton.Location = new System.Drawing.Point(33, 262);
            this.InventoryCountButton.Name = "InventoryCountButton";
            this.InventoryCountButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.InventoryCountButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.InventoryCountButton.OnHoverTextColor = System.Drawing.Color.White;
            this.InventoryCountButton.selected = false;
            this.InventoryCountButton.Size = new System.Drawing.Size(226, 71);
            this.InventoryCountButton.TabIndex = 52;
            this.InventoryCountButton.Text = "Inventory Count";
            this.InventoryCountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InventoryCountButton.Textcolor = System.Drawing.Color.White;
            this.InventoryCountButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryCountButton.Click += new System.EventHandler(this.InventoryCountButton_Click);
            // 
            // ReportingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(293, 467);
            this.Controls.Add(this.InventoryCountButton);
            this.Controls.Add(this.RebateContractsButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.OrderDeskInvoicesButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportingMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagmentMenu";
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
        private Bunifu.Framework.UI.BunifuCustomLabel Managment;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton OrderDeskInvoicesButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuFlatButton RebateContractsButton;
        private Bunifu.Framework.UI.BunifuFlatButton InventoryCountButton;
    }
}