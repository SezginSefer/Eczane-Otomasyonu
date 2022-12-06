using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace ViewModels
{
    public class SiparisItemViewModel
    {
        [DisplayName("Kayıt Numarası")]
        public int SiparisItemId { get; set; }

        [DisplayName("Reçete Numarası")]
        public int SiparisHeaderId { get; set; }

        [DisplayName("İlaç Kayıt Numarası")]
        public int IlacId { get; set; }

        [DisplayName("Hasta Kayıt Numarası")]
        public int HastaId { get; set; }

        [DisplayName("Hasta TC Kimlik Numarası")]
        public string HastaTc { get; set; }

        [DisplayName("İlaç adı")]
        public string IlacAd { get; set; }

        [DisplayName("İlacın Fiyatı")]
        public string IlacFiyat { get; set; }

        [DisplayName("Satın Alım Adeti")]
        public int Adet { get; set; }


        //public virtual SiparisViewmodel SiparisViewmodel { get; set; }
    }
}


