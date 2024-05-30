using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_4
{
    public class Dikdortgen
    {
        public int En { get; set; }
        public int Boy { get; set; }
        public int Cevresi { get; set; }

        public int AlanHesapla(int e, int b)
        {
            En = e;
            Boy = b;
            int alan = En * Boy;

            return alan;
        }
    }
}
