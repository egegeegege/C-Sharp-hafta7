using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_5
{
    public class Zaman
    {
        public int Saat { get; set; }
        public int Dakika { get; set; }
        public int Saniye { get; set; }

        public Zaman(int h, int m)
        {
            Saat = h;
            Dakika = m;
        }

        public Zaman(int h, int m, int s)
        {
            Saat = h;
            Dakika = m;
            Saniye = s;
        }

        public Zaman(Zaman z)
        {
            Saat = z.Saat;
            Dakika = z.Dakika;
            Saniye = z.Saniye;
        }

        public void ZamanYaz()
        {
            Console.WriteLine("{0}:{1}:{2}", Saat, Dakika, Saniye);
        }
    }
}
