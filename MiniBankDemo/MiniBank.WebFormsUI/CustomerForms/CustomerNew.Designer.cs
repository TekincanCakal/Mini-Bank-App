
namespace MiniBank.WebFormsUI.CustomerForms
{
    partial class CustomerNew
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
            this.lblIdentityNumber = new System.Windows.Forms.Label();
            this.tbxIdentityNumber = new System.Windows.Forms.TextBox();
            this.lnlFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lnlLastName = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lnlPassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbIsAdmin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.ForeColor = System.Drawing.Color.White;
            this.lblIdentityNumber.Location = new System.Drawing.Point(250, 50);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(300, 30);
            this.lblIdentityNumber.TabIndex = 0;
            this.lblIdentityNumber.Text = "Identity Number";
            this.lblIdentityNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIdentityNumber
            // 
            this.tbxIdentityNumber.Location = new System.Drawing.Point(254, 83);
            this.tbxIdentityNumber.Name = "tbxIdentityNumber";
            this.tbxIdentityNumber.Size = new System.Drawing.Size(296, 32);
            this.tbxIdentityNumber.TabIndex = 1;
            this.tbxIdentityNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxIdentityNumber_KeyPress);
            // 
            // lnlFirstName
            // 
            this.lnlFirstName.ForeColor = System.Drawing.Color.White;
            this.lnlFirstName.Location = new System.Drawing.Point(250, 118);
            this.lnlFirstName.Name = "lnlFirstName";
            this.lnlFirstName.Size = new System.Drawing.Size(300, 30);
            this.lnlFirstName.TabIndex = 2;
            this.lnlFirstName.Text = "First Name";
            this.lnlFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(254, 151);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(296, 32);
            this.tbxFirstName.TabIndex = 3;
            this.tbxFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFirstName_KeyPress);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(254, 219);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(296, 32);
            this.tbxLastName.TabIndex = 5;
            this.tbxLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastName_KeyPress);
            // 
            // lnlLastName
            // 
            this.lnlLastName.ForeColor = System.Drawing.Color.White;
            this.lnlLastName.Location = new System.Drawing.Point(250, 186);
            this.lnlLastName.Name = "lnlLastName";
            this.lnlLastName.Size = new System.Drawing.Size(300, 30);
            this.lnlLastName.TabIndex = 4;
            this.lnlLastName.Text = "Last Name";
            this.lnlLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(254, 356);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(296, 32);
            this.tbxUsername.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(250, 323);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(300, 30);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(254, 424);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(296, 32);
            this.tbxPassword.TabIndex = 9;
            // 
            // lnlPassword
            // 
            this.lnlPassword.ForeColor = System.Drawing.Color.White;
            this.lnlPassword.Location = new System.Drawing.Point(250, 391);
            this.lnlPassword.Name = "lnlPassword";
            this.lnlPassword.Size = new System.Drawing.Size(300, 30);
            this.lnlPassword.TabIndex = 8;
            this.lnlPassword.Text = "Password";
            this.lnlPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(254, 497);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(296, 32);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "CustomerNew";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.ForeColor = System.Drawing.Color.White;
            this.lblDateOfBirth.Location = new System.Drawing.Point(250, 254);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(300, 30);
            this.lblDateOfBirth.TabIndex = 11;
            this.lblDateOfBirth.Text = "Date Of Birth";
            this.lblDateOfBirth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(254, 288);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(296, 32);
            this.dtpDateOfBirth.TabIndex = 12;
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.AutoSize = true;
            this.cbIsAdmin.ForeColor = System.Drawing.Color.White;
            this.cbIsAdmin.Location = new System.Drawing.Point(254, 463);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(113, 28);
            this.cbIsAdmin.TabIndex = 13;
            this.cbIsAdmin.Text = "isAdmin";
            this.cbIsAdmin.UseVisualStyleBackColor = true;
            // 
            // CustomerNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.cbIsAdmin);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.lnlPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lnlLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lnlFirstName);
            this.Controls.Add(this.tbxIdentityNumber);
            this.Controls.Add(this.lblIdentityNumber);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomerNew";
            this.Text = "CustomerNew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentityNumber;
        private System.Windows.Forms.TextBox tbxIdentityNumber;
        private System.Windows.Forms.Label lnlFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lnlLastName;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lnlPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.CheckBox cbIsAdmin;
    }
}