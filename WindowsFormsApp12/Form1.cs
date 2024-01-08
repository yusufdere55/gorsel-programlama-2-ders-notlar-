using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kopyala komutunu verdiniz.");
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kes komutunu verdiniz.");
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yapıştır komutunu verdiniz.");
        }
    }
}
