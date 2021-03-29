using System;
using System.Windows.Forms;
using MiniBank.Entities.Concrete;

namespace MiniBank.WebFormsUI.BankAccountForms
{
    public partial class BankAccountUpdate : Form
    {
        public BankAccountUpdate()
        {
            InitializeComponent();
        }
        BankAccount bankAccount;
        private void btnGetBankAccount_Click(object sender, EventArgs e)
        {
            bankAccount = MainForm.BankAccountService.Get(tbxBankAccountNumber.Text);
            if (bankAccount != null)
            {
                pnlMain.Visible = true;
                tbxMoney.Text = "Money: " + bankAccount.Money;
            }
            else
            {
                MessageBox.Show("Bank Account not found");
                pnlMain.Visible = false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainForm.BankAccountService.Delete(bankAccount);
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal newMoney = bankAccount.Money - Convert.ToDecimal(tbxMoney.Text);
            if (newMoney >= 0)
            {
                bankAccount.Money = newMoney;
                MainForm.BankAccountService.Update(bankAccount);
                tbxMoney.Text = "Money: " + bankAccount.Money;
            }
            else
            {
                MessageBox.Show("Not enough money for this");
            }
        }
        private void btnGive_Click(object sender, EventArgs e)
        {
            bankAccount.Money = bankAccount.Money + Convert.ToDecimal(tbxMoney.Text);
            MainForm.BankAccountService.Update(bankAccount);
            tbxMoney.Text = "Money: " + bankAccount.Money;
        }
    }
}
