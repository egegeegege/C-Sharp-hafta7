using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_4
{
    public class Randevu
    {
        public string RandevuDurumu { get; set; } = "Pasif";

        public Randevu()
        {
            RandevuDurumu = "Aktif";
        }

    }
}
