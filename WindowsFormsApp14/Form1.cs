using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = System.Drawing.Bitmap.FromFile("C:\\Users\\user\\Downloads\\IMG_20231110_153617.jpg");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult sonuc;
            openFileDialog1.Filter = "Resim dosyaları |*.JPG; *.BMP; *.PNG; *.GIF";
            sonuc = openFileDialog1.ShowDialog();

            if(Convert.ToString(sonuc) == "OK")
            {
                string dosya = openFileDialog1.FileName;
                pictureBox1.Image = System.Drawing.Bitmap.FromFile(dosya);
            }
        }
    }
}
