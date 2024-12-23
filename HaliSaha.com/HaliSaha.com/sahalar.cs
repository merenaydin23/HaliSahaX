using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaliSaha.com
{
    public partial class lblSahaAdi : UserControl
    {
        public lblSahaAdi()
        {
            InitializeComponent();
        }

        private void sahalar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            foreach (Form item in Application.OpenForms)
            {
                if (item.GetType().Name == "SahaListesi")
                {
                    item.Close();
                    item.BackColor = Color.FromArgb(240,240,240);
                    item.Controls.Clear();
                }
            }
          frmSahaBilgiDüzenlemeEkrani frm = new frmSahaBilgiDüzenlemeEkrani();
          frm.gelenKod = lblSahaNumarasi.Text;
          frm.ShowDialog();
        } 

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
           
        }
    }
}
