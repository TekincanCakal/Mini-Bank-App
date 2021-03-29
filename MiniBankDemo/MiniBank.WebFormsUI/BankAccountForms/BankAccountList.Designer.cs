
namespace MiniBank.WebFormsUI.BankAccountForms
{
    partial class BankAccountList
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
            this.dgwSearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwSearch
            // 
            this.dgwSearch.AllowUserToAddRows = false;
            this.dgwSearch.AllowUserToDeleteRows = false;
            this.dgwSearch.AllowUserToResizeColumns = false;
            this.dgwSearch.AllowUserToResizeRows = false;
            this.dgwSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgwSearch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgwSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwSearch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.dgwSearch.Location = new System.Drawing.Point(0, 0);
            this.dgwSearch.MultiSelect = false;
            this.dgwSearch.Name = "dgwSearch";
            this.dgwSearch.ReadOnly = true;
            this.dgwSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgwSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwSearch.Size = new System.Drawing.Size(800, 600);
            this.dgwSearch.TabIndex = 5;
            // 
            // BankAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgwSearch);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BankAccountList";
            this.Text = "BankAccountList";
            this.LocationChanged += new System.EventHandler(this.BankAccountList_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSearch;
    }
}