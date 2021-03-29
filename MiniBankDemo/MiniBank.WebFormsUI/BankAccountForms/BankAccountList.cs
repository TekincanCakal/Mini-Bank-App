using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniBank.WebFormsUI.BankAccountForms
{
    public partial class BankAccountList : Form
    {
        public BankAccountList()
        {
            InitializeComponent();
            styleGrid();
        }
        public void styleGrid()
        {
            dgwSearch.Font = new Font("Consolas", 12F, FontStyle.Regular);
            dgwSearch.ForeColor = Color.Black;
            dgwSearch.BorderStyle = BorderStyle.None;
            dgwSearch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgwSearch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgwSearch.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgwSearch.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgwSearch.BackgroundColor = Color.FromArgb(35, 35, 35);

            dgwSearch.EnableHeadersVisualStyles = false;
            dgwSearch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgwSearch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 25);
            dgwSearch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void BankAccountList_LocationChanged(object sender, EventArgs e)
        {
            dgwSearch.DataSource = MainForm.UserService.GetAll();
        }
    }
}
