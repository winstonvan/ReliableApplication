using System;

namespace Reliable
{
    partial class Reliable
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reliable));
            this.mainMenuElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.backPanel = new System.Windows.Forms.Panel();
            this.ReportingDisabledButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ReportingButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuPanelTwo = new System.Windows.Forms.Panel();
            this.AccountManagementButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.companyInformationButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.changePasswordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AccountsPayableButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.AccountsPayableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.WarehouseButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.SalesButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.ManagementButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.AccountsReceivableButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.GeneralLedgerButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.CatalogCreatorButtonDisabled = new Bunifu.Framework.UI.BunifuTileButton();
            this.CatalogCreatorButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.WarehouseButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.SalesButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.ManagementButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.GeneralLedgerButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.AccountsReceivableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.apButtonTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.glTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.salesTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.companyTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuPanelTransitionTwo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.backPanel.SuspendLayout();
            this.menuPanelTwo.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuElipse
            // 
            this.mainMenuElipse.ElipseRadius = 5;
            this.mainMenuElipse.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.closeButton);
            this.salesTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 36);
            this.panel1.TabIndex = 9;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Active = false;
            this.minimizeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.BorderRadius = 0;
            this.minimizeButton.ButtonText = "";
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
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
            this.minimizeButton.Location = new System.Drawing.Point(884, 4);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.minimizeButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.minimizeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.minimizeButton.selected = false;
            this.minimizeButton.Size = new System.Drawing.Size(31, 30);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeButton.Textcolor = System.Drawing.Color.White;
            this.minimizeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanelTransitionTwo.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Active = false;
            this.closeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.BorderRadius = 0;
            this.closeButton.ButtonText = "gfdsg";
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.closeButton, BunifuAnimatorNS.DecorationType.None);
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
            this.closeButton.Location = new System.Drawing.Point(913, 4);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.closeButton.OnHovercolor = System.Drawing.Color.Red;
            this.closeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.closeButton.selected = false;
            this.closeButton.Size = new System.Drawing.Size(31, 30);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "gfdsg";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeButton.Textcolor = System.Drawing.Color.White;
            this.closeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // backPanel
            // 
            this.backPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.backPanel.Controls.Add(this.ReportingDisabledButton);
            this.backPanel.Controls.Add(this.ReportingButton);
            this.backPanel.Controls.Add(this.menuPanelTwo);
            this.backPanel.Controls.Add(this.AccountsPayableButtonDisabled);
            this.backPanel.Controls.Add(this.AccountsPayableButton);
            this.backPanel.Controls.Add(this.WarehouseButtonDisabled);
            this.backPanel.Controls.Add(this.SalesButtonDisabled);
            this.backPanel.Controls.Add(this.ManagementButtonDisabled);
            this.backPanel.Controls.Add(this.AccountsReceivableButtonDisabled);
            this.backPanel.Controls.Add(this.GeneralLedgerButtonDisabled);
            this.backPanel.Controls.Add(this.CatalogCreatorButtonDisabled);
            this.backPanel.Controls.Add(this.CatalogCreatorButton);
            this.backPanel.Controls.Add(this.WarehouseButton);
            this.backPanel.Controls.Add(this.SalesButton);
            this.backPanel.Controls.Add(this.ManagementButton);
            this.backPanel.Controls.Add(this.GeneralLedgerButton);
            this.backPanel.Controls.Add(this.AccountsReceivableButton);
            this.backPanel.Controls.Add(this.menuPanel);
            this.salesTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(948, 526);
            this.backPanel.TabIndex = 10;
            // 
            // ReportingDisabledButton
            // 
            this.ReportingDisabledButton.AutoSize = true;
            this.ReportingDisabledButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ReportingDisabledButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReportingDisabledButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ReportingDisabledButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ReportingDisabledButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.ReportingDisabledButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.ReportingDisabledButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.ReportingDisabledButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.ReportingDisabledButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.ReportingDisabledButton, BunifuAnimatorNS.DecorationType.None);
            this.ReportingDisabledButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ReportingDisabledButton.ForeColor = System.Drawing.Color.White;
            this.ReportingDisabledButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportingDisabledButton.Image")));
            this.ReportingDisabledButton.ImagePosition = 14;
            this.ReportingDisabledButton.ImageZoom = 50;
            this.ReportingDisabledButton.LabelPosition = 27;
            this.ReportingDisabledButton.LabelText = "Reporting";
            this.ReportingDisabledButton.Location = new System.Drawing.Point(287, 289);
            this.ReportingDisabledButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReportingDisabledButton.Name = "ReportingDisabledButton";
            this.ReportingDisabledButton.Size = new System.Drawing.Size(177, 155);
            this.ReportingDisabledButton.TabIndex = 34;
            this.ReportingDisabledButton.Visible = false;
            // 
            // ReportingButton
            // 
            this.ReportingButton.AutoSize = true;
            this.ReportingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ReportingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ReportingButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ReportingButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ReportingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.ReportingButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.ReportingButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.ReportingButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.ReportingButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.ReportingButton, BunifuAnimatorNS.DecorationType.None);
            this.ReportingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ReportingButton.ForeColor = System.Drawing.Color.White;
            this.ReportingButton.Image = ((System.Drawing.Image)(resources.GetObject("ReportingButton.Image")));
            this.ReportingButton.ImagePosition = 14;
            this.ReportingButton.ImageZoom = 50;
            this.ReportingButton.LabelPosition = 27;
            this.ReportingButton.LabelText = "Reporting";
            this.ReportingButton.Location = new System.Drawing.Point(287, 289);
            this.ReportingButton.Margin = new System.Windows.Forms.Padding(0);
            this.ReportingButton.Name = "ReportingButton";
            this.ReportingButton.Size = new System.Drawing.Size(177, 155);
            this.ReportingButton.TabIndex = 33;
            this.ReportingButton.Click += new System.EventHandler(this.OrderDeskInvoicesButton_Click);
            // 
            // menuPanelTwo
            // 
            this.menuPanelTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanelTwo.Controls.Add(this.AccountManagementButton);
            this.menuPanelTwo.Controls.Add(this.companyInformationButton);
            this.menuPanelTwo.Controls.Add(this.changePasswordButton);
            this.salesTransition.SetDecoration(this.menuPanelTwo, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.menuPanelTwo, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.menuPanelTwo, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.menuPanelTwo, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.menuPanelTwo, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTwo.Location = new System.Drawing.Point(0, 66);
            this.menuPanelTwo.Name = "menuPanelTwo";
            this.menuPanelTwo.Size = new System.Drawing.Size(146, 126);
            this.menuPanelTwo.TabIndex = 11;
            // 
            // AccountManagementButton
            // 
            this.AccountManagementButton.Active = false;
            this.AccountManagementButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.AccountManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.AccountManagementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AccountManagementButton.BorderRadius = 0;
            this.AccountManagementButton.ButtonText = "Account Managment";
            this.AccountManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.AccountManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.AccountManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.AccountManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.AccountManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.AccountManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.AccountManagementButton.DisabledColor = System.Drawing.Color.Gray;
            this.AccountManagementButton.Iconcolor = System.Drawing.Color.Transparent;
            this.AccountManagementButton.Iconimage = null;
            this.AccountManagementButton.Iconimage_right = null;
            this.AccountManagementButton.Iconimage_right_Selected = null;
            this.AccountManagementButton.Iconimage_Selected = null;
            this.AccountManagementButton.IconMarginLeft = 0;
            this.AccountManagementButton.IconMarginRight = 0;
            this.AccountManagementButton.IconRightVisible = true;
            this.AccountManagementButton.IconRightZoom = 0D;
            this.AccountManagementButton.IconVisible = true;
            this.AccountManagementButton.IconZoom = 90D;
            this.AccountManagementButton.IsTab = false;
            this.AccountManagementButton.Location = new System.Drawing.Point(3, 88);
            this.AccountManagementButton.Margin = new System.Windows.Forms.Padding(4);
            this.AccountManagementButton.Name = "AccountManagementButton";
            this.AccountManagementButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.AccountManagementButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.AccountManagementButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AccountManagementButton.selected = false;
            this.AccountManagementButton.Size = new System.Drawing.Size(141, 28);
            this.AccountManagementButton.TabIndex = 2;
            this.AccountManagementButton.Text = "Account Managment";
            this.AccountManagementButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AccountManagementButton.Textcolor = System.Drawing.Color.White;
            this.AccountManagementButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountManagementButton.Click += new System.EventHandler(this.accountManagmentButton_Click);
            // 
            // companyInformationButton
            // 
            this.companyInformationButton.Active = false;
            this.companyInformationButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.companyInformationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.companyInformationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.companyInformationButton.BorderRadius = 0;
            this.companyInformationButton.ButtonText = "Company Info";
            this.companyInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.companyInformationButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.companyInformationButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.companyInformationButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.companyInformationButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.companyInformationButton, BunifuAnimatorNS.DecorationType.None);
            this.companyInformationButton.DisabledColor = System.Drawing.Color.Gray;
            this.companyInformationButton.Iconcolor = System.Drawing.Color.Transparent;
            this.companyInformationButton.Iconimage = null;
            this.companyInformationButton.Iconimage_right = null;
            this.companyInformationButton.Iconimage_right_Selected = null;
            this.companyInformationButton.Iconimage_Selected = null;
            this.companyInformationButton.IconMarginLeft = 0;
            this.companyInformationButton.IconMarginRight = 0;
            this.companyInformationButton.IconRightVisible = true;
            this.companyInformationButton.IconRightZoom = 0D;
            this.companyInformationButton.IconVisible = true;
            this.companyInformationButton.IconZoom = 90D;
            this.companyInformationButton.IsTab = false;
            this.companyInformationButton.Location = new System.Drawing.Point(3, 54);
            this.companyInformationButton.Margin = new System.Windows.Forms.Padding(4);
            this.companyInformationButton.Name = "companyInformationButton";
            this.companyInformationButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.companyInformationButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.companyInformationButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.companyInformationButton.selected = false;
            this.companyInformationButton.Size = new System.Drawing.Size(140, 28);
            this.companyInformationButton.TabIndex = 1;
            this.companyInformationButton.Text = "Company Info";
            this.companyInformationButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.companyInformationButton.Textcolor = System.Drawing.Color.White;
            this.companyInformationButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyInformationButton.Click += new System.EventHandler(this.CompanyInformationButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Active = false;
            this.changePasswordButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.changePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.changePasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changePasswordButton.BorderRadius = 0;
            this.changePasswordButton.ButtonText = "Change Password";
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.changePasswordButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.changePasswordButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.changePasswordButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.changePasswordButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.changePasswordButton, BunifuAnimatorNS.DecorationType.None);
            this.changePasswordButton.DisabledColor = System.Drawing.Color.Gray;
            this.changePasswordButton.Iconcolor = System.Drawing.Color.Transparent;
            this.changePasswordButton.Iconimage = null;
            this.changePasswordButton.Iconimage_right = null;
            this.changePasswordButton.Iconimage_right_Selected = null;
            this.changePasswordButton.Iconimage_Selected = null;
            this.changePasswordButton.IconMarginLeft = 0;
            this.changePasswordButton.IconMarginRight = 0;
            this.changePasswordButton.IconRightVisible = true;
            this.changePasswordButton.IconRightZoom = 0D;
            this.changePasswordButton.IconVisible = true;
            this.changePasswordButton.IconZoom = 90D;
            this.changePasswordButton.IsTab = false;
            this.changePasswordButton.Location = new System.Drawing.Point(3, 20);
            this.changePasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.changePasswordButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.changePasswordButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.changePasswordButton.selected = false;
            this.changePasswordButton.Size = new System.Drawing.Size(140, 28);
            this.changePasswordButton.TabIndex = 0;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePasswordButton.Textcolor = System.Drawing.Color.White;
            this.changePasswordButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // AccountsPayableButtonDisabled
            // 
            this.AccountsPayableButtonDisabled.AutoSize = true;
            this.AccountsPayableButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsPayableButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountsPayableButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsPayableButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsPayableButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.AccountsPayableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.AccountsPayableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.AccountsPayableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.AccountsPayableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.AccountsPayableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.AccountsPayableButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AccountsPayableButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.AccountsPayableButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("AccountsPayableButtonDisabled.Image")));
            this.AccountsPayableButtonDisabled.ImagePosition = 14;
            this.AccountsPayableButtonDisabled.ImageZoom = 50;
            this.AccountsPayableButtonDisabled.LabelPosition = 27;
            this.AccountsPayableButtonDisabled.LabelText = "Accounts Payable";
            this.AccountsPayableButtonDisabled.Location = new System.Drawing.Point(62, 93);
            this.AccountsPayableButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.AccountsPayableButtonDisabled.Name = "AccountsPayableButtonDisabled";
            this.AccountsPayableButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.AccountsPayableButtonDisabled.TabIndex = 31;
            this.AccountsPayableButtonDisabled.Visible = false;
            // 
            // AccountsPayableButton
            // 
            this.AccountsPayableButton.AutoSize = true;
            this.AccountsPayableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsPayableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountsPayableButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsPayableButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AccountsPayableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.AccountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.AccountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.AccountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.AccountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.AccountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.AccountsPayableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AccountsPayableButton.ForeColor = System.Drawing.Color.White;
            this.AccountsPayableButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountsPayableButton.Image")));
            this.AccountsPayableButton.ImagePosition = 14;
            this.AccountsPayableButton.ImageZoom = 50;
            this.AccountsPayableButton.LabelPosition = 27;
            this.AccountsPayableButton.LabelText = "Accounts Payable";
            this.AccountsPayableButton.Location = new System.Drawing.Point(62, 93);
            this.AccountsPayableButton.Margin = new System.Windows.Forms.Padding(0);
            this.AccountsPayableButton.Name = "AccountsPayableButton";
            this.AccountsPayableButton.Size = new System.Drawing.Size(177, 155);
            this.AccountsPayableButton.TabIndex = 30;
            this.AccountsPayableButton.Click += new System.EventHandler(this.AccountsPayableButton_Click);
            // 
            // WarehouseButtonDisabled
            // 
            this.WarehouseButtonDisabled.AutoSize = true;
            this.WarehouseButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WarehouseButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WarehouseButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WarehouseButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WarehouseButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.WarehouseButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.WarehouseButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.WarehouseButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.WarehouseButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.WarehouseButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.WarehouseButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.WarehouseButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.WarehouseButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("WarehouseButtonDisabled.Image")));
            this.WarehouseButtonDisabled.ImagePosition = 14;
            this.WarehouseButtonDisabled.ImageZoom = 50;
            this.WarehouseButtonDisabled.LabelPosition = 27;
            this.WarehouseButtonDisabled.LabelText = "Warehouse";
            this.WarehouseButtonDisabled.Location = new System.Drawing.Point(737, 289);
            this.WarehouseButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseButtonDisabled.Name = "WarehouseButtonDisabled";
            this.WarehouseButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.WarehouseButtonDisabled.TabIndex = 27;
            this.WarehouseButtonDisabled.Visible = false;
            // 
            // SalesButtonDisabled
            // 
            this.SalesButtonDisabled.AutoSize = true;
            this.SalesButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SalesButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalesButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SalesButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SalesButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.SalesButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.SalesButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.SalesButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.SalesButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.SalesButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.SalesButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SalesButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.SalesButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("SalesButtonDisabled.Image")));
            this.SalesButtonDisabled.ImagePosition = 14;
            this.SalesButtonDisabled.ImageZoom = 50;
            this.SalesButtonDisabled.LabelPosition = 27;
            this.SalesButtonDisabled.LabelText = "Sales";
            this.SalesButtonDisabled.Location = new System.Drawing.Point(512, 289);
            this.SalesButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.SalesButtonDisabled.Name = "SalesButtonDisabled";
            this.SalesButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.SalesButtonDisabled.TabIndex = 26;
            this.SalesButtonDisabled.Visible = false;
            // 
            // ManagementButtonDisabled
            // 
            this.ManagementButtonDisabled.AutoSize = true;
            this.ManagementButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ManagementButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManagementButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ManagementButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ManagementButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.ManagementButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.ManagementButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.ManagementButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.ManagementButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.ManagementButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.ManagementButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ManagementButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.ManagementButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("ManagementButtonDisabled.Image")));
            this.ManagementButtonDisabled.ImagePosition = 14;
            this.ManagementButtonDisabled.ImageZoom = 50;
            this.ManagementButtonDisabled.LabelPosition = 27;
            this.ManagementButtonDisabled.LabelText = "Management";
            this.ManagementButtonDisabled.Location = new System.Drawing.Point(62, 289);
            this.ManagementButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.ManagementButtonDisabled.Name = "ManagementButtonDisabled";
            this.ManagementButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.ManagementButtonDisabled.TabIndex = 25;
            this.ManagementButtonDisabled.Visible = false;
            // 
            // AccountsReceivableButtonDisabled
            // 
            this.AccountsReceivableButtonDisabled.AutoSize = true;
            this.AccountsReceivableButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsReceivableButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountsReceivableButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsReceivableButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsReceivableButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.AccountsReceivableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.AccountsReceivableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.AccountsReceivableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.AccountsReceivableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.AccountsReceivableButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.AccountsReceivableButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AccountsReceivableButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.AccountsReceivableButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("AccountsReceivableButtonDisabled.Image")));
            this.AccountsReceivableButtonDisabled.ImagePosition = 14;
            this.AccountsReceivableButtonDisabled.ImageZoom = 50;
            this.AccountsReceivableButtonDisabled.LabelPosition = 27;
            this.AccountsReceivableButtonDisabled.LabelText = "Accounts Receivable";
            this.AccountsReceivableButtonDisabled.Location = new System.Drawing.Point(287, 93);
            this.AccountsReceivableButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.AccountsReceivableButtonDisabled.Name = "AccountsReceivableButtonDisabled";
            this.AccountsReceivableButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.AccountsReceivableButtonDisabled.TabIndex = 24;
            this.AccountsReceivableButtonDisabled.Visible = false;
            // 
            // GeneralLedgerButtonDisabled
            // 
            this.GeneralLedgerButtonDisabled.AutoSize = true;
            this.GeneralLedgerButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.GeneralLedgerButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GeneralLedgerButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.GeneralLedgerButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.GeneralLedgerButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.GeneralLedgerButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.GeneralLedgerButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.GeneralLedgerButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.GeneralLedgerButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.GeneralLedgerButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.GeneralLedgerButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GeneralLedgerButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.GeneralLedgerButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("GeneralLedgerButtonDisabled.Image")));
            this.GeneralLedgerButtonDisabled.ImagePosition = 14;
            this.GeneralLedgerButtonDisabled.ImageZoom = 50;
            this.GeneralLedgerButtonDisabled.LabelPosition = 27;
            this.GeneralLedgerButtonDisabled.LabelText = "General Ledger";
            this.GeneralLedgerButtonDisabled.Location = new System.Drawing.Point(737, 93);
            this.GeneralLedgerButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.GeneralLedgerButtonDisabled.Name = "GeneralLedgerButtonDisabled";
            this.GeneralLedgerButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.GeneralLedgerButtonDisabled.TabIndex = 23;
            this.GeneralLedgerButtonDisabled.Visible = false;
            // 
            // CatalogCreatorButtonDisabled
            // 
            this.CatalogCreatorButtonDisabled.AutoSize = true;
            this.CatalogCreatorButtonDisabled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CatalogCreatorButtonDisabled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CatalogCreatorButtonDisabled.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CatalogCreatorButtonDisabled.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CatalogCreatorButtonDisabled.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.glTransition.SetDecoration(this.CatalogCreatorButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.CatalogCreatorButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.CatalogCreatorButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.CatalogCreatorButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.CatalogCreatorButtonDisabled, BunifuAnimatorNS.DecorationType.None);
            this.CatalogCreatorButtonDisabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CatalogCreatorButtonDisabled.ForeColor = System.Drawing.Color.White;
            this.CatalogCreatorButtonDisabled.Image = ((System.Drawing.Image)(resources.GetObject("CatalogCreatorButtonDisabled.Image")));
            this.CatalogCreatorButtonDisabled.ImagePosition = 14;
            this.CatalogCreatorButtonDisabled.ImageZoom = 50;
            this.CatalogCreatorButtonDisabled.LabelPosition = 27;
            this.CatalogCreatorButtonDisabled.LabelText = "Catalog Creator";
            this.CatalogCreatorButtonDisabled.Location = new System.Drawing.Point(512, 93);
            this.CatalogCreatorButtonDisabled.Margin = new System.Windows.Forms.Padding(0);
            this.CatalogCreatorButtonDisabled.Name = "CatalogCreatorButtonDisabled";
            this.CatalogCreatorButtonDisabled.Size = new System.Drawing.Size(177, 155);
            this.CatalogCreatorButtonDisabled.TabIndex = 22;
            this.CatalogCreatorButtonDisabled.Visible = false;
            // 
            // CatalogCreatorButton
            // 
            this.CatalogCreatorButton.AutoSize = true;
            this.CatalogCreatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CatalogCreatorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CatalogCreatorButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.CatalogCreatorButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CatalogCreatorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.CatalogCreatorButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.CatalogCreatorButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.CatalogCreatorButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.CatalogCreatorButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.CatalogCreatorButton, BunifuAnimatorNS.DecorationType.None);
            this.CatalogCreatorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CatalogCreatorButton.ForeColor = System.Drawing.Color.White;
            this.CatalogCreatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CatalogCreatorButton.Image")));
            this.CatalogCreatorButton.ImagePosition = 14;
            this.CatalogCreatorButton.ImageZoom = 50;
            this.CatalogCreatorButton.LabelPosition = 27;
            this.CatalogCreatorButton.LabelText = "Catalog Creator";
            this.CatalogCreatorButton.Location = new System.Drawing.Point(512, 93);
            this.CatalogCreatorButton.Margin = new System.Windows.Forms.Padding(0);
            this.CatalogCreatorButton.Name = "CatalogCreatorButton";
            this.CatalogCreatorButton.Size = new System.Drawing.Size(177, 155);
            this.CatalogCreatorButton.TabIndex = 21;
            this.CatalogCreatorButton.Click += new System.EventHandler(this.CatalogCreator_Click);
            // 
            // WarehouseButton
            // 
            this.WarehouseButton.AutoSize = true;
            this.WarehouseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WarehouseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.WarehouseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.WarehouseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.WarehouseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.WarehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.WarehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.WarehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.WarehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.WarehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.WarehouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.WarehouseButton.ForeColor = System.Drawing.Color.White;
            this.WarehouseButton.Image = ((System.Drawing.Image)(resources.GetObject("WarehouseButton.Image")));
            this.WarehouseButton.ImagePosition = 14;
            this.WarehouseButton.ImageZoom = 50;
            this.WarehouseButton.LabelPosition = 27;
            this.WarehouseButton.LabelText = "Warehouse";
            this.WarehouseButton.Location = new System.Drawing.Point(737, 289);
            this.WarehouseButton.Margin = new System.Windows.Forms.Padding(0);
            this.WarehouseButton.Name = "WarehouseButton";
            this.WarehouseButton.Size = new System.Drawing.Size(177, 155);
            this.WarehouseButton.TabIndex = 20;
            this.WarehouseButton.Click += new System.EventHandler(this.Warehouse_Click);
            // 
            // SalesButton
            // 
            this.SalesButton.AutoSize = true;
            this.SalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalesButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.SalesButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SalesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.SalesButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.SalesButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.SalesButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.SalesButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.SalesButton, BunifuAnimatorNS.DecorationType.None);
            this.SalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SalesButton.ForeColor = System.Drawing.Color.White;
            this.SalesButton.Image = ((System.Drawing.Image)(resources.GetObject("SalesButton.Image")));
            this.SalesButton.ImagePosition = 14;
            this.SalesButton.ImageZoom = 50;
            this.SalesButton.LabelPosition = 27;
            this.SalesButton.LabelText = "Sales";
            this.SalesButton.Location = new System.Drawing.Point(512, 289);
            this.SalesButton.Margin = new System.Windows.Forms.Padding(0);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(177, 155);
            this.SalesButton.TabIndex = 19;
            this.SalesButton.Click += new System.EventHandler(this.Sales_Click);
            // 
            // ManagementButton
            // 
            this.ManagementButton.AutoSize = true;
            this.ManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ManagementButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ManagementButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ManagementButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.ManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.ManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.ManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.ManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.ManagementButton, BunifuAnimatorNS.DecorationType.None);
            this.ManagementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ManagementButton.ForeColor = System.Drawing.Color.White;
            this.ManagementButton.Image = ((System.Drawing.Image)(resources.GetObject("ManagementButton.Image")));
            this.ManagementButton.ImagePosition = 14;
            this.ManagementButton.ImageZoom = 50;
            this.ManagementButton.LabelPosition = 27;
            this.ManagementButton.LabelText = "Management";
            this.ManagementButton.Location = new System.Drawing.Point(62, 289);
            this.ManagementButton.Margin = new System.Windows.Forms.Padding(0);
            this.ManagementButton.Name = "ManagementButton";
            this.ManagementButton.Size = new System.Drawing.Size(177, 155);
            this.ManagementButton.TabIndex = 18;
            this.ManagementButton.Click += new System.EventHandler(this.Management_Click);
            // 
            // GeneralLedgerButton
            // 
            this.GeneralLedgerButton.AutoSize = true;
            this.GeneralLedgerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.GeneralLedgerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GeneralLedgerButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.GeneralLedgerButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.GeneralLedgerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.GeneralLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.GeneralLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.GeneralLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.GeneralLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.GeneralLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.GeneralLedgerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.GeneralLedgerButton.ForeColor = System.Drawing.Color.White;
            this.GeneralLedgerButton.Image = ((System.Drawing.Image)(resources.GetObject("GeneralLedgerButton.Image")));
            this.GeneralLedgerButton.ImagePosition = 14;
            this.GeneralLedgerButton.ImageZoom = 50;
            this.GeneralLedgerButton.LabelPosition = 27;
            this.GeneralLedgerButton.LabelText = "General Ledger";
            this.GeneralLedgerButton.Location = new System.Drawing.Point(737, 93);
            this.GeneralLedgerButton.Margin = new System.Windows.Forms.Padding(0);
            this.GeneralLedgerButton.Name = "GeneralLedgerButton";
            this.GeneralLedgerButton.Size = new System.Drawing.Size(177, 155);
            this.GeneralLedgerButton.TabIndex = 17;
            this.GeneralLedgerButton.Click += new System.EventHandler(this.GeneralLedger_Click);
            // 
            // AccountsReceivableButton
            // 
            this.AccountsReceivableButton.AutoSize = true;
            this.AccountsReceivableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsReceivableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AccountsReceivableButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.AccountsReceivableButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.AccountsReceivableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.AccountsReceivableButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.AccountsReceivableButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.AccountsReceivableButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.AccountsReceivableButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.AccountsReceivableButton, BunifuAnimatorNS.DecorationType.None);
            this.AccountsReceivableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.AccountsReceivableButton.ForeColor = System.Drawing.Color.White;
            this.AccountsReceivableButton.Image = ((System.Drawing.Image)(resources.GetObject("AccountsReceivableButton.Image")));
            this.AccountsReceivableButton.ImagePosition = 14;
            this.AccountsReceivableButton.ImageZoom = 50;
            this.AccountsReceivableButton.LabelPosition = 27;
            this.AccountsReceivableButton.LabelText = "Accounts Receivable";
            this.AccountsReceivableButton.Location = new System.Drawing.Point(287, 93);
            this.AccountsReceivableButton.Margin = new System.Windows.Forms.Padding(0);
            this.AccountsReceivableButton.Name = "AccountsReceivableButton";
            this.AccountsReceivableButton.Size = new System.Drawing.Size(177, 155);
            this.AccountsReceivableButton.TabIndex = 16;
            this.AccountsReceivableButton.Click += new System.EventHandler(this.AccountsReceivable_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanel.Controls.Add(this.menuButton);
            this.salesTransition.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Location = new System.Drawing.Point(0, 35);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(146, 45);
            this.menuPanel.TabIndex = 4;
            // 
            // menuButton
            // 
            this.menuButton.Active = false;
            this.menuButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuButton.BorderRadius = 0;
            this.menuButton.ButtonText = "Menu";
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.menuButton, BunifuAnimatorNS.DecorationType.None);
            this.menuButton.DisabledColor = System.Drawing.Color.Gray;
            this.menuButton.Iconcolor = System.Drawing.Color.Transparent;
            this.menuButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("menuButton.Iconimage")));
            this.menuButton.Iconimage_right = null;
            this.menuButton.Iconimage_right_Selected = null;
            this.menuButton.Iconimage_Selected = null;
            this.menuButton.IconMarginLeft = 0;
            this.menuButton.IconMarginRight = 0;
            this.menuButton.IconRightVisible = true;
            this.menuButton.IconRightZoom = 0D;
            this.menuButton.IconVisible = true;
            this.menuButton.IconZoom = 50D;
            this.menuButton.IsTab = false;
            this.menuButton.Location = new System.Drawing.Point(3, 7);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4);
            this.menuButton.Name = "menuButton";
            this.menuButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.menuButton.OnHoverTextColor = System.Drawing.Color.White;
            this.menuButton.selected = false;
            this.menuButton.Size = new System.Drawing.Size(140, 34);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.menuButton.Textcolor = System.Drawing.Color.White;
            this.menuButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // apButtonTransition
            // 
            this.apButtonTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.apButtonTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.apButtonTransition.DefaultAnimation = animation3;
            this.apButtonTransition.Interval = 1;
            this.apButtonTransition.MaxAnimationTime = 500;
            this.apButtonTransition.TimeStep = 0.05F;
            // 
            // glTransition
            // 
            this.glTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.glTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.glTransition.DefaultAnimation = animation2;
            this.glTransition.Interval = 1;
            this.glTransition.MaxAnimationTime = 500;
            this.glTransition.TimeStep = 0.05F;
            // 
            // salesTransition
            // 
            this.salesTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.salesTransition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 1F;
            this.salesTransition.DefaultAnimation = animation5;
            this.salesTransition.Interval = 1;
            this.salesTransition.MaxAnimationTime = 500;
            this.salesTransition.TimeStep = 0.05F;
            // 
            // companyTransition
            // 
            this.companyTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.companyTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.companyTransition.DefaultAnimation = animation4;
            this.companyTransition.Interval = 1;
            this.companyTransition.MaxAnimationTime = 500;
            this.companyTransition.TimeStep = 0.05F;
            // 
            // menuPanelTransitionTwo
            // 
            this.menuPanelTransitionTwo.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.menuPanelTransitionTwo.Cursor = null;
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
            animation1.TransparencyCoeff = 0F;
            this.menuPanelTransitionTwo.DefaultAnimation = animation1;
            this.menuPanelTransitionTwo.Interval = 3;
            // 
            // Reliable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(948, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backPanel);
            this.salesTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reliable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Reliable_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            this.menuPanelTwo.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse mainMenuElipse;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private System.Windows.Forms.Panel backPanel;
        private Bunifu.Framework.UI.BunifuFlatButton menuButton;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton changePasswordButton;
        private BunifuAnimatorNS.BunifuTransition apButtonTransition;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BunifuAnimatorNS.BunifuTransition glTransition;
        private BunifuAnimatorNS.BunifuTransition companyTransition;
        private BunifuAnimatorNS.BunifuTransition salesTransition;
        private System.Windows.Forms.Panel menuPanelTwo;
        private BunifuAnimatorNS.BunifuTransition menuPanelTransitionTwo;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton companyInformationButton;
        private Bunifu.Framework.UI.BunifuFlatButton AccountManagementButton;
        private Bunifu.Framework.UI.BunifuTileButton AccountsReceivableButton;
        private Bunifu.Framework.UI.BunifuTileButton GeneralLedgerButton;
        private Bunifu.Framework.UI.BunifuTileButton ManagementButton;
        private Bunifu.Framework.UI.BunifuTileButton SalesButton;
        private Bunifu.Framework.UI.BunifuTileButton WarehouseButton;
        private Bunifu.Framework.UI.BunifuTileButton CatalogCreatorButton;
        private Bunifu.Framework.UI.BunifuTileButton CatalogCreatorButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton WarehouseButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton SalesButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton ManagementButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton AccountsReceivableButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton GeneralLedgerButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton AccountsPayableButtonDisabled;
        private Bunifu.Framework.UI.BunifuTileButton AccountsPayableButton;
        private Bunifu.Framework.UI.BunifuTileButton ReportingButton;
        private Bunifu.Framework.UI.BunifuTileButton ReportingDisabledButton;
    }
}

