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
    public partial class frmSahaYönlendirmeElrani : DevExpress.XtraEditors.XtraForm
    {
        public frmSahaYönlendirmeElrani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=HaliSahaVT;Integrated Security=True");

        private void Btn_Kapat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmSahaYönlendirmeElrani_Load(object sender, EventArgs e)
        {
            bilgiGetir();
            int sayi = SahaListePaneli.Controls.Count;
            if(sayi == 0)
            {
                popupMenu menu = new popupMenu();
                menu.lblMesaj.BackColor = Color.FromArgb( 213 ,76,98 );
                menu.lblMesaj.Text = "Herhangi Bir Kayda Ulaşım Sağlanmadı !!";
                menu.ShowDialog();
                this.Close();
            }
            else
            {

            }
            MessageBox.Show(sayi.ToString());
        }

        private void SahaListePaneli_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_Click(object sender , EventArgs e)
        {
            Button btn = (Button)sender;
            frmSahaBilgiDüzenlemeEkrani frm = new frmSahaBilgiDüzenlemeEkrani();
            frm.gelenKod = btn.Tag.ToString();
            frm.ShowDialog();
        }

        private void frmSahaYönlendirmeElrani_Activated(object sender, EventArgs e)
        {
            bilgiGetir();
             int sayi = SahaListePaneli.Controls.Count;
            if(sayi == 0)
            {
                this.Close();
            }
        }
        void bilgiGetir()
        {
            SahaListePaneli.Controls.Clear();
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from Tbl_Sahalar order by ad asc ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                Button btn = new Button();
                btn.Text = oku["ad"].ToString();
                btn.Tag = oku["kod"].ToString();
                btn.Width = 249;
                btn.Height = 85;
                btn.BackColor = Color.MediumPurple;
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Cursor = Cursors.Hand;
                btn.Click += btn_Click;

                btn.FlatAppearance.MouseDownBackColor = Color.Red;
                btn.FlatAppearance.MouseOverBackColor = Color.Gray;
                SahaListePaneli.Controls.Add(btn);
            }
            baglanti.Close();
        }

        private void PnlUstMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}