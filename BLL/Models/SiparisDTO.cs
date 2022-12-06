using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class SiparisDTO
    {
        public int siparisHeaderId { get; set; }
        public int HastaId { get; set; }
        public string HastaTc { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }
        public string ToplamTutar { get; set; }
    }
}
