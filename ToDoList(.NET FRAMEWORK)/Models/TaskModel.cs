using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class TaskModel
    {
        internal readonly Font Font;

        public int TaskID { get; set; }
        public string TaskTitle { get; set; }
        public DateTime TaskDueDate { get; set; }
        public bool TaskIsCompleted { get; set; }
        public int UserID { get; set; }
    }
}
