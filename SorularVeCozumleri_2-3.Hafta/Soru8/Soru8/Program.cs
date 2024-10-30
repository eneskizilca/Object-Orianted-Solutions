using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{
    class Program
    {
        // Fibonacci serisini belirli bir uzunluk için hesaplayalım.
        static List<int> Fibonacci(int n)
        {
            List<int> fibonacciListesi = new List<int> { 1, 1 };
            for (int i = 2; i < n; i++)
            {
                int yeniFibonacci = fibonacciListesi[i - 1] + fibonacciListesi[i - 2];
                fibonacciListesi.Add(yeniFibonacci);
            }
            return fibonacciListesi;
        }

        // Bir sayının asal olup olmadığını kontrol etmek için fonksiyon
        static bool AsalMi(int sayi)
        {
            if (sayi <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
                if (sayi % i == 0)
                    return false;
            return true;
        }

        static string SifreCozumleme(string sifreliMesaj)
        {
            List<int> fibonacciListesi = Fibonacci(sifreliMesaj.Length);
            char[] cozulmusMesaj = new char[sifreliMesaj.Length];

            for (int i = 0; i < sifreliMesaj.Length; i++)
            {
                int karakterPozisyonu = i + 1;
                int sifreliAsciiDegeri = (int)sifreliMesaj[i];
                int fibonacciDegeri = fibonacciListesi[i];

                int orjinalAsciiDegeri;

                // Mod çözümlemesine göre işlem yapıyoruz.
                if (AsalMi(karakterPozisyonu))
                {
                    // Pozisyon asal ise mod 100 ile şifrelenmiştir.
                    orjinalAsciiDegeri = sifreliAsciiDegeri;
                    while (orjinalAsciiDegeri < 0 || orjinalAsciiDegeri > 127 || orjinalAsciiDegeri % fibonacciDegeri != 0)
                    {
                        orjinalAsciiDegeri += 100;
                    }
                }
                else
                {
                    // Pozisyon asal değilse mod 256 ile şifrelenmiştir.
                    orjinalAsciiDegeri = sifreliAsciiDegeri;
                    while (orjinalAsciiDegeri < 0 || orjinalAsciiDegeri > 127 || orjinalAsciiDegeri % fibonacciDegeri != 0)
                    {
                        orjinalAsciiDegeri += 256;
                    }
                }

                // Bölme işlemiyle orijinal ASCII değerini buluyoruz
                orjinalAsciiDegeri /= fibonacciDegeri;
                cozulmusMesaj[i] = (char)orjinalAsciiDegeri;
            }

            return new string(cozulmusMesaj);
        }

        static void Main()
        {
            Console.Write("Şifreli mesajı girin: ");
            string sifreliMesaj = Console.ReadLine();
            string cozulmusMesaj = SifreCozumleme(sifreliMesaj);
            Console.WriteLine("Çözülmüş mesaj: " + cozulmusMesaj);
            Console.ReadLine();
        }
    }
}
