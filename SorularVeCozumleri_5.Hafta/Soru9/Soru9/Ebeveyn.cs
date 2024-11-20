using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru9
{
    class Ebeveyn
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Cocuk> Cocuklar { get; set; }

        public Ebeveyn(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
            Cocuklar = new List<Cocuk>();
        }
        public void CocukEkle(Cocuk cocuk)
        {
            if (!Cocuklar.Contains(cocuk))
            {
                Cocuklar.Add(cocuk);
            }
        }
    }
}
