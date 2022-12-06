using DAL.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using EczaneOtomasyonuDAL.Interface;
namespace DAL.Repositories
{
    public class IlacRepository : IMainInterface<IlaclarViewModel>
    {
        DatabaseContext db = new DatabaseContext();
        public bool Add(IlaclarViewModel model)
        {
            try
            {
                Ilac obj = new Ilac();
                obj.IlacAd = model.IlacAd;
                obj.IlacSgk = model.IlacSgk;
                obj.IlacPeriyot = model.IlacPeriyot;
                obj.IlacStok = model.IlacStok;
                obj.IlacFiyat = model.IlacFiyat;
                db.Ilaclar.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception hata)
            {
                return false;
            }
        }

        public int AddPlus(IlaclarViewModel model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            try
            {
                Ilac obj = db.Ilaclar.Find(id);
                if (obj == null)
                    return false;
                else
                {
                    db.Ilaclar.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception hata)
            {

                return false;
            }
        }

        public IEnumerable<IlaclarViewModel> GetAll()
        {
            List<IlaclarViewModel> lstModel = new List<IlaclarViewModel>();
            foreach (Ilac obj in db.Ilaclar)
            {
                IlaclarViewModel model = new IlaclarViewModel();
                model.IlacId = obj.IlacId;
                model.IlacAd = obj.IlacAd;
                model.IlacSgk = obj.IlacSgk;
                model.IlacPeriyot = obj.IlacPeriyot;
                model.IlacStok = obj.IlacStok;
                model.IlacFiyat = obj.IlacFiyat;
                lstModel.Add(model);
            }
            return lstModel;
        }

        public IlaclarViewModel GetById(int id)
        {
            Ilac obj = db.Ilaclar.Find(id);
            if (obj == null)
                return null;
            else
            {
                IlaclarViewModel model = new IlaclarViewModel();
                model.IlacId = obj.IlacId;
                model.IlacAd = obj.IlacAd;
                model.IlacSgk = obj.IlacSgk;
                model.IlacPeriyot = obj.IlacPeriyot;
                model.IlacStok = obj.IlacStok;
                model.IlacFiyat = obj.IlacFiyat;
                return model;
            }
        }

        public IEnumerable<IlaclarViewModel> GetFilter(long id)
        {
            throw new NotImplementedException();
        }

        public bool Update(IlaclarViewModel model)
        {
            try
            {
                Ilac obj = db.Ilaclar.Find(model.IlacId);
                if (obj == null)
                    return false;
                else
                {
                    obj.IlacAd = model.IlacAd;
                    obj.IlacSgk = model.IlacSgk;
                    obj.IlacPeriyot = model.IlacPeriyot;
                    obj.IlacStok = model.IlacStok;
                    obj.IlacFiyat = model.IlacFiyat;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception hata)
            {

                return false;
            }
        }
    }

}
