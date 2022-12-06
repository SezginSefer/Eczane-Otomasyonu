using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;
using BLL.Models;
using ViewModels;
using DAL.Repositories;
using DAL.Context;
using Domain.Entities;

namespace BLL.Services
{
    public class IlacServices : IServiceInterface<IlacDTO>
    {
        DatabaseContext db = new DatabaseContext();

        public bool Check(IlacDTO idto)
        {
            if ((idto.IlacAd.Length == 0) || (idto.IlacSgk.Length == 0) || (idto.IlacPeriyot.Length == 0 || idto.IlacFiyat.Length == 0))
            {
                Exception ex = new Exception("İlaç bilgileri boş bırakılamaz.");
                throw ex;
            }
            else if (idto.IlacAd.Length < 2)
            {
                Exception ex = new Exception("Girdiğiniz ilaç adını kontrol ediniz.");
                throw ex;
            }
            else if (Convert.ToInt32(idto.IlacFiyat) < 0)
            {
                Exception ex = new Exception("Girdiğiniz fiyat değerini kontrol ediniz.");
                throw ex;
            }
            else if (Convert.ToInt32(idto.IlacStok) < 0)
            {
                Exception ex = new Exception("Girdiğiniz stok değerini kontrol ediniz.");
                throw ex;
            }
            else if (Compare(idto) == true)
            {
                Exception ex = new Exception("Bu ilacın kaydı sistemde mevcut.");
                throw ex;
            }
            else
            {
                IlaclarViewModel model = new IlaclarViewModel();
                IlacRepository repoIlac = new IlacRepository();
                model.IlacAd = idto.IlacAd;
                model.IlacSgk = idto.IlacSgk;
                model.IlacPeriyot = idto.IlacPeriyot;
                model.IlacStok = idto.IlacStok;
                model.IlacFiyat = idto.IlacFiyat;
                repoIlac.Add(model);
                db.SaveChanges();
                return true;
            }

        }

        public bool Compare(IlacDTO idto)
        {
            Ilac model = db.Ilaclar.Where(w => w.IlacAd == idto.IlacAd).FirstOrDefault();
            return model != null;

        }
    }
}
