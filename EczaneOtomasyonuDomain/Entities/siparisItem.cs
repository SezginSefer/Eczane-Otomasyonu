using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class siparisItem
    {
        [Key]
        public int SiparisItemId { get; set; }
        public int SiparisHeaderId {get;set;}
        public int HastaId { get; set; }
        public int IlacId { get; set; }
        public int Adet { get; set; }

        public virtual Ilac Ilac { get; set; }

        public virtual Hasta Hasta { get; set; }

        public virtual siparisHeader siparisHeader { get; set; }
    }
}
