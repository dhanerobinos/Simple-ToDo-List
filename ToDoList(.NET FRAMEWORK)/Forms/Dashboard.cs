using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoList.Forms;
using ToDoList.Handlers;
using ToDoList.Interfaces;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList
{
    public partial class Dashboard : Form
    {
        private Users _currentUser;
        private readonly TaskService _taskService = new TaskService();
        private readonly MyDayTaskService _daytaskService = new MyDayTaskService();
        private readonly ImportantTaskService _importantTaskService = new ImportantTaskService();
        private readonly PlannedTaskService PlannedTaskService = new PlannedTaskService();
        private List<TaskModel> tasks;
        private TaskForm _taskForm;
        private TaskModel _selectedTask;
        private MyDayTaskModel _selectedMyDayTask;
        private ImportantTaskModel _selectedImportantTask;
        private PlannedTaskModel _selectedPlannedTask;
        private Form activeForm = null;

        public Dashboard(Users user)
        {
            InitializeComponent();

            _currentUser = user;
        }
       
        private void LoadForm(Form childForm)
        {
            // Close the currently active form if any
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void iconbtnMyday_Click(object sender, EventArgs e)
        {
            LoadForm(new MyDayForm(_currentUser));
        }

        private void iconbtnTasks_Click(object sender, EventArgs e)
        {
            LoadForm(new TaskForm(_currentUser));
        }

        private void icnbtnPlanned_Click(object sender, EventArgs e)
        {
            LoadForm(new PlannedForm(_currentUser));
        }

        private void iconbtnImportant_Click(object sender, EventArgs e)
        {
            LoadForm(new ImportantForm(_currentUser));
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            btnAddTasks.Hide();
            taskPanel.Show();
        }
        private void btnSaveTask_Click(object sender, EventArgs e)
        {

            string title = tbTitle.Text;
            DateTime dueDate = dtpDueDate.Value;

            if (mainPanel.Controls.Count > 0 && title != "")
            {
                Control currentForm = mainPanel.Controls[0];

                if (currentForm is IAddableForm<TaskModel> taskForm)
                {
                    var newData = taskForm.GetNewData(title, dueDate);
                    taskForm.AddData(newData);
                    LoadForm(new TaskForm(_currentUser));
                }
                else if(currentForm is IAddableForm<MyDayTaskModel> myDayForm)
                {
                    var newData = myDayForm.GetNewData(title, dueDate);
                    myDayForm.AddData(newData);
                    LoadForm(new MyDayForm(_currentUser));
                }
                else if(currentForm is IAddableForm<ImportantTaskModel> importantForm)
                {
                    var newData = importantForm.GetNewData(title, dueDate);
                    importantForm.AddData(newData);
                    LoadForm(new ImportantForm(_currentUser));
                }
                else if(currentForm is PlannedForm plannedForm)
                {
                    var newData = plannedForm.GetNewData(title, dueDate);
                    plannedForm.AddData(newData);
                    LoadForm(new PlannedForm(_currentUser));
                }
              else
                {
                    MessageBox.Show("Please write a task to add.", "No Task Type Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls[0] is IDeletableForm<TaskModel> deletableForm)
            {
                DeleteHandler.HandleDelete(deletableForm, task => _taskService.DeleteTask(task));
                LoadForm(new TaskForm(_currentUser));
            }
            else if (mainPanel.Controls[0] is IDeletableForm<MyDayTaskModel> myDayDeletableForm)
            {
                DeleteHandler.HandleDelete(myDayDeletableForm, task => _daytaskService.DeleteDayTask(task));
                LoadForm(new MyDayForm(_currentUser));
            }
            else if (mainPanel.Controls[0] is IDeletableForm<ImportantTaskModel> importantDeletableForm)
            {
                DeleteHandler.HandleDelete(importantDeletableForm, task => _importantTaskService.DeleteImportantTask(task));
                LoadForm(new ImportantForm(_currentUser));
            }
            else if (mainPanel.Controls[0] is PlannedForm plannedDeletableForm)
            {
                DeleteHandler.HandleDelete(plannedDeletableForm, task => PlannedTaskService.DeletePlannedTask(task));
                LoadForm(new PlannedForm(_currentUser));
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Count > 0)
            {
                Control currentForm = mainPanel.Controls[0]; 

                if (currentForm is TaskForm taskForm)
                {
                    _selectedTask = taskForm.GetSelectedItem();
                    if (_selectedTask != null)
                    {
                        tbEditTask.Text = _selectedTask.TaskTitle;
                        dtpEditDueDate.Value = _selectedTask.TaskDueDate;

                        taskForm.LoadData(_selectedTask);
                        editPanel.Visible = true;
                        taskPanel.Hide();
                    }
                }
                else if (currentForm is MyDayForm myDayForm)
                {
                    _selectedMyDayTask = myDayForm.GetSelectedItem();
                    if (_selectedMyDayTask != null)
                    {
                        tbEditTask.Text = _selectedMyDayTask.DayTaskTitle;
                        dtpEditDueDate.Value = _selectedMyDayTask.DayTaskDueDate;

                        myDayForm.LoadData(_selectedMyDayTask);
                        editPanel.Visible = true;
                        taskPanel.Hide();
                    }
                }
                else if (currentForm is ImportantForm importantForm)
                {
                    _selectedImportantTask = importantForm.GetSelectedItem();
                    if (_selectedImportantTask != null)
                    {
                        tbEditTask.Text = _selectedImportantTask.ImportantTaskTitle;
                        dtpEditDueDate.Value = _selectedImportantTask.ImportantTaskDueDate;
                        importantForm.LoadData(_selectedImportantTask);
                        editPanel.Visible = true;
                        taskPanel.Hide();
                    }
                }
                else if (currentForm is PlannedForm plannedForm)
                {
                    _selectedPlannedTask = plannedForm.GetSelectedItem();
                    if (_selectedPlannedTask != null)
                    {
                        tbEditTask.Text = _selectedPlannedTask.PlannedTaskTitle;
                        dtpEditDueDate.Value = _selectedPlannedTask.PlannedTaskDueDate;
                        plannedForm.LoadData(_selectedPlannedTask);
                        editPanel.Visible = true;
                        taskPanel.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            string title = tbEditTask.Text;
            DateTime dueDate = dtpEditDueDate.Value;

            if (mainPanel.Controls.Count > 0)
            {
                Control currentForm = mainPanel.Controls[0];

                if (currentForm is IEditableForm<TaskModel> taskForm)
                {
                    EditHandler.HandleEditSave(taskForm, title, dueDate, task =>
                    {
                        TaskService.UpdateTasks(task);
                    });

                    LoadForm(new TaskForm(_currentUser));
                    editPanel.Visible = false;
                }
                else if (currentForm is IEditableForm<MyDayTaskModel> myDayForm)
                {
                    EditHandler.HandleEditSave(myDayForm, title, dueDate, task =>
                    {
                        MyDayTaskService.UpdateDayTasks(task);
                    });

                    LoadForm(new MyDayForm(_currentUser));
                    editPanel.Visible = false;
                }
                else if (currentForm is IEditableForm<ImportantTaskModel> importantForm)
                {
                    EditHandler.HandleEditSave(importantForm, title, dueDate, task =>
                    {
                        ImportantTaskService.UpdateImportantTasks(task);
                    });
                    LoadForm(new ImportantForm(_currentUser));
                    editPanel.Visible = false;
                }
                else if (currentForm is PlannedForm plannedForm)
                {
                    EditHandler.HandleEditSave(plannedForm, title, dueDate, task =>
                    {
                        PlannedTaskService.UpdatePlannedTask(task);
                    });
                    LoadForm(new PlannedForm(_currentUser));
                    editPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please select a task to edit.", "No Task Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (mainPanel.Controls.Count > 0)
            {
                Control currentForm = mainPanel.Controls[0];

                if (currentForm is ICompletableForm<TaskModel> taskForm)
                {
                    var selectedTask = taskForm.GetSelectedItem();
                    if (selectedTask != null)
                    {
                        taskForm.MarkAsCompleted(selectedTask);
                        LoadForm(new TaskForm(_currentUser));
                    }
                }
                else if (currentForm is ICompletableForm<MyDayTaskModel> myDayForm)
                {
                    var selectedTask = myDayForm.GetSelectedItem();
                    if (selectedTask != null)
                    {
                        myDayForm.MarkAsCompleted(selectedTask);
                        LoadForm(new MyDayForm(_currentUser));
                    }
                }
                else if (currentForm is ICompletableForm<ImportantTaskModel> importantForm)
                {
                    var selectedTask = importantForm.GetSelectedItem();
                    if (selectedTask != null)
                    {
                        importantForm.MarkAsCompleted(selectedTask);
                        LoadForm(new ImportantForm(_currentUser));
                    }
                }
                else if (currentForm is ICompletableForm<PlannedTaskModel> plannedForm)
                {
                    var selectedTask = plannedForm.GetSelectedItem();
                    if (selectedTask != null)
                    {
                        plannedForm.MarkAsCompleted(selectedTask);
                        LoadForm(new PlannedForm(_currentUser));
                    }
                }
                else
                {
                    MessageBox.Show("No form selected.");
                }
            }
        }
    }
}

