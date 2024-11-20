using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{
    class Sirket
    {
        public string Ad { get; set; }
        public string Konum { get; set; }
        public List<Calisan> Calisanlar { get; set; }

        public Sirket(string ad, string konum)
        {
            Ad = ad;
            Konum = konum;
            Calisanlar = new List<Calisan>();
        }
        public void CalisanEkle(Calisan calisan)
        {
            if (!Calisanlar.Contains(calisan))
            {
                Calisanlar.Add(calisan);
            }
        }
    }
}
