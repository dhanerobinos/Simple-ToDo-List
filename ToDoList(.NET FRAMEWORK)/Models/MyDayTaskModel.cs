using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList.Models
{
    public class MyDayTaskModel
    {
        public int DayTaskID{ get; set; }
        public string DayTaskTitle {  get; set; }
        public DateTime DayTaskDueDate { get; set; }
        public bool DayTaskIsCompleted {  get; set; }
        public int UserID { get; set; }
    }
}
