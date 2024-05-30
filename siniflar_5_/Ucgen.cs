using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_5_
{
    public class Ucgen
    {
        public int Taban { get; set; }
        public int Yukseklik { get; set; }

        private int Alan()
        {
            int alan = (Taban * Yukseklik) / 2;
            return alan;
        }

        public void TabanYukseklikBelirle(int taban, int yukseklik)
        {
            if (taban == 0 || yukseklik == 0)
            {
                Taban = 0;
                Yukseklik = 0;
            }
            else
            {
                Taban = taban;
                Yukseklik = yukseklik;
            }
        }

        public void Yaz()
        {
            Console.WriteLine("Taban: {0}", Taban);
            Console.WriteLine("Yükseklik: {0}", Yukseklik);
            Console.WriteLine("Alan: {0}", Alan());
        }
    }
}
