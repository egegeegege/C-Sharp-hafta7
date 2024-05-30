using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaman zaman = new Zaman(10,23);
            zaman.ZamanYaz();
            Zaman zaman2 = new Zaman(zaman);  // copy constructor. bir nesneyi başka bir nesneye kopyalamak için kullanılabilir.
            zaman2.ZamanYaz();
            // copy constructor => kopya yapıcı method.

            Console.ReadLine();
        }
    }
}
