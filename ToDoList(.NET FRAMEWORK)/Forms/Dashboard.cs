using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Forms;

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
        
    }
}
