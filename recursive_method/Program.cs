using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursive_method
{
    internal class Program
    {
        static int sayac = 0; // Global değişken tanımlama
        static void Main(string[] args)
        {
            // Recursive method => Kendini tekrar eden methodlar.
            // Genelde kendini tekrar eden işler için kullanılır.
            // Kullanırken dikkat etmemiz gereken noktalar vardır.
            // Öncelikle bu methodun kendi içinde olan tekrarı bir şekilde durdurulmalıdır.
            MyForm();

            Console.ReadLine();
        }


        static void MyForm()
        {

            Console.WriteLine(sayac);
            sayac++;
            if (sayac < 10)
            {
                MyForm();
            }
        }
    }
}
