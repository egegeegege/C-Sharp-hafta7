using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_2
{
    public class Zaman
    {
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }

        // ctor
        public Zaman()  // constructor => inşaa edici method Zaman sınıfının instance alındığında ilk bu method çalışır ve Sınıf ismiyle Constructor ismi aynı olmak zorundadır !!
        {
            Saat = DateTime.Now.Hour;
            Dakika = DateTime.Now.Minute;
            Saniye = DateTime.Now.Second;
        }
    }
}
