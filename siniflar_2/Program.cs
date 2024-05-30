using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance (Miras)
            // Üst sınıfın alt sınıfa özelliklerini aktarması durumu
            Kahve kahve = new Kahve();
            kahve.Sicaklik = 90;
            kahve.SicakMi = false;
            kahve.Isit();
            
            Console.WriteLine("Kahvenin sıcaklığı: {0}",kahve.Sicaklik);

            Cay cay = new Cay();
            cay.Isit();
            Console.WriteLine("Çay sıcaklığı: {0}", cay.Sicaklik);

            Americano americano = new Americano();
            Console.ReadLine();
        }
    }

    public class Icecegim  // Parent sınıf (Soyut sınıf) ama teknik anlamda soyut değildir.
    {
        public int Sicaklik { get; set; }
        public int KaynamaNoktası { get; set; }
        public bool SicakMi { get; set; }

        public void Isit()
        {
            if (SicakMi)
            {
                Sicaklik = Sicaklik;
            }
            else
            {
                Sicaklik = Sicaklik + 10;
            }
        }
    }
    // inheritance (Miras alma)
    // Icecegim sinifi Kahve ve Cay sınıfına özelliklerini ve methodlarını aktarır.
    // Bu durumda Icecegim sınıfı ata (parent) sınıf haline dönüşmüş olur
    // Kahve ve Cay sınıfı ise çocuk (child | alt) sınıf haline dönüşmüş olur.
    public class Kahve : Icecegim  
    {
        public int CekirdekBuyuklugu { get; set; }
    }
    public class Americano : Kahve  // Dolaylı yolla Icecegim sınıfı ve Kahve sınıfının özelliklerini aldı
    {

    }

    public class Cay : Icecegim
    {
        public bool KacakMi { get; set; }
    }

    public class Mesrubat : Icecegim
    {

    }

    // Bir sınıf sadece bir sınıftan miras alabilir !!
    //public class SariKola : Icecegim : Mesrubat  // Hata verir !
    //{

    //}
}
