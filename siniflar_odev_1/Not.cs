using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_odev_1
{
    internal class Not
    {
        public int Vize { get; set; }
        public int Final { get; set; }

        public void VizeFinalBelirle(int v, int f)
        {
            // Ödev
            /* 
             Not adında bir sınıf oluşturulacak. Propertyleri Vize ve Final olacak.
             Methodları VizeFinalBelirle(int v, int f) , OrtalamaAl adlı geriye double döndürecek ve Öğrencinin Vize,Final ve Ortalaması ekrana yazdıracak methodlar olacak.
             */

            Final = v;
            Vize = f;

        }
        public double OrtalamaAl()
        {

            double sonuc = (Final + Vize) / 2;

            return sonuc;
        }
       

    }
}
