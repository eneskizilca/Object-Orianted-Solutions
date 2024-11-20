using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    class Kurs
    {
        public string Ad { get; set; }
        public string Kod { get; set; }
        public List<Ogrenci> Ogrenciler { get; private set; }

        public Kurs(string ad, string kod)
        {
            Ad = ad;
            Kod = kod;
            Ogrenciler = new List<Ogrenci>();
        }

        // Kursa öğrenci ekleme metodu
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            if (!Ogrenciler.Contains(ogrenci))
            {
                Ogrenciler.Add(ogrenci);
            }
        }

        // Kursa kayıtlı öğrencileri yazdırma
        public void OgrencileriGoster()
        {
            Console.WriteLine($"Kurs: {Ad} ({Kod})");
            Console.WriteLine("Kayıtlı Öğrenciler:");
            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine($"- {ogrenci.Ad} ({ogrenci.Yas} yaşında)");
            }
        }
    }
}
