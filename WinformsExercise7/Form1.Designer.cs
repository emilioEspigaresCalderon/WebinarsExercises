namespace WinformsExercise7
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
            this.colours = new System.Windows.Forms.ComboBox();
            this.selectedColour = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // colours
            // 
            this.colours.FormattingEnabled = true;
            this.colours.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Yellow",
            "White"});
            this.colours.Location = new System.Drawing.Point(323, 110);
            this.colours.Name = "colours";
            this.colours.Size = new System.Drawing.Size(121, 24);
            this.colours.TabIndex = 0;
            this.colours.SelectedIndexChanged += new System.EventHandler(this.colourSelected_colours);
            // 
            // selectedColour
            // 
            this.selectedColour.Location = new System.Drawing.Point(255, 263);
            this.selectedColour.Name = "selectedColour";
            this.selectedColour.Size = new System.Drawing.Size(258, 22);
            this.selectedColour.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectedColour);
            this.Controls.Add(this.colours);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox colours;
        private System.Windows.Forms.TextBox selectedColour;
    }
}

