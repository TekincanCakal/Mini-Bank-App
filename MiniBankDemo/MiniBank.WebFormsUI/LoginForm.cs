using System;
using System.Drawing;
using System.Windows.Forms;
using MiniBank.Business.Abstract;
using MiniBank.Business.DependencyResolvers.Ninject;
using MiniBank.Entities.Concrete;
using XanderUI;

namespace MiniBank.WebFormsUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            ActiveControl = pbLogo;
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
        #endregion
        #region TextBoxUI
        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            pnlUsername.BackColor = Color.Aqua;
            if (tbxUsername.Text == "Username")
            {
                tbxUsername.Text = "";
            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            pnlUsername.BackColor = Color.White;
            if (String.IsNullOrEmpty(tbxUsername.Text))
            {
                tbxUsername.Text = "Username";
            }
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            pnlPassword.BackColor = Color.Aqua;
            if (tbxPassword.Text == "Password")
            {
                tbxPassword.Text = "";
                tbxPassword.PasswordChar = '*';
            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            pnlPassword.BackColor = Color.White;
            if (String.IsNullOrEmpty(tbxPassword.Text))
            {
                tbxPassword.Text = "Password";
                tbxPassword.PasswordChar = '\0';
            }
        }
        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            IUserService userService = InstanceFactory.GetInstance<IUserService>();
            try
            {
                User user = userService.Login(tbxUsername.Text, tbxPassword.Text);
                MainForm mainForm = new MainForm(user, this);
                mainForm.Show();
                this.Hide();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
            {
                btnLogin_Click(sender, null);
            }
        }
    }
}
