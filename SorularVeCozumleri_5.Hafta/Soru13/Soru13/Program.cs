using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru13
{
    //Örnek 4: Kütüphane ve Kitap(Ödev)
    //Bir kütüphane birçok kitaba sahip olabilir, ancak kitaplar kütüphaneden bağımsız olarak var olabilir.
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Kutuphane
    {
        public string Ad { get; set; }
        public List<Kitap> Kitaplar { get; set; }
        public Kutuphane(string ad)
        {
            Ad = ad;
            Kitaplar = new List<Kitap>();
        }
        void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }
    class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public Kitap(string baslik, string yazar)
        {
            Baslik = baslik;
            Yazar = yazar;
        }
    }
}
