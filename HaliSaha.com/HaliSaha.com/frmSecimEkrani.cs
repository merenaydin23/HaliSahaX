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

namespace HaliSaha.com
{
    public partial class frmSecimEkrani : DevExpress.XtraEditors.XtraForm
    {
        public frmSecimEkrani()
        {
            InitializeComponent();
        }

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            txtAciklama frm = new txtAciklama();
            frm.ShowDialog();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            //Önce vir liste erkarnnıan gidmemiz gerekicek nedeni ise oluşturdupumuz saha ıd
            frmSahaYönlendirmeEkrani frm = new frmSahaYönlendirmeEkrani();
            frm.ShowDialog();
        }
    }
}