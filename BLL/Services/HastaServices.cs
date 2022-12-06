using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Models;
using ViewModels;
using DAL.Repositories;
using Domain.Entities;
using DAL.Context;
using EczaneOtomasyonuDAL.Interface;

namespace BLL.Services
{
    
    public class HastaServices : IServiceInterface<HastaDTO>
    {
        DatabaseContext db = new DatabaseContext();
        public bool Check(HastaDTO hdto)
        {
            if ((hdto.HastaTc.Length ==0) || (hdto.HastaAd.Length == 0) || (hdto.HastaSoyad.Length == 0))
            {
                Exception ex = new Exception("Hasta bilgileri boş bırakılamaz.");
                throw ex;
            }
            else if (hdto.HastaTc.Length != 11)
            {
                Exception ex = new Exception("Hasta TC numarası 11 haneli olmalıdır.");
                throw ex;
             
            }
            else if ((hdto.HastaAd.Length >0 && hdto.HastaAd.Length <= 2) || (hdto.HastaSoyad.Length >0 && hdto.HastaSoyad.Length <2))
            {
                Exception ex = new Exception("Hasta adı ve soyadını kontrol ediniz.");
                throw ex;
                
            }
            else if (Compare(hdto) == true)
            {
                Exception ex = new Exception("Bu TC kimlik numarası ile daha önceden kayıt yapılmış.");
                throw ex;
            }
            else
            {
                HastalarViewModel model = new HastalarViewModel();
                HastalarRepository repoHasta = new HastalarRepository();
                model.HastaTc = hdto.HastaTc;
                model.HastaAd = hdto.HastaAd;
                model.HastaSoyad = hdto.HastaSoyad;
                repoHasta.Add(model);
                db.SaveChanges();
                return true;
            }
              
            
        }

        public bool Compare(HastaDTO hdto)
        {
            Hasta model = db.Hastalar.Where(w => w.HastaTc == hdto.HastaTc).FirstOrDefault();
            return model != null;
        }
    }
}
