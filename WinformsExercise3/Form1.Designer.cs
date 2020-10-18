namespace WebinarsExercise3
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
            this.result = new System.Windows.Forms.TextBox();
            this.labelOperand1 = new System.Windows.Forms.Label();
            this.labelOperand2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.sumButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operand1
            // 
            this.operand1.Location = new System.Drawing.Point(350, 101);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(100, 22);
            this.operand1.TabIndex = 0;
            // 
            // operand2
            // 
            this.operand2.Location = new System.Drawing.Point(350, 151);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(100, 22);
            this.operand2.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(350, 276);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 2;
            // 
            // labelOperand1
            // 
            this.labelOperand1.AutoSize = true;
            this.labelOperand1.Location = new System.Drawing.Point(245, 101);
            this.labelOperand1.Name = "labelOperand1";
            this.labelOperand1.Size = new System.Drawing.Size(76, 17);
            this.labelOperand1.TabIndex = 3;
            this.labelOperand1.Text = "Operand1:";
            // 
            // labelOperand2
            // 
            this.labelOperand2.AutoSize = true;
            this.labelOperand2.Location = new System.Drawing.Point(245, 151);
            this.labelOperand2.Name = "labelOperand2";
            this.labelOperand2.Size = new System.Drawing.Size(76, 17);
            this.labelOperand2.TabIndex = 4;
            this.labelOperand2.Text = "Operand2:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(275, 276);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(52, 17);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result:";
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(246, 211);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 6;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sum_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(508, 210);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelOperand2);
            this.Controls.Add(this.labelOperand1);
            this.Controls.Add(this.result);
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
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label labelOperand1;
        private System.Windows.Forms.Label labelOperand2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button resetButton;
    }
}

