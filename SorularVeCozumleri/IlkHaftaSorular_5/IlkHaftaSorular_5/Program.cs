using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHaftaSorular_5
{
    // en kısa yol bulma labirent
    class Program
    {
        // Hareket yönleri: Yukarı, Aşağı, Sol, Sağ
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };

        static void Main()
        {
            int[,] labirent = {
                { 1, 0, 0, 0 },
                { 1, 1, 0, 1 },
                { 0, 1, 1, 1 },
                { 0, 0, 0, 1 }
            };

            int sonuc = EnKisaYoluBul(labirent);
            if (sonuc == -1)
            {
                Console.WriteLine("Yol Yok");
            }
            else
            {
                Console.WriteLine("En Kısa Yol: " + sonuc + " adım");
            }
            Console.ReadLine();
        }

        static int EnKisaYoluBul(int[,] labirent)
        {
            int n = labirent.GetLength(0);
            bool[,] ziyaretEdildi = new bool[n, n];

            // Kuyruk kullanarak BFS başlatıyoruz (x, y, adım sayısı)
            Queue<Tuple<int, int, int>> kuyruk = new Queue<Tuple<int, int, int>>();
            kuyruk.Enqueue(new Tuple<int, int, int>(0, 0, 0));
            ziyaretEdildi[0, 0] = true;

            while (kuyruk.Count > 0)
            {
                var mevcut = kuyruk.Dequeue();
                int x = mevcut.Item1;
                int y = mevcut.Item2;
                int adim = mevcut.Item3;

                // Hazineye ulaştık mı? (N-1, N-1)
                if (x == n - 1 && y == n - 1)
                {
                    return adim;
                }

                // Dört yön için (yukarı, aşağı, sol, sağ) hareket et
                for (int i = 0; i < 4; i++)
                {
                    int yeniX = x + dx[i];
                    int yeniY = y + dy[i];

                    // Geçerli ve yürünebilir bir hücre mi?
                    if (yeniX >= 0 && yeniY >= 0 && yeniX < n && yeniY < n &&
                        labirent[yeniX, yeniY] == 1 && !ziyaretEdildi[yeniX, yeniY])
                    {
                        kuyruk.Enqueue(new Tuple<int, int, int>(yeniX, yeniY, adim + 1));
                        ziyaretEdildi[yeniX, yeniY] = true;
                    }
                }
            }

            // Hazineye ulaşılamadıysa
            return -1;
        }
    }
}
