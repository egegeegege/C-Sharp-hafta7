using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siniflar_6
{
    public class Omurgali
    {
        public double Boy { get; set; }
        public double Agirlik { get; set; }

        public void OzellikGoster()
        {
            Console.WriteLine("Boy: {0}", Boy);
            Console.WriteLine("Ağırlık: {0}", Agirlik);
        }
    }
}
