using System;

using System.Windows.Forms;
using ToDoList.Forms;
using ToDoList.Interfaces;
using ToDoList_.NET_FRAMEWORK_.Forms;


namespace ToDoList
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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
            LoadForm(new TaskForm());
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
            /*string title = txtTaskTitle.Text.Trim();
            DateTime dueDate = dateTimePickerDueDate.Value;

            if (activeForm is ICrudForm crudForm)
            {
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Please enter a task title.");
                    return;
                }

                crudForm.AddItem(title, dueDate);
                txtTaskTitle.Clear(); // reset after add
            }

            */
        }
    }
}
