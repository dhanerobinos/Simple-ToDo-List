using Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Interfaces;
using ToDoList.Models;


namespace ToDoList.Forms
{
    public partial class TaskForm : Form, 
        IAddableForm<TaskModel>, IDeletableForm<TaskModel>, IEditableForm<TaskModel>,ICompletableForm<TaskModel>
    {
        private readonly TaskService TaskService = new TaskService();
        private TaskModel _taskToEdit;

        private Users _currentUser;
        public TaskForm(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadTaskListToListView();
        }

        public void LoadTaskListToListView()
        {
            listViewTasks.Items.Clear();
            var tasks = TaskService.GetTasksByUser(_currentUser.UserID);

            listViewTasks.View = View.Details;
            listViewTasks.Columns.Clear();

           
            listViewTasks.Columns.Add("Title", 150);       
            listViewTasks.Columns.Add("Due Date", 120);    
            listViewTasks.Columns.Add("Completed", 100);

            foreach (TaskModel task in tasks)
            {
                var item = new ListViewItem(task.TaskTitle);
                item.SubItems.Add(task.TaskDueDate.ToShortDateString());
                item.SubItems.Add(task.TaskIsCompleted ? "Completed" : "Pending");

                FontStyle newStyle = task.TaskIsCompleted
                    ? item.Font.Style | FontStyle.Strikeout
                    : item.Font.Style & ~FontStyle.Strikeout;

                item.Font = new Font(item.Font.FontFamily, item.Font.Size, newStyle);

                item.Tag = task;
                listViewTasks.Items.Add(item);
            }


        }
        public TaskModel GetNewData(string title, DateTime dueDate)
        {
            return new TaskModel
            {
                TaskTitle = title,
                TaskDueDate = dueDate,
                TaskIsCompleted = false
            };
        }
        public void LoadData(TaskModel data)
        {
            _taskToEdit = data;

        }
        public TaskModel GetEditedData(string title, DateTime dueDate)
        {
            if (_taskToEdit == null)
                throw new InvalidOperationException("Error,No task loaded.");

            return new TaskModel
            {
                TaskID = _taskToEdit.TaskID,
                TaskTitle = title,
                TaskDueDate = dueDate,
                TaskIsCompleted = _taskToEdit.TaskIsCompleted,
                UserID = _taskToEdit.UserID 
            };
        }
        public void AddData(TaskModel data)
        {

            data.UserID = _currentUser.UserID;
            TaskService.AddTasks(data);
        }
        public TaskModel GetSelectedItem()
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                var selectedItem = listViewTasks.SelectedItems[0];
                return (TaskModel)selectedItem.Tag;
            }
            return null;
        }
        public void MarkAsCompleted(TaskModel task)
        {
            task.TaskIsCompleted = !task.TaskIsCompleted;
            TaskService.UpdateTaskStatus(task);

            foreach (ListViewItem item in listViewTasks.Items)
            {
                if (item.Tag is TaskModel t && t.TaskID == task.TaskID)
                {
                    t.TaskIsCompleted = task.TaskIsCompleted;
                    item.Font = new Font(item.Font, t.TaskIsCompleted ? FontStyle.Strikeout : FontStyle.Regular);
                    break;
                }
            }
        }

    }
}
