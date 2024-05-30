using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KrediHesap hesap = new KrediHesap();
            Console.WriteLine(hesap.Limit);
            Console.WriteLine(hesap.HesapNo);
            Console.WriteLine(hesap.KartSahibi);

            Ayirac();

            hesap.KartSahibi = "Tahsin Canpolat";
            hesap.Limit = 10000.00;
            hesap.HesapNo = 112123121313;

            Console.WriteLine(hesap.Limit);
            Console.WriteLine(hesap.HesapNo);
            Console.WriteLine(hesap.KartSahibi);

            Ayirac();

            KrediHesap hesap1;  // bir nesne oluşturma yapmadık. Yani nesneyi ayağa kaldırmadık

            //Console.WriteLine(hesap1.KartSahibi);  // Hata verir.
            //Console.WriteLine(hesap1.Limit);
            //Console.WriteLine(hesap1.HesapNo);

            hesap1 = hesap; // nesneler aynı sınıfa dahil ise birbirne aktarım yapabilirim.

            Console.WriteLine(hesap1.Limit);
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap1.KartSahibi);
            
            
            Ayirac();

            hesap1.KartSahibi = "Ali Demir";
            hesap1.Limit = 14000.00;
            hesap1.HesapNo = 34353535;

            Console.WriteLine(hesap1.Limit);
            Console.WriteLine(hesap1.HesapNo);
            Console.WriteLine(hesap1.KartSahibi);

            // Hesap bilgileride değişti çünkü classlar bir reference typetır ve ramdaki reference değiştiğinden hesap ında değerleri değişti.

            Console.WriteLine(hesap.Limit);
            Console.WriteLine(hesap.HesapNo);
            Console.WriteLine(hesap.KartSahibi);


            Console.ReadLine();
        }

        static void Ayirac()
        {
            Console.WriteLine("*********************");
        }
    }
}
