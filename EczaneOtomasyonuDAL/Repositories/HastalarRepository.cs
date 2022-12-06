using DAL.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Domain;
using System.Data.Entity;
using EczaneOtomasyonuDAL.Interface;


namespace DAL.Repositories
{
    
    public class HastalarRepository : IMainInterface <HastalarViewModel> 
        
    {
        DatabaseContext db = new DatabaseContext();
        public bool Add(HastalarViewModel model)
        {
            try
            {
                Hasta obj = new Hasta();
                obj.HastaTc = model.HastaTc;
                obj.HastaAd = model.HastaAd;
                obj.HastaSoyad = model.HastaSoyad;
                db.Hastalar.Add(obj);
                db.SaveChanges();
                return true;
            }
            catch (Exception hata)
            {
                return false;
            }
        }

        public bool Update(HastalarViewModel model)
        {
            try
            {
                Hasta obj = db.Hastalar.Find(model.HastaId);
                if (obj == null)
                    return false;
                else
                {
                    obj.HastaTc = model.HastaTc;
                    obj.HastaAd = model.HastaAd;
                    obj.HastaSoyad = model.HastaSoyad;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception hata)
            {

                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                Hasta obj = db.Hastalar.Find(id);
                if (obj == null)
                    return false;
                else
                {
                    db.Hastalar.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception hata)
            {

                return false;   
            }
        }

        public IEnumerable<HastalarViewModel> GetAll()
        {
            List<HastalarViewModel> lstModel = new List<HastalarViewModel>();
            foreach(Hasta obj in db.Hastalar)
            {
                HastalarViewModel model = new HastalarViewModel();
                model.HastaId = obj.HastaId;
                model.HastaTc = obj.HastaTc;
                model.HastaAd = obj.HastaAd;
                model.HastaSoyad = obj.HastaSoyad;
                lstModel.Add(model);
            }
            return lstModel;

        }

        public HastalarViewModel GetById(int id)
        {
            Hasta obj = db.Hastalar.Find(id);
            if (obj == null)
                return null;
            else
            {
                HastalarViewModel model = new HastalarViewModel();
                model.HastaId = obj.HastaId;
                model.HastaTc = obj.HastaTc;
                model.HastaAd = obj.HastaAd;
                model.HastaSoyad = obj.HastaSoyad;
                return model;
            }
        }

        public IEnumerable<HastalarViewModel> GetFilter(long id)
        {
            throw new NotImplementedException();

        }

        public int AddPlus(HastalarViewModel model)
        {
            throw new NotImplementedException();
        }
    }

}
