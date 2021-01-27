using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_27_BatuParduotuve.Models
{
     public class Batas
    {
        [Key]
        public int BataiId { get; set; }
        public string BatuPavadinimas { get; set; }
        public string Tipas { get; set; }
        public decimal BatuKaina { get; set; }

    }
}
