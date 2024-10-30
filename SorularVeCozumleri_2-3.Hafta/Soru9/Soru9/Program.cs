using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru9
{
    class Program
    {
        static int MinEnerjiYolu(int[,] enerjiMatrisi, int N)
        {
            // Min enerji maliyetlerini tutacak olan tabloyu oluştur
            int[,] enerjiTablosu = new int[N, N];

            // Başlangıç hücresinin enerji maliyeti
            enerjiTablosu[0, 0] = enerjiMatrisi[0, 0];

            // İlk satır ve ilk sütunu doldur
            for (int i = 1; i < N; i++)
            {
                enerjiTablosu[0, i] = enerjiTablosu[0, i - 1] + enerjiMatrisi[0, i];
                enerjiTablosu[i, 0] = enerjiTablosu[i - 1, 0] + enerjiMatrisi[i, 0];
            }

            // Diğer hücreleri doldur
            for (int i = 1; i < N; i++)
            {
                for (int j = 1; j < N; j++)
                {
                    // Üç farklı hücreden gelebiliriz: yukarıdan, soldan veya çapraz soldan
                    int yukaridanGel = enerjiTablosu[i - 1, j];
                    int soldanGel = enerjiTablosu[i, j - 1];
                    int caprazdanGel = enerjiTablosu[i - 1, j - 1];

                    // Minimum enerji maliyetini hesapla
                    enerjiTablosu[i, j] = enerjiMatrisi[i, j] + Math.Min(yukaridanGel, Math.Min(soldanGel, caprazdanGel));
                }
            }

            // Hedef hücredeki (N-1, N-1) enerji değeri en az maliyetli yolu gösterir
            return enerjiTablosu[N - 1, N - 1];
        }

        static void Main()
        {
            // Enerji matrisi tanımla
            int[,] enerjiMatrisi = {
            { 4, 7, 8, 6, 4 },
            { 6, 7, 3, 9, 2 },
            { 3, 8, 1, 2, 4 },
            { 7, 1, 7, 3, 7 },
            { 2, 9, 8, 9, 3 }
        };

            int N = enerjiMatrisi.GetLength(0); // Matrisin boyutu (NxN)

            int minEnerji = MinEnerjiYolu(enerjiMatrisi, N);

            Console.WriteLine("En az enerji harcanarak hedefe ulaşma maliyeti: " + minEnerji);
            Console.ReadLine();
        }
    }
}
