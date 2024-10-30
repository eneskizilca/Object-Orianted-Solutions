using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru10
{
    class Program
    {
        static List<string> SonucDizileri = new List<string>();

        static void KombinasyonlariDeneme(string ifade, List<int> sayilar, List<char> operatörler, int index, int sonuc)
        {
            if (index == sayilar.Count)
            {
                if (sonuc > 0)
                {
                    SonucDizileri.Add(ifade + " = " + sonuc);
                }
                return;
            }

            int sayi = sayilar[index];

            // İlk sayı ekleniyor, operatör olmadan
            if (index == 0)
            {
                KombinasyonlariDeneme(sayi.ToString(), sayilar, operatörler, index + 1, sayi);
            }
            else
            {
                // Toplama işlemi
                KombinasyonlariDeneme(ifade + " + " + sayi, sayilar, operatörler, index + 1, sonuc + sayi);

                // Çıkarma işlemi
                KombinasyonlariDeneme(ifade + " - " + sayi, sayilar, operatörler, index + 1, sonuc - sayi);

                // Çarpma işlemi
                KombinasyonlariDeneme(ifade + " * " + sayi, sayilar, operatörler, index + 1, sonuc * sayi);

                // Bölme işlemi (sıfır bölme hatasından kaçınmak için)
                if (sayi != 0 && sonuc % sayi == 0)
                {
                    KombinasyonlariDeneme(ifade + " / " + sayi, sayilar, operatörler, index + 1, sonuc / sayi);
                }
            }
        }

        static void Main()
        {
            // Sayı dizisi ve operatör listesi
            List<int> sayilar = new List<int> { 3, 4, 5, 2 };
            List<char> operatörler = new List<char> { '+', '-', '*', '/' };

            // Kombinasyonları başlat
            KombinasyonlariDeneme("", sayilar, operatörler, 0, 0);

            // Sonuçları yazdır
            if (SonucDizileri.Count > 0)
            {
                Console.WriteLine("Geçerli kombinasyonlar:");
                foreach (string sonuc in SonucDizileri)
                {
                    Console.WriteLine(sonuc);
                }
            }
            else
            {
                Console.WriteLine("Çözüm bulunamadı.");
            }
            Console.ReadLine();
        }
    }
}
