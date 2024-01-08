using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
    
    
namespace WindowsFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ace.OLEDB.12.0;" + "Data Source = C:\\Users\\user\\Documents\\kitap_db.accdb");


        void listele()
        {
            conn.Open();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM kitap", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        string durum = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                durum = "1";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString()=="True")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                durum = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand kaydet = new OleDbCommand("INSERT INTO kitap (kitap_adi, yazar_adi, sayfa, kitap_tur,durum) VALUES (@p1,@p2,@p3,@p4,@p5)", conn);

            kaydet.Parameters.AddWithValue("@p1", textBox2.Text);
            kaydet.Parameters.AddWithValue("@p2", textBox3.Text);
            kaydet.Parameters.AddWithValue("@p3", textBox4.Text);
            kaydet.Parameters.AddWithValue("@p4", comboBox1.Text);
            kaydet.Parameters.AddWithValue("@p5", durum);
            kaydet.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Kayıt Eklendi");
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            OleDbCommand sil = new OleDbCommand("DELETE FROM kitap WHERE kitap_ID = @p1", conn);
            sil.Parameters.AddWithValue("@p1", textBox1.Text);

            sil.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Silindi");
            listele();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            OleDbCommand guncelle = new OleDbCommand("UPDATE kitap SET kitap_adi = @v1, yazar_adi = @v2, sayfa = @v3, kitap_tur = @v4, durum = @v5 WHERE kitap_ID = @p1", conn);

            guncelle.Parameters.AddWithValue("@v1", textBox2.Text);
            guncelle.Parameters.AddWithValue("@v2", textBox3.Text);
            guncelle.Parameters.AddWithValue("@v3", textBox4.Text);
            guncelle.Parameters.AddWithValue("@v4", comboBox1.Text);
            guncelle.Parameters.AddWithValue("@v5", durum);
            guncelle.Parameters.AddWithValue("@p1", textBox1.Text);

            guncelle.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Kayıt Güncellendi");
            listele();
        }
    }
}
