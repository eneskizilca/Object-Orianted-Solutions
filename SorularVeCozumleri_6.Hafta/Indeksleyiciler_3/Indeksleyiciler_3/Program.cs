using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksleyiciler_3
{
    // Bir Satranç Tahtası Durumu
    // Bir sınıf oluşturun:

    // -Satranç tahtasındaki her bir kareyi temsil etsin.
    // -Kullanıcı, indeksleyici aracılığıyla bir kareye taş koyabilsin ya da taşın ne olduğunu
    // öğrenebilsin.
    // -Eğer kullanıcı geçersiz bir kareye erişmeye çalışırsa bir hata mesajı döndürsün.
    class Program
    {
        static void Main(string[] args)
        {
            SatrancTahtasi tahta = new SatrancTahtasi();

        // Taş yerleştirme
        tahta["E2"] = "Piyon";
        tahta["G1"] = "At";

        // Taşları kontrol etme
        Console.WriteLine($"E2 karesi: {tahta["E2"]}");
        Console.WriteLine($"G1 karesi: {tahta["G1"]}");

        // Geçersiz kareye erişim
        try
        {
            Console.WriteLine($"X9 karesi: {tahta["X9"]}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }

        // Tahtayı yazdırma
        tahta.TahtayiYazdir();
        }
    }
    public class SatrancTahtasi
    {
        private string[,] tahtadakiTaslar = new string[8, 8]; // 8x8 satranç tahtası

        public SatrancTahtasi()
        {
            // Tahta başlangıçta boş
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tahtadakiTaslar[i, j] = "Boş";
                }
            }
        }

        // İndeksleyici: Satranç tahtasındaki karelere erişim
        public string this[string kare]
        {
            get
            {
                (int satir, int sutun) = KordinataDonustur(kare);
                return tahtadakiTaslar[satir, sutun];
            }
            set
            {
                (int satir, int sutun) = KordinataDonustur(kare);
                tahtadakiTaslar[satir, sutun] = value;
                Console.WriteLine($"'{kare}' karesine '{value}' yerleştirildi.");
            }
        }

        // Tahta üzerindeki bir kareyi (örn. "A1") satır ve sütun indeksine dönüştürür
        private (int, int) KordinataDonustur(string kare)
        {
            if (kare.Length != 2 || kare[0] < 'A' || kare[0] > 'H' || kare[1] < '1' || kare[1] > '8')
            {
                throw new ArgumentException($"Geçersiz kare: {kare}. Satranç tahtasında 'A1' - 'H8' arasında kareler vardır.");
            }

            int satir = 8 - int.Parse(kare[1].ToString()); // '1' -> 7, '8' -> 0
            int sutun = kare[0] - 'A'; // 'A' -> 0, 'H' -> 7

            return (satir, sutun);
        }

        // Satranç tahtasını yazdırır
        public void TahtayiYazdir()
        {
            Console.WriteLine("Satranç Tahtası:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write($"{tahtadakiTaslar[i, j],10} ");
                }
                Console.WriteLine();
            }
        }
    }
}
