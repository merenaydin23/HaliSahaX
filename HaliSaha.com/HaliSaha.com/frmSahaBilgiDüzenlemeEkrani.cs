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
    public partial class frmSahaBilgiDüzenlemeEkrani : DevExpress.XtraEditors.XtraForm
    {
        public frmSahaBilgiDüzenlemeEkrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");

        public string gelenKod = "";
        private void rBDogal_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "1";
            rBDogal.ForeColor = Color.FromArgb(229,125,0);
            rBYapay.ForeColor = Color.FromArgb(64, 64, 64);

        }

        private void rBYapay_CheckedChanged(object sender, EventArgs e)
        {
            lblCimTuru.Text = "2";
            rBYapay.ForeColor = Color.FromArgb(229, 125, 0);
            rBDogal.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "1";
            radioButton1.ForeColor = Color.FromArgb(229, 125, 0);
            rBKapali.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBKapali_CheckedChanged(object sender, EventArgs e)
        {
            lblSahaTuru.Text = "2";
            rBKapali.ForeColor = Color.FromArgb(229, 125, 0);
            radioButton1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void rBDiger_CheckedChanged(object sender, EventArgs e)
        {
            // DEĞİŞTİRECEĞİZ
            
            rBDiger.ForeColor = Color.FromArgb(229, 125, 0);
            rBStandart.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = true;
            gBoy.Visible = true;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void rBStandart_CheckedChanged(object sender, EventArgs e)
        {
            rBStandart.ForeColor = Color.FromArgb(229, 125, 0);
            rBDiger.ForeColor = Color.FromArgb(64, 64, 64);
            gBEn.Visible = false;
            gBoy.Visible = false;
            txtBoy.Text = "";
            txtEn.Text = "";
        }

        private void txtEn_TextChanged(object sender, EventArgs e)
        {

        }

        private void gBEn_Enter(object sender, EventArgs e)
        {

        }

        private void gBoy_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rBDiger.Checked)
            {
                // Eğer en ve boy alanları boşsa uyarı ver
                if (string.IsNullOrWhiteSpace(txtEn.Text) || string.IsNullOrWhiteSpace(txtBoy.Text))
                {
                    popupMenu menu = new popupMenu();
                    menu.lblMesaj.BackColor = Color.FromArgb(64, 64, 64);
                    menu.lblMesaj.Text = "LÜTFEN SAHAYA AİT EN VE BOY DEĞERLERİNİ GİRİNİZ ";
                    menu.Show();
                    return; // Eksik bilgi varsa metodu sonlandır
                }
            }

            // Tüm kontroller başarılıysa güncelleme işlemi başlatılır
            if (güncelle()) // güncelle metodu "true" dönerse başarılıdır
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(43, 178, 123);
                menu.lblMesaj.Text = "SAHA KAYIT İŞLEMİ BAŞARILI BİR ŞEKİLDE GÜNCELLENMİŞTİR!!! ";
                menu.Show();
            }
            else
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(229, 0, 0);
                menu.lblMesaj.Text = "GÜNCELLEME SIRASINDA BİR HATA OLUŞTU!";
                menu.Show();
            }
        }

        private void frmSahaBilgiDüzenlemeEkrani_Load(object sender, EventArgs e)
        {
            bilgiGetir();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private bool güncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Tbl_Sahalar SET ad = @ad,cim = @cim,tur = @tur,boyut = @boyut,en = @en,boy = @boy,aciklama = @aciklama where kod = @kod", baglanti);

                komut.Parameters.AddWithValue("@kod", gelenKod);
                komut.Parameters.AddWithValue("@ad", txtSahaAdi.Text.ToUpper());
                komut.Parameters.AddWithValue("@cim", lblCimTuru.Text);
                komut.Parameters.AddWithValue("@tur", lblSahaTuru.Text);

                if (rBStandart.Checked)
                {
                    komut.Parameters.AddWithValue("@boyut", "1");
                    komut.Parameters.AddWithValue("@en", "25");
                    komut.Parameters.AddWithValue("@boy", "45");
                }
                else
                {
                    komut.Parameters.AddWithValue("@boyut", "2");
                    komut.Parameters.AddWithValue("@en", txtEn.Text);
                    komut.Parameters.AddWithValue("@boy", txtBoy.Text);
                }

                komut.Parameters.AddWithValue("@aciklama", txtAciklama.Text.ToUpper());

                komut.ExecuteNonQuery();
                baglanti.Close();
                bilgiGetir();
                return true; // Güncelleme başarılı
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message); // Hata mesajını göster
                return false; // Güncelleme başarısız
            }
            finally
            {
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
            }
        }
        void bilgiGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar where kod = @kod", baglanti);
            komut.Parameters.AddWithValue("@kod ", gelenKod);  //*****
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                txtSahaAdi.Text = oku["ad"].ToString();
                txtAciklama.Text = oku["aciklama"].ToString();
                if (oku["cim"].ToString()=="1")
                {
                    rBDogal.Checked = true; 
                }
                else
                {
                    rBYapay.Checked = true; 
                }
                if (oku["tur"].ToString() == "1")
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    rBKapali.Checked = true;
                }
                if (oku["boyut"].ToString() == "1")
                {
                    rBStandart.Checked = true;
                }
                else
                {
                    rBDiger.Checked = true;
                    txtEn.Text = oku["en"].ToString();
                    txtBoy.Text = oku["boy"].ToString();
                }


            }
            else
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb(213 ,76 ,98 );
                menu.lblMesaj.Text = "SAHA KAYDINA ULAŞIM SAĞLANAMADI !! ";
                menu.ShowDialog();
                this.Close();
            }
            baglanti.Close();
        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.FromArgb(229,125,0);
            button2.ForeColor = Color.White;

            Btn_Kapat.BackColor = Color.FromArgb(64, 64, 64);

            Btn_Kapat.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(229, 125, 0);
            button2.BackColor = Color.FromArgb(64, 64, 64);
            Btn_Kapat.BackColor = Color.FromArgb(64, 64, 64);

            Btn_Kapat.ForeColor = Color.White;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // kayot silme işlemi yapılacak ,
            this.Hide();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Sahalar where kod =@kod ", baglanti);
            komut.Parameters.AddWithValue("@kod", gelenKod);
            komut.ExecuteNonQuery();
            baglanti.Close();
            popupMenu menu = new popupMenu();
            menu.lblMesaj.BackColor = Color.FromArgb(43,178,123);
            menu.lblMesaj.Text = "SAHA KAYIT BİLGİLERİ BAŞARILI BİR ŞEKİLDE SİLİNMİŞTİR !! ";
            menu.ShowDialog();
            this.Close();
        }
    }
}