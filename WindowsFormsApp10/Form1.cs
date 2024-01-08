using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuStrip Anamenu = new MenuStrip();
            this.Controls.Add(Anamenu);
            ToolStripMenuItem Dosya;
            Dosya = new System.Windows.Forms.ToolStripMenuItem();
            Dosya.Text = "Dosya";
            ToolStripMenuItem Duzen;
            Duzen= new System.Windows.Forms.ToolStripMenuItem();
            Duzen.Text = "Düzen";
            Anamenu.Items.Add(Dosya);
            Anamenu.Items.Add(Duzen);
            ToolStripMenuItem Yeni;
            ToolStripMenuItem Kapat;
            Yeni = new System.Windows.Forms.ToolStripMenuItem();
            Kapat = new System.Windows.Forms.ToolStripMenuItem();
            Yeni.Text = "Yeni";
            Kapat.Text = "Kapat";
            Dosya.DropDownItems.Add(Yeni);
            Dosya.DropDownItems.Add(Kapat);

            Kapat.Click += new System.EventHandler(Kapat_Click);
           

        }

        private void Kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
