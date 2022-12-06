using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class IlaclarViewModel
    {
        [DisplayName("İlaç Kayıt No")]
        public int IlacId { get; set; }

        [DisplayName("İlaç Adı")]
        public string IlacAd { get; set; }

        [DisplayName("SGK Karşılama Durumu")]
        public string IlacSgk { get; set; }

        [DisplayName("Kullanım Periyodu")]
        public string IlacPeriyot { get; set; }

        [DisplayName("Stok Adeti")]
        public string IlacStok { get; set; }

        [DisplayName("Fiyat")]
        public string IlacFiyat { get; set; }

    }
}
