using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace BLL.Models
{
    public class IlacDTO
    {
        public int IlacId { get; set; }
        public string IlacAd { get; set; }
        public string IlacSgk { get; set; }
        public string IlacPeriyot { get; set; }
        public string IlacStok { get; set; }
        public string IlacFiyat { get; set; }

        //IlacDTO (Ilac ilc)
        //{
        //    IlacId = ilc.IlacId;
        //    IlacAd = ilc.IlacAd;
        //    IlacSgk = ilc.IlacSgk;
        //    IlacPeriyot = ilc.IlacPeriyot;
        //    IlacStok = ilc.IlacStok;
        //    IlacFiyat = ilc.IlacFiyat;
        //}
    }

}
