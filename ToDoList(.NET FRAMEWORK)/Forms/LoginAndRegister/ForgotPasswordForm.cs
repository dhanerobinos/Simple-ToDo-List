using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Forms;
using ToDoList.Services;

namespace ToDoList.LoginAndRegister

{
    public partial class ForgotPasswordForm : Form
    {
        private PasswordService PasswordService = new PasswordService();
        public ForgotPasswordForm()
        {
           InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string confirmPassword = tbConfirm.Text;

            if (username == null || password == null)
            {
                MessageBox.Show("Username and Password cannot be empty.");
            }
            else if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
            }
            else if (PasswordService.ResetPassword(username, password))
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Reset Password Failed, Please try again.");
            }
        }
    }
}
