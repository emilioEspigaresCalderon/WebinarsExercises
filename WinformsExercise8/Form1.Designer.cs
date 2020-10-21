namespace WinformsExercise8
{
    partial class Form1
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
            this.students = new System.Windows.Forms.ListBox();
            this.classroom1 = new System.Windows.Forms.Button();
            this.classroom2 = new System.Windows.Forms.Button();
            this.studentSelected = new System.Windows.Forms.TextBox();
            this.clearList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // students
            // 
            this.students.FormattingEnabled = true;
            this.students.ItemHeight = 16;
            this.students.Location = new System.Drawing.Point(136, 40);
            this.students.Name = "students";
            this.students.Size = new System.Drawing.Size(120, 196);
            this.students.TabIndex = 0;
            this.students.SelectedIndexChanged += new System.EventHandler(this.StudentSelected);
            // 
            // classroom1
            // 
            this.classroom1.Location = new System.Drawing.Point(136, 271);
            this.classroom1.Name = "classroom1";
            this.classroom1.Size = new System.Drawing.Size(120, 23);
            this.classroom1.TabIndex = 1;
            this.classroom1.Text = "Classroom 1";
            this.classroom1.UseVisualStyleBackColor = true;
            this.classroom1.Click += new System.EventHandler(this.classroom1_Click);
            // 
            // classroom2
            // 
            this.classroom2.Location = new System.Drawing.Point(136, 328);
            this.classroom2.Name = "classroom2";
            this.classroom2.Size = new System.Drawing.Size(120, 23);
            this.classroom2.TabIndex = 2;
            this.classroom2.Text = "Classroom 2";
            this.classroom2.UseVisualStyleBackColor = true;
            this.classroom2.Click += new System.EventHandler(this.classroom2_Click);
            // 
            // studentSelected
            // 
            this.studentSelected.Location = new System.Drawing.Point(339, 40);
            this.studentSelected.Name = "studentSelected";
            this.studentSelected.Size = new System.Drawing.Size(316, 22);
            this.studentSelected.TabIndex = 3;
            // 
            // clearList
            // 
            this.clearList.Location = new System.Drawing.Point(136, 379);
            this.clearList.Name = "clearList";
            this.clearList.Size = new System.Drawing.Size(120, 23);
            this.clearList.TabIndex = 4;
            this.clearList.Text = "Clear list";
            this.clearList.UseVisualStyleBackColor = true;
            this.clearList.Click += new System.EventHandler(this.clearList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearList);
            this.Controls.Add(this.studentSelected);
            this.Controls.Add(this.classroom2);
            this.Controls.Add(this.classroom1);
            this.Controls.Add(this.students);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox students;
        private System.Windows.Forms.Button classroom1;
        private System.Windows.Forms.Button classroom2;
        private System.Windows.Forms.TextBox studentSelected;
        private System.Windows.Forms.Button clearList;
    }
}

