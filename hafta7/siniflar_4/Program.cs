using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dikdörtgenin alanını hesaplayan bir sınıf ve bu sınıfa ait methodu oluşturacağız.

            Dikdortgen dikdortgen = new Dikdortgen();
            int alan = dikdortgen.AlanHesapla(10,20);

            Console.WriteLine("Dikdörtgenin alanı: {0}",alan);

            Console.ReadLine();
        }
    }
}
