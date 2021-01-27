using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_27_BatuParduotuve.Servisas
{
    public class Pardavimai
    {
       [Key]
        public int PardavimuId { get; set; }
        public string NupirktiBatai { get; set; }
        public int KiekPoru { get; set; }
        public int PiniguIsleista { get; set; }
    }
}
