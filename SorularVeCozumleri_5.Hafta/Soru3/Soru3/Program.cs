 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru3
{
    //Örnek 4: Ürün ve Sipariş (Ödev)
    //Bir sipariş birden fazla ürün içerebilir, ancak ürünlerin siparişe dair bilgisi yoktur.
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun("Dizüstü Bilgisayar", 15000);
            Urun urun2 = new Urun("Akıllı Telefon", 10000);
            Urun urun3 = new Urun("Kulaklık", 1500);

            // Sipariş oluştur
            Siparis siparis = new Siparis(DateTime.Now);

            // Siparişe ürünler ekle
            siparis.UrunEkle(urun1);
            siparis.UrunEkle(urun2);
            siparis.UrunEkle(urun3);

            // Sipariş bilgilerini yazdır
            siparis.SiparisBilgisi();

            Console.Read();
        }
    }

    public class Urun
    {
        private int fiyat; // UML'deki "-Fiyat" tanımı

        public string Ad { get; set; }

        // Public property: fiyatı okuma ve özel olarak ayarlama
        public int Fiyat
        {
            get { return fiyat; } // Fiyatı dışarıdan okumayı sağlar
            private set
            {
                if (value < 0)
                    Console.WriteLine("Fiyat negatif olamaz!");
                fiyat = value; // Yalnızca geçerli değerler atanır
            }
        }

        public Urun(string ad, int fiyat)
        {
            Ad = ad;
            Fiyat = fiyat; // Constructor üzerinden atama
        }

        public void UrunBilgisi()
        {
            Console.WriteLine($"Ürün Adı: {Ad}, Fiyat: {Fiyat} TL");
        }
    }


    class Siparis
    {
        public DateTime Tarih { get; set; }
        public Decimal Toplam { get; set; }
        public List<Urun> Urunler;
        public Siparis(DateTime tarih)
        {
            Tarih = tarih;
            Urunler = new List<Urun>();
            Toplam = 0;
        }

        // Siparişe ürün ekleme metodu
        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
            Toplam += urun.Fiyat; // Ürünün fiyatını toplam tutara ekle
        }

        // Sipariş bilgilerini yazdırma metodu
        public void SiparisBilgisi()
        {
            Console.WriteLine($"Sipariş Tarihi: {Tarih.ToShortDateString()}");
            Console.WriteLine("Sipariş Edilen Ürünler:");
            foreach (var urun in Urunler)
            {
                urun.UrunBilgisi();
            }
            Console.WriteLine($"Toplam Tutar: {Toplam} TL");
        }
    }
}
