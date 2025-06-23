namespace ToDoList_.NET_FRAMEWORK_.Forms
{
    partial class ImportantForm
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
            this.iconbtnImportant = new FontAwesome.Sharp.IconButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
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
            this.iconbtnImportant.Location = new System.Drawing.Point(-22, 1);
            this.iconbtnImportant.Name = "iconbtnImportant";
            this.iconbtnImportant.Size = new System.Drawing.Size(177, 39);
            this.iconbtnImportant.TabIndex = 3;
            this.iconbtnImportant.Text = "Important";
            this.iconbtnImportant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconbtnImportant.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(357, 294);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ImportantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 352);
            this.Controls.Add(this.iconbtnImportant);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportantForm";
            this.Text = "ImportantForm";
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton iconbtnImportant;
        private System.Windows.Forms.ListView listView1;
    }
}