using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru9
{
    class Cocuk
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Ebeveyn Ebeveyn { get; set; }

        public Cocuk(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }
        public void EbeveynAtaması(Ebeveyn ebeveyn)
        {
            Ebeveyn = ebeveyn;
        }
    }
}
