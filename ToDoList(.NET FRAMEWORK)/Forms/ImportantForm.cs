using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Interfaces;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Forms
{
    public partial class ImportantForm : Form
        ,IAddableForm<ImportantTaskModel>, IEditableForm<ImportantTaskModel>, IDeletableForm<ImportantTaskModel>, ICompletableForm<ImportantTaskModel>
    {
        private readonly ImportantTaskService ImportantTaskService = new ImportantTaskService();
        private Users _currentUser;
        private ImportantTaskModel _taskToEdit;
        public ImportantForm(Users user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadImportantTasks();
            
        }
        public void LoadImportantTasks()
        {
            ImportantTaskListView.Items.Clear();
            var tasks = ImportantTaskService.GetTasksByUser(_currentUser.UserID);

            ImportantTaskListView.View = View.Details;
            ImportantTaskListView.Columns.Clear();


            ImportantTaskListView.Columns.Add("Title", 150);
            ImportantTaskListView.Columns.Add("Due Date", 120);
            ImportantTaskListView.Columns.Add("Completed", 100);

            foreach (ImportantTaskModel task in tasks)
            {
                var item = new ListViewItem(task.ImportantTaskTitle);
                item.SubItems.Add(task.ImportantTaskDueDate.ToShortDateString());
                item.SubItems.Add(task.ImportantTaskIsCompleted? "Completed" : "Pending");

                if (task.ImportantTaskIsCompleted)
                {
                    item.Font = new Font(item.Font, FontStyle.Strikeout);
                }

                item.Tag = task;
                ImportantTaskListView.Items.Add(item);
            }
        }
        public ImportantTaskModel GetNewData(string title, DateTime dueDate)
        {
            return new ImportantTaskModel
            {
                ImportantTaskTitle = title,
                ImportantTaskDueDate = dueDate,
                ImportantTaskIsCompleted = false
            };
        }
        public void AddData(ImportantTaskModel data)
        {
            data.UserID = _currentUser.UserID;
            ImportantTaskService.AddImportantTasks(data);
        }
        public void LoadData(ImportantTaskModel data)
        {
            _taskToEdit = data;
        }
        public ImportantTaskModel GetEditedData(string title, DateTime dueDate)
        {
            if (_taskToEdit == null)
                throw new InvalidOperationException("No task loaded. Call LoadData() first.");

            return new ImportantTaskModel
            {
                ImportantTaskID = _taskToEdit.ImportantTaskID,
                ImportantTaskTitle = title,
                ImportantTaskDueDate = dueDate,
                ImportantTaskIsCompleted = _taskToEdit.ImportantTaskIsCompleted,
                UserID = _taskToEdit.UserID
            };
        }
        public ImportantTaskModel GetSelectedItem()
        {
            if (ImportantTaskListView.SelectedItems.Count > 0)
            {
                var selectedItem = ImportantTaskListView.SelectedItems[0];
                return (ImportantTaskModel)selectedItem.Tag;
            }
            return null;
        }
        public void MarkAsCompleted(ImportantTaskModel task)
        {
            task.ImportantTaskIsCompleted = !task.ImportantTaskIsCompleted;
            ImportantTaskService.UpdateTaskStatus(task);
        }
    
    }
}
