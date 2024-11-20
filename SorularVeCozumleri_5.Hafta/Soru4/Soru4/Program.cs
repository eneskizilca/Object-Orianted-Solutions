using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru4
{
    //Örnek 5: Müşteri ve Sipariş(Ödev)
    //Bir müşteri birden fazla sipariş verebilir, ancak siparişler müşteriye referans vermez.
    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri oluştur
            Musteri musteri1 = new Musteri("Ahmet Yılmaz", "5555555555");

            // Siparişler oluştur
            Siparis siparis1 = new Siparis(DateTime.Now, "Hazırlanıyor");
            Siparis siparis2 = new Siparis(DateTime.Now.AddDays(1), "Teslim Edildi");

            // Siparişleri müşteriye ekle
            musteri1.SiparisVer(siparis1);
            musteri1.SiparisVer(siparis2);

            Console.WriteLine();

            // Müşterinin siparişlerini göster
            musteri1.SiparisleriGoster();

            Console.Read();
        }
    }

    class Musteri
    {
        public string Ad { get; set; }
        public string Telefon { get; set; }
        public List<Siparis> Siparisler { get; private set; }

        public Musteri(string ad, string telefon)
        {
            Ad = ad;
            Telefon = telefon;
            Siparisler = new List<Siparis>();
        }

        // Sipariş verme metodu
        public void SiparisVer(Siparis siparis)
        {
            Siparisler.Add(siparis);
            Console.WriteLine($"{Ad} isimli müşteri yeni bir sipariş verdi: Tarih - {siparis.Tarih.ToShortDateString()}, Durum - {siparis.Durum}");
        }
        public void SiparisleriGoster()
        {
            Console.WriteLine($"Müşteri: {Ad}, Telefon: {Telefon}");
            Console.WriteLine("Siparişler:");
            foreach (var siparis in Siparisler)
            {
                Console.WriteLine($"- Tarih: {siparis.Tarih.ToShortDateString()}, Durum: {siparis.Durum}");
            }
        }
    }
    class Siparis
    {
        public DateTime Tarih { get; set; }
        public string Durum { get; set; }
        public Siparis(DateTime tarih, string durum)
        {
            Tarih = tarih;
            Durum = durum;
        }
    }

}
