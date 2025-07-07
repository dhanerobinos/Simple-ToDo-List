using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Interfaces;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Forms
{
    public partial class MyDayForm : Form,
        IAddableForm<MyDayTaskModel>,IEditableForm<MyDayTaskModel>,IDeletableForm<MyDayTaskModel>,ICompletableForm<MyDayTaskModel>
    {
        private readonly MyDayTaskService MyDayTaskService = new MyDayTaskService();
        private Users _currentUser;
        private MyDayTaskModel _taskToEdit;
        public MyDayForm(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadMyDayTasks(); 
        }

       public void LoadMyDayTasks()
        {
            MyDayListView.Items.Clear();
            var tasks = MyDayTaskService.GetTasksByUser(_currentUser.UserID);

            MyDayListView.View = View.Details;
            MyDayListView.Columns.Clear();
            MyDayListView.Columns.Add("Title", 150);
            MyDayListView.Columns.Add("Due Date", 120);
            MyDayListView.Columns.Add("Completed", 100);

            foreach (MyDayTaskModel task in tasks)
            {
                var item = new ListViewItem(task.DayTaskTitle);
                item.SubItems.Add(task.DayTaskDueDate.ToShortDateString());
                item.SubItems.Add(task.DayTaskIsCompleted ? "Completed" : "Pending");

                if (task.DayTaskIsCompleted)
                {
                    item.Font = new Font(item.Font, FontStyle.Strikeout);
                }
                item.Tag = task;
                MyDayListView.Items.Add(item);
            }
        }
        public MyDayTaskModel GetNewData(string title, DateTime dueDate)
        {
            return new MyDayTaskModel
            {
                DayTaskTitle = title,
                DayTaskDueDate = dueDate,
                DayTaskIsCompleted = false
            };
        }
        public void AddData(MyDayTaskModel data)
        {
            data.UserID = _currentUser.UserID;
            MyDayTaskService.AddDayTasks(data);
           
        }
        public void LoadData(MyDayTaskModel data)
        {
            _taskToEdit = data;
        }
        public MyDayTaskModel GetEditedData(string title, DateTime dueDate)
        {
            if (_taskToEdit == null)
                throw new InvalidOperationException("No task loaded. Call LoadData() first.");

            return new MyDayTaskModel
            {
                DayTaskID = _taskToEdit.DayTaskID,
                DayTaskTitle = title,
                DayTaskDueDate = dueDate,
                DayTaskIsCompleted = _taskToEdit.DayTaskIsCompleted,
                UserID = _taskToEdit.UserID
            };
        }
        public MyDayTaskModel GetSelectedItem()
        {
            if (MyDayListView.SelectedItems.Count > 0)
            {
                var selectedItem = MyDayListView.SelectedItems[0];
                return (MyDayTaskModel)selectedItem.Tag;
            }
            return null;
        }
        public void MarkAsCompleted(MyDayTaskModel task)
        {
            task.DayTaskIsCompleted = !task.DayTaskIsCompleted;
            MyDayTaskService.UpdateTaskStatus(task);
        }
    }
}
