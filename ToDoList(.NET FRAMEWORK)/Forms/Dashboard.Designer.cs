namespace ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.toDoListAppDBDataSet1 = new ToDoList.ToDoListAppDBDataSet();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.btnSaveTask = new FontAwesome.Sharp.IconButton();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.editPanel = new System.Windows.Forms.Panel();
            this.btnEditSave = new FontAwesome.Sharp.IconButton();
            this.tbEditTask = new System.Windows.Forms.TextBox();
            this.dtpEditDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddTasks = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnComplete = new FontAwesome.Sharp.IconButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.icnbtnPlanned = new FontAwesome.Sharp.IconButton();
            this.iconbtnMyday = new FontAwesome.Sharp.IconButton();
            this.iconbtnImportant = new FontAwesome.Sharp.IconButton();
            this.iconbtnTasks = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListAppDBDataSet1)).BeginInit();
            this.taskPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toDoListAppDBDataSet1
            // 
            this.toDoListAppDBDataSet1.DataSetName = "ToDoListAppDBDataSet";
            this.toDoListAppDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskPanel
            // 
            this.taskPanel.Controls.Add(this.btnSaveTask);
            this.taskPanel.Controls.Add(this.tbTitle);
            this.taskPanel.Controls.Add(this.dtpDueDate);
            this.taskPanel.Location = new System.Drawing.Point(167, 431);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(544, 56);
            this.taskPanel.TabIndex = 9;
            this.taskPanel.Visible = false;
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnSaveTask.IconColor = System.Drawing.Color.Black;
            this.btnSaveTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveTask.Location = new System.Drawing.Point(3, 0);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Size = new System.Drawing.Size(55, 53);
            this.btnSaveTask.TabIndex = 11;
            this.btnSaveTask.UseVisualStyleBackColor = true;
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.tbTitle.Location = new System.Drawing.Point(63, 19);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(433, 20);
            this.tbTitle.TabIndex = 10;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dtpDueDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpDueDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpDueDate.Location = new System.Drawing.Point(502, 19);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(32, 20);
            this.dtpDueDate.TabIndex = 1;
            // 
            // editPanel
            // 
            this.editPanel.Controls.Add(this.btnEditSave);
            this.editPanel.Controls.Add(this.tbEditTask);
            this.editPanel.Controls.Add(this.dtpEditDueDate);
            this.editPanel.Location = new System.Drawing.Point(167, 428);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(544, 56);
            this.editPanel.TabIndex = 12;
            this.editPanel.Visible = false;
            // 
            // btnEditSave
            // 
            this.btnEditSave.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnEditSave.IconColor = System.Drawing.Color.Black;
            this.btnEditSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditSave.Location = new System.Drawing.Point(3, 0);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(55, 53);
            this.btnEditSave.TabIndex = 11;
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // tbEditTask
            // 
            this.tbEditTask.BackColor = System.Drawing.SystemColors.Control;
            this.tbEditTask.Location = new System.Drawing.Point(63, 19);
            this.tbEditTask.Name = "tbEditTask";
            this.tbEditTask.Size = new System.Drawing.Size(433, 20);
            this.tbEditTask.TabIndex = 10;
            // 
            // dtpEditDueDate
            // 
            this.dtpEditDueDate.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dtpEditDueDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpEditDueDate.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dtpEditDueDate.Location = new System.Drawing.Point(502, 19);
            this.dtpEditDueDate.Name = "dtpEditDueDate";
            this.dtpEditDueDate.Size = new System.Drawing.Size(32, 20);
            this.dtpEditDueDate.TabIndex = 1;
            // 
            // btnAddTasks
            // 
            this.btnAddTasks.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTasks.IconColor = System.Drawing.Color.Black;
            this.btnAddTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTasks.Location = new System.Drawing.Point(167, 431);
            this.btnAddTasks.Name = "btnAddTasks";
            this.btnAddTasks.Size = new System.Drawing.Size(55, 53);
            this.btnAddTasks.TabIndex = 9;
            this.btnAddTasks.UseVisualStyleBackColor = true;
            this.btnAddTasks.Click += new System.EventHandler(this.btnAddTasks_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(629, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComplete.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnComplete.IconColor = System.Drawing.Color.Black;
            this.btnComplete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnComplete.IconSize = 30;
            this.btnComplete.Location = new System.Drawing.Point(426, 25);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(118, 33);
            this.btnComplete.TabIndex = 10;
            this.btnComplete.Text = "Complete";
            this.btnComplete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(165, 62);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(548, 353);
            this.mainPanel.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.Location = new System.Drawing.Point(534, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 32);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(766, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // icnbtnPlanned
            // 
            this.icnbtnPlanned.FlatAppearance.BorderSize = 0;
            this.icnbtnPlanned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnPlanned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnbtnPlanned.ForeColor = System.Drawing.Color.White;
            this.icnbtnPlanned.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.icnbtnPlanned.IconColor = System.Drawing.Color.White;
            this.icnbtnPlanned.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnPlanned.IconSize = 30;
            this.icnbtnPlanned.Location = new System.Drawing.Point(0, 237);
            this.icnbtnPlanned.Name = "icnbtnPlanned";
            this.icnbtnPlanned.Size = new System.Drawing.Size(177, 52);
            this.icnbtnPlanned.TabIndex = 3;
            this.icnbtnPlanned.Text = "Planned";
            this.icnbtnPlanned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnbtnPlanned.UseVisualStyleBackColor = true;
            this.icnbtnPlanned.Click += new System.EventHandler(this.icnbtnPlanned_Click);
            // 
            // iconbtnMyday
            // 
            this.iconbtnMyday.FlatAppearance.BorderSize = 0;
            this.iconbtnMyday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnMyday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnMyday.ForeColor = System.Drawing.Color.White;
            this.iconbtnMyday.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.iconbtnMyday.IconColor = System.Drawing.Color.White;
            this.iconbtnMyday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnMyday.IconSize = 30;
            this.iconbtnMyday.Location = new System.Drawing.Point(0, 141);
            this.iconbtnMyday.Name = "iconbtnMyday";
            this.iconbtnMyday.Size = new System.Drawing.Size(177, 52);
            this.iconbtnMyday.TabIndex = 4;
            this.iconbtnMyday.Text = "My Day";
            this.iconbtnMyday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnMyday.UseVisualStyleBackColor = true;
            this.iconbtnMyday.Click += new System.EventHandler(this.iconbtnMyday_Click);
            // 
            // iconbtnImportant
            // 
            this.iconbtnImportant.FlatAppearance.BorderSize = 0;
            this.iconbtnImportant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnImportant.ForeColor = System.Drawing.Color.White;
            this.iconbtnImportant.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.iconbtnImportant.IconColor = System.Drawing.Color.White;
            this.iconbtnImportant.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnImportant.IconSize = 30;
            this.iconbtnImportant.Location = new System.Drawing.Point(0, 190);
            this.iconbtnImportant.Name = "iconbtnImportant";
            this.iconbtnImportant.Size = new System.Drawing.Size(177, 52);
            this.iconbtnImportant.TabIndex = 2;
            this.iconbtnImportant.Text = "Important";
            this.iconbtnImportant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnImportant.UseVisualStyleBackColor = true;
            this.iconbtnImportant.Click += new System.EventHandler(this.iconbtnImportant_Click);
            // 
            // iconbtnTasks
            // 
            this.iconbtnTasks.FlatAppearance.BorderSize = 0;
            this.iconbtnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnTasks.ForeColor = System.Drawing.Color.White;
            this.iconbtnTasks.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconbtnTasks.IconColor = System.Drawing.Color.White;
            this.iconbtnTasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnTasks.IconSize = 30;
            this.iconbtnTasks.Location = new System.Drawing.Point(0, 284);
            this.iconbtnTasks.Name = "iconbtnTasks";
            this.iconbtnTasks.Size = new System.Drawing.Size(177, 52);
            this.iconbtnTasks.TabIndex = 5;
            this.iconbtnTasks.Text = "Tasks";
            this.iconbtnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnTasks.UseVisualStyleBackColor = true;
            this.iconbtnTasks.Click += new System.EventHandler(this.iconbtnTasks_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.iconbtnTasks);
            this.panel1.Controls.Add(this.iconbtnMyday);
            this.panel1.Controls.Add(this.icnbtnPlanned);
            this.panel1.Controls.Add(this.iconbtnImportant);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 494);
            this.panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 30;
            this.btnLogout.Location = new System.Drawing.Point(0, 439);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(177, 52);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 541);
            this.Controls.Add(this.editPanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnAddTasks);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.taskPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.toDoListAppDBDataSet1)).EndInit();
            this.taskPanel.ResumeLayout(false);
            this.taskPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ToDoListAppDBDataSet toDoListAppDBDataSet1;
        private System.Windows.Forms.Panel taskPanel;
        private System.Windows.Forms.TextBox tbTitle;
        private FontAwesome.Sharp.IconButton btnAddTasks;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnComplete;
        private System.Windows.Forms.Panel mainPanel;
        private FontAwesome.Sharp.IconButton btnSaveTask;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Panel editPanel;
        private FontAwesome.Sharp.IconButton btnEditSave;
        private System.Windows.Forms.TextBox tbEditTask;
        private System.Windows.Forms.DateTimePicker dtpEditDueDate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton icnbtnPlanned;
        private FontAwesome.Sharp.IconButton iconbtnMyday;
        private FontAwesome.Sharp.IconButton iconbtnImportant;
        private FontAwesome.Sharp.IconButton iconbtnTasks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}