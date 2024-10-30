using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Program
    {
        // Asal sayı kontrol fonksiyonu
        static bool AsalMi(int sayi)
        {
            if (sayi <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        // Ay basamakları toplamı çift mi?
        static bool AyBasamaklariToplamCiftMi(int ay)
        {
            int toplam = 0;
            while (ay > 0)
            {
                toplam += ay % 10;
                ay /= 10;
            }
            return toplam % 2 == 0;
        }

        // Yıl koşulunu kontrol et
        static bool YilKosulu(int yil)
        {
            int rakamToplami = 0, tempYil = yil;
            while (tempYil > 0)
            {
                rakamToplami += tempYil % 10;
                tempYil /= 10;
            }
            return rakamToplami < yil / 4;
        }

        static List<string> GecerliTarihleriBul(int baslangicYil, int bitisYil)
        {
            List<string> uygunTarihler = new List<string>();
            DateTime bugun = DateTime.Now;

            for (int yil = baslangicYil; yil <= bitisYil; yil++)
            {
                if (!YilKosulu(yil)) continue;

                for (int ay = 1; ay <= 12; ay++)
                {
                    if (!AyBasamaklariToplamCiftMi(ay)) continue;

                    int gunSayisi = DateTime.DaysInMonth(yil, ay);
                    for (int gun = 1; gun <= gunSayisi; gun++)
                    {
                        if (!AsalMi(gun)) continue;

                        DateTime tarih = new DateTime(yil, ay, gun);
                        if (tarih > bugun)
                        {
                            uygunTarihler.Add(tarih.ToString("dd-MM-yyyy"));
                        }
                    }
                }
            }

            return uygunTarihler;
        }

        static void Main()
        {
            int baslangicYil = 2000;
            int bitisYil = 3000;

            List<string> uygunTarihler = GecerliTarihleriBul(baslangicYil, bitisYil);

            Console.WriteLine("Cihazın kabul ettiği tarihler:");
            foreach (string tarih in uygunTarihler)
            {
                Console.WriteLine(tarih);
            }
        }
    }
}
