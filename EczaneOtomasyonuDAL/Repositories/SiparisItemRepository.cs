using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneOtomasyonuDAL.Interface;
using ViewModels;
using Domain.Entities;
using DAL.Context;

namespace EczaneOtomasyonuDAL.Repositories
{
    public class SiparisItemRepository : IMainInterface<SiparisItemViewModel>
    {
        DatabaseContext db = new DatabaseContext();
        public bool Add(SiparisItemViewModel model)
        {
            try
            {

                siparisItem obj = new siparisItem();
                obj.HastaId = model.HastaId;
                obj.SiparisItemId = model.SiparisItemId;
                obj.SiparisHeaderId = model.SiparisHeaderId;
                obj.IlacId = model.IlacId;
                obj.Adet = model.Adet;
                db.siparisItems.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception hata)
            {
                return false;
            }
        }

        public int AddPlus(SiparisItemViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            try
            {
                siparisItem obj = db.siparisItems.Find(id);
                if (obj == null)
                    return false;
                else
                {
                    db.siparisItems.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception hata)
            {

                return false;
            }
        }
        public IEnumerable<SiparisItemViewModel> GetAll()
        {
            List<SiparisItemViewModel> lstModel = new List<SiparisItemViewModel>();
            foreach (siparisItem obj in db.siparisItems)
            {
                SiparisItemViewModel model = new SiparisItemViewModel();
                new siparisItem();
                model.SiparisItemId = obj.SiparisItemId;
                model.SiparisHeaderId = obj.SiparisHeaderId;
                //model.HastaTc = obj.Hasta.HastaTc;
                model.HastaId = obj.HastaId;
                model.IlacId = obj.IlacId;
                //model.IlacAd = obj.Ilac.IlacAd;
                //model.IlacFiyat = obj.Ilac.IlacFiyat;
                model.Adet = obj.Adet;
                lstModel.Add(model);
            }
            return lstModel;
        }

        public SiparisItemViewModel GetById(int id)
        {

            siparisItem obj = db.siparisItems.Find(id);
            if (obj == null)
            {
                return null;
            }

            else
            {

                SiparisItemViewModel model = new SiparisItemViewModel();
                model.SiparisItemId = obj.SiparisItemId;
                model.SiparisHeaderId = obj.siparisHeader.SiparisHeaderId;
                model.HastaTc = obj.Hasta.HastaTc;
                model.IlacAd = obj.Ilac.IlacAd;
                model.IlacId = obj.Ilac.IlacId;
                model.IlacFiyat = obj.Ilac.IlacFiyat;
                model.Adet = obj.Adet;
                return model;

            }

        }

        public IEnumerable<SiparisItemViewModel> GetFilter(long id)
        {
            List<SiparisItemViewModel> lstModel = new List<SiparisItemViewModel>();
            foreach (siparisItem obj in db.siparisItems)
            {
                if (obj.HastaId == id || obj.SiparisHeaderId== id)
                {
                    SiparisItemViewModel model = new SiparisItemViewModel();
                    model.SiparisHeaderId = obj.SiparisHeaderId;
                    model.SiparisItemId = obj.SiparisItemId;
                    model.HastaId = obj.HastaId;
                    model.HastaTc = obj.Hasta.HastaTc;
                    model.IlacId = obj.Ilac.IlacId;
                    model.IlacAd = obj.Ilac.IlacAd;
                    model.IlacFiyat = obj.Ilac.IlacFiyat;
                    model.Adet = obj.Adet;
                    lstModel.Add(model);
                }

            }
            return (IEnumerable<SiparisItemViewModel>)lstModel;
        }

        public bool Update(SiparisItemViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
