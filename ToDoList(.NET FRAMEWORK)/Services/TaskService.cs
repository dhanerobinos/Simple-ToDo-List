using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows;
using ToDoList.DataAccess;
using ToDoList.DataAcess;
using ToDoList.Models;


namespace Services
{
    public class TaskService
    {


        public List<TaskModel> GetAllTasks()
        {
            string query = "SELECT * FROM Task";
            return DataAccess.LoadData<TaskModel>(query, reader => new TaskModel
            {
               TaskID = Convert.ToInt32(reader["TaskID"]),
               TaskTitle = reader["TaskTitle"].ToString(),
               TaskDueDate = Convert.ToDateTime(reader["TaskDueDate"]),
               TaskIsCompleted = Convert.ToBoolean(reader["TaskIsCompleted"]),
           
            });
        }




        public static void AddTasks(TaskModel task,Users users)
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
                        cmd.Parameters.AddWithValue("@UserID", users.UserID);
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
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Task SET TaskTitle = @TaskTitle, TaskDueDate = @TaskDueDate, TaskIsCompleted = @TaskIsCompleted  WHERE TaskID = @TaskID;";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskTitle", task.TaskTitle);
                        cmd.Parameters.AddWithValue("@TaskDueDate", task.TaskDueDate);
                        cmd.Parameters.AddWithValue("@TaskIsCompleted", task.TaskIsCompleted);
                        cmd.Parameters.AddWithValue("@TaskID", task.TaskID);
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
