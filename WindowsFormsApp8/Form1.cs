using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Items.Add("Dosya");
            menuStrip1.Items.Add("Düzen");
            menuStrip1.Items.Add("Görünüm");
            menuStrip1.Items.Add("Proje");
            menuStrip1.Items.Add("Test");
            menuStrip1.Items.Add("Araçlar");
            menuStrip1.Items.Add("Yardım");
        }
    }
}
