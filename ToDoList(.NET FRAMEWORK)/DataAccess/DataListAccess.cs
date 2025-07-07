using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ToDoList.DataAcess;
namespace ToDoList.DataAccess

{
    public static class DataListAccess
    {
        

        public static List<T> LoadData<T>(
            string query,
            Func<SqlDataReader, T> mapFunction,
            SqlParameter[] parameters = null)
        {
            List<T> results = new List<T>();

            using (SqlConnection conn = new SqlConnection(DbConnection.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    T item = mapFunction(reader); // create object from reader
                    results.Add(item);
                }

                reader.Close();
            }

            return results;
        }
    }

}
