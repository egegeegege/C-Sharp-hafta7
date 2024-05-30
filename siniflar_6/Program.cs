using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.Boy = 40;
            kedi.Agirlik = 8;
            kedi.BoyGoster();
            Console.WriteLine("********************");
            kedi.OzellikGoster();

            Console.ReadLine();
        }
    }
}
