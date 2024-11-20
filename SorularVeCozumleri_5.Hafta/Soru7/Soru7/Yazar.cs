using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
            Kitaplar = new List<Kitap>();
        }
        public void KitapEkle(Kitap kitap)
        {
            if (!Kitaplar.Contains(kitap))
            {
                Kitaplar.Add(kitap);
            }
        }
    }
}
