using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{
    class Calisan
    {
        public string Ad { get; set; }
        public Sirket Sirket { get; set; }

        public Calisan(string ad)
        {
            Ad = ad;
        }
        public void SirketAtama(Sirket sirket)
        {
            Sirket = sirket;
        }
    }
}
