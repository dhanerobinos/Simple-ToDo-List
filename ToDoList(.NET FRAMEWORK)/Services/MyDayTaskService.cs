using System;
using System.Collections.Generic;
using ToDoList.Models;
using ToDoList.DataAcess;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ToDoList.Services
{
    public class MyDayTaskService
    {
        public List<MyDayTaskModel> GetTasksByUser(int userId)
        {
            List<MyDayTaskModel> tasks = new List<MyDayTaskModel>();

            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
            {
                string query = "SELECT * FROM MyDayTask WHERE UserID = @userId";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", userId);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tasks.Add(new MyDayTaskModel
                    {
                        DayTaskID = Convert.ToInt32(reader["DayTaskID"]),
                        DayTaskTitle = reader["DayTaskTitle"].ToString(),
                        DayTaskDueDate = Convert.ToDateTime(reader["DayTaskDueDate"]),
                        DayTaskIsCompleted = Convert.ToBoolean(reader["DayTaskIsCompleted"]),
                        UserID = Convert.ToInt32(reader["UserID"])
                    });
                }
            }

            return tasks;
        }
        public static void AddDayTasks(MyDayTaskModel dayTask)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO MyDayTask(DayTaskTitle,DayTaskDueDate,DayTaskIsCompleted,UserID) VALUES(@DayTaskTitle,@DayTaskDueDate,@DayTaskIsCompleted,@UserID)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DayTaskTitle", dayTask.DayTaskTitle);
                    cmd.Parameters.AddWithValue("@DayTaskDueDate", dayTask.DayTaskDueDate);
                    cmd.Parameters.AddWithValue("@DayTaskIsCompleted", dayTask.DayTaskIsCompleted);
                    cmd.Parameters.AddWithValue("@UserID",dayTask.UserID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateDayTasks(MyDayTaskModel dayTask)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand("UPDATE MyDayTask SET DayTaskTitle = @DayTaskTitle, DayTaskDueDate = @DayTaskDueDate WHERE DayTaskID = @DayTaskID AND UserID = @UserID", connection))
                {
                    cmd.Parameters.AddWithValue("@DayTaskID", dayTask.DayTaskID);
                    cmd.Parameters.AddWithValue("@DayTaskTitle", dayTask.DayTaskTitle);
                    cmd.Parameters.AddWithValue("@DayTaskDueDate", dayTask.DayTaskDueDate);
                    cmd.Parameters.AddWithValue("@UserID", dayTask.UserID);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void UpdateTaskStatus(MyDayTaskModel dayTask)
        {
            using (SqlConnection connection = new SqlConnection(DbConnection.ConnectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE MyDayTask SET DayTaskIsCompleted = @DayTaskIsCompleted WHERE DayTaskID = @DayTaskID", connection))
                {
                    cmd.Parameters.AddWithValue("@DayTaskIsCompleted", dayTask.DayTaskIsCompleted);
                    cmd.Parameters.AddWithValue("@DayTaskID", dayTask.DayTaskID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public bool DeleteDayTask(MyDayTaskModel dayTask)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();

                    using (var cmd = new SqlCommand("DELETE FROM MyDayTask WHERE DayTaskID = @DayTaskID", connection))
                    {
                        cmd.Parameters.AddWithValue("@DayTaskID", dayTask.DayTaskID);
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
