using System;
using System.Windows.Forms;
using ToDoList.LoginAndRegister;
using ToDoList.Models;
using ToDoList.Services;

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
            else
            {
                Users users = _authService.ValidateLogin(username, password);
                if (users != null)
                {
                    var dashboard = new Dashboard(users);
                    this.Hide();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = !cbShowPassword.Checked;
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             this.Hide();
            ForgotPasswordForm forgotPassForm = new ForgotPasswordForm();
            forgotPassForm.Show();
        }

        private void btnCreatAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignupForm signupForm = new SignupForm();
            signupForm.Show();
        }
    }
}
