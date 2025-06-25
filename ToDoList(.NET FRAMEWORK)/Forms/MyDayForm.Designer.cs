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
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.iconbtnMyday.Location = new System.Drawing.Point(-18, -2);
            this.iconbtnMyday.Name = "iconbtnMyday";
            this.iconbtnMyday.Size = new System.Drawing.Size(177, 52);
            this.iconbtnMyday.TabIndex = 9;
            this.iconbtnMyday.Text = "My Day";
            this.iconbtnMyday.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnMyday.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 284);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MyDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 352);
            this.Controls.Add(this.iconbtnMyday);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyDayForm";
            this.Text = "MyDayForm";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconbtnMyday;
        private System.Windows.Forms.ListView listView1;
    }
}