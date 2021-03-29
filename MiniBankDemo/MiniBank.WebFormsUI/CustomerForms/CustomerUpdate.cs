using System;
using System.Windows.Forms;
using MiniBank.Entities.Concrete;

namespace MiniBank.WebFormsUI.CustomerForms
{
    public partial class CustomerUpdate : Form
    {
        public CustomerUpdate()
        {
            InitializeComponent();
        }
        private User user;
        private void tbxCustomerId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void btnGetUser_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(tbxCustomerId.Text);
            user = MainForm.UserService.Get(customerId);
            if (user != null)
            {
                pnlMain.Visible = true;
                tbxFirstName.Text = user.FirstName;
                tbxLastName.Text = user.LastName;
                tbxIdentityNumber.Text = user.IdentityNumber + "";
                tbxUsername.Text = user.Username;
                tbxPassword.Text = user.Password;
                cbIsAdmin.Checked = user.Perm == 1;
            }
            else
            {
                MessageBox.Show("User not found");
                pnlMain.Visible = false;
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user.Username = tbxUsername.Text;
            user.Password = tbxPassword.Text;
            user.FirstName = tbxFirstName.Text;
            user.LastName = tbxLastName.Text;
            user.IdentityNumber = long.Parse(tbxIdentityNumber.Text);
            user.Perm = cbIsAdmin.Checked ? 1 : 0;
            MainForm.UserService.Update(user);
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainForm.UserService.Delete(user);
        }
        private void btnCreateBankAccount_Click(object sender, EventArgs e)
        {
            try
            {
                BankAccount bankAccount = new BankAccount
                {
                    BankAccountNumber = MainForm.BankAccountService.GetRandomBankAccountNumber(user.CustomerId),
                    CustomerId = user.CustomerId,
                    Iban = MainForm.BankAccountService.GetRandomIBAN()
                };
                MainForm.BankAccountService.Register(bankAccount);
                MessageBox.Show(String.Format("Success Iban: {0} Bank Account Number: {1}", bankAccount.Iban, bankAccount.BankAccountNumber));
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.InnerException.Message);
            }
        }
        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            try
            {
                CreditCard creditCard = new CreditCard
                {
                    CustomerId = user.CustomerId,
                    CutOffDay = Convert.ToInt32(nudCutOffDay.Value),
                    DueDay = Convert.ToInt32(nudDueDay.Value),
                    CardNumber = MainForm.CreditCardService.GetRandomCardNumber()
                };
                MainForm.CreditCardService.Register(creditCard);
                MessageBox.Show("Success");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.InnerException.InnerException.Message);
            }
        }
        private void CustomerUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
