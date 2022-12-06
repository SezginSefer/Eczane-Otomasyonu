using DAL.Repositories;
using EczaneOtomasyonuDAL.Interface;
using EczaneOtomasyonuDAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;

namespace EczaneOtomasyonuUygulaması
{
    public partial class GecmisSatislarEkrani : Form
    {
        IMainInterface<SiparisItemViewModel> repoRecete = new SiparisItemRepository();
        IMainInterface<HastalarViewModel> repoHasta = new HastalarRepository();
        IMainInterface<SiparisViewmodel> repoSiparis = new SiparisRepository();

        public GecmisSatislarEkrani()
        {
            InitializeComponent();
        }

        private void btnGecmisSatisGoster_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = repoSiparis.GetAll();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            long siparisinid = long.Parse(dataGridView4.CurrentRow.Cells["SiparisHeaderId"].Value.ToString());
            if (repoRecete.GetFilter(siparisinid) == null)
                MessageBox.Show("Bu siparişe bağlı bir reçete yok.");
            else 
                dataGridView4.DataSource = repoRecete.GetFilter(siparisinid);


        }

        private void btnGecmisRecete_Click(object sender, EventArgs e)
        {
            long siparisinid =Convert.ToInt64(comboBox1.SelectedValue);
            if (repoRecete.GetFilter(siparisinid) == null)
                MessageBox.Show("Seçili hasta adına kayıtlı reçete yok.");
            else
                dataGridView4.DataSource = repoRecete.GetFilter(siparisinid);
        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            int siparisid = int.Parse(dataGridView4.CurrentRow.Cells["SiparisHeaderId"].Value.ToString());
            int receteid = int.Parse(dataGridView4.CurrentRow.Cells["SiparisItemId"].Value.ToString());

            repoSiparis.Delete(siparisid);
            repoRecete.Delete(receteid);
            dataGridView4.DataSource = repoSiparis.GetAll();
        }

        private void cmbHastaRecete(object sender, ListControlConvertEventArgs e)
        {
            string HastaAd = ((HastalarViewModel)e.ListItem).HastaAd;
            string HastaSoyad = ((HastalarViewModel)e.ListItem).HastaSoyad;
            string HastaTc = ((HastalarViewModel)e.ListItem).HastaTc;
            e.Value = HastaTc + " - " + HastaAd + " " + HastaSoyad;
        }

        private void GecmisSatislarEkrani_Load(object sender, EventArgs e)
        {
            List<HastalarViewModel> lstModel2 = new List<HastalarViewModel>();
            lstModel2 = (List<HastalarViewModel>)repoHasta.GetAll();
            comboBox1.DataSource = lstModel2;
            comboBox1.DisplayMember = "HastaTc";
            comboBox1.ValueMember = "HastaId";
        }
    }
}
