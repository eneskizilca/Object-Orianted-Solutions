using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelenSayi;
            List<int> sayilar = new List<int>();

            while (true)
            {
                Console.Write("Sayi giriniz: ");
                gelenSayi = Convert.ToInt32(Console.ReadLine());
                if (gelenSayi == 0)
                    break;
                sayilar.Add(gelenSayi);
            }

            sayilar.Sort();
            Console.Write("Sayilar: ");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            } Console.WriteLine("");

            double ortalama = ortalamaHesapla(sayilar);
            double medyan = medyanHesapla(sayilar);
            Console.WriteLine("Sayilarin ortalaması: " + ortalama);
            Console.WriteLine("Sayilarin medyanı: " + medyan);

            Console.Write("Çıkış için enter'a basın...");
            Console.ReadLine();
        }
        static double medyanHesapla(List<int> sayilar)
        {
            if (sayilar.Count % 2 == 0)
                return (sayilar[sayilar.Count / 2 - 1] + sayilar[sayilar.Count / 2]) / 2;
            else
                return sayilar[sayilar.Count / 2];
        }

        static double ortalamaHesapla(List<int> sayilar)
        {
            return sayilar.Average();
        }
    }
}
