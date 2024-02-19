using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connStr = new SqlConnection("Data Source=PC;" +
                "                                       Initial Catalog=Malzeme;" +
                "                                       User ID=sa;Password=1234;" +
                "                                       Connect Timeout=30;" +
                "                                       Encrypt=False;" +
                "                                       TrustServerCertificate=False;" +
                "                                       ApplicationIntent=ReadWrite;" +
                "                                       MultiSubnetFailover=False");

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriGetir();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtMkodu.Text = dataGridView1.Rows[index].Cells["MalzemeKodu"].Value.ToString();
                txtMadı.Text = dataGridView1.Rows[index].Cells["MalzemeAdı"].Value.ToString();
                txtYsatıs.Text = dataGridView1.Rows[index].Cells["YıllıkSatıs"].Value.ToString();
                txtBfiyat.Text = dataGridView1.Rows[index].Cells["BirimFiyat"].Value.ToString();
                txtMstok.Text = dataGridView1.Rows[index].Cells["MinStok"].Value.ToString();
                txtTsure.Text = dataGridView1.Rows[index].Cells["TedSure"].Value.ToString();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            veriEkle();
            veriGetir();
        }

        private void veriEkle()
        {
            connStr.Open();

            string sorgu = $"insert into UrunListe values({txtMkodu.Text},'{txtMadı.Text}',{txtYsatıs.Text},{txtBfiyat.Text},{txtMstok.Text},{txtTsure.Text})";
            SqlCommand komut = new SqlCommand(sorgu, connStr);
            SqlDataReader calistir = komut.ExecuteReader();

            while (calistir.Read())
            {
                dataGridView1.Rows.Add(calistir["MalzemeKodu"],
                                        calistir["MalzemeAdı"],
                                        calistir["YıllıkSatıs"],
                                        calistir["BirimFiyat"],
                                        calistir["MinStok"],
                                        calistir["TedSure"]);
            }

            connStr.Close();
        }
        private void veriGetir()
        {
            dataGridView1.Rows.Clear();

            connStr.Open();

            string sorgu = "select ul.MalzemeKodu," +
                "                   ul.MalzemeAdı," +
                "                   ul.YıllıkSatıs," +
                "                   ul.BirimFiyat," +
                "                   ul.MinStok," +
                "                   ul.TedSure " +
                "                   from UrunListe ul";

            SqlCommand komut = new SqlCommand(sorgu, connStr);
            SqlDataReader calistir = komut.ExecuteReader();

            while (calistir.Read())
            {
                dataGridView1.Rows.Add(calistir["MalzemeKodu"],
                                        calistir["MalzemeAdı"],
                                        calistir["YıllıkSatıs"],
                                        calistir["BirimFiyat"],
                                        calistir["MinStok"],
                                        calistir["TedSure"]);
            }
            connStr.Close();
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            var nesneler = groupBox1.Controls.OfType<TextBox>();

            foreach (var nesne in nesneler)
            {
                nesne.Clear();
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            veriGuncelle();
        }
        private void veriGuncelle()
        {
            connStr.Open();

            string sorgu = $"UPDATE UrunListe SET MalzemeAdı='{txtMadı.Text}',YıllıkSatıs='{txtYsatıs.Text}',BirimFiyat='{txtBfiyat.Text}',MinStok='{txtMstok.Text}',TedSure='{txtTsure.Text}' where MalzemeKodu='{txtMkodu.Text}'";
            SqlCommand komut = new SqlCommand(sorgu, connStr);
            SqlDataReader calistir = komut.ExecuteReader();
            connStr.Close();

            veriGetir();

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            veriSil();
        }
        private void veriSil()
        {
            connStr.Open();

            string sorgu = $"delete from UrunListe where MalzemeKodu={txtMkodu.Text}";
            SqlCommand komut = new SqlCommand(sorgu, connStr);
            SqlDataReader calistir = komut.ExecuteReader();
            connStr.Close();

            veriGetir();
        }
        
        private void veriAra()
        {
            connStr.Open();

            string sorgu = $"select * from UrunListe ul with(nolock) where ul.MalzemeAdı like '%{textBox7.Text}%'";
            SqlCommand komut = new SqlCommand(sorgu, connStr);
            SqlDataReader calistir = komut.ExecuteReader();

            while (calistir.Read())
            {
                dataGridView1.Rows.Add(calistir["MalzemeKodu"],
                                        calistir["MalzemeAdı"],
                                        calistir["YıllıkSatıs"],
                                        calistir["BirimFiyat"],
                                        calistir["MinStok"],
                                        calistir["TedSure"]);
            }

            connStr.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            veriAra();
        }
    }
}
