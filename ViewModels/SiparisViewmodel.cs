using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class SiparisViewmodel
    {
        [DisplayName("Sipariş Numarası")]
        public int SiparisHeaderId { get; set; }

        [DisplayName("Hasta Kayıt Numarası")]
        public int HastaId { get; set; }

        [DisplayName("Hasta TC Kimlik No")]
        public string HastaTc { get; set; }

        [DisplayName("Hasta Adı")]
        public string HastaAd { get; set; }

        [DisplayName("Hasta Soyadı")]
        public string HastaSoyad { get; set; }

        [DisplayName("Toplam Tutar")]
        public string ToplamTutar { get; set; }

        //public ICollection<SiparisItemViewModel> siparisItemvm { get; set; }

        //[DisplayName("Sipariş Tutarı")]
        //public string ToplamTutar { get {
        //        //linq sum
        //        string result;
        //        //return result;

        //    } }
    }


}
