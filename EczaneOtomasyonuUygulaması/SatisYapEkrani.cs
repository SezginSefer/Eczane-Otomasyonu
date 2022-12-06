using DAL.Context;
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
using BLL.Models;
using BLL.Services;
using Domain.Entities;

namespace EczaneOtomasyonuUygulaması
{
    public partial class SatisYapEkrani : Form
    {
        DatabaseContext db = new DatabaseContext();
        IMainInterface<SiparisViewmodel> repoSiparis = new SiparisRepository();
        IMainInterface<IlaclarViewModel> repoIlac = new IlacRepository();
        IMainInterface<SiparisItemViewModel> repoRecete = new SiparisItemRepository();
        IMainInterface<HastalarViewModel> repoHasta = new HastalarRepository();
        int ttutar;
        public SatisYapEkrani()
        {
            InitializeComponent();
        }



        private void SatisYapEkrani_Load(object sender, EventArgs e)
        {
            dataGridViewHasta.DataSource = repoHasta.GetAll();
            dataGridViewIlac.DataSource = repoIlac.GetAll();
            List<IlaclarViewModel> lstModel = new List<IlaclarViewModel>();
            lstModel = (List<IlaclarViewModel>)repoIlac.GetAll();
            //comboBox1.DataSource = lstModel;
            //comboBox1.DisplayMember = "IlacAd";
            //comboBox1.ValueMember = "IlacId";

            


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxFormat(object sender, ListControlConvertEventArgs e)
        {
            string IlacAd = ((IlaclarViewModel)e.ListItem).IlacAd;
            string IlacFiyat = ((IlaclarViewModel)e.ListItem).IlacFiyat;
            string IlacStok = ((IlaclarViewModel)e.ListItem).IlacStok;
            e.Value = IlacAd + " |   Fiyat: " + IlacFiyat + " |   Stok: " + IlacStok;
        }

        private void ComboBoxFormat2(object sender, ListControlConvertEventArgs e)
        {
            string HastaAd = ((HastalarViewModel)e.ListItem).HastaAd;
            string HastaSoyad = ((HastalarViewModel)e.ListItem).HastaSoyad;
            string HastaTc = ((HastalarViewModel)e.ListItem).HastaTc;
            e.Value = HastaTc + " - " + HastaAd + " " + HastaSoyad;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SiparisViewmodel hdrmodel = new SiparisViewmodel();
            SiparisItemViewModel itemmodel = new SiparisItemViewModel();

            hdrmodel.HastaId =Convert.ToInt32(txtHastaId.Text);
            hdrmodel.ToplamTutar =Convert.ToString(Convert.ToInt32(txtIlacAdet.Text) * Convert.ToInt32(txtIlacFiyat.Text));
            int yeniid = repoSiparis.AddPlus(hdrmodel);

            itemmodel.HastaId =Convert.ToInt32(txtHastaId.Text);
            itemmodel.HastaTc = txtHastaTc.Text;
            itemmodel.IlacId =Convert.ToInt32(txtIlacId.Text);
            itemmodel.IlacAd = txtIlacAd.Text;
            itemmodel.IlacFiyat = txtIlacFiyat.Text;
            itemmodel.Adet = Convert.ToInt32(txtIlacAdet.Text);
            itemmodel.SiparisHeaderId = yeniid;
            repoRecete.Add(itemmodel);
            ttutar= Convert.ToInt32(Convert.ToInt32(txtIlacAdet.Text) * Convert.ToInt32(txtIlacFiyat.Text));
            MessageBox.Show("Toplam Tutar " + Convert.ToString(ttutar + " TL"));
            ttutar = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            txtHastaAd.Text = dataGridViewHasta.CurrentRow.Cells["HastaAd"].Value.ToString();
            txtHastaSoyad.Text = dataGridViewHasta.CurrentRow.Cells["HastaSoyad"].Value.ToString();
            txtHastaTc.Text = dataGridViewHasta.CurrentRow.Cells["HastaTc"].Value.ToString();
            txtHastaId.Text = dataGridViewHasta.CurrentRow.Cells["HastaId"].Value.ToString();



        }

        private void btnIlac_Click(object sender, EventArgs e)
        {
            txtIlacAd.Text = dataGridViewIlac.CurrentRow.Cells["IlacAd"].Value.ToString();
            txtIlacFiyat.Text = dataGridViewIlac.CurrentRow.Cells["IlacFiyat"].Value.ToString();
            txtIlacId.Text = dataGridViewIlac.CurrentRow.Cells["IlacId"].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
