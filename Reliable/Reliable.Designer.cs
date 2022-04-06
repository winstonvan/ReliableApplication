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
            this.warehouseButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.managmentButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.salesNewButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.generalLedgerButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.accountsPayableButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuPanelTwo = new System.Windows.Forms.Panel();
            this.accountManagmentButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.companyInformationButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.changePasswordButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.apButtonTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.glTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.salesTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.companyTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuPanelTransitionTwo = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.backPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuPanelTwo.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1175, 36);
            this.panel1.TabIndex = 9;
            // 
            // minimizeButton
            // 
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
            this.minimizeButton.Location = new System.Drawing.Point(1095, 3);
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
            this.salesTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(12, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // closeButton
            // 
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
            this.closeButton.Location = new System.Drawing.Point(1132, 3);
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
            this.backPanel.Controls.Add(this.warehouseButton);
            this.backPanel.Controls.Add(this.managmentButton);
            this.backPanel.Controls.Add(this.salesNewButton);
            this.backPanel.Controls.Add(this.generalLedgerButton);
            this.backPanel.Controls.Add(this.accountsPayableButton);
            this.backPanel.Controls.Add(this.menuPanel);
            this.backPanel.Controls.Add(this.pictureBox1);
            this.backPanel.Controls.Add(this.menuPanelTwo);
            this.salesTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1175, 592);
            this.backPanel.TabIndex = 10;
            // 
            // warehouseButton
            // 
            this.warehouseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.warehouseButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.warehouseButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.warehouseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.warehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.warehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.warehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.warehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.warehouseButton, BunifuAnimatorNS.DecorationType.None);
            this.warehouseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warehouseButton.ForeColor = System.Drawing.Color.White;
            this.warehouseButton.Image = ((System.Drawing.Image)(resources.GetObject("warehouseButton.Image")));
            this.warehouseButton.ImagePosition = 5;
            this.warehouseButton.ImageZoom = 60;
            this.warehouseButton.LabelPosition = 34;
            this.warehouseButton.LabelText = "Warehouse";
            this.warehouseButton.Location = new System.Drawing.Point(928, 346);
            this.warehouseButton.Margin = new System.Windows.Forms.Padding(6);
            this.warehouseButton.Name = "warehouseButton";
            this.warehouseButton.Size = new System.Drawing.Size(169, 147);
            this.warehouseButton.TabIndex = 13;
            this.warehouseButton.Click += new System.EventHandler(this.WarehouseButton_Click);
            // 
            // managmentButton
            // 
            this.managmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.managmentButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.managmentButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.managmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.managmentButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.managmentButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.managmentButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.managmentButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.managmentButton, BunifuAnimatorNS.DecorationType.None);
            this.managmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managmentButton.ForeColor = System.Drawing.Color.White;
            this.managmentButton.Image = ((System.Drawing.Image)(resources.GetObject("managmentButton.Image")));
            this.managmentButton.ImagePosition = 2;
            this.managmentButton.ImageZoom = 70;
            this.managmentButton.LabelPosition = 34;
            this.managmentButton.LabelText = "Managment";
            this.managmentButton.Location = new System.Drawing.Point(488, 346);
            this.managmentButton.Margin = new System.Windows.Forms.Padding(6);
            this.managmentButton.Name = "managmentButton";
            this.managmentButton.Size = new System.Drawing.Size(169, 147);
            this.managmentButton.TabIndex = 12;
            this.managmentButton.Click += new System.EventHandler(this.ManagmentButton_Click);
            // 
            // salesNewButton
            // 
            this.salesNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.salesNewButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.salesNewButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.salesNewButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.salesNewButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.salesNewButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.salesNewButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.salesNewButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.salesNewButton, BunifuAnimatorNS.DecorationType.None);
            this.salesNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesNewButton.ForeColor = System.Drawing.Color.White;
            this.salesNewButton.Image = ((System.Drawing.Image)(resources.GetObject("salesNewButton.Image")));
            this.salesNewButton.ImagePosition = 6;
            this.salesNewButton.ImageZoom = 65;
            this.salesNewButton.LabelPosition = 34;
            this.salesNewButton.LabelText = "Sales";
            this.salesNewButton.Location = new System.Drawing.Point(713, 346);
            this.salesNewButton.Margin = new System.Windows.Forms.Padding(6);
            this.salesNewButton.Name = "salesNewButton";
            this.salesNewButton.Size = new System.Drawing.Size(169, 147);
            this.salesNewButton.TabIndex = 9;
            this.salesNewButton.Click += new System.EventHandler(this.SalesNewButton_Click);
            // 
            // generalLedgerButton
            // 
            this.generalLedgerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.generalLedgerButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.generalLedgerButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.generalLedgerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.generalLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.generalLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.generalLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.generalLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.generalLedgerButton, BunifuAnimatorNS.DecorationType.None);
            this.generalLedgerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.generalLedgerButton.ForeColor = System.Drawing.Color.White;
            this.generalLedgerButton.Image = ((System.Drawing.Image)(resources.GetObject("generalLedgerButton.Image")));
            this.generalLedgerButton.ImagePosition = 20;
            this.generalLedgerButton.ImageZoom = 50;
            this.generalLedgerButton.LabelPosition = 34;
            this.generalLedgerButton.LabelText = "General Ledger";
            this.generalLedgerButton.Location = new System.Drawing.Point(263, 346);
            this.generalLedgerButton.Margin = new System.Windows.Forms.Padding(6);
            this.generalLedgerButton.Name = "generalLedgerButton";
            this.generalLedgerButton.Size = new System.Drawing.Size(169, 147);
            this.generalLedgerButton.TabIndex = 8;
            this.generalLedgerButton.Click += new System.EventHandler(this.GeneralLedgerButton_Click);
            // 
            // accountsPayableButton
            // 
            this.accountsPayableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.accountsPayableButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.accountsPayableButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.accountsPayableButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.glTransition.SetDecoration(this.accountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.accountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.accountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.accountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.accountsPayableButton, BunifuAnimatorNS.DecorationType.None);
            this.accountsPayableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountsPayableButton.ForeColor = System.Drawing.Color.White;
            this.accountsPayableButton.Image = ((System.Drawing.Image)(resources.GetObject("accountsPayableButton.Image")));
            this.accountsPayableButton.ImagePosition = 17;
            this.accountsPayableButton.ImageZoom = 50;
            this.accountsPayableButton.LabelPosition = 34;
            this.accountsPayableButton.LabelText = "Accounts Payable";
            this.accountsPayableButton.Location = new System.Drawing.Point(48, 346);
            this.accountsPayableButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.accountsPayableButton.Name = "accountsPayableButton";
            this.accountsPayableButton.Size = new System.Drawing.Size(169, 147);
            this.accountsPayableButton.TabIndex = 7;
            this.accountsPayableButton.Click += new System.EventHandler(this.AccountsPayableButton_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.pictureBox1.BackgroundImage = global::Reliable.Properties.Resources.ReliableLongWhiteBlueNew;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.salesTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Location = new System.Drawing.Point(170, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 221);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuPanelTwo
            // 
            this.menuPanelTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuPanelTwo.Controls.Add(this.accountManagmentButton);
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
            // accountManagmentButton
            // 
            this.accountManagmentButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.accountManagmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.accountManagmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accountManagmentButton.BorderRadius = 0;
            this.accountManagmentButton.ButtonText = "Account Managment";
            this.accountManagmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuPanelTransitionTwo.SetDecoration(this.accountManagmentButton, BunifuAnimatorNS.DecorationType.None);
            this.glTransition.SetDecoration(this.accountManagmentButton, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this.accountManagmentButton, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this.accountManagmentButton, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this.accountManagmentButton, BunifuAnimatorNS.DecorationType.None);
            this.accountManagmentButton.DisabledColor = System.Drawing.Color.Gray;
            this.accountManagmentButton.Iconcolor = System.Drawing.Color.Transparent;
            this.accountManagmentButton.Iconimage = null;
            this.accountManagmentButton.Iconimage_right = null;
            this.accountManagmentButton.Iconimage_right_Selected = null;
            this.accountManagmentButton.Iconimage_Selected = null;
            this.accountManagmentButton.IconMarginLeft = 0;
            this.accountManagmentButton.IconMarginRight = 0;
            this.accountManagmentButton.IconRightVisible = true;
            this.accountManagmentButton.IconRightZoom = 0D;
            this.accountManagmentButton.IconVisible = true;
            this.accountManagmentButton.IconZoom = 90D;
            this.accountManagmentButton.IsTab = false;
            this.accountManagmentButton.Location = new System.Drawing.Point(3, 88);
            this.accountManagmentButton.Name = "accountManagmentButton";
            this.accountManagmentButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.accountManagmentButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.accountManagmentButton.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.accountManagmentButton.selected = false;
            this.accountManagmentButton.Size = new System.Drawing.Size(141, 28);
            this.accountManagmentButton.TabIndex = 2;
            this.accountManagmentButton.Text = "Account Managment";
            this.accountManagmentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.accountManagmentButton.Textcolor = System.Drawing.Color.White;
            this.accountManagmentButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManagmentButton.Click += new System.EventHandler(this.accountManagmentButton_Click);
            // 
            // companyInformationButton
            // 
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
            this.ClientSize = new System.Drawing.Size(1175, 592);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.backPanel);
            this.glTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.apButtonTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.companyTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.salesTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.menuPanelTransitionTwo.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reliable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dff";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reliable_FormClosing);
            this.Load += new System.EventHandler(this.Reliable_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.backPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuPanelTwo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse mainMenuElipse;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private System.Windows.Forms.Panel backPanel;
        private Bunifu.Framework.UI.BunifuFlatButton menuButton;
        private System.Windows.Forms.Panel menuPanel;
        private Bunifu.Framework.UI.BunifuFlatButton changePasswordButton;
        private Bunifu.Framework.UI.BunifuTileButton accountsPayableButton;
        private BunifuAnimatorNS.BunifuTransition apButtonTransition;
        private Bunifu.Framework.UI.BunifuTileButton salesNewButton;
        private Bunifu.Framework.UI.BunifuTileButton generalLedgerButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private BunifuAnimatorNS.BunifuTransition glTransition;
        private BunifuAnimatorNS.BunifuTransition companyTransition;
        private BunifuAnimatorNS.BunifuTransition salesTransition;
        private System.Windows.Forms.Panel menuPanelTwo;
        private BunifuAnimatorNS.BunifuTransition menuPanelTransitionTwo;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuFlatButton companyInformationButton;
        private Bunifu.Framework.UI.BunifuTileButton managmentButton;
        private Bunifu.Framework.UI.BunifuTileButton warehouseButton;
        private Bunifu.Framework.UI.BunifuFlatButton accountManagmentButton;
    }
}

