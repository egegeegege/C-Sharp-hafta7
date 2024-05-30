using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaman zaman = new Zaman();
            zaman.ZamanYaz();

            Zaman zaman1 = new Zaman(10,20,15);
            zaman1.ZamanYaz();

            Console.ReadLine();
        }
    }
}
