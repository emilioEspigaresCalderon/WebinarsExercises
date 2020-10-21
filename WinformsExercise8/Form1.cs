using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsExercise8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void classroom1_Click(object sender, EventArgs e)
        {
            students.Items.Clear();
            students.Items.Add("Josep");
            students.Items.Add("Marina");
            students.Items.Add("Aina");
        }

        private void classroom2_Click(object sender, EventArgs e)
        {
            students.Items.Clear();
            students.Items.Add("Joan");
            students.Items.Add("Xesc");
            students.Items.Add("Paula");
        }

        private void clearList_Click(object sender, EventArgs e)
        {
            students.Items.Clear();
        }

        private void StudentSelected(object sender, EventArgs e)
        {
            studentSelected.Text = students.SelectedItem.ToString();
        }
    }
}
