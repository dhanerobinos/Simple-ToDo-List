using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList_.NET_FRAMEWORK_.DataAccess;


namespace ToDoList_.NET_FRAMEWORK_.Services
{
    public class AuthService
    {
        public bool ValidateLogin(string username, string password)
        {
            try
            {

                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @username AND Password = @password";

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
         

                //Register a new user in the database
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Users (Username, Password) VALUES (@username, @password)";
                    using (var insertCmd = new SqlCommand(query, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@username", username);
                        insertCmd.Parameters.AddWithValue("@password", password);
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
                    using(var updateCmd = new SqlCommand(updateQuery, connection))
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
