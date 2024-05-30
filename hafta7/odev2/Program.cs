using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Ödev
             * Islem adinda bir method oluşturun
             * 1. method %18 kdv uygulayıp kullanıcıya göstersin
             * 2. method 3 sayının toplamını göstersin
             * 3. method aldığı değere 11 eklesin.
             * 
             */

                Console.WriteLine(Islem(100.0));
                Console.WriteLine(Islem(10,20,30));
                Console.WriteLine(Islem(10));

                Console.ReadLine();
        }

        static int Islem(double fiyat)
        {
            int sonuc = (int) (fiyat * 1.18);
            return sonuc;
        }
        static int Islem(int a, int b, int c)
        {
            return a + b + c;   
        }
        static int Islem(int x)
        {
            return x + 11;
        }
    }
}
