using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Image Resim;
            Resim = Image.FromFile("C:\\Users\\user\\Downloads\\kaydet.png");
            Save.Image = Resim;
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seçinizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (seçinizToolStripMenuItem.Text == "Fenerbahçe") 
                this.Text = "Şampiyon Fenerbahçe";
            if (seçinizToolStripMenuItem.Text == "Galatasaray") 
                this.Text = "Şampiyon Galatasaray";
            if (seçinizToolStripMenuItem.Text == "Beşiktaş") 
               this.Text = "Şampiyon Beşiktaş";
            if (seçinizToolStripMenuItem.Text == "Trabzonspor") 
                this.Text = "Şampiyon Trabzonspor";
        }

        private void seçinizToolStripMenuItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiğiniz Takım: " + seçinizToolStripMenuItem.Text);
        }
    }
}
