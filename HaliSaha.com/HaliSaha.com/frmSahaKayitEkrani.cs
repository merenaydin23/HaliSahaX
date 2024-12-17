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
using System.Data.SqlClient;

namespace HaliSaha.com
{
    public partial class txtAciklama : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");



        public txtAciklama()
        {
            InitializeComponent();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoy_Enter(object sender, EventArgs e)
        {

        }

        private void rBDogal_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "1";
            rBDogal.ForeColor = Color.MediumPurple;
            rBYapay.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBYapay_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "2";
            rBYapay.ForeColor = Color.MediumPurple;
            rBDogal.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBKapali_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "2";
            rBKapali.ForeColor = Color.MediumPurple;
            radioButton1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "1";
            radioButton1.ForeColor = Color.MediumPurple;
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBStandart_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "45";
            lblBoy.Text = "25";
            rBStandart.ForeColor = Color.MediumPurple;
            rBDiger.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = false;
            gBoy.Visible = false;
            txtBoy.Text = " ";
            txtEn.Text = " ";
        }

        private void rBDiger_CheckedChanged(object sender, EventArgs e)
        {
            lblEn.Text = "60";
            lblBoy.Text = "40";
            rBDiger.ForeColor = Color.MediumPurple;
            rBStandart.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = true;
            gBoy.Visible = true;
            txtBoy.Text = " ";
            txtEn.Text = " ";
        }

        private void rBAcik_Load(object sender, EventArgs e)
        {
            sahaKoduOlustur();
        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        void sahaKoduOlustur()
        {
            Random rastgele = new Random();
            string Semboller = "01234567898765432109875621300145201234567890000222545411";
            string olusanKod = "";
            for (int i = 0; i < 5; i++)
            {
                olusanKod += Semboller[rastgele.Next(Semboller.Length)];
            }
            lblSahaKod.Text = olusanKod;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Öncelikle Saha Adı kontrolü
            if (string.IsNullOrWhiteSpace(txtSahaAdi.Text))
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(229, 125, 0);
                menu.lblMesaj.Text = "LÜTFEN SAHA ADINI GİRİNİZ !!";
                menu.Show();
                return; // Metodu sonlandır
            }

            // Eğer 'Diğer' seçili ise EN ve BOY değerlerini kontrol et
            if (rBDiger.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtEn.Text) || string.IsNullOrWhiteSpace(txtBoy.Text))
                {
                    popupMenu menu = new popupMenu();
                    menu.lblMesaj.BackColor = Color.FromArgb(229, 125, 0);
                    menu.lblMesaj.Text = "LÜTFEN SAHAYA AİT EN VE BOY DEĞERLERİNİ GİRİNİZ !!";
                    menu.Show();
                    return; // Metodu sonlandır
                }
            }

            // Tüm kontrollerden geçerse kaydetme işlemi yapılır
            kaydet();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnTamamla_TextChanged(object sender, EventArgs e)
        {

        }
        void kaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Sahalar(kod,ad,cim,tur,boyut,en,boy,aciklama) values(@kod,@ad,@cim,@tur,@boyut,@en,@boy,@aciklama)", baglanti);
            komut.Parameters.AddWithValue("@kod",lblSahaKod.Text);
            komut.Parameters.AddWithValue("@ad",txtSahaAdi.Text.ToUpper());
            komut.Parameters.AddWithValue("@cim",lblCimTuru.Text);
            komut.Parameters.AddWithValue("@tur",lblSahaTuru.Text);
            if (rBStandart.Checked)
            {
              komut.Parameters.AddWithValue("@boyut","1");
              komut.Parameters.AddWithValue("@en","25");
            komut.Parameters.AddWithValue("@boy","45");
            }
            else
            {
                komut.Parameters.AddWithValue("@boyut", "2");
                komut.Parameters.AddWithValue("@en", txtEn.Text);
                komut.Parameters.AddWithValue("@boy", txtBoy.Text);
            }
            
           
            komut.Parameters.AddWithValue("@aciklama",textBox1.Text.ToUpper());
            komut.ExecuteNonQuery();
            baglanti.Close();
            sahaKoduOlustur();
            temizlemeMetodu();
            popupMenu menu = new popupMenu();
            menu.lblMesaj.BackColor = Color.FromArgb(43, 178, 123);
            menu.lblMesaj.Text = "SAHA KAYIT İŞLEMİ BAŞARILI !!! ";
            menu.Show();


        }
        void temizlemeMetodu()
        {
            txtSahaAdi.Text = "";
            textBox1.Text="";
            txtEn.Text = "";
            txtBoy.Text = "";
            gBEn.Visible = false;
            gBoy.Visible = false;
            radioButton1.Checked = true; //RbAçik
            rBDogal.Checked = true;
            rBStandart.Checked = true;
            txtSahaAdi.Focus();

        }


    }
}
