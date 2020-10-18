namespace WinformsExercise6
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
            this.radioButtonsPanel = new System.Windows.Forms.Panel();
            this.green = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.black = new System.Windows.Forms.RadioButton();
            this.okButton = new System.Windows.Forms.Button();
            this.chosenColour = new System.Windows.Forms.TextBox();
            this.radioButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonsPanel
            // 
            this.radioButtonsPanel.Controls.Add(this.black);
            this.radioButtonsPanel.Controls.Add(this.red);
            this.radioButtonsPanel.Controls.Add(this.green);
            this.radioButtonsPanel.Location = new System.Drawing.Point(298, 75);
            this.radioButtonsPanel.Name = "radioButtonsPanel";
            this.radioButtonsPanel.Size = new System.Drawing.Size(200, 113);
            this.radioButtonsPanel.TabIndex = 0;
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(44, 4);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(69, 21);
            this.green.TabIndex = 0;
            this.green.TabStop = true;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(45, 40);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 21);
            this.red.TabIndex = 1;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(44, 76);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(63, 21);
            this.black.TabIndex = 2;
            this.black.TabStop = true;
            this.black.Text = "Black";
            this.black.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(342, 233);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(110, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // chosenColour
            // 
            this.chosenColour.Location = new System.Drawing.Point(229, 327);
            this.chosenColour.Name = "chosenColour";
            this.chosenColour.Size = new System.Drawing.Size(339, 22);
            this.chosenColour.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chosenColour);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.radioButtonsPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.radioButtonsPanel.ResumeLayout(false);
            this.radioButtonsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel radioButtonsPanel;
        private System.Windows.Forms.RadioButton black;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox chosenColour;
    }
}

