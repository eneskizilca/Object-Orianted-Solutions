using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public List<Kurs> Kurlar { get; private set; }

        public Ogrenci(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
            Kurlar = new List<Kurs>();
        }

        // Öğrenciye kurs ekleme metodu
        public void KursEkle(Kurs kurs)
        {
            if (!Kurlar.Contains(kurs))
            {
                Kurlar.Add(kurs);
                kurs.OgrenciEkle(this); // Kurs sınıfında öğrenciyi de ekle
            }
        }

        // Öğrencinin kayıtlı olduğu kursları yazdırma
        public void KurslariGoster()
        {
            Console.WriteLine($"Öğrenci: {Ad}, Yaş: {Yas}");
            Console.WriteLine("Kayıtlı Olduğu Kurslar:");
            foreach (var kurs in Kurlar)
            {
                Console.WriteLine($"- {kurs.Ad} ({kurs.Kod})");
            }
        }
    }
}
