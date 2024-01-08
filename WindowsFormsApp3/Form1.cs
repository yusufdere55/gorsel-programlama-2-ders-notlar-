using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if(progressBar1.Value % 20 == 10 ) {
                label1.BackColor = Color.White;
            }

            if(progressBar1.Value % 20 == 0)
            {
                label1.ForeColor = Color.Red;
            }
            if(progressBar1.Value == 100)
            {
                label1.BackColor = Color.Transparent;
                label1.ForeColor = Color.Black;
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.White;
            }

            if (progressBar2.Value % 20 == 0)
            {
                label2.ForeColor = Color.Red;
            }
            if (progressBar2.Value == 100)
            {
                label2.BackColor = Color.Transparent;
                label2.ForeColor = Color.Black;
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }

            if (progressBar3.Value % 20 == 0)
            {
                label3.ForeColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                label3.BackColor = Color.Transparent;
                label3.ForeColor = Color.Black;
                timer3.Stop();
                MessageBox.Show("Yemek Hazır");
            }
        }
    }
}
