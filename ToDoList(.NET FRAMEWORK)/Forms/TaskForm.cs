using Services;
using System;
using System.Windows.Forms;
using ToDoList.Interfaces;
using ToDoList.Models;

using ToDoList.Services;

namespace ToDoList.Forms
{
    public partial class TaskForm : Form, IAddableForm<TaskModel>, IDeletableForm<TaskModel>
    {
        private readonly TaskService _taskService = new TaskService();
        private Users _currentUser;
        public TaskForm(Users user)
        {
            InitializeComponent();
            LoadTaskListToListView();
            _currentUser = user;

        }

        public void LoadTaskListToListView()
        {
            listViewTasks.Items.Clear();
            var tasks = _taskService.GetAllTasks();

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
        public void AddData(TaskModel data)
        {
            
            TaskService.AddTasks(data, _currentUser); 
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

    }
}
