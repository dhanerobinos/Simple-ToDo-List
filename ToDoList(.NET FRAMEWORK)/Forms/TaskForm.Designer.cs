namespace ToDoList_.NET_FRAMEWORK_.Forms
{
    partial class TaskForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.iconbtnTasks = new FontAwesome.Sharp.IconButton();
            this.addtaskPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnSaveTasks = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.addtaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconbtnTasks
            // 
            this.iconbtnTasks.FlatAppearance.BorderSize = 0;
            this.iconbtnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnTasks.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconbtnTasks.IconColor = System.Drawing.Color.Black;
            this.iconbtnTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnTasks.IconSize = 30;
            this.iconbtnTasks.Location = new System.Drawing.Point(-2, -2);
            this.iconbtnTasks.Name = "iconbtnTasks";
            this.iconbtnTasks.Size = new System.Drawing.Size(177, 52);
            this.iconbtnTasks.TabIndex = 6;
            this.iconbtnTasks.Text = "Tasks";
            this.iconbtnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnTasks.UseVisualStyleBackColor = true;
            // 
            // addtaskPanel
            // 
            this.addtaskPanel.Controls.Add(this.btnAdd);
            this.addtaskPanel.Controls.Add(this.textBox1);
            this.addtaskPanel.Controls.Add(this.btnSaveTasks);
            this.addtaskPanel.Controls.Add(this.iconButton1);
            this.addtaskPanel.Controls.Add(this.dateTimePicker1);
            this.addtaskPanel.Location = new System.Drawing.Point(12, 284);
            this.addtaskPanel.Name = "addtaskPanel";
            this.addtaskPanel.Size = new System.Drawing.Size(357, 56);
            this.addtaskPanel.TabIndex = 8;
            this.addtaskPanel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 10;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(311, 9);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(43, 44);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(273, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(32, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // btnSaveTasks
            // 
            this.btnSaveTasks.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSaveTasks.IconColor = System.Drawing.Color.Black;
            this.btnSaveTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveTasks.Location = new System.Drawing.Point(3, 7);
            this.btnSaveTasks.Name = "btnSaveTasks";
            this.btnSaveTasks.Size = new System.Drawing.Size(55, 43);
            this.btnSaveTasks.TabIndex = 9;
            this.btnSaveTasks.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(357, 56);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 352);
            this.Controls.Add(this.addtaskPanel);
            this.Controls.Add(this.iconbtnTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.addtaskPanel.ResumeLayout(false);
            this.addtaskPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnTasks;
        private System.Windows.Forms.Panel addtaskPanel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton btnSaveTasks;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnAdd;
    }
}