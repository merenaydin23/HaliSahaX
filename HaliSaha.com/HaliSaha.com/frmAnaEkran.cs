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
    public partial class frmAnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public frmAnaEkran()
        {
            InitializeComponent();
        }

        private void PnlUstMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            // Kullanıcıya onay mesajı göster
            DialogResult dialogResult = MessageBox.Show(
                "Ay - Ka Halısaha Otomasyonundan çıkmak istiyor musunuz?",
                "Çıkış Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // Kullanıcı 'Yes' (Evet) seçeneğini tıklarsa uygulamayı kapat
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Uygulamayı kapatır
            }
            // Aksi halde hiçbir işlem yapma
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
