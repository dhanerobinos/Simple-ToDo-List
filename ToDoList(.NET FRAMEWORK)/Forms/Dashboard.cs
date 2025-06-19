using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList_.NET_FRAMEWORK_.Forms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void LoadForm(object formObj)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);

            if (formObj is Form f)
            {
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainPanel.Controls.Add(f);
                this.mainPanel.Tag = f;
                f.Show();
            }
        }

        private void iconbtnMyday_Click(object sender, EventArgs e)
        {
            LoadForm(new MyDayForm());
        }

        private void iconbtnImportant_Click(object sender, EventArgs e)
        {
            LoadForm(new ImportantForm());
        }

        private void icnbtnPlanned_Click(object sender, EventArgs e)
        {
            LoadForm(new PlannedForm());
        }

        private void iconbtnTasks_Click(object sender, EventArgs e)
        {
            LoadForm(new TaskForm());
        }
    }
}
