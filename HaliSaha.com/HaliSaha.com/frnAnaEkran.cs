using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaliSaha.com
{
    public partial class frnAnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public frnAnaEkran()
        {
            InitializeComponent();
        }

        private void frnAnaEkran_Load(object sender, EventArgs e)
        {
            // button2 için MouseLeave olayını bağlama
            button2.MouseLeave += button2_MouseLeave;
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan çıkış yapma isteğini onaylamasını isteyin
            DialogResult result = MessageBox.Show("Ay - Ka Halı Saha Otomasyonu sisteminden çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Eğer kullanıcı "Evet" derse uygulamayı kapat
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı kapatır
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.m11;
            button2.ForeColor = Color.MediumPurple;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.m1;
            button2.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSecimEkrani frm = new frmSecimEkrani();
            frm.ShowDialog(); // Sadece tıklama olayında pencere açılır.
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.m2;
            button1.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.m22;
            button1.ForeColor = Color.MediumPurple;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.m3;
            button3.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.m33;
            button3.ForeColor = Color.MediumPurple;
        }
    }
}
