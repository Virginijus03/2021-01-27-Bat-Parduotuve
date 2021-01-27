using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_27_BatuParduotuve.Models
{
    public class BatoDydis
    {
       [Key]
        public int BatudydisId { get; set; }
        public int BatuDydis { get; set; }
        public int BatuKiekis { get; set; }
        
    }
}
