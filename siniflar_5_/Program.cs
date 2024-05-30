using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taban değeri giriniz");
            int taban = int.Parse(Console.ReadLine());
            Console.WriteLine("Yükseklik değeri giriniz");
            int yukseklik = int.Parse(Console.ReadLine());

            Ucgen ucgen = new Ucgen();
            ucgen.TabanYukseklikBelirle(taban, yukseklik);
            ucgen.Yaz();

            Console.ReadLine();
        }
    }
}
