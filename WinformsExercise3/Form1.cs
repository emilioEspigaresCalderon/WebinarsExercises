using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebinarsExercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            int op1, op2, res;
            op1 = Convert.ToInt32(operand1.Text);
            op2 = Convert.ToInt32(operand2.Text);
            res = op1 + op2;
            result.Text = Convert.ToString(res);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            operand1.Text = "";
            operand2.Text = "";
            result.Text = "";
        }
    }
}
