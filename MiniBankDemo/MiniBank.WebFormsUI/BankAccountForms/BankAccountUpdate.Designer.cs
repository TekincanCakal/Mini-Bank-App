
namespace MiniBank.WebFormsUI.BankAccountForms
{
    partial class BankAccountUpdate
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
            this.btnGetBankAccount = new System.Windows.Forms.Button();
            this.tbxBankAccountNumber = new System.Windows.Forms.TextBox();
            this.lblBankAccountNumber = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnGive = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblMoney = new System.Windows.Forms.Label();
            this.tbxMoney = new System.Windows.Forms.TextBox();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetBankAccount
            // 
            this.btnGetBankAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBankAccount.ForeColor = System.Drawing.Color.White;
            this.btnGetBankAccount.Location = new System.Drawing.Point(250, 80);
            this.btnGetBankAccount.Name = "btnGetBankAccount";
            this.btnGetBankAccount.Size = new System.Drawing.Size(296, 32);
            this.btnGetBankAccount.TabIndex = 34;
            this.btnGetBankAccount.Text = "Get Bank Account";
            this.btnGetBankAccount.UseVisualStyleBackColor = true;
            this.btnGetBankAccount.Click += new System.EventHandler(this.btnGetBankAccount_Click);
            // 
            // tbxBankAccountNumber
            // 
            this.tbxBankAccountNumber.Location = new System.Drawing.Point(250, 39);
            this.tbxBankAccountNumber.Name = "tbxBankAccountNumber";
            this.tbxBankAccountNumber.Size = new System.Drawing.Size(296, 32);
            this.tbxBankAccountNumber.TabIndex = 33;
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.ForeColor = System.Drawing.Color.White;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(250, 10);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(300, 30);
            this.lblBankAccountNumber.TabIndex = 32;
            this.lblBankAccountNumber.Text = "Bank Account Number";
            this.lblBankAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnGive);
            this.pnlMain.Controls.Add(this.textBox1);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnWithdraw);
            this.pnlMain.Controls.Add(this.lblMoney);
            this.pnlMain.Controls.Add(this.tbxMoney);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(16, 118);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(772, 470);
            this.pnlMain.TabIndex = 35;
            this.pnlMain.Visible = false;
            // 
            // btnGive
            // 
            this.btnGive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGive.ForeColor = System.Drawing.Color.White;
            this.btnGive.Location = new System.Drawing.Point(10, 81);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(200, 32);
            this.btnGive.TabIndex = 36;
            this.btnGive.Text = "Give";
            this.btnGive.UseVisualStyleBackColor = true;
            this.btnGive.Click += new System.EventHandler(this.btnGive_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 32);
            this.textBox1.TabIndex = 35;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(467, 32);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(10, 43);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(200, 32);
            this.btnWithdraw.TabIndex = 32;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblMoney
            // 
            this.lblMoney.ForeColor = System.Drawing.Color.White;
            this.lblMoney.Location = new System.Drawing.Point(10, 10);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(300, 30);
            this.lblMoney.TabIndex = 14;
            this.lblMoney.Text = "Money:";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMoney
            // 
            this.tbxMoney.Location = new System.Drawing.Point(216, 43);
            this.tbxMoney.Name = "tbxMoney";
            this.tbxMoney.Size = new System.Drawing.Size(258, 32);
            this.tbxMoney.TabIndex = 15;
            // 
            // BankAccountUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnGetBankAccount);
            this.Controls.Add(this.tbxBankAccountNumber);
            this.Controls.Add(this.lblBankAccountNumber);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BankAccountUpdate";
            this.Text = "BankAccountUpdate";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetBankAccount;
        private System.Windows.Forms.TextBox tbxBankAccountNumber;
        private System.Windows.Forms.Label lblBankAccountNumber;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox tbxMoney;
        private System.Windows.Forms.Button btnGive;
        private System.Windows.Forms.TextBox textBox1;
    }
}