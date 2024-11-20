using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    //Örnek 3: Çalışan ve Departman(Ödev)
    //Bir çalışan bir departmana aittir ancak departman çalışana doğrudan referans vermez.
    public class Departman
    {
        public string Ad { get; set; }
        public string Lokasyon { get; set; }

        // Constructor
        public Departman(string ad, string lokasyon)
        {
            Ad = ad;
            Lokasyon = lokasyon;
        }
    }

    public class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Departman Departman { get; private set; } // Çalışan bir departmana ait, ancak dışarıdan atanabilir.

        // Constructor
        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        // Departman Ata Fonksiyonu
        public void DepartmanAta(Departman departman)
        {
            Departman = departman;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Departman oluştur
            Departman yazilimDepartmani = new Departman("Yazılım", "İstanbul");
            Departman insanKaynaklari = new Departman("İnsan Kaynakları", "Ankara");

            // Çalışanlar oluştur
            Calisan calisan1 = new Calisan("Ahmet Yılmaz", "Yazılım Geliştirici");
            Calisan calisan2 = new Calisan("Fatma Kaya", "İK Uzmanı");

            // Çalışanlara departman ataması
            calisan1.DepartmanAta(yazilimDepartmani);
            calisan2.DepartmanAta(insanKaynaklari);

            // Bilgileri yazdır
            Console.WriteLine($"Çalışan: {calisan1.Ad}");
            Console.WriteLine($"Pozisyon: {calisan1.Pozisyon}");
            Console.WriteLine($"Departman: {calisan1.Departman.Ad} ({calisan1.Departman.Lokasyon})");
            Console.WriteLine();

            Console.WriteLine($"Çalışan: {calisan2.Ad}");
            Console.WriteLine($"Pozisyon: {calisan2.Pozisyon}");
            Console.WriteLine($"Departman: {calisan2.Departman.Ad} ({calisan2.Departman.Lokasyon})");
        }
    }

}
