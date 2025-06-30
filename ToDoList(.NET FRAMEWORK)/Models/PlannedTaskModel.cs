using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_.NET_FRAMEWORK_.Models
{
    public class PlannedTaskModel
    {
        public int PlannedTaskID { get; set; }
        public string PlannedTaskTitle { get; set; }
        public DateTimePicker PlannedTaskDueDate { get; set; }
        public bool PlannedTaskIsCompleted { get; set; }
    }
}
