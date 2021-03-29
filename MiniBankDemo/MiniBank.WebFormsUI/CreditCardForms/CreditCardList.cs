using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniBank.WebFormsUI.CreditCardForms
{
    public partial class CreditCardList : Form
    {
        public CreditCardList()
        {
            InitializeComponent();
            styleGrid();
        }
        public void styleGrid()
        {
            dgw.Font = new Font("Consolas", 12F, FontStyle.Regular);
            dgw.ForeColor = Color.Black;
            dgw.BorderStyle = BorderStyle.None;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgw.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgw.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgw.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgw.BackgroundColor = Color.FromArgb(35, 35, 35);

            dgw.EnableHeadersVisualStyles = false;
            dgw.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgw.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            dgw.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
        private void CreditCardList_Load(object sender, EventArgs e)
        {
            dgw.DataSource = MainForm.CreditCardService.GetAll();
        }
    }
}
