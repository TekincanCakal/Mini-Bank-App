using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBank.WebFormsUI.CustomerForms
{
    public partial class CustomerList : Form
    {
        public CustomerList()
        {
            InitializeComponent();
            styleGrid();
        }
        private void Search_Load(object sender, EventArgs e)
        {
            dgwSearch.DataSource = MainForm.UserService.GetAll();
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
    }
}
