using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Models
{
    public class PlannedTaskModel
    {
        public int PlannedTaskID { get; set; }
        public string PlannedTaskTitle { get; set; }
        public DateTime PlannedTaskDueDate { get; set; }
        public bool PlannedTaskIsCompleted { get; set; }
        public int UserID { get; set; }
    }
}
