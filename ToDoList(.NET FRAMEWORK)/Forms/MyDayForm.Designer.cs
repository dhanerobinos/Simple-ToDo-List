namespace ToDoList.Forms
{
    partial class MyDayForm
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
            this.iconbtnMyday = new FontAwesome.Sharp.IconButton();
            this.MyDayListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.iconbtnMyday.Location = new System.Drawing.Point(-22, 1);
            this.iconbtnMyday.Name = "iconbtnMyday";
            this.iconbtnMyday.Size = new System.Drawing.Size(177, 37);
            this.iconbtnMyday.TabIndex = 9;
            this.iconbtnMyday.Text = "My Day";
            this.iconbtnMyday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnMyday.UseVisualStyleBackColor = true;
            // 
            // MyDayListView
            // 
            this.MyDayListView.BackColor = System.Drawing.SystemColors.Control;
            this.MyDayListView.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDayListView.HideSelection = false;
            this.MyDayListView.Location = new System.Drawing.Point(12, 46);
            this.MyDayListView.Name = "MyDayListView";
            this.MyDayListView.Size = new System.Drawing.Size(524, 294);
            this.MyDayListView.TabIndex = 8;
            this.MyDayListView.UseCompatibleStateImageBehavior = false;
            // 
            // MyDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 353);
            this.Controls.Add(this.iconbtnMyday);
            this.Controls.Add(this.MyDayListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyDayForm";
            this.Text = "MyDayForm";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconbtnMyday;
        private System.Windows.Forms.ListView MyDayListView;
    }
}