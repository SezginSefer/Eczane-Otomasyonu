using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class siparisHeader
    {
        [Key]
        public int SiparisHeaderId { get; set; }
        public int HastaId { get; set; }
        public string ToplamTutar { get; set; }

        public virtual ICollection<siparisItem> siparisItem { get; set; }

        public virtual Hasta Hasta { get; set; }

        //relationship
    }
}
