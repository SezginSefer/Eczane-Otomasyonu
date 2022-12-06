using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using EczaneOtomasyonuDAL.Interface;
using EczaneOtomasyonuDAL.Repositories;
using BLL.Models;
using DAL.Context;
using BLL.Interface;
using BLL.Services;
using System.Data.Entity.Infrastructure;

namespace EczaneOtomasyonuUygulaması
{
    public partial class HastaKayitEkrani : Form
    {
        DatabaseContext db = new DatabaseContext();

        //TODO: Dependency Injection
        IServiceInterface<IlacDTO> servisIlac = new IlacServices();
        IServiceInterface<HastaDTO> servisHasta = new HastaServices();
        IMainInterface<IlaclarViewModel> repoIlac = new IlacRepository();
        IMainInterface<SiparisViewmodel> repoSiparis = new SiparisRepository();
        IMainInterface<SiparisItemViewModel> repoRecete = new SiparisItemRepository();
        IMainInterface<HastalarViewModel> repoHasta = new HastalarRepository();
        public HastaKayitEkrani()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            HastaDTO hdto = new HastaDTO();
            HastalarViewModel model = new HastalarViewModel();
            hdto.HastaTc = txtHastaTc.Text;
            hdto.HastaAd = txtHastaAd.Text;
            hdto.HastaSoyad = txtHastaSoyad.Text;
            try
            {
                servisHasta.Check(hdto);
                db.SaveChanges();
                dataGridView1.DataSource = repoHasta.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

 
        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoHasta.GetAll();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int hastaninid = int.Parse(dataGridView1.CurrentRow.Cells["HastaId"].Value.ToString());
            repoHasta.Delete(hastaninid);
            dataGridView1.DataSource = repoHasta.GetAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = repoHasta.GetAll();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSiparisSil_Click(object sender, EventArgs e)
        {
            int siparisinid = int.Parse(dataGridView1.CurrentRow.Cells["SiparisHeaderId"].Value.ToString());
            repoSiparis.Delete(siparisinid);
            dataGridView1.DataSource = repoSiparis.GetAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            long siparisinid = long.Parse(dataGridView1.CurrentRow.Cells["HastaTc"].Value.ToString());
            if (repoSiparis.GetFilter(siparisinid) == null)
                MessageBox.Show("");
            else
                dataGridView1.DataSource = repoSiparis.GetFilter(siparisinid);
        }
    }

}
