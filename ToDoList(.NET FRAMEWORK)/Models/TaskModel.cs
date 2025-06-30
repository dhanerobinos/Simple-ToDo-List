using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TaskModel
    {
        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public DateTime TaskDueDate { get; set; }
        public bool TaskIsCompleted { get; set; }
    }
}
