using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHaftaSorular_4
{
    //4. Soru ROBOTLARLA İLGİLİ
    class Program
    {
        //Uzerinde vakit harcadim, yine de yapay zekadan yardım aldım ve anladım
        //bilmediğimiz konular ve yapılar içerdiğinden

        // Hareket yönleri: Yukarı, Aşağı, Sol, Sağ
        static int[] dx = { -1, 1, 0, 0 };
        static int[] dy = { 0, 0, -1, 1 };

        static void Main()
        {
            int[,] grid = {
            { 1, 1, 0, 1 },
            { 0, 1, 0, 0 },
            { 1, 1, 1, 0 },
            { 0, 0, 1, 1 }
        };

            // Başlangıç pozisyonları
            List<Tuple<int, int>> robotlar = new List<Tuple<int, int>> {
            new Tuple<int, int>(0, 0),
            new Tuple<int, int>(2, 2),
            new Tuple<int, int>(3, 3)
        };

            int toplamKurtarilan = RobotlariCalistir(grid, robotlar);
            Console.WriteLine("Toplam kurtarılan düğüm sayısı: " + toplamKurtarilan);
        }

        static int RobotlariCalistir(int[,] grid, List<Tuple<int, int>> robotlar)
        {
            int n = grid.GetLength(0);
            bool[,] ziyaretEdildi = new bool[n, n];
            int toplamKurtarilan = 0;

            foreach (var robot in robotlar)
            {
                toplamKurtarilan += KurtarilabilirDugumler(grid, ziyaretEdildi, robot.Item1, robot.Item2);
            }

            return toplamKurtarilan;
        }

        static int KurtarilabilirDugumler(int[,] grid, bool[,] ziyaretEdildi, int x, int y)
        {
            int n = grid.GetLength(0);

            // Geçersiz veya zaten ziyaret edilmiş bir düğümse geri dön
            if (x < 0 || y < 0 || x >= n || y >= n || grid[x, y] == 0 || ziyaretEdildi[x, y])
            {
                return 0;
            }

            // Düğümü kurtar ve ziyaret edildi olarak işaretle
            ziyaretEdildi[x, y] = true;
            int kurtarilan = 1;

            // Dört yön için (yukarı, aşağı, sol, sağ) hareket et
            for (int i = 0; i < 4; i++)
            {
                int yeniX = x + dx[i];
                int yeniY = y + dy[i];
                kurtarilan += KurtarilabilirDugumler(grid, ziyaretEdildi, yeniX, yeniY);
            }

            return kurtarilan;
        }
    }
}
