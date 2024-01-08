using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // + Butonu
            progressBar1.Value += 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Başlat Butonu
            progressBar1.Value = 45;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // - Butonu
            NprogressBar1.Value -= 10;
        }
    }
}
