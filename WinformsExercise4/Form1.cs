using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebinarsExercise4
{
    public partial class Form1 : Form
    {
        int op1, op2, res;

        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "+";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "?";
            operand1.Text = "0";
            operand2.Text = "0";
            Result.Text = "0";
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToInt32(operand1.Text);
            op2 = Convert.ToInt32(operand2.Text);

            switch(operationLabel.Text)
            {
                case "-":
                    res = op1 - op2;
                    break;
                case "+":
                    res = op1 + op2;
                    break;
                case "?":
                    MessageBox.Show("Select an operation, please");
                    break;
            }
            
            Result.Text = Convert.ToString(res);
        }

        private void substract_Click(object sender, EventArgs e)
        {
            operationLabel.Text = "-";
        }
    }
}
