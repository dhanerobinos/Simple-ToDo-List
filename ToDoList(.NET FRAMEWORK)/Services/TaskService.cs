using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using ToDoList.DataAcess;
using ToDoList.Models;


namespace Services
{
    public class TaskService
    {
        public List<TaskModel> GetTasksByUser(int userId)
        {
            List<TaskModel> tasks = new List<TaskModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
            {
                string query = "SELECT * FROM Task WHERE UserID = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new TaskModel
                    {
                        TaskID = Convert.ToInt32(reader["TaskID"]),
                        TaskTitle = reader["TaskTitle"].ToString(),
                        TaskDueDate = Convert.ToDateTime(reader["TaskDueDate"]),
                        TaskIsCompleted = Convert.ToBoolean(reader["TaskIsCompleted"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }

            return tasks;
        }
        public static void AddTasks(TaskModel task)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString)) {
                    {
                        connection.Open();
                        string query = "INSERT INTO Task (TaskTitle, TaskDueDate, TaskIsCompleted,UserID) VALUES (@TaskTitle, @TaskDueDate, @TaskIsCompleted,@UserID)";
                       
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@TaskTitle", task.TaskTitle);
                        cmd.Parameters.AddWithValue("@TaskDueDate", task.TaskDueDate);
                        cmd.Parameters.AddWithValue("@TaskIsCompleted", task.TaskIsCompleted);
                        cmd.Parameters.AddWithValue("@UserID", task.UserID);
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void UpdateTasks(TaskModel task)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE Task SET TaskTitle = @TaskTitle, TaskDueDate = @TaskDueDate WHERE TaskID = @TaskID AND UserID = @UserID", connection))
                {
                    cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                    cmd.Parameters.AddWithValue("@TaskTitle", task.TaskTitle);
                    cmd.Parameters.AddWithValue("@TaskDueDate", task.TaskDueDate);
                    cmd.Parameters.AddWithValue("@UserID", task.UserID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateTaskStatus(TaskModel task)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE Task SET TaskIsCompleted = @TaskIsCompleted WHERE TaskID = @TaskID", connection))
                {
                    cmd.Parameters.AddWithValue("@TaskIsCompleted", task.TaskIsCompleted);
                    cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool DeleteTask(TaskModel task)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("DELETE FROM Task WHERE TaskID = @TaskID", connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
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
