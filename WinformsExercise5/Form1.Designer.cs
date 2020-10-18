namespace WinformsExercise5
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
            this.mouse = new System.Windows.Forms.CheckBox();
            this.dog = new System.Windows.Forms.CheckBox();
            this.cat = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.animalsChosen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mouse
            // 
            this.mouse.AutoSize = true;
            this.mouse.Location = new System.Drawing.Point(351, 56);
            this.mouse.Name = "mouse";
            this.mouse.Size = new System.Drawing.Size(72, 21);
            this.mouse.TabIndex = 0;
            this.mouse.Text = "Mouse";
            this.mouse.UseVisualStyleBackColor = true;
            // 
            // dog
            // 
            this.dog.AutoSize = true;
            this.dog.Location = new System.Drawing.Point(351, 107);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(56, 21);
            this.dog.TabIndex = 1;
            this.dog.Text = "Dog";
            this.dog.UseVisualStyleBackColor = true;
            // 
            // cat
            // 
            this.cat.AutoSize = true;
            this.cat.Location = new System.Drawing.Point(351, 159);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(51, 21);
            this.cat.TabIndex = 2;
            this.cat.Text = "Cat";
            this.cat.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(351, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // animalsChosen
            // 
            this.animalsChosen.Location = new System.Drawing.Point(283, 321);
            this.animalsChosen.Name = "animalsChosen";
            this.animalsChosen.Size = new System.Drawing.Size(228, 22);
            this.animalsChosen.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.animalsChosen);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cat);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.mouse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox mouse;
        private System.Windows.Forms.CheckBox dog;
        private System.Windows.Forms.CheckBox cat;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox animalsChosen;
    }
}

