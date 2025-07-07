using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using ToDoList.DataAcess;
using ToDoList.Models;

namespace ToDoList.Services
{
    public class PlannedTaskService
    {
        public List<PlannedTaskModel> GetTasksByUser(int userId)
        {
            List<PlannedTaskModel> tasks = new List<PlannedTaskModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
            {
                string query = "SELECT * FROM PlannedTask WHERE UserID = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new PlannedTaskModel
                    {
                        PlannedTaskID = Convert.ToInt32(reader["PlannedTaskID"]),
                        PlannedTaskTitle = reader["PlannedTaskTitle"].ToString(),
                        PlannedTaskDueDate = Convert.ToDateTime(reader["PlannedTaskDueDate"]),
                        PlannedTaskIsCompleted = Convert.ToBoolean(reader["PlannedTaskIsCompleted"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }

            return tasks;
        }
        public static void AddPlannedTask(PlannedTaskModel plannedTask)
            {
                try
                {
                    using (var connection = new SqlConnection(DbConnection.ConnectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO PlannedTask(PlannedTaskTitle,PlannedTaskDueDate,PlannedTaskIsCompleted,UserID) VALUES(@PlannedTaskTitle,@PlannedTaskDueDate,@PlannedTaskIsCompleted,@UserID)";

                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@PlannedTaskTitle", plannedTask.PlannedTaskTitle);
                        cmd.Parameters.AddWithValue("@PlannedTaskDueDate", plannedTask.PlannedTaskDueDate);
                        cmd.Parameters.AddWithValue("@PlannedTaskIsCompleted", plannedTask.PlannedTaskIsCompleted);
                        cmd.Parameters.AddWithValue("@UserID", plannedTask.UserID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public static void UpdatePlannedTask(PlannedTaskModel plannedTask)
            {
                using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("UPDATE PlannedTask SET PlannedTaskTitle = @PlannedTaskTitle, PlannedTaskDueDate = @PlannedTaskDueDate WHERE PlannedTaskID = @PlannedTaskID AND UserID = @UserID", connection))
                    {
                        cmd.Parameters.AddWithValue("@PlannedTaskID", plannedTask.PlannedTaskID);
                        cmd.Parameters.AddWithValue("@PlannedTaskTitle", plannedTask.PlannedTaskTitle);
                        cmd.Parameters.AddWithValue("@PlannedTaskDueDate", plannedTask.PlannedTaskDueDate);
                        cmd.Parameters.AddWithValue("@UserID", plannedTask.UserID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        public void UpdateTaskStatus(PlannedTaskModel plannedTask)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE PlannedTask SET PlannedTaskIsCompleted = @PlannedTaskIsCompleted WHERE PlannedTaskID = @PlannedTaskID", connection))
                {
                    cmd.Parameters.AddWithValue("@PlannedTaskIsCompleted", plannedTask.PlannedTaskIsCompleted);
                    cmd.Parameters.AddWithValue("@PlannedTaskID", plannedTask.PlannedTaskID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool DeletePlannedTask(PlannedTaskModel plannedTask)
            {
                try { 
                    using (var connection = new SqlConnection(DbConnection.ConnectionString))
                
                    {
                        connection.Open();

                        using (var cmd = new SqlCommand("DELETE FROM PlannedTask WHERE PlannedTaskID = @PlannedTaskID", connection))
                        {
                            cmd.Parameters.AddWithValue("PlannedTaskID", plannedTask.PlannedTaskID);
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
