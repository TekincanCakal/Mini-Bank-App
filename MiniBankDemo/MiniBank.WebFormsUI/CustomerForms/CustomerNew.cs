using System;
using System.Windows.Forms;
using MiniBank.Entities.Concrete;

namespace MiniBank.WebFormsUI.CustomerForms
{
    public partial class CustomerNew : Form
    {
        public CustomerNew()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            long IdentityNumber = long.Parse(tbxIdentityNumber.Text);
            string FirstName = tbxFirstName.Text;
            string LastName = tbxLastName.Text;
            string Username = tbxUsername.Text;
            string Password = tbxPassword.Text;
            int dogumYılı = dtpDateOfBirth.Value.Year;
            kimlikDogrulama.KPSPublicSoapClient webService = new kimlikDogrulama.KPSPublicSoapClient();
            if (webService.TCKimlikNoDogrula(IdentityNumber, FirstName, LastName, dogumYılı))
            {
                try
                {
                    MainForm.UserService.Register(new User
                    {
                        IdentityNumber = IdentityNumber,
                        FirstName = FirstName,
                        LastName = LastName,
                        Username = Username,
                        Password = Password,
                        Perm = cbIsAdmin.Checked ? 1 : 0
                    });
                    MessageBox.Show("Success");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong Identity Number or Date Of Birth");
            }
        }
        private void tbxIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
