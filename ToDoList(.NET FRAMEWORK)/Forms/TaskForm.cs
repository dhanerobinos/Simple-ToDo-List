using Services;
using ToDoList.Services;
using System.Windows.Forms;

namespace ToDoList.Forms
{
    public partial class TaskForm : Form
    {
        private readonly TaskService _taskService = new TaskService();
        public TaskForm()
        {
            InitializeComponent();
            LoadTaskListToListView();
        }

        private void LoadTaskListToListView()
        {
            listViewTasks.Items.Clear();
            var tasks = _taskService.GetAllTasks();

            listViewTasks.View = View.Details;
            listViewTasks.Columns.Clear();

           
            listViewTasks.Columns.Add("Title", 150);       // column 0
            listViewTasks.Columns.Add("Due Date", 120);    // column 1
            listViewTasks.Columns.Add("Completed", 100);   // column 2


            foreach (var task in tasks)
            {
                ListViewItem item = new ListViewItem(task.TaskTitle); // main column
               
                item.Tag = task.TaskID;
                item.SubItems.Add(task.TaskDueDate.ToShortDateString());
                listViewTasks.Items.Add(item);
                item.SubItems.Add(task.TaskIsCompleted ? "Yes" : "No");
            }
        }

    }
}
