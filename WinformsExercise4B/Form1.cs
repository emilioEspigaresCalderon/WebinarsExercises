using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsExercise4B
{
    public partial class Form1 : Form
    {
        int op1, op2, res;

        private void calculate_Click(object sender, EventArgs e)
        {
            op1 = Convert.ToInt32(operand1.Text);
            op2 = Convert.ToInt32(operand2.Text);

            switch (operation.Text)
            {
                case "-":
                    res = op1 - op2;
                    result.Text = Convert.ToString(res);
                    break;
                case "+":
                    res = op1 + op2;
                    result.Text = Convert.ToString(res);
                    break;
                case "--Select--":
                    MessageBox.Show("Warning! Operation not selected!");
                    break;
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            operand1.Text = "0";
            operand2.Text = "0";
            result.Text = "0";
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
