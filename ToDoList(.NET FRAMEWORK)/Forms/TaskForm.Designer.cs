namespace ToDoList.Forms
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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.iconbtnTasks.Location = new System.Drawing.Point(-24, -2);
            this.iconbtnTasks.Name = "iconbtnTasks";
            this.iconbtnTasks.Size = new System.Drawing.Size(177, 52);
            this.iconbtnTasks.TabIndex = 6;
            this.iconbtnTasks.Text = "Tasks";
            this.iconbtnTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnTasks.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 284);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 352);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.iconbtnTasks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconbtnTasks;
        private System.Windows.Forms.ListView listView1;
    }
}