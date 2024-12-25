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
using System.Globalization;


namespace HaliSaha.com
{
    public partial class frmKarsiasmaEkrani : DevExpress.XtraEditors.XtraForm
    {
        public frmKarsiasmaEkrani()
        {
            InitializeComponent();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void bilgiPaneli_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmKarsiasmaEkrani_Load(object sender, EventArgs e)
        {
            DateTime bugün = DateTime.Now;
            button1.Text = bugün.ToShortDateString();
            button2.Text = bugün.AddDays(1).ToShortDateString();
            button3.Text = bugün.AddDays(2).ToShortDateString();
            button4.Text = bugün.AddDays(3).ToShortDateString();
            button5.Text = bugün.AddDays(4).ToShortDateString();
            button6.Text = bugün.AddDays(5).ToShortDateString();
            button7.Text = bugün.AddDays(6).ToShortDateString();







        }

        private void btnİleri_Click(object sender, EventArgs e)
        {
            string sonTarih = button7.Text;
            DateTime olustur = Convert.ToDateTime(sonTarih);

            button1.Text = olustur.AddDays(1).ToShortDateString();
            button2.Text = olustur.AddDays(2).ToShortDateString();
            button3.Text = olustur.AddDays(3).ToShortDateString();
            button4.Text = olustur.AddDays(4).ToShortDateString();
            button5.Text = olustur.AddDays(5).ToShortDateString();
            button6.Text = olustur.AddDays(6).ToShortDateString();
            button7.Text = olustur.AddDays(7).ToShortDateString();
            foreach (Button item in gBTarih.Controls)
            {
                TimeSpan ts = Convert.ToDateTime(item.Text) - DateTime.Today;
                if (ts.Days > 0)
                {
                    //item.Text = ts.Days.ToString();
                    item.BackColor = Color.FromArgb(46,178,123);

                }

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            string ilkTarih = button1.Text;
            DateTime olustur = Convert.ToDateTime(ilkTarih);

            button7.Text = olustur.AddDays(-1).ToShortDateString();
            button6.Text = olustur.AddDays(-2).ToShortDateString();
            button5.Text = olustur.AddDays(-3).ToShortDateString();
            button4.Text = olustur.AddDays(-4).ToShortDateString();
            button3.Text = olustur.AddDays(-5).ToShortDateString();
            button2.Text = olustur.AddDays(-6).ToShortDateString();
            button1.Text = olustur.AddDays(-7).ToShortDateString();
            foreach(Button item in gBTarih.Controls)
            {
                TimeSpan ts = Convert.ToDateTime(item.Text) - DateTime.Today;
                if(ts.Days <0)
                {
                    //item.Text = ts.Days.ToString();
                    item.BackColor = Color.FromArgb(213,76,98);

                }
               
              
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DateTime tarih = Convert.ToDateTime(btn.Text);
            gBTarih.Text = $"{tarih.ToShortDateString()} {tarih.ToString("ddd", new CultureInfo("tr-TR"))}";
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void gbSaat_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void SaatClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            GBSaat.Text = btn.Text;

            // Tüm butonların rengini siyah yap
            foreach (Control control in GBSaat.Controls)
            {
                if (control is Button item)
                {
                    item.BackColor = Color.Black;
                }
            }

            // Sadece tıklanan butonun rengini turuncu yap
            btn.BackColor = Color.OrangeRed;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}