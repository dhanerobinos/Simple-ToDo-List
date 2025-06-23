namespace ToDoList_.NET_FRAMEWORK_.Forms
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconbtnTasks = new FontAwesome.Sharp.IconButton();
            this.iconbtnMyday = new FontAwesome.Sharp.IconButton();
            this.icnbtnPlanned = new FontAwesome.Sharp.IconButton();
            this.iconbtnImportant = new FontAwesome.Sharp.IconButton();
            this.toDoListAppDBDataSet1 = new ToDoList_.NET_FRAMEWORK_.ToDoListAppDBDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addtaskPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSaveTasks = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListAppDBDataSet1)).BeginInit();
            this.addtaskPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.iconbtnTasks);
            this.panel1.Controls.Add(this.iconbtnMyday);
            this.panel1.Controls.Add(this.icnbtnPlanned);
            this.panel1.Controls.Add(this.iconbtnImportant);
            this.panel1.Location = new System.Drawing.Point(1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 432);
            this.panel1.TabIndex = 0;
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
            this.iconbtnTasks.Location = new System.Drawing.Point(-17, 196);
            this.iconbtnTasks.Name = "iconbtnTasks";
            this.iconbtnTasks.Size = new System.Drawing.Size(177, 52);
            this.iconbtnTasks.TabIndex = 5;
            this.iconbtnTasks.Text = "Tasks";
            this.iconbtnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnTasks.UseVisualStyleBackColor = true;
            this.iconbtnTasks.Click += new System.EventHandler(this.iconbtnTasks_Click);
            // 
            // iconbtnMyday
            // 
            this.iconbtnMyday.FlatAppearance.BorderSize = 0;
            this.iconbtnMyday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnMyday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnMyday.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconbtnMyday.IconColor = System.Drawing.Color.Black;
            this.iconbtnMyday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnMyday.IconSize = 30;
            this.iconbtnMyday.Location = new System.Drawing.Point(-17, 53);
            this.iconbtnMyday.Name = "iconbtnMyday";
            this.iconbtnMyday.Size = new System.Drawing.Size(177, 52);
            this.iconbtnMyday.TabIndex = 4;
            this.iconbtnMyday.Text = "My Day";
            this.iconbtnMyday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnMyday.UseVisualStyleBackColor = true;
            this.iconbtnMyday.Click += new System.EventHandler(this.iconbtnMyday_Click);
            // 
            // icnbtnPlanned
            // 
            this.icnbtnPlanned.FlatAppearance.BorderSize = 0;
            this.icnbtnPlanned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnbtnPlanned.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.icnbtnPlanned.IconColor = System.Drawing.Color.Black;
            this.icnbtnPlanned.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnPlanned.IconSize = 30;
            this.icnbtnPlanned.Location = new System.Drawing.Point(-17, 149);
            this.icnbtnPlanned.Name = "icnbtnPlanned";
            this.icnbtnPlanned.Size = new System.Drawing.Size(177, 52);
            this.icnbtnPlanned.TabIndex = 3;
            this.icnbtnPlanned.Text = "Planned";
            this.icnbtnPlanned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnbtnPlanned.UseVisualStyleBackColor = true;
            this.icnbtnPlanned.Click += new System.EventHandler(this.icnbtnPlanned_Click);
            // 
            // iconbtnImportant
            // 
            this.iconbtnImportant.FlatAppearance.BorderSize = 0;
            this.iconbtnImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnImportant.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconbtnImportant.IconColor = System.Drawing.Color.Black;
            this.iconbtnImportant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnImportant.IconSize = 30;
            this.iconbtnImportant.Location = new System.Drawing.Point(-17, 102);
            this.iconbtnImportant.Name = "iconbtnImportant";
            this.iconbtnImportant.Size = new System.Drawing.Size(177, 52);
            this.iconbtnImportant.TabIndex = 2;
            this.iconbtnImportant.Text = "Important";
            this.iconbtnImportant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnImportant.UseVisualStyleBackColor = true;
            this.iconbtnImportant.Click += new System.EventHandler(this.iconbtnImportant_Click);
            // 
            // toDoListAppDBDataSet1
            // 
            this.toDoListAppDBDataSet1.DataSetName = "ToDoListAppDBDataSet";
            this.toDoListAppDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 33);
            this.panel3.TabIndex = 3;
            // 
            // addtaskPanel
            // 
            this.addtaskPanel.Controls.Add(this.textBox1);
            this.addtaskPanel.Controls.Add(this.btnSaveTasks);
            this.addtaskPanel.Controls.Add(this.iconButton1);
            this.addtaskPanel.Controls.Add(this.dateTimePicker1);
            this.addtaskPanel.Location = new System.Drawing.Point(181, 332);
            this.addtaskPanel.Name = "addtaskPanel";
            this.addtaskPanel.Size = new System.Drawing.Size(357, 56);
            this.addtaskPanel.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 10;
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
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 20;
            this.btnDelete.Location = new System.Drawing.Point(439, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(331, 34);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(117, 33);
            this.iconButton3.TabIndex = 10;
            this.iconButton3.Text = "Complete";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(157, 71);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(381, 254);
            this.mainPanel.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.addtaskPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListAppDBDataSet1)).EndInit();
            this.addtaskPanel.ResumeLayout(false);
            this.addtaskPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ToDoListAppDBDataSet toDoListAppDBDataSet1;
        private FontAwesome.Sharp.IconButton iconbtnImportant;
        private FontAwesome.Sharp.IconButton iconbtnMyday;
        private FontAwesome.Sharp.IconButton icnbtnPlanned;
        private FontAwesome.Sharp.IconButton iconbtnTasks;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel addtaskPanel;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton btnSaveTasks;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel mainPanel;
    }
}