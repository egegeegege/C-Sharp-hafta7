using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Ödev
             Kullanıcıdan alınacak 2 ürün fiyatından pahalı olana %30 indirim uygulayacak method yazılacak.
             ve kullanıcı 3. ürünü almak isterse 3. ürüne %50 indirim uygulayacak method yazılacak.
             2 ürün yada 3 ürün için kullanıcının ne kadar fiyat ödemesi gerektiği gösterilecek.     
             2 adet method kullanılacak. ilki 2 ürün için ikincisi 3 ürün için çalışacak.
             */

            Console.WriteLine("1. ürünün fiyatını giriniz");
            int fiyat1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. ürünün fiyatını giriniz");
            int fiyat2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3. ürünü almak istermisiniz ? (evet:1/hayır:2)");
            string cevap = Console.ReadLine();
            if(cevap == "1")
            {
                Console.WriteLine("3. ürünün fiyatını giriniz");
                int fiyat3 = int.Parse(Console.ReadLine());
                IndirimElli(fiyat1, fiyat2, fiyat3);
            }
            else if(cevap == "2") {

                IndirimOtuz(fiyat1,fiyat2);
            
            }
            else
            {
                Console.WriteLine("Lütfen geçerli cevap giriniz");
            }

            Console.ReadLine();
        }

       static void IndirimElli(int fiyat1, int fiyat2, int fiyat3)
        {
           double sonFiyat = (fiyat3 * 0.5) + fiyat1 + fiyat2;
           Console.WriteLine("3 ürün için toplam fiyat: {0}", sonFiyat);
        }

        static void IndirimOtuz(int fiyat1, int fiyat2)
        {
            double sonFiyat = 0;

            if (fiyat1 >= fiyat2)
            {
                sonFiyat = fiyat1 * 0.7 + fiyat2;
            }
            else
            {
                sonFiyat = fiyat2 * 0.7 + fiyat1;
            }

            Console.WriteLine("2 ürün için ödeyeceğiniz fiyat: {0}",sonFiyat);
        }
    }
}
