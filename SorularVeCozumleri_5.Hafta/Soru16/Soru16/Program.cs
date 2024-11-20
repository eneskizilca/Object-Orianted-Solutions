using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru16
{
    //Örnek 4: Okul ve Öğrenci(Ödev)
    //Bir okulda birçok öğrenci olabilir, ancak okul kapandığında öğrenciler de kapanır çünkü okul,
    //öğrencilerin hayatlarını sürdürebileceği bir yerdir.
    class Ogrenci
    {
        public string Ad { get; set; }
        public int Yas { get; set; }

        public Ogrenci(string ad, int yas)
        {
            Ad = ad;
            Yas = yas;
        }

        public void OgrenciBilgisi()
        {
            Console.WriteLine($"Öğrenci Adı: {Ad}, Yaşı: {Yas}");
        }
    }

    class Okul
    {
        public string Ad { get; set; }
        private List<Ogrenci> Ogrenciler { get; set; }

        public Okul(string ad)
        {
            Ad = ad;
            Ogrenciler = new List<Ogrenci>();
        }

        public void OgrenciOlustur(string ogrenciAdi, int ogrenciYasi)
        {
            Ogrenci yeniOgrenci = new Ogrenci(ogrenciAdi, ogrenciYasi);
            Ogrenciler.Add(yeniOgrenci);
            Console.WriteLine($"{ogrenciAdi} isimli öğrenci okula eklendi.");
        }

        public void OgrenciListesi()
        {
            Console.WriteLine($"\nOkul Adı: {Ad}");
            Console.WriteLine("Öğrenci Listesi:");
            foreach (var ogrenci in Ogrenciler)
            {
                ogrenci.OgrenciBilgisi();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Okulun adını girin: ");
            string okulAdi = Console.ReadLine();

            Okul okul = new Okul(okulAdi);

            Console.WriteLine("\nÖğrenci ekleme işlemi:");
            while (true)
            {
                Console.Write("Öğrenci adını girin (çıkmak için 'q' yazın): ");
                string ad = Console.ReadLine();
                if (ad.ToLower() == "q")
                    break;

                Console.Write("Öğrencinin yaşını girin: ");
                int yas = int.Parse(Console.ReadLine());

                okul.OgrenciOlustur(ad, yas);
            }

            Console.WriteLine("\nOkul ve öğrenciler listesi:");
            okul.OgrenciListesi();

            Console.WriteLine("\nProgram sona erdi.");

            Console.Read();
        }
    }
}
