using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    // Örnek 2: Yazar ve Kitap (Ödev)
    // Bir yazar, birden fazla kitaba sahip olabilir ancak kitap, yazara referans vermez.
    class Program
    {
        static void Main(string[] args)
        {
            Yazar yazar = new Yazar("Atatürk", "Türkiye");
            
            Kitap kitap1 = new Kitap("Nutuk", "9789750814306");
            Kitap kitap2 = new Kitap("Geometri", "9789750809586");

            yazar.KitapEkle(kitap1);
            yazar.KitapEkle(kitap2);
            
            Console.WriteLine($"Yazar: {yazar.Ad} ({yazar.Ulke})");
            Console.WriteLine("Kitapları:");
            foreach (var kitap in yazar.Kitaplar)
            {
                Console.WriteLine($"- {kitap.Baslik} (ISBN: {kitap.ISBN})");
            }
            Console.Read();
        }
    }

    public class Kitap
    {
        public string Baslik { get; set; }
        public string ISBN { get; set; }

        // Constructor
        public Kitap(string baslik, string isbn)
        {
            Baslik = baslik;
            ISBN = isbn;
        }
    }

    public class Yazar
    {
        public string Ad { get; set; }
        public string Ulke { get; set; }
        public List<Kitap> Kitaplar { get; set; }

        // Constructor
        public Yazar(string ad, string ulke)
        {
            Ad = ad;
            Ulke = ulke;
            Kitaplar = new List<Kitap>();
        }

        public void KitapEkle(Kitap kitap)
        {
            Kitaplar.Add(kitap);
        }
    }

}
