using System;
using System.Drawing;
using System.Windows.Forms;
using MiniBank.Business.Abstract;
using MiniBank.Business.DependencyResolvers.Ninject;
using MiniBank.Entities.Concrete;
using MiniBank.WebFormsUI.BankAccountForms;
using MiniBank.WebFormsUI.CreditCardForms;
using MiniBank.WebFormsUI.CustomerForms;

namespace MiniBank.WebFormsUI
{
    public partial class MainForm : Form
    {
        private LoginForm _loginForm;
        public static IUserService UserService;
        public static IBankAccountService BankAccountService;
        public static ICreditCardService CreditCardService;
        public static ILogService LogService;
        public User LoginedUser;
        public MainForm(User user, LoginForm loginForm)
        {
            InitializeComponent();
            _loginForm = loginForm;
            LoginedUser = user;
            UserService = InstanceFactory.GetInstance<IUserService>();
            BankAccountService = InstanceFactory.GetInstance<IBankAccountService>();
            CreditCardService = InstanceFactory.GetInstance<ICreditCardService>();
            LogService = InstanceFactory.GetInstance<ILogService>();
        }
        #region FormMoveEvents
        Point _mouseDownPoint = Point.Empty;

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDownPoint = new Point(e.X, e.Y);
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDownPoint = Point.Empty;
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseDownPoint.IsEmpty)
            {
                Location = new Point(Location.X + (e.X - _mouseDownPoint.X), Location.Y + (e.Y - _mouseDownPoint.Y));
            }
        }
        private void pnlTopBar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _loginForm.Show();
        }
        #endregion
        public void OpenForm(Form form)
        {
            pnlMidBar.Controls.Clear();
            form.TopLevel = false;
            pnlMidBar.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.BackColor = pnlMidBar.BackColor;
            form.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUserNameInfo.Text = String.Format("{0}  {1}", LoginedUser.FirstName, LoginedUser.LastName);
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlCustomer.Visible = !pnlCustomer.Visible;
        }
        private void btnBankAccount_Click(object sender, EventArgs e)
        {
            pnlBankAcount.Visible = !pnlBankAcount.Visible;
        }
        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            pnlCreditCard.Visible = !pnlCreditCard.Visible;
        }
        private void btnCustomerNew_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerNew());
        }
        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerList());
        }
        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerUpdate());
        }
        private void btnBankAccountList_Click(object sender, EventArgs e)
        {
            //OpenForm(new BankAccountList());
        }
        private void btnBankAccountUpdate_Click(object sender, EventArgs e)
        {
            OpenForm(new BankAccountUpdate());
        }
        private void btnCreditCardList_Click(object sender, EventArgs e)
        {
            OpenForm(new CreditCardList());
        }
    }
}
