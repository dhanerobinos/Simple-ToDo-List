namespace ToDoList.Forms
{
    partial class PlannedForm
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
            this.icnbtnPlanned = new FontAwesome.Sharp.IconButton();
            this.PlannedTaskListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.icnbtnPlanned.Location = new System.Drawing.Point(-22, 1);
            this.icnbtnPlanned.Name = "icnbtnPlanned";
            this.icnbtnPlanned.Size = new System.Drawing.Size(177, 40);
            this.icnbtnPlanned.TabIndex = 9;
            this.icnbtnPlanned.Text = "Planned";
            this.icnbtnPlanned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnbtnPlanned.UseVisualStyleBackColor = true;
            // 
            // PlannedTaskListView
            // 
            this.PlannedTaskListView.BackColor = System.Drawing.SystemColors.Control;
            this.PlannedTaskListView.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlannedTaskListView.HideSelection = false;
            this.PlannedTaskListView.Location = new System.Drawing.Point(12, 46);
            this.PlannedTaskListView.Name = "PlannedTaskListView";
            this.PlannedTaskListView.Size = new System.Drawing.Size(524, 294);
            this.PlannedTaskListView.TabIndex = 8;
            this.PlannedTaskListView.UseCompatibleStateImageBehavior = false;
            // 
            // PlannedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 353);
            this.Controls.Add(this.icnbtnPlanned);
            this.Controls.Add(this.PlannedTaskListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlannedForm";
            this.Text = "PlannedForm";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton icnbtnPlanned;
        private System.Windows.Forms.ListView PlannedTaskListView;
    }
}