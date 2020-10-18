using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebinarsExercise2
{
    public partial class Form1 : Form
    {
        public int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == true)
            {
                MessageBox.Show("Checkbox Checked");
            }
            else
            {
                MessageBox.Show("Checkbox Unchecked");
            }
        }
    }
}
