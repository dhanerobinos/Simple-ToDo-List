using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_.NET_FRAMEWORK_.Models
{
    public class ImportantTaskModel
    {
        public int ImporatantTaskID { get; set; }
        public string ImportantTaskTitle { get; set; }
        public DateTimePicker ImportantTaskDueDate { get; set; }
        public bool ImportantTaskIsCompleted { get; set; }
    }
}
