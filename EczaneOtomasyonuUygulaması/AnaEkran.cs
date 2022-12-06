using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EczaneOtomasyonuUygulaması
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnHastaKayıt_Click(object sender, EventArgs e)
        {
            HastaKayitEkrani frm = new HastaKayitEkrani();
            frm.Show();
        }

        private void HastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IlacKayitEkrani frm = new IlacKayitEkrani();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SatisYapEkrani frm = new SatisYapEkrani();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GecmisSatislarEkrani frm = new GecmisSatislarEkrani();
            frm.Show();
        }
    }
}
