using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace ViewModels
{
    public class HastalarViewModel
    {
        [DisplayName("Hasta Kayıt Numarası")]
        public int HastaId { get; set; }

        [DisplayName("Hasta TC Kimlik Numarası")]
        public string HastaTc { get; set; }

        [DisplayName("Hasta Adı")]
        public string HastaAd { get; set; }

        [DisplayName("Hasta Soyadı")]
        public string HastaSoyad { get; set; }

        //public string HastaTamAd { get { return HastaAd + " " + HastaSoyad; } set { } }

    }
}
