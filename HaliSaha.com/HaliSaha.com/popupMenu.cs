using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HaliSaha.com
{
    public partial class popupMenu : XtraForm
    {

        private Timer timer1;
        private int sayac = 0;

        public popupMenu()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer1 = new Timer();
            timer1.Interval = 150; // Set interval to 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 12)
            {
                this.Close();
            }
        }

        private void lblMesaj_Click(object sender, EventArgs e)
        {

        }
    }
}
