using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Interfaces;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Forms
{
    public partial class PlannedForm : Form, 
        IAddableForm<PlannedTaskModel>, IEditableForm<PlannedTaskModel>, IDeletableForm<PlannedTaskModel>,ICompletableForm<PlannedTaskModel>
    {
        private readonly PlannedTaskService PlannedTaskService = new PlannedTaskService();
        private Users _currentUser;
        private PlannedTaskModel _taskToEdit;
        public PlannedForm (Users user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadPlannedTasks();    
        }
        public void LoadPlannedTasks()
        {
            PlannedTaskListView.Items.Clear();
            var tasks = PlannedTaskService.GetTasksByUser(_currentUser.UserID);

            PlannedTaskListView.View = View.Details;
            PlannedTaskListView.Columns.Clear();
            PlannedTaskListView.Columns.Add("Title", 150);
            PlannedTaskListView.Columns.Add("Due Date", 120);
            PlannedTaskListView.Columns.Add("Completed", 100);

            foreach (PlannedTaskModel task in tasks)
            {
                var item = new ListViewItem(task.PlannedTaskTitle);
                item.SubItems.Add(task.PlannedTaskDueDate.ToShortDateString());
                item.SubItems.Add(task.PlannedTaskIsCompleted ? "Completed" : "Pending");

                if (task.PlannedTaskIsCompleted)
                {
                    item.Font = new Font(item.Font, FontStyle.Strikeout);
                }
                item.Tag = task;
                PlannedTaskListView.Items.Add(item);
            }
        }
        public PlannedTaskModel GetNewData(string title, DateTime dueDate)
        {
            return new PlannedTaskModel
            {
                PlannedTaskTitle = title,
                PlannedTaskDueDate = dueDate,
                PlannedTaskIsCompleted = false
            };
        }
        public void AddData(PlannedTaskModel data)
        {
            data.UserID = _currentUser.UserID;
            PlannedTaskService.AddPlannedTask(data);        
        }
        public void LoadData(PlannedTaskModel data)
        {
            _taskToEdit = data;
        }
        public PlannedTaskModel GetEditedData(string title, DateTime dueDate)
        {
            if (_taskToEdit == null)
                throw new InvalidOperationException("No task loaded. Call LoadData() first.");

            return new PlannedTaskModel
            {
                PlannedTaskID = _taskToEdit.PlannedTaskID,
                PlannedTaskTitle = title,
                PlannedTaskDueDate = dueDate,
                PlannedTaskIsCompleted = _taskToEdit.PlannedTaskIsCompleted,
                UserID = _taskToEdit.UserID
            };
        }
        public PlannedTaskModel GetSelectedItem()
        {
            if (PlannedTaskListView.SelectedItems.Count > 0)
            {
                var selectedItem = PlannedTaskListView.SelectedItems[0];
                return (PlannedTaskModel)selectedItem.Tag;
            }
            return null;
        }
        public void MarkAsCompleted(PlannedTaskModel task)
        {
            task.PlannedTaskIsCompleted = !task.PlannedTaskIsCompleted;
            PlannedTaskService.UpdateTaskStatus(task);
        }
    }
}
