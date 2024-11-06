using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            Kutuphane kutuphane = new Kutuphane();

            Kitap kitap1 = new Kitap("Savaş ve Barış", "Lev Tolstoy", 1869);
            Kitap kitap2 = new Kitap("1984", "George Orwell", 1949);

            kutuphane.KitapEkle(kitap1);
            kutuphane.KitapEkle(kitap2);

            kutuphane.KitaplariListele();
            Console.ReadLine();
        }
    }

    class Kitap
    {
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayinYili { get; set; }

        public Kitap(string baslik, string yazar, int yayinYili)
        {
            Baslik = baslik;
            Yazar = yazar;
            YayinYili = yayinYili;
        }
        public override string ToString()
        {
            return $"{Baslik} - {Yazar} ({YayinYili})";
        }
    }
    class Kutuphane
    {
        public List<Kitap> kitaplar;

        public Kutuphane()
        {
            kitaplar = new List<Kitap>();
        }
        public void KitapEkle(Kitap yeniKitap)
        {
            kitaplar.Add(yeniKitap);
            Console.WriteLine($"{yeniKitap.Baslik} adlı kitap kütüphaneye eklendi.");
        }
        public void KitaplariListele()
        {
            Console.WriteLine("Kütüphanedeki Kitaplar:");
            foreach (Kitap kitap in this.kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }

    }
}
