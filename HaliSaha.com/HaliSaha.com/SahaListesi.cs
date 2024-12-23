using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace HaliSaha.com
{
    public partial class SahaListesi : DevExpress.XtraEditors.XtraForm
    {
        public SahaListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");


        private void SahaListesi_Load(object sender, EventArgs e)
        {

            SahaOluştur();
            int sayı = SahaListePaneli.Controls.Count;
            if(sayı == 0)
            {
                lblMesaj.Text = " 0 Adet Sonuç Bulundu";
                pnlMesaj.BackColor = Color.FromArgb(213,76,98);
            }
            else
            {
                lblMesaj.Text = sayı.ToString()+" Adet Sonuç Bulundu";
                pnlMesaj.BackColor = Color.FromArgb(43,178,123);
               
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void SahaListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
        void SahaOluştur()
        {
            SahaListePaneli.Controls.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar order by ad asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblSahaAdi sablon = new lblSahaAdi();
                sablon.label1.Text = oku["ad"].ToString(); // label1 = sahaadi
                sablon.lblSahaNumarasi.Text = oku["kod"].ToString();
                SahaListePaneli.Controls.Add(sablon);
            }
            baglanti.Close();
        }

        private void pnlMesaj_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // txtSearch 
            SahaListePaneli.Controls.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar WHERE ad LIKE '%"+textBox1.Text+"%'collate Latin1_General_CI_AI order by ad asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblSahaAdi sablon = new lblSahaAdi();
                sablon.label1.Text = oku["ad"].ToString(); // label1 = sahaadi
                sablon.lblSahaNumarasi.Text = oku["kod"].ToString();
                SahaListePaneli.Controls.Add(sablon);
            }
            baglanti.Close();
            int sayı = SahaListePaneli.Controls.Count;
            if (sayı == 0)
            {
                lblMesaj.Text = " 0 Adet Sonuç Bulundu";
                pnlMesaj.BackColor = Color.FromArgb(213, 76, 98);
            }
            else
            {
                lblMesaj.Text = sayı.ToString() + " Adet Sonuç Bulundu";
                pnlMesaj.BackColor = Color.FromArgb(43, 178, 123);

            }
        }

        private void SahaListePaneli_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}