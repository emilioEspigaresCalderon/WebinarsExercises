using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsExercise5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            animalsChosen.Text = "Animals chosen: ";
            if(mouse.Checked == true)
            {
                animalsChosen.Text = animalsChosen.Text + mouse.Name + " ";
            }

            if (dog.Checked == true)
            {
                animalsChosen.Text = animalsChosen.Text + dog.Name + " ";
            }

            if (cat.Checked == true)
            {
                animalsChosen.Text = animalsChosen.Text + cat.Name;
            }
        }
    }
}
