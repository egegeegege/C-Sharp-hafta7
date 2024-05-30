using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaman zaman = new Zaman();
            Console.WriteLine("{0}:{1}:{2}", zaman.Saat, zaman.Dakika, zaman.Saniye);

            Console.ReadLine();
        }
    }
}
