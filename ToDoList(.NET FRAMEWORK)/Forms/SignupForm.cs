using System;
using ToDoList_.NET_FRAMEWORK_.Services;
using System.Windows.Forms;

namespace ToDoList_.NET_FRAMEWORK_.Forms
{
    public partial class SignupForm : Form
    {
        private AuthService _authService = new AuthService();
        public SignupForm()
        {
            InitializeComponent();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (username == null || password == null)
            {
                MessageBox.Show("Username and Password cannot be empty.");
            }
            else if (_authService.RegisterUser(username, password))
            {
                MessageBox.Show("Registration successful! You can now log in.");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registration failed. Please try again.");
            }
        }
    }
}

