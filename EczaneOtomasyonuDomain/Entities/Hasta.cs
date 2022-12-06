using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Hasta
    {
        [Key]
        public int HastaId { get; set; }
        public string HastaTc { get; set; }
        public string HastaAd { get; set; }
        public string HastaTamAd { get { return HastaAd + " " + HastaSoyad; } set { } }
        public string HastaSoyad { get; set; }


        public virtual ICollection<siparisHeader> siparisHeaders { get; set; }

        public virtual ICollection<siparisItem> SiparisItems { get; set; }

    }
}
