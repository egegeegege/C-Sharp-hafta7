using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_6
{
    public class Kedi : Omurgali
    {
        public string Tur { get; set; }
        public string Renk { get; set; }
        public string Cinsiyet { get; set; }

        public void BoyGoster()
        {
            Console.WriteLine("Boy: {0}", Boy);
        }
        public void AgirlikGoster()
        {
            Console.WriteLine("Ağırlık: {0}", Agirlik);
        }

        public void TurGoster()
        {
            Console.WriteLine("Tür: {0}", Tur);
        }

    }
}
