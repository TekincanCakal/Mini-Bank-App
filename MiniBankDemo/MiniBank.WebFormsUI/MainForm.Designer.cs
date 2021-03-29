namespace MiniBank.WebFormsUI
{
    partial class MainForm
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlBotBar = new System.Windows.Forms.Panel();
            this.pnlMidBar = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlCreditCard = new System.Windows.Forms.Panel();
            this.btnCreditCardList = new System.Windows.Forms.Button();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.pnlBankAcount = new System.Windows.Forms.Panel();
            this.btnBankAccountUpdate = new System.Windows.Forms.Button();
            this.btnBankAccountList = new System.Windows.Forms.Button();
            this.btnBankAccount = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnCustomerNew = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.lblUserNameInfo = new System.Windows.Forms.Label();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.pnlTopBar.SuspendLayout();
            this.pnlBotBar.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlCreditCard.SuspendLayout();
            this.pnlBankAcount.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Black;
            this.pnlTopBar.Controls.Add(this.btnExit);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1000, 30);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDoubleClick);
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            this.pnlTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseMove);
            this.pnlTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Aqua;
            this.btnExit.Location = new System.Drawing.Point(975, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlBotBar
            // 
            this.pnlBotBar.Controls.Add(this.pnlMidBar);
            this.pnlBotBar.Controls.Add(this.pnlLeft);
            this.pnlBotBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotBar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.pnlBotBar.Location = new System.Drawing.Point(0, 30);
            this.pnlBotBar.Name = "pnlBotBar";
            this.pnlBotBar.Size = new System.Drawing.Size(1000, 600);
            this.pnlBotBar.TabIndex = 2;
            // 
            // pnlMidBar
            // 
            this.pnlMidBar.AutoScroll = true;
            this.pnlMidBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlMidBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMidBar.Location = new System.Drawing.Point(200, 0);
            this.pnlMidBar.Name = "pnlMidBar";
            this.pnlMidBar.Size = new System.Drawing.Size(800, 600);
            this.pnlMidBar.TabIndex = 1;
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlLeft.Controls.Add(this.pnlMenu);
            this.pnlLeft.Controls.Add(this.pnlUserInfo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(200, 600);
            this.pnlLeft.TabIndex = 8;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenu.Controls.Add(this.pnlCreditCard);
            this.pnlMenu.Controls.Add(this.btnCreditCard);
            this.pnlMenu.Controls.Add(this.pnlBankAcount);
            this.pnlMenu.Controls.Add(this.btnBankAccount);
            this.pnlMenu.Controls.Add(this.pnlCustomer);
            this.pnlMenu.Controls.Add(this.btnCustomer);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 225);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 375);
            this.pnlMenu.TabIndex = 3;
            // 
            // pnlCreditCard
            // 
            this.pnlCreditCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCreditCard.Controls.Add(this.btnCreditCardList);
            this.pnlCreditCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCreditCard.Location = new System.Drawing.Point(0, 250);
            this.pnlCreditCard.Name = "pnlCreditCard";
            this.pnlCreditCard.Size = new System.Drawing.Size(200, 35);
            this.pnlCreditCard.TabIndex = 7;
            this.pnlCreditCard.Visible = false;
            // 
            // btnCreditCardList
            // 
            this.btnCreditCardList.BackColor = System.Drawing.Color.Transparent;
            this.btnCreditCardList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreditCardList.FlatAppearance.BorderSize = 0;
            this.btnCreditCardList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCreditCardList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCreditCardList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditCardList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreditCardList.ForeColor = System.Drawing.Color.LightGray;
            this.btnCreditCardList.Location = new System.Drawing.Point(0, 0);
            this.btnCreditCardList.Name = "btnCreditCardList";
            this.btnCreditCardList.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCreditCardList.Size = new System.Drawing.Size(200, 30);
            this.btnCreditCardList.TabIndex = 2;
            this.btnCreditCardList.Text = "List";
            this.btnCreditCardList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditCardList.UseVisualStyleBackColor = false;
            this.btnCreditCardList.Click += new System.EventHandler(this.btnCreditCardList_Click);
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreditCard.FlatAppearance.BorderSize = 0;
            this.btnCreditCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btnCreditCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.btnCreditCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditCard.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreditCard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCreditCard.Location = new System.Drawing.Point(0, 220);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCreditCard.Size = new System.Drawing.Size(200, 30);
            this.btnCreditCard.TabIndex = 6;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // pnlBankAcount
            // 
            this.pnlBankAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlBankAcount.Controls.Add(this.btnBankAccountUpdate);
            this.pnlBankAcount.Controls.Add(this.btnBankAccountList);
            this.pnlBankAcount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBankAcount.Location = new System.Drawing.Point(0, 155);
            this.pnlBankAcount.Name = "pnlBankAcount";
            this.pnlBankAcount.Size = new System.Drawing.Size(200, 65);
            this.pnlBankAcount.TabIndex = 5;
            this.pnlBankAcount.Visible = false;
            // 
            // btnBankAccountUpdate
            // 
            this.btnBankAccountUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnBankAccountUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBankAccountUpdate.FlatAppearance.BorderSize = 0;
            this.btnBankAccountUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBankAccountUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBankAccountUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankAccountUpdate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankAccountUpdate.ForeColor = System.Drawing.Color.LightGray;
            this.btnBankAccountUpdate.Location = new System.Drawing.Point(0, 30);
            this.btnBankAccountUpdate.Name = "btnBankAccountUpdate";
            this.btnBankAccountUpdate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBankAccountUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnBankAccountUpdate.TabIndex = 3;
            this.btnBankAccountUpdate.Text = "Update";
            this.btnBankAccountUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankAccountUpdate.UseVisualStyleBackColor = false;
            this.btnBankAccountUpdate.Click += new System.EventHandler(this.btnBankAccountUpdate_Click);
            // 
            // btnBankAccountList
            // 
            this.btnBankAccountList.BackColor = System.Drawing.Color.Transparent;
            this.btnBankAccountList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBankAccountList.FlatAppearance.BorderSize = 0;
            this.btnBankAccountList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBankAccountList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBankAccountList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankAccountList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankAccountList.ForeColor = System.Drawing.Color.LightGray;
            this.btnBankAccountList.Location = new System.Drawing.Point(0, 0);
            this.btnBankAccountList.Name = "btnBankAccountList";
            this.btnBankAccountList.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBankAccountList.Size = new System.Drawing.Size(200, 30);
            this.btnBankAccountList.TabIndex = 2;
            this.btnBankAccountList.Text = "List";
            this.btnBankAccountList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankAccountList.UseVisualStyleBackColor = false;
            this.btnBankAccountList.Click += new System.EventHandler(this.btnBankAccountList_Click);
            // 
            // btnBankAccount
            // 
            this.btnBankAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBankAccount.FlatAppearance.BorderSize = 0;
            this.btnBankAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btnBankAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.btnBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankAccount.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBankAccount.Location = new System.Drawing.Point(0, 125);
            this.btnBankAccount.Name = "btnBankAccount";
            this.btnBankAccount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBankAccount.Size = new System.Drawing.Size(200, 30);
            this.btnBankAccount.TabIndex = 4;
            this.btnBankAccount.Text = "Bank Account";
            this.btnBankAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankAccount.UseVisualStyleBackColor = true;
            this.btnBankAccount.Click += new System.EventHandler(this.btnBankAccount_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlCustomer.Controls.Add(this.btnCustomerUpdate);
            this.pnlCustomer.Controls.Add(this.btnCustomerList);
            this.pnlCustomer.Controls.Add(this.btnCustomerNew);
            this.pnlCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCustomer.Location = new System.Drawing.Point(0, 30);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(200, 95);
            this.pnlCustomer.TabIndex = 3;
            this.pnlCustomer.Visible = false;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerUpdate.FlatAppearance.BorderSize = 0;
            this.btnCustomerUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCustomerUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCustomerUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUpdate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerUpdate.ForeColor = System.Drawing.Color.LightGray;
            this.btnCustomerUpdate.Location = new System.Drawing.Point(0, 60);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCustomerUpdate.Size = new System.Drawing.Size(200, 30);
            this.btnCustomerUpdate.TabIndex = 3;
            this.btnCustomerUpdate.Text = "Update";
            this.btnCustomerUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerUpdate.UseVisualStyleBackColor = false;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerList.FlatAppearance.BorderSize = 0;
            this.btnCustomerList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCustomerList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCustomerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerList.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerList.ForeColor = System.Drawing.Color.LightGray;
            this.btnCustomerList.Location = new System.Drawing.Point(0, 30);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCustomerList.Size = new System.Drawing.Size(200, 30);
            this.btnCustomerList.TabIndex = 2;
            this.btnCustomerList.Text = "List";
            this.btnCustomerList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerList.UseVisualStyleBackColor = false;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnCustomerNew
            // 
            this.btnCustomerNew.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomerNew.FlatAppearance.BorderSize = 0;
            this.btnCustomerNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCustomerNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCustomerNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerNew.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerNew.ForeColor = System.Drawing.Color.LightGray;
            this.btnCustomerNew.Location = new System.Drawing.Point(0, 0);
            this.btnCustomerNew.Name = "btnCustomerNew";
            this.btnCustomerNew.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCustomerNew.Size = new System.Drawing.Size(200, 30);
            this.btnCustomerNew.TabIndex = 1;
            this.btnCustomerNew.Text = "New";
            this.btnCustomerNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomerNew.UseVisualStyleBackColor = false;
            this.btnCustomerNew.Click += new System.EventHandler(this.btnCustomerNew_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(21)))), ((int)(((byte)(51)))));
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomer.Location = new System.Drawing.Point(0, 0);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(200, 30);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlUserInfo.Controls.Add(this.lblUserNameInfo);
            this.pnlUserInfo.Controls.Add(this.pbUserImage);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(200, 225);
            this.pnlUserInfo.TabIndex = 2;
            // 
            // lblUserNameInfo
            // 
            this.lblUserNameInfo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserNameInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserNameInfo.Location = new System.Drawing.Point(3, 178);
            this.lblUserNameInfo.Name = "lblUserNameInfo";
            this.lblUserNameInfo.Size = new System.Drawing.Size(194, 30);
            this.lblUserNameInfo.TabIndex = 3;
            this.lblUserNameInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbUserImage
            // 
            this.pbUserImage.BackgroundImage = global::MiniBank.WebFormsUI.Properties.Resources.Man_Avatar;
            this.pbUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserImage.Location = new System.Drawing.Point(25, 25);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(150, 150);
            this.pbUserImage.TabIndex = 2;
            this.pbUserImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.pnlBotBar);
            this.Controls.Add(this.pnlTopBar);
            this.Font = new System.Drawing.Font("Ink Free", 18F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlBotBar.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlCreditCard.ResumeLayout(false);
            this.pnlBankAcount.ResumeLayout(false);
            this.pnlCustomer.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlBotBar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMidBar;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Label lblUserNameInfo;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnCustomerNew;
        private System.Windows.Forms.Panel pnlBankAcount;
        private System.Windows.Forms.Button btnBankAccountUpdate;
        private System.Windows.Forms.Button btnBankAccountList;
        private System.Windows.Forms.Button btnBankAccount;
        private System.Windows.Forms.Panel pnlCreditCard;
        private System.Windows.Forms.Button btnCreditCardList;
        private System.Windows.Forms.Button btnCreditCard;
    }
}