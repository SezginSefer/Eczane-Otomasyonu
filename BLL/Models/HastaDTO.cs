using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using Domain.Entities;
namespace BLL.Models
{
    public class HastaDTO
    {
        public int HastaId { get; set; }
        public string HastaTc { get; set; }
        public string HastaAd { get; set; }
        public string HastaSoyad { get; set; }

        //public HastaDTO(HastalarViewModel hVM)
        //{
        //    HastaId = hVM.HastaId;
        //    HastaTc =hVM.HastaTc;
        //    HastaAd = hVM.HastaAd;
        //    HastaSoyad = hVM.HastaSoyad;
        //}


    }

}
