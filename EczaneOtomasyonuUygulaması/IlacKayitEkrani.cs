using BLL.Interface;
using BLL.Models;
using BLL.Services;
using DAL.Context;
using DAL.Repositories;
using EczaneOtomasyonuDAL.Interface;
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
    public partial class IlacKayitEkrani : Form
    {
        IServiceInterface<IlacDTO> servisIlac = new IlacServices();
        IMainInterface<IlaclarViewModel> repoIlac = new IlacRepository();

        DatabaseContext db = new DatabaseContext();

        public IlacKayitEkrani()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIlacEkle_Click(object sender, EventArgs e)
        {
            IlacDTO idto = new IlacDTO();
            IlaclarViewModel model = new IlaclarViewModel();
            idto.IlacAd = txtIlacAdi.Text;
            idto.IlacSgk = txtIlacSgk.Text;
            idto.IlacPeriyot = txtIlacPeriyot.Text;
            idto.IlacStok = txtIlacStok.Text;
            idto.IlacFiyat = txtIlacFiyat.Text;
            try
            {
                servisIlac.Check(idto);
                db.SaveChanges();
                dataGridView2.DataSource = repoIlac.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = repoIlac.GetAll();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int ilacinid = int.Parse(dataGridView2.CurrentRow.Cells["IlacId"].Value.ToString());
            repoIlac.Delete(ilacinid);
            dataGridView2.DataSource = repoIlac.GetAll();
        }

        private void IlacKayitEkrani_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = repoIlac.GetAll();
        }
    }
}
