using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsExercise6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            chosenColour.Text = "Chosen colour: ";
            if (green.Checked == true)
            {
                chosenColour.Text = chosenColour.Text + green.Name;
            }

            if (red.Checked == true)
            {
                chosenColour.Text = chosenColour.Text + red.Name;
            }

            if (black.Checked == true)
            {
                chosenColour.Text = chosenColour.Text + black.Name;
            }
        }
    }
}
