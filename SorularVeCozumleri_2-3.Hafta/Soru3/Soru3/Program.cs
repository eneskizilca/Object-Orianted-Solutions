using System;
using System.Collections.Generic;

namespace Soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelenSayi;
            int alinacakSayiSayisi;
            List<int> sayilar = new List<int>();

            Console.Write("Kac adet sayi girmek istersiniz?: ");
            alinacakSayiSayisi = Convert.ToInt32(Console.ReadLine());

            while (alinacakSayiSayisi > 0)
            {
                Console.Write("Pozitif sayi giriniz: ");
                gelenSayi = Convert.ToInt32(Console.ReadLine());
                if (gelenSayi == 0)
                    break;
                if (gelenSayi > 0)
                {
                    sayilar.Add(gelenSayi);
                    alinacakSayiSayisi--;
                }
            }

            sayilar.Sort();

            int baslangicDeger = sayilar[0];
            int bitisDeger = sayilar[0];

            for (int i = 1; i < sayilar.Count; i++)
            {
                // eğer sayı ardışık değilse, mevcut grubu bitirip yeni bir gruba başla
                if (sayilar[i] != bitisDeger + 1)
                {
                    Console.WriteLine(baslangicDeger == bitisDeger ? $"{baslangicDeger}" : $"{baslangicDeger}-{bitisDeger}");
                    baslangicDeger = sayilar[i];
                }
                bitisDeger = sayilar[i];
            }

            // son grubu yazdır
            Console.WriteLine(baslangicDeger == bitisDeger ? $"{baslangicDeger}" : $"{baslangicDeger}-{bitisDeger}");
            Console.ReadLine();
        }
    }
}
