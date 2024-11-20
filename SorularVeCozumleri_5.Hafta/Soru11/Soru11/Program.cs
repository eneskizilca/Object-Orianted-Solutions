using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru11
{
    //Örnek 2: Ev ve Oda(Ödev)
    //Bir evde birden fazla oda olabilir, ancak oda sınıfı, ev sınıfının bir parçasıdır fakat evin yokluğu oda
    //için belirleyici değildir.
    class Program
    {
        static void Main(string[] args)
        {
            // Ev oluştur
            Ev ev = new Ev("Deniz Manzaralı Villa");

            // Odalar oluştur
            Oda salon = new Oda("30 m²", "Salon");
            Oda mutfak = new Oda("15 m²", "Mutfak");
            Oda yatakOdasi = new Oda("20 m²", "Yatak Odası");
            Oda banyo = new Oda("10 m²", "Banyo");

            // Odaları eve ekle
            ev.OdaEkle(salon);
            ev.OdaEkle(mutfak);
            ev.OdaEkle(yatakOdasi);
            ev.OdaEkle(banyo);

            // Evin bilgilerini yazdır
            ev.EvBilgisi();

            Console.ReadLine();
        }
    }

    class Oda
    {
        public string Boyut { get; set; }
        public string Tip { get; set; }

        public Oda(string boyut, string tip)
        {
            Boyut = boyut;
            Tip = tip;
        }
        public void OdaBilgisi()
        {
            Console.WriteLine($"Oda Tipi: {Tip}, Boyut: {Boyut}");
        }
    }
    class Ev
    {
        public string Ad { get; set; }
        public List<Oda> Odalar{ get; set; }

        public Ev(string ad)
        {
            Ad = ad;
            Odalar = new List<Oda>();
        }
        public void OdaEkle(Oda oda)
        {
            Odalar.Add(oda);
        }
        public void EvBilgisi()
        {
            Console.WriteLine($"Ev Adı: {Ad}");
            Console.WriteLine("Odalar:");
            foreach (var oda in Odalar)
            {
                oda.OdaBilgisi();
            }
        }
    }
}
