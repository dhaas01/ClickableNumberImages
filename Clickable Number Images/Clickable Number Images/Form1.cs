using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clickable_Number_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberOnePictureBox_Click(object sender, EventArgs e)
        {
            numberBox.Text = "One";
        }

        private void NumberTwoPictureBox_Click(object sender, EventArgs e)
        {
            numberBox.Text = "Two";
        }

        private void NumberThreePictureBox_Click(object sender, EventArgs e)
        {
            numberBox.Text = "Three";
        }

        private void NumberFourPictureBox_Click(object sender, EventArgs e)
        {
            numberBox.Text = "Four";
        }

        private void NumberFivePictureBox_Click(object sender, EventArgs e)
        {
            numberBox.Text = "Five";
        }
    }
}
