using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.DataAcess;
using ToDoList.Services;


namespace ToDoList.Services
{
    public class AuthService
    {
        private PasswordService passwordService;
        public bool ValidateLogin(string username, string password)
        {
            try
            {

                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT Id FROM Users WHERE Username = @username AND Password = @password";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public bool RegisterUser(string username, string password)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    // Check if the username already exists
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username";
                    using (var checkCmd = new SqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@username", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different username.");
                            return false;
                        }
                    }
                }

                string hashedPassword = passwordService.HashPassword(password);

                //Register a new user
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    using (var insertCmd = new SqlCommand(query, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", hashedPassword);
                        int rowsAffected = insertCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public bool ResetPassword(string username, string newPassword)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string updateQuery = "UPDATE Users SET Password = @newPassword & Username=@username";
                    using (var updateCmd = new SqlCommand(updateQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@username", username);
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        int rowsAffected = updateCmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
