using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_27_BatųParduotuve.Models
{
     public class Batas
    {
        

        public int BataiId { get; set; }
        public string BatuPavadinimas { get; set; }
        public string Moteriski { get; set; }
        public string Vyriski { get; set; }
        public string Vaikiski { get; set; }
        public int BatuKaina { get; set; }

    }
}
