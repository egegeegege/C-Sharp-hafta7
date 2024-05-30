using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev
            /* 
             Not adında bir sınıf oluşturulacak. Propertyleri Vize ve Final olacak.
             Methodları VizeFinalBelirle(int v, int f) , OrtalamaAl adlı geriye double döndürecek ve Öğrencinin Vize,Final ve Ortalaması ekrana yazdıracak methodlar olacak.
                 */

            Console.WriteLine("Vize Notunuzu Giririnz");
            int vize = int.Parse(Console.ReadLine());
            Console.WriteLine("Final Notunuzu Giririnz");
            int final = int.Parse(Console.ReadLine());

            Not not = new Not();
            not.Vize = vize;
            not.Final = final;
            not.VizeFinalBelirle(vize,final);
            Console.WriteLine("vize ve final ortalamanız: {0}", not.OrtalamaAl());

            Console.ReadLine();

        }
    }
}
