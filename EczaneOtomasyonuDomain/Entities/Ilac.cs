using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Ilac
    {
        [Key]
        public int IlacId { get; set; }
        public string IlacAd { get; set; }
        public string IlacSgk { get; set; }
        public string IlacPeriyot { get; set; }
        public string IlacStok { get; set; }
        public string IlacFiyat { get; set; }

        ICollection<siparisItem> siparisItem { get; set; }
    }
}
