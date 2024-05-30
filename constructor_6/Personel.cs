using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_6
{
    public class Personel
    {
        public DateTime IseGirisTarihi { get; set; }

        public Personel()
        {
             IseGirisTarihi = DateTime.Now;
        }

    }
}
