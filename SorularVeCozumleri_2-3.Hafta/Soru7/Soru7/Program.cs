using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 5; // Labirent satır sayısı (örneğin, 5x5 boyutunda)
            int N = 5; // Labirent sütun sayısı

            List<Tuple<int, int>> yol = new List<Tuple<int, int>>();
            bool[,] ziyaretEdildi = new bool[M, N];

            if (LabirentCoz(0, 0, M, N, yol, ziyaretEdildi))
            {
                Console.WriteLine("Yol bulundu:");
                foreach (var adim in yol)
                {
                    Console.Write($"({adim.Item1}, {adim.Item2}) ");
                }
            }
            else
            {
                Console.WriteLine("Şehir kayboldu!");
            }
            Console.ReadLine();
        }

        static bool LabirentCoz(int x, int y, int M, int N, List<Tuple<int, int>> yol, bool[,] ziyaretEdildi)
        {
            // Sınır ve ziyaret kontrolü
            if (x < 0 || x >= M || y < 0 || y >= N || ziyaretEdildi[x, y] || !GecerliMi(x, y))
            {
                return false;
            }

            // Bu noktayı ziyaret edildi olarak işaretleyelim
            ziyaretEdildi[x, y] = true;
            yol.Add(Tuple.Create(x, y));

            // Hedefe ulaşıldı mı kontrolü
            if (x == M - 1 && y == N - 1)
            {
                return true;
            }

            // Dört yön için DFS çağır
            if (LabirentCoz(x + 1, y, M, N, yol, ziyaretEdildi) ||   // sağ
                LabirentCoz(x, y + 1, M, N, yol, ziyaretEdildi) ||   // aşağı
                LabirentCoz(x - 1, y, M, N, yol, ziyaretEdildi) ||   // sol
                LabirentCoz(x, y - 1, M, N, yol, ziyaretEdildi))     // yukarı
            {
                return true;
            }

            // Geri dön ve yol listesinden çıkar
            yol.RemoveAt(yol.Count - 1);
            return false;
        }

        static bool GecerliMi(int x, int y)
        {
            return BasamaklarAsalMi(x) && BasamaklarAsalMi(y) && ToplamCarpimaBolunurMu(x, y);
        }

        static bool BasamaklarAsalMi(int sayi)
        {
            int onlarBasamagi = sayi / 10;
            int birlerBasamagi = sayi % 10;
            return AsalMi(onlarBasamagi) && AsalMi(birlerBasamagi);
        }

        static bool AsalMi(int sayi)
        {
            return sayi == 2 || sayi == 3 || sayi == 5 || sayi == 7;
        }

        static bool ToplamCarpimaBolunurMu(int x, int y)
        {
            int toplam = x + y;
            int carpim = x * y;
            return carpim != 0 && toplam % carpim == 0;
        }
    }   
}
