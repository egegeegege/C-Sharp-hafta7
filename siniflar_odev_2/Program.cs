using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev
            // Product adlı bir sınıf olacak. Bu sınıfının özellikleri ProductId, ProductName, Price, Discount, Category
            // olacak. Bir döngüde bu ürün 10 defa oluşturulacak. ve ürünün özellikleri yazılacak. Ve generici Product olan bir List e atılacak.
            // Daha sonra List in içindeki tüm ürünler özellikleri ile beraber ekrana yazılacak.

            int tekrar = 0;

            while (tekrar >= 10)
            {

                Product product = new Product();
                product.ProductId = 1;
                product.ProductName = "EMaB";
                product.Price = 1000;
                product.Discount = 900;
                product.Category = "BAslan";

                List<Product> products = new List<Product>();
                
                products.Add(product);
            
            
            }

            Console.WriteLine();
            Console.ReadLine();

        }


    }
}

