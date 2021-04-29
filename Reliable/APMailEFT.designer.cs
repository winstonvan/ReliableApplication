namespace RMP_Inventory_Finder
{
    partial class APMailEFT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(APMailEFT));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.checkRegisterTab = new System.Windows.Forms.TabControl();
            this.APTab = new System.Windows.Forms.TabPage();
            this.mailButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.generatePDFS = new Bunifu.Framework.UI.BunifuTileButton();
            this.queryButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.label8 = new System.Windows.Forms.Label();
            this.postedFlagBox = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.emailDGV = new System.Windows.Forms.DataGridView();
            this.remittanceInfoTab = new System.Windows.Forms.TabPage();
            this.saveChanges = new Bunifu.Framework.UI.BunifuTileButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bccEmail = new System.Windows.Forms.TextBox();
            this.serverText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.productDescriptionLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.compAddressTwo = new System.Windows.Forms.TextBox();
            this.compAddressOne = new System.Windows.Forms.TextBox();
            this.compName = new System.Windows.Forms.TextBox();
            this.searchKeysLabel = new System.Windows.Forms.Label();
            this.itemNumberLabel = new System.Windows.Forms.Label();
            this.creatorName = new System.Windows.Forms.TextBox();
            this.checkRegisterPage = new System.Windows.Forms.TabPage();
            this.checkRegisterPDFButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.label10 = new System.Windows.Forms.Label();
            this.checkRegisterFlag = new System.Windows.Forms.TextBox();
            this.checkRegisterQueryButton = new Bunifu.Framework.UI.BunifuTileButton();
            this.label9 = new System.Windows.Forms.Label();
            this.checkRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.checkRegisterDGV = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rMPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RMPConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.rISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RISConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.checkRegisterTab.SuspendLayout();
            this.APTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDGV)).BeginInit();
            this.remittanceInfoTab.SuspendLayout();
            this.checkRegisterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkRegisterDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkRegisterTab
            // 
            this.checkRegisterTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkRegisterTab.Controls.Add(this.APTab);
            this.checkRegisterTab.Controls.Add(this.remittanceInfoTab);
            this.checkRegisterTab.Controls.Add(this.checkRegisterPage);
            this.checkRegisterTab.HotTrack = true;
            this.checkRegisterTab.Location = new System.Drawing.Point(0, 63);
            this.checkRegisterTab.Name = "checkRegisterTab";
            this.checkRegisterTab.SelectedIndex = 0;
            this.checkRegisterTab.Size = new System.Drawing.Size(1152, 476);
            this.checkRegisterTab.TabIndex = 1;
            this.checkRegisterTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.pageLayoutTabs_DrawItem_1);
            // 
            // APTab
            // 
            this.APTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.APTab.Controls.Add(this.mailButton);
            this.APTab.Controls.Add(this.generatePDFS);
            this.APTab.Controls.Add(this.queryButton);
            this.APTab.Controls.Add(this.label8);
            this.APTab.Controls.Add(this.postedFlagBox);
            this.APTab.Controls.Add(this.nameText);
            this.APTab.Controls.Add(this.label2);
            this.APTab.Controls.Add(this.label1);
            this.APTab.Controls.Add(this.dateTimePicker1);
            this.APTab.Controls.Add(this.emailDGV);
            this.APTab.Location = new System.Drawing.Point(4, 22);
            this.APTab.Name = "APTab";
            this.APTab.Padding = new System.Windows.Forms.Padding(3);
            this.APTab.Size = new System.Drawing.Size(1144, 450);
            this.APTab.TabIndex = 0;
            this.APTab.Text = "Accounts Payable";
            // 
            // mailButton
            // 
            this.mailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mailButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.mailButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.mailButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailButton.ForeColor = System.Drawing.Color.White;
            this.mailButton.Image = ((System.Drawing.Image)(resources.GetObject("mailButton.Image")));
            this.mailButton.ImagePosition = 2;
            this.mailButton.ImageZoom = 70;
            this.mailButton.LabelPosition = 27;
            this.mailButton.LabelText = "Send Mail";
            this.mailButton.Location = new System.Drawing.Point(901, 18);
            this.mailButton.Margin = new System.Windows.Forms.Padding(5);
            this.mailButton.Name = "mailButton";
            this.mailButton.Size = new System.Drawing.Size(123, 120);
            this.mailButton.TabIndex = 15;
            this.mailButton.Click += new System.EventHandler(this.mailButton_Click);
            // 
            // generatePDFS
            // 
            this.generatePDFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.generatePDFS.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.generatePDFS.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.generatePDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generatePDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatePDFS.ForeColor = System.Drawing.Color.White;
            this.generatePDFS.Image = ((System.Drawing.Image)(resources.GetObject("generatePDFS.Image")));
            this.generatePDFS.ImagePosition = 2;
            this.generatePDFS.ImageZoom = 70;
            this.generatePDFS.LabelPosition = 27;
            this.generatePDFS.LabelText = "Generate PDFs";
            this.generatePDFS.Location = new System.Drawing.Point(654, 18);
            this.generatePDFS.Margin = new System.Windows.Forms.Padding(5);
            this.generatePDFS.Name = "generatePDFS";
            this.generatePDFS.Size = new System.Drawing.Size(123, 120);
            this.generatePDFS.TabIndex = 14;
            this.generatePDFS.Click += new System.EventHandler(this.generatePDFS_Click);
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
            this.queryButton.Location = new System.Drawing.Point(399, 18);
            this.queryButton.Margin = new System.Windows.Forms.Padding(6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(123, 120);
            this.queryButton.TabIndex = 13;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(74, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Flag:";
            // 
            // postedFlagBox
            // 
            this.postedFlagBox.Location = new System.Drawing.Point(110, 92);
            this.postedFlagBox.Name = "postedFlagBox";
            this.postedFlagBox.Size = new System.Drawing.Size(158, 20);
            this.postedFlagBox.TabIndex = 11;
            this.postedFlagBox.Text = "N";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(110, 64);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(158, 20);
            this.nameText.TabIndex = 8;
            this.nameText.Text = "EFT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // emailDGV
            // 
            this.emailDGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.emailDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailDGV.Location = new System.Drawing.Point(8, 156);
            this.emailDGV.Name = "emailDGV";
            this.emailDGV.Size = new System.Drawing.Size(1128, 286);
            this.emailDGV.TabIndex = 0;
            // 
            // remittanceInfoTab
            // 
            this.remittanceInfoTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.remittanceInfoTab.Controls.Add(this.saveChanges);
            this.remittanceInfoTab.Controls.Add(this.label7);
            this.remittanceInfoTab.Controls.Add(this.bccEmail);
            this.remittanceInfoTab.Controls.Add(this.serverText);
            this.remittanceInfoTab.Controls.Add(this.label6);
            this.remittanceInfoTab.Controls.Add(this.label5);
            this.remittanceInfoTab.Controls.Add(this.label4);
            this.remittanceInfoTab.Controls.Add(this.label3);
            this.remittanceInfoTab.Controls.Add(this.productDescriptionLabel);
            this.remittanceInfoTab.Controls.Add(this.passwordText);
            this.remittanceInfoTab.Controls.Add(this.emailText);
            this.remittanceInfoTab.Controls.Add(this.compAddressTwo);
            this.remittanceInfoTab.Controls.Add(this.compAddressOne);
            this.remittanceInfoTab.Controls.Add(this.compName);
            this.remittanceInfoTab.Controls.Add(this.searchKeysLabel);
            this.remittanceInfoTab.Controls.Add(this.itemNumberLabel);
            this.remittanceInfoTab.Controls.Add(this.creatorName);
            this.remittanceInfoTab.Location = new System.Drawing.Point(4, 22);
            this.remittanceInfoTab.Name = "remittanceInfoTab";
            this.remittanceInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.remittanceInfoTab.Size = new System.Drawing.Size(1144, 450);
            this.remittanceInfoTab.TabIndex = 1;
            this.remittanceInfoTab.Text = "Additional Info";
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.saveChanges.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.saveChanges.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.saveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChanges.ForeColor = System.Drawing.Color.White;
            this.saveChanges.Image = ((System.Drawing.Image)(resources.GetObject("saveChanges.Image")));
            this.saveChanges.ImagePosition = 10;
            this.saveChanges.ImageZoom = 60;
            this.saveChanges.LabelPosition = 27;
            this.saveChanges.LabelText = "Save";
            this.saveChanges.Location = new System.Drawing.Point(490, 249);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(6);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(123, 120);
            this.saveChanges.TabIndex = 23;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(747, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "BCC:";
            // 
            // bccEmail
            // 
            this.bccEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bccEmail.Location = new System.Drawing.Point(784, 144);
            this.bccEmail.Name = "bccEmail";
            this.bccEmail.Size = new System.Drawing.Size(204, 20);
            this.bccEmail.TabIndex = 21;
            this.bccEmail.Text = "AP@reliableclean.com";
            // 
            // serverText
            // 
            this.serverText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serverText.Location = new System.Drawing.Point(784, 118);
            this.serverText.Name = "serverText";
            this.serverText.Size = new System.Drawing.Size(204, 20);
            this.serverText.TabIndex = 20;
            this.serverText.Text = "mail.reliableclean.com";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(737, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Server:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(722, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(740, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(321, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Company Address Part 2:";
            // 
            // productDescriptionLabel
            // 
            this.productDescriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.productDescriptionLabel.AutoSize = true;
            this.productDescriptionLabel.ForeColor = System.Drawing.Color.White;
            this.productDescriptionLabel.Location = new System.Drawing.Point(321, 94);
            this.productDescriptionLabel.Name = "productDescriptionLabel";
            this.productDescriptionLabel.Size = new System.Drawing.Size(126, 13);
            this.productDescriptionLabel.TabIndex = 12;
            this.productDescriptionLabel.Text = "Company Address Part 1:";
            // 
            // passwordText
            // 
            this.passwordText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordText.Location = new System.Drawing.Point(784, 91);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '•';
            this.passwordText.Size = new System.Drawing.Size(204, 20);
            this.passwordText.TabIndex = 9;
            this.passwordText.Text = "5Cb5036ad0";
            // 
            // emailText
            // 
            this.emailText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailText.Location = new System.Drawing.Point(784, 65);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(204, 20);
            this.emailText.TabIndex = 8;
            this.emailText.Text = "rcs@reliableclean.com";
            // 
            // compAddressTwo
            // 
            this.compAddressTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compAddressTwo.Location = new System.Drawing.Point(453, 117);
            this.compAddressTwo.Name = "compAddressTwo";
            this.compAddressTwo.Size = new System.Drawing.Size(208, 20);
            this.compAddressTwo.TabIndex = 6;
            this.compAddressTwo.Text = "Sudbury, ON P3C 4E1";
            // 
            // compAddressOne
            // 
            this.compAddressOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compAddressOne.Location = new System.Drawing.Point(453, 91);
            this.compAddressOne.Name = "compAddressOne";
            this.compAddressOne.Size = new System.Drawing.Size(208, 20);
            this.compAddressOne.TabIndex = 5;
            this.compAddressOne.Text = "345 Regent Street";
            // 
            // compName
            // 
            this.compName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.compName.Location = new System.Drawing.Point(453, 65);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(208, 20);
            this.compName.TabIndex = 4;
            this.compName.Text = "Reliable Maintenance Products";
            // 
            // searchKeysLabel
            // 
            this.searchKeysLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchKeysLabel.AutoSize = true;
            this.searchKeysLabel.ForeColor = System.Drawing.Color.White;
            this.searchKeysLabel.Location = new System.Drawing.Point(362, 68);
            this.searchKeysLabel.Name = "searchKeysLabel";
            this.searchKeysLabel.Size = new System.Drawing.Size(85, 13);
            this.searchKeysLabel.TabIndex = 3;
            this.searchKeysLabel.Text = "Company Name:";
            // 
            // itemNumberLabel
            // 
            this.itemNumberLabel.AutoSize = true;
            this.itemNumberLabel.ForeColor = System.Drawing.Color.White;
            this.itemNumberLabel.Location = new System.Drawing.Point(29, 68);
            this.itemNumberLabel.Name = "itemNumberLabel";
            this.itemNumberLabel.Size = new System.Drawing.Size(91, 13);
            this.itemNumberLabel.TabIndex = 1;
            this.itemNumberLabel.Text = "Accounting Clerk:";
            // 
            // creatorName
            // 
            this.creatorName.Location = new System.Drawing.Point(126, 65);
            this.creatorName.Name = "creatorName";
            this.creatorName.Size = new System.Drawing.Size(173, 20);
            this.creatorName.TabIndex = 0;
            this.creatorName.Text = "Geninne";
            // 
            // checkRegisterPage
            // 
            this.checkRegisterPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.checkRegisterPage.Controls.Add(this.checkRegisterPDFButton);
            this.checkRegisterPage.Controls.Add(this.label10);
            this.checkRegisterPage.Controls.Add(this.checkRegisterFlag);
            this.checkRegisterPage.Controls.Add(this.checkRegisterQueryButton);
            this.checkRegisterPage.Controls.Add(this.label9);
            this.checkRegisterPage.Controls.Add(this.checkRegisterDate);
            this.checkRegisterPage.Controls.Add(this.checkRegisterDGV);
            this.checkRegisterPage.Location = new System.Drawing.Point(4, 22);
            this.checkRegisterPage.Name = "checkRegisterPage";
            this.checkRegisterPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkRegisterPage.Size = new System.Drawing.Size(1144, 450);
            this.checkRegisterPage.TabIndex = 2;
            this.checkRegisterPage.Text = "Cheque Register";
            // 
            // checkRegisterPDFButton
            // 
            this.checkRegisterPDFButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkRegisterPDFButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkRegisterPDFButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.checkRegisterPDFButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRegisterPDFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegisterPDFButton.ForeColor = System.Drawing.Color.White;
            this.checkRegisterPDFButton.Image = ((System.Drawing.Image)(resources.GetObject("checkRegisterPDFButton.Image")));
            this.checkRegisterPDFButton.ImagePosition = 2;
            this.checkRegisterPDFButton.ImageZoom = 70;
            this.checkRegisterPDFButton.LabelPosition = 27;
            this.checkRegisterPDFButton.LabelText = "Export to PDF";
            this.checkRegisterPDFButton.Location = new System.Drawing.Point(217, 292);
            this.checkRegisterPDFButton.Margin = new System.Windows.Forms.Padding(5);
            this.checkRegisterPDFButton.Name = "checkRegisterPDFButton";
            this.checkRegisterPDFButton.Size = new System.Drawing.Size(123, 120);
            this.checkRegisterPDFButton.TabIndex = 17;
            this.checkRegisterPDFButton.Visible = false;
            this.checkRegisterPDFButton.Click += new System.EventHandler(this.checkRegisterPDFButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(168, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Flag:";
            // 
            // checkRegisterFlag
            // 
            this.checkRegisterFlag.Location = new System.Drawing.Point(204, 100);
            this.checkRegisterFlag.Name = "checkRegisterFlag";
            this.checkRegisterFlag.Size = new System.Drawing.Size(158, 20);
            this.checkRegisterFlag.TabIndex = 15;
            this.checkRegisterFlag.Text = "N";
            // 
            // checkRegisterQueryButton
            // 
            this.checkRegisterQueryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkRegisterQueryButton.color = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkRegisterQueryButton.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.checkRegisterQueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkRegisterQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRegisterQueryButton.ForeColor = System.Drawing.Color.White;
            this.checkRegisterQueryButton.Image = ((System.Drawing.Image)(resources.GetObject("checkRegisterQueryButton.Image")));
            this.checkRegisterQueryButton.ImagePosition = 2;
            this.checkRegisterQueryButton.ImageZoom = 70;
            this.checkRegisterQueryButton.LabelPosition = 27;
            this.checkRegisterQueryButton.LabelText = "Query";
            this.checkRegisterQueryButton.Location = new System.Drawing.Point(217, 150);
            this.checkRegisterQueryButton.Margin = new System.Windows.Forms.Padding(6);
            this.checkRegisterQueryButton.Name = "checkRegisterQueryButton";
            this.checkRegisterQueryButton.Size = new System.Drawing.Size(123, 120);
            this.checkRegisterQueryButton.TabIndex = 14;
            this.checkRegisterQueryButton.Click += new System.EventHandler(this.checkRegisterQueryButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(165, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Date:";
            // 
            // checkRegisterDate
            // 
            this.checkRegisterDate.Location = new System.Drawing.Point(204, 64);
            this.checkRegisterDate.Name = "checkRegisterDate";
            this.checkRegisterDate.Size = new System.Drawing.Size(200, 20);
            this.checkRegisterDate.TabIndex = 2;
            // 
            // checkRegisterDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkRegisterDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.checkRegisterDGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkRegisterDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.checkRegisterDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkRegisterDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.checkRegisterDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.checkRegisterDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkRegisterDGV.DoubleBuffered = true;
            this.checkRegisterDGV.EnableHeadersVisualStyles = false;
            this.checkRegisterDGV.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.checkRegisterDGV.HeaderForeColor = System.Drawing.Color.White;
            this.checkRegisterDGV.Location = new System.Drawing.Point(597, 6);
            this.checkRegisterDGV.Name = "checkRegisterDGV";
            this.checkRegisterDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.checkRegisterDGV.Size = new System.Drawing.Size(539, 438);
            this.checkRegisterDGV.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1152, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.RISConnect.Click += new System.EventHandler(this.RISConnect_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 36);
            this.panel1.TabIndex = 3;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 20);
            this.bunifuCustomLabel2.TabIndex = 18;
            this.bunifuCustomLabel2.Text = "EFT Mail";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
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
            this.minimizeButton.Location = new System.Drawing.Point(1072, 3);
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
            this.closeButton.Location = new System.Drawing.Point(1109, 3);
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
            // APMailEFT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1152, 539);
            this.Controls.Add(this.checkRegisterTab);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "APMailEFT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AP EFT Mail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.checkRegisterTab.ResumeLayout(false);
            this.APTab.ResumeLayout(false);
            this.APTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailDGV)).EndInit();
            this.remittanceInfoTab.ResumeLayout(false);
            this.remittanceInfoTab.PerformLayout();
            this.checkRegisterPage.ResumeLayout(false);
            this.checkRegisterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkRegisterDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl checkRegisterTab;
        private System.Windows.Forms.TabPage APTab;
        private System.Windows.Forms.TabPage remittanceInfoTab;
        private System.Windows.Forms.DataGridView emailDGV;
        private System.Windows.Forms.Label itemNumberLabel;
        private System.Windows.Forms.TextBox creatorName;
        private System.Windows.Forms.Label productDescriptionLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox compAddressTwo;
        private System.Windows.Forms.TextBox compAddressOne;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.Label searchKeysLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox bccEmail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rMPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RMPConnect;
        private System.Windows.Forms.ToolStripMenuItem rISToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RISConnect;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox postedFlagBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton closeButton;
        private Bunifu.Framework.UI.BunifuFlatButton minimizeButton;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuTileButton queryButton;
        private Bunifu.Framework.UI.BunifuTileButton mailButton;
        private Bunifu.Framework.UI.BunifuTileButton generatePDFS;
        private Bunifu.Framework.UI.BunifuTileButton saveChanges;
        private System.Windows.Forms.TabPage checkRegisterPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker checkRegisterDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid checkRegisterDGV;
        private Bunifu.Framework.UI.BunifuTileButton checkRegisterQueryButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox checkRegisterFlag;
        private Bunifu.Framework.UI.BunifuTileButton checkRegisterPDFButton;
    }
}

