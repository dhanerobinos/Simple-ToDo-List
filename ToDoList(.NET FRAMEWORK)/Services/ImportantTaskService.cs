using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using ToDoList.DataAcess;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class ImportantTaskService
    {
        public List<ImportantTaskModel> GetTasksByUser(int userId)
        {
            List<ImportantTaskModel> tasks = new List<ImportantTaskModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
            {
                string query = "SELECT * FROM ImportantTask WHERE UserID = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new ImportantTaskModel
                    {
                        ImportantTaskID = Convert.ToInt32(reader["ImportantTaskID"]),
                        ImportantTaskTitle = reader["ImportantTaskTitle"].ToString(),
                        ImportantTaskDueDate = Convert.ToDateTime(reader["ImportantTaskDueDate"]),
                        ImportantTaskIsCompleted = Convert.ToBoolean(reader["ImportantTaskIsCompleted"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }

            return tasks;
        }

        public static void AddImportantTasks(ImportantTaskModel importantTask)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO ImportantTask(ImportantTaskTitle,ImportantTaskDueDate,ImportantTaskIsCompleted,UserID) VALUES(@ImportantTaskTitle,@ImportantTaskDueDate,@ImportantTaskIsCompleted,@UserID)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ImportantTaskTitle", importantTask.ImportantTaskTitle);
                    cmd.Parameters.AddWithValue("@ImportantTaskDueDate", importantTask.ImportantTaskDueDate);
                    cmd.Parameters.AddWithValue("@ImportantTaskIsCompleted", importantTask.ImportantTaskIsCompleted);
                    cmd.Parameters.AddWithValue("@UserID", importantTask.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateImportantTasks(ImportantTaskModel importantTask)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE ImportantTask SET ImportantTaskTitle = @ImportantTaskTitle, ImportantTaskDueDate = @ImportantTaskDueDate WHERE ImportantTaskID = @ImportantTaskID AND UserID = @UserID", connection))
                {
                    cmd.Parameters.AddWithValue("@ImportantTask", importantTask.ImportantTaskID);
                    cmd.Parameters.AddWithValue("@ImportantTaskTitle", importantTask.ImportantTaskTitle);
                    cmd.Parameters.AddWithValue("@ImportantTaskDueDate", importantTask.ImportantTaskDueDate);
                    cmd.Parameters.AddWithValue("@UserID", importantTask.UserID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateTaskStatus(ImportantTaskModel task)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand  ("UPDATE ImportantTask SET ImportantTaskIsCompleted = @ImportantTaskIsCompleted WHERE ImportantTaskID = @ImportantTaskID", connection))
                {
                    cmd.Parameters.AddWithValue("@ImportantTaskIsCompleted", task.ImportantTaskIsCompleted);
                    cmd.Parameters.AddWithValue("@ImportantTaskID", task.ImportantTaskID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool DeleteImportantTask(ImportantTaskModel importantTask)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("DELETE FROM ImportantTask WHERE ImportantTaskID = @ImportantTaskID", connection))
                    {
                        cmd.Parameters.AddWithValue("@ImportantTaskID", importantTask.ImportantTaskID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if a row was deleted
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Deleting Task: {ex.Message}");
                return false; // Return false if an error occurred
            }
        }
    }
}
