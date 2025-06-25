using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows;
using ToDoList.DataAcess;
using ToDoList.Models;

namespace Services
{
    public class TaskService
    {
        public static void AddTasks(string TaskTitle, DateTime DueDate, bool IsCompleted)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Tasks (TaskTitle, DueDate, IsCompleted) VALUES(@TaskTitle,@DueDate, @IsCompleted)";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskTitle", TaskTitle);
                        cmd.Parameters.AddWithValue("@DueDate", DueDate);
                        cmd.Parameters.AddWithValue("@IsCompleted", IsCompleted);
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateTasks(string TaskTitle, DateTime DueDate, bool IsCompleted)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Tasks  SET @TaskTitle =TaskTitle, @DueDate = DueDate, @IsCompleted = IsCompleted";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskTitle", TaskTitle);
                        cmd.Parameters.AddWithValue("@DueDate", DueDate);
                        cmd.Parameters.AddWithValue("@IsCompleted", IsCompleted);
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
