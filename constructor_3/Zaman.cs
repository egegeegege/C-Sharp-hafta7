using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_3
{
    public class Zaman
    {
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }

        public Zaman()
        {
            Saat = DateTime.Now.Hour;
            Dakika = DateTime.Now.Minute;
            Saniye = DateTime.Now.Second;
        }

        public Zaman(int h, int m, int s) // constructor overload edildi.
        {
            Saat = h;
            Dakika = m;
            Saniye = s;
        }

        public void ZamanYaz()
        {
            Console.WriteLine("{0}:{1}:{2}", Saat, Dakika, Saniye);
        }
    }
}
