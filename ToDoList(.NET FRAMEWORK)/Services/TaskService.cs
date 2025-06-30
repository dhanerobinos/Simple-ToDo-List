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




        public static void AddTasks(string TaskTitle, DateTime TaskDueDate, bool TaskIsCompleted)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO Task (TaskTitle, TaskDueDate,  TaskIsCompleted) VALUES(@TaskTitle,@TaskDueDate, @TaskIsCompleted)";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskTitle", TaskTitle);
                        cmd.Parameters.AddWithValue("@DueDate", TaskDueDate);
                        cmd.Parameters.AddWithValue("@IsCompleted", TaskIsCompleted);
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateTasks(string TaskTitle, DateTime TaskDueDate, bool TaskIsCompleted)
        {
            try
            {
                using (var connection = new SqlConnection(DbConnection.ConnectionString))
                {
                    connection.Open();
                    string query = "UPDATE Task  SET @TaskTitle =TaskTitle, @TaskDueDate = TaskDueDate, @TaskIsCompleted = TaskIsCompleted";

                    using (var cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TaskTitle", TaskTitle);
                        cmd.Parameters.AddWithValue("@DueDate", TaskDueDate);
                        cmd.Parameters.AddWithValue("@IsCompleted", TaskIsCompleted);
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
