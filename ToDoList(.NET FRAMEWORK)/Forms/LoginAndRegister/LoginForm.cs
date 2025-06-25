using System;
using ToDoList.Services;
using System.Windows.Forms;
using System.Drawing;
using ToDoList.Forms;
using ToDoList.LoginAndRegister;

namespace ToDoList.Forms
{
    public partial class LoginForm : Form
    {
        private AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Username and Password cannot be empty.");
               
            }
            else if (_authService.ValidateLogin(username, password))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private void btnCreatAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ForgotPasswordForm forgotPassForm = new ForgotPasswordForm();
            forgotPassForm.Show();
        }
    }
}
