using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Randevu randevu = new Randevu();
            Console.WriteLine(randevu.RandevuDurumu);

            Console.ReadLine();
        }
    }
}
