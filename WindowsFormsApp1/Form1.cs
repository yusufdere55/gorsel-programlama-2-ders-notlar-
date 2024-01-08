using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int konum;
            richTextBox1.HideSelection = false;
            konum = richTextBox1.Find(textBox1.Text,RichTextBoxFinds.WholeWord);

            if (konum == -1)
                MessageBox.Show("Aranan kelime bulunamadı..");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            int konum = richTextBox1.Find(aranan,richTextBox1.SelectionStart + 1,
                RichTextBoxFinds.WholeWord);
            if (konum < 0)
                MessageBox.Show("Başka bulunamadı");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.HideSelection = false;
            int konum;
            string aranan = textBox1.Text;

            if (richTextBox1.SelectedText == aranan)
                richTextBox1.SelectedText = textBox2.Text;
            konum = richTextBox1.Find(aranan, 0 , RichTextBoxFinds.WholeWord);

            if (konum == -1)
                MessageBox.Show("Aranan kelime bulunamadı..");
        }
    }
}
