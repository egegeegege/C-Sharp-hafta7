using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sınıf (Class)
            // C# içerisinde tanımlanmış ve her biri bir durumu veya yapıyı ifadede eden bloklardır. Bazı durumlarda c# içerisinde tanımlanmış sınıflar yeterli olmayabilir. Bu durumlarda bizim kendi sınıflarımızı yazmamız gerekir.
              // Sınıf tanımlama yapacağımız proje yada işe göre değişkenlik gösterebilir.
              // Sınıflar içersinde o sınıf özelinde özellikler ve methodlar tanımlanır.
            Icecek icecek = new Icecek();
            icecek.Sicaklik = 90;
            icecek.Isit();

            Console.WriteLine(icecek.Sicaklik);

            FastFood food = new FastFood();
            food.AsitliMi = true;

            

            Console.ReadLine();

              
        }
    }

    public class Icecek // Sınıf tanımı
    {
        // Ozellikleri (Property)
        public int Sicaklik { get; set; } = 100; // get => çağırma , set => değiştirme
        public int KaynamaNoktasi { get; set; } // kısayol prop / tab tab
        public bool SicakMi { get; set; } = false;

        // Method
        public void Isit()
        {
            if (SicakMi == false)
            {
                Sicaklik += 10;
            }
            else
            {
                Sicaklik = Sicaklik;
            }
        }
        
    }

    public class FastFood
    {
        public bool AsitliMi { get; set;}
    }
}
