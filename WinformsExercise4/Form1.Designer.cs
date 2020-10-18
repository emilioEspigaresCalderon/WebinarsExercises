namespace WebinarsExercise4
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
            this.operand1 = new System.Windows.Forms.TextBox();
            this.operand2 = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.operationLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.equalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // operand1
            // 
            this.operand1.Location = new System.Drawing.Point(350, 56);
            this.operand1.Name = "operand1";
            this.operand1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operand1.Size = new System.Drawing.Size(100, 22);
            this.operand1.TabIndex = 0;
            this.operand1.Text = "0";
            // 
            // operand2
            // 
            this.operand2.Location = new System.Drawing.Point(350, 168);
            this.operand2.Name = "operand2";
            this.operand2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operand2.Size = new System.Drawing.Size(100, 22);
            this.operand2.TabIndex = 1;
            this.operand2.Text = "0";
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(350, 253);
            this.Result.Name = "Result";
            this.Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Result.Size = new System.Drawing.Size(100, 22);
            this.Result.TabIndex = 2;
            this.Result.Text = "0";
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(234, 96);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(87, 23);
            this.sumButton.TabIndex = 3;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sum_Click);
            // 
            // substractButton
            // 
            this.substractButton.Location = new System.Drawing.Point(234, 134);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(87, 23);
            this.substractButton.TabIndex = 4;
            this.substractButton.Text = "Substract";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substract_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(319, 298);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(87, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // operationLabel
            // 
            this.operationLabel.AutoSize = true;
            this.operationLabel.Location = new System.Drawing.Point(390, 115);
            this.operationLabel.Name = "operationLabel";
            this.operationLabel.Size = new System.Drawing.Size(16, 17);
            this.operationLabel.TabIndex = 6;
            this.operationLabel.Text = "?";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(412, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.reset_Click);
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Location = new System.Drawing.Point(390, 217);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(16, 17);
            this.equalLabel.TabIndex = 8;
            this.equalLabel.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.operationLabel);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.operand2);
            this.Controls.Add(this.operand1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox operand1;
        private System.Windows.Forms.TextBox operand2;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label operationLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label equalLabel;
    }
}

