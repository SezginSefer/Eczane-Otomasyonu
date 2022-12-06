using DAL.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using System.Data.SQLite;
using EczaneOtomasyonuDAL.Interface;

namespace DAL.Repositories
{
    public class SiparisRepository : IMainInterface<SiparisViewmodel>
    {
        DatabaseContext db = new DatabaseContext();
        public bool Add(SiparisViewmodel model)
        {


            try
            {
                siparisHeader obj = new siparisHeader();
                obj.HastaId = model.HastaId;
                obj.SiparisHeaderId = model.SiparisHeaderId;
                obj.ToplamTutar = model.ToplamTutar;
                db.siparisHeaders.Add(obj);
                db.SaveChanges();
                int yeniid = obj.SiparisHeaderId;
                return true;
            }
            catch (Exception)
            {
                return false; ;
            }
            
            

        }

        public bool Delete(int id)
        {
            try
            {
                siparisHeader obj = db.siparisHeaders.Find(id);
                if (obj == null)
                    return false;
                else
                {
                    db.siparisHeaders.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public IEnumerable<SiparisViewmodel> GetAll()
        {
            List<SiparisViewmodel> lstModel = new List<SiparisViewmodel>();
            foreach (siparisHeader obj in db.siparisHeaders)
            {
                SiparisViewmodel model = new SiparisViewmodel();
                model.SiparisHeaderId = obj.SiparisHeaderId;
                model.HastaId = obj.HastaId;
                model.HastaTc = obj.Hasta.HastaTc;
                model.HastaAd = obj.Hasta.HastaAd;
                model.HastaSoyad = obj.Hasta.HastaSoyad;
                model.ToplamTutar = obj.ToplamTutar;
                lstModel.Add(model);
            }
            return lstModel;
        }

        public SiparisViewmodel GetById(int id)
        {
            siparisHeader obj = db.siparisHeaders.Find(id);
            if (obj == null)
                return null;
            else
            {
                SiparisViewmodel model = new SiparisViewmodel();
                model.SiparisHeaderId = obj.SiparisHeaderId;
                model.HastaTc = obj.Hasta.HastaTc;
                model.HastaAd = obj.Hasta.HastaAd;
                model.HastaSoyad = obj.Hasta.HastaSoyad;
                model.ToplamTutar = obj.ToplamTutar;
                return model;
            }
        }

        public IEnumerable<SiparisViewmodel> GetFilter(long id)
        {
            List<SiparisViewmodel> lstModel = new List<SiparisViewmodel>();
            foreach (siparisHeader obj in db.siparisHeaders)
            {
                if (obj.Hasta.HastaTc ==Convert.ToString(id))
                {
                    SiparisViewmodel model = new SiparisViewmodel();
                    model.SiparisHeaderId = obj.SiparisHeaderId;
                    //model.HastaId = obj.Hasta.HastaId;
                    model.HastaTc = obj.Hasta.HastaTc;
                    model.HastaAd = obj.Hasta.HastaAd;
                    model.HastaSoyad = obj.Hasta.HastaSoyad;
                    model.ToplamTutar = obj.ToplamTutar;
                    lstModel.Add(model);
                }

            }
            return (IEnumerable<SiparisViewmodel>)lstModel;
        }

        public bool Update(SiparisViewmodel model)
        {
            try
            {
                siparisHeader obj= db.siparisHeaders.Find(model.SiparisHeaderId);
                if (obj == null)
                    return false;
                else
                {
                    //obj.HastaId = model.HastaId;
                    obj.ToplamTutar = model.ToplamTutar;
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception hata)
            {

                return false;
            }
        }


        public int AddPlus(SiparisViewmodel model)
        {
            try
            {
                siparisHeader obj = new siparisHeader();
                obj.HastaId = model.HastaId;
                obj.SiparisHeaderId = model.SiparisHeaderId;
                obj.ToplamTutar = model.ToplamTutar;
                db.siparisHeaders.Add(obj);
                db.SaveChanges();
                int yeniid = obj.SiparisHeaderId;
                return yeniid;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
