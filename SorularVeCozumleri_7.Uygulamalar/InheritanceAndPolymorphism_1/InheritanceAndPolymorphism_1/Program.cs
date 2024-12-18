using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism_1
{
    class Program
    {
        // Bir şirketin çalışanlarını yöneten bir program yazmanız isteniyor. Detaylar PDF'te.
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan türünü seçin: (1 - Yazılımcı, 2 - Muhasebeci)");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Yazilimci yazilimci = new Yazilimci();

                Console.Write("Ad: ");
                yazilimci.Ad = Console.ReadLine();

                Console.Write("Soyad: ");
                yazilimci.Soyad = Console.ReadLine();

                Console.Write("Maaş: ");
                yazilimci.Maas = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Pozisyon: ");
                yazilimci.Pozisyon = Console.ReadLine();

                Console.Write("Yazılım Dili: ");
                yazilimci.YazilimDili = Console.ReadLine();

                yazilimci.BilgiYazdir();
            }
            else if (secim == "2")
            {
                Muhasebeci muhasebeci = new Muhasebeci();

                Console.Write("Ad: ");
                muhasebeci.Ad = Console.ReadLine();

                Console.Write("Soyad: ");
                muhasebeci.Soyad = Console.ReadLine();

                Console.Write("Maaş: ");
                muhasebeci.Maas = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Pozisyon: ");
                muhasebeci.Pozisyon = Console.ReadLine();

                Console.Write("Muhasebe Yazılımı: ");
                muhasebeci.MuhasebeYazilimi = Console.ReadLine();

                muhasebeci.BilgiYazdir();
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }

            Console.Read();
        }
    }
}