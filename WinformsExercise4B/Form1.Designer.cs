namespace WinformsExercise4B
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
            this.equal = new System.Windows.Forms.Label();
            this.operation = new System.Windows.Forms.ListBox();
            this.calculate = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // operand1
            // 
            this.operand1.Location = new System.Drawing.Point(350, 94);
            this.operand1.Name = "operand1";
            this.operand1.Size = new System.Drawing.Size(100, 22);
            this.operand1.TabIndex = 0;
            // 
            // operand2
            // 
            this.operand2.Location = new System.Drawing.Point(350, 197);
            this.operand2.Name = "operand2";
            this.operand2.Size = new System.Drawing.Size(100, 22);
            this.operand2.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(350, 311);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 22);
            this.result.TabIndex = 2;
            // 
            // equal
            // 
            this.equal.AutoSize = true;
            this.equal.Location = new System.Drawing.Point(393, 259);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(16, 17);
            this.equal.TabIndex = 3;
            this.equal.Text = "=";
            // 
            // operation
            // 
            this.operation.FormattingEnabled = true;
            this.operation.ItemHeight = 16;
            this.operation.Items.AddRange(new object[] {
            "--Select--",
            "+",
            "-"});
            this.operation.Location = new System.Drawing.Point(350, 147);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(100, 20);
            this.operation.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(317, 367);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(83, 23);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(406, 367);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 6;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.equal);
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
        private System.Windows.Forms.Label equal;
        private System.Windows.Forms.ListBox operation;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button reset;
    }
}

