using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.DataAcess
{
    public class DbConnection
    {
        public static string ConnectionString
        {
            get
            {
                return "Server = DHANE\\SQLEXPRESS;Initial Catalog=ToDoListAppDB;Integrated Security=True;";
            }
        }
    }
}
