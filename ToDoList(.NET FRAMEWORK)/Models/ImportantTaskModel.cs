using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Models
{
    public class ImportantTaskModel
    {
        public int ImportantTaskID { get; set; }
        public string ImportantTaskTitle { get; set; }
        public DateTime ImportantTaskDueDate { get; set; }
        public bool ImportantTaskIsCompleted { get; set; }
        public int UserID { get; set; }
    }
}
