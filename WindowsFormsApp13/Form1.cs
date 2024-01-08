using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) {
                pictureBox1.Image = ımageList1.Images[0];
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = ımageList1.Images[1];
            }
            else if(comboBox1.SelectedIndex == 2) {
                pictureBox1.Image = ımageList1.Images[2];
            }
            else if(comboBox1.SelectedIndex == 3) {
                pictureBox1.Image = ımageList1.Images[3];
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.Image = ımageList1.Images[4];
            }
            else if (comboBox1.SelectedIndex == 5) {
                pictureBox1.Image = ımageList1.Images[5];
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                pictureBox1.Image = ımageList1.Images[6];
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if(comboBox2.SelectedIndex == 2)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if(comboBox2.SelectedIndex == 3)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            }
        }
    }
}
