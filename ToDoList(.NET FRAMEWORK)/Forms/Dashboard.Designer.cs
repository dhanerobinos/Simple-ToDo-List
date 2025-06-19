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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.iconbtnMyday = new FontAwesome.Sharp.IconButton();
            this.icnbtnPlanned = new FontAwesome.Sharp.IconButton();
            this.iconbtnImportant = new FontAwesome.Sharp.IconButton();
            this.toDoListAppDBDataSet1 = new ToDoList_.NET_FRAMEWORK_.ToDoListAppDBDataSet();
            this.iconbtnAdd = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toDoListAppDBDataSet1)).BeginInit();
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
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(157, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(381, 352);
            this.mainPanel.TabIndex = 2;
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
            this.iconbtnMyday.Location = new System.Drawing.Point(-17, 58);
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
            // iconbtnAdd
            // 
            this.iconbtnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.iconbtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.iconbtnAdd.FlatAppearance.BorderSize = 0;
            this.iconbtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconbtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconbtnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconbtnAdd.IconColor = System.Drawing.Color.MediumOrchid;
            this.iconbtnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconbtnAdd.IconSize = 50;
            this.iconbtnAdd.Location = new System.Drawing.Point(376, 331);
            this.iconbtnAdd.Name = "iconbtnAdd";
            this.iconbtnAdd.Size = new System.Drawing.Size(78, 57);
            this.iconbtnAdd.TabIndex = 1;
            this.iconbtnAdd.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(1, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 33);
            this.panel3.TabIndex = 3;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.iconbtnAdd);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.White;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toDoListAppDBDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ToDoListAppDBDataSet toDoListAppDBDataSet1;
        private FontAwesome.Sharp.IconButton iconbtnAdd;
        private FontAwesome.Sharp.IconButton iconbtnImportant;
        private FontAwesome.Sharp.IconButton iconbtnMyday;
        private FontAwesome.Sharp.IconButton icnbtnPlanned;
        private FontAwesome.Sharp.IconButton iconbtnTasks;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel3;
    }
}