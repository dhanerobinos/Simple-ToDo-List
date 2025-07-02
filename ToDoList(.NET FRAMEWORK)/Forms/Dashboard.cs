using Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoList.DataAccess;
using ToDoList.Forms;
using ToDoList.Forms;
using ToDoList.Handlers;
using ToDoList.Interfaces;
using ToDoList.Models;
using ToDoList.Services;
using ToDoList_.NET_FRAMEWORK_.Services;




namespace ToDoList
{
    public partial class Dashboard : Form
    {
        private Users _currentUser;
        private readonly TaskService _taskService = new TaskService();
        private List<TaskModel> tasks;

        public Dashboard(Users user)
        {
            InitializeComponent();

            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
        }


        private Form activeForm = null;

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
            LoadForm(new MyDayForm());
        }

        private void iconbtnTasks_Click(object sender, EventArgs e)
        {
            LoadForm(new TaskForm(_currentUser));
        }

        private void icnbtnPlanned_Click(object sender, EventArgs e)
        {
            LoadForm(new PlannedForm());
        }

        private void iconbtnImportant_Click(object sender, EventArgs e)
        {
            LoadForm(new ImportantForm());
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

            if (mainPanel.Controls.Count > 0)
            {
                Control currentForm = mainPanel.Controls[0];

                if (currentForm is IAddableForm<TaskModel> taskForm)
                {
                    var newData = taskForm.GetNewData(title, dueDate);
                    taskForm.AddData(newData);
                    LoadForm(new TaskForm(_currentUser));
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
        }
    }
}
