using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int time = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time.ToString();
            if (time == 20)
            {
                this.BackColor = Color.AliceBlue;
            }
            if (time == 40)
            {
                this.BackColor = Color.Aqua;
            }
            if (time == 60)
            {
                this.BackColor = Color.Blue;
            }
            if (time == 80)
            {
                this.BackColor = Color.Beige;
            }
            if (time == 100)
            {
                timer1.Stop();
                time = 0;
                this.BackColor = Color.White;
            }
        }
    }
}
