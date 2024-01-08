using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = System.Drawing.Bitmap.FromFile("C:\\Users\\user\\Downloads\\IMG_20230820_184957.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(pictureBox1.Image);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IDataObject data1 = Clipboard.GetDataObject();

            if(data1.GetDataPresent(DataFormats.Bitmap))
                pictureBox2.Image = (Bitmap)data1.GetData(DataFormats.Bitmap);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = ımageList1.Images[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(System.Drawing.RotateFlipType.Rotate180FlipY);
            pictureBox2.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save("C:\\Users\\user\\Desktop\\test4.mwf", System.Drawing.Imaging.ImageFormat.Wmf);
        }
    }
}
