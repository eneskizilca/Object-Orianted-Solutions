using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHaftaSorular_2
{

    // Matris çarpımı
    class Program
    {
        static void Main()
        {
            int[,] matris1 = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            int[,] matris2 = {
                { 9, 8, 7 },
                { 6, 5, 4 },
                { 3, 2, 1 }
            };

            //MATRİS ÇARPIMI KONUSU linner cebirde kullandığımız bir konu

            int[,] sonuc = MatrisCarpimi(matris1, matris2);

            Console.WriteLine("Matris Çarpımı Sonucu:");
            YazdirMatris(sonuc);
            Console.ReadLine();
        }

        static int[,] MatrisCarpimi(int[,] matris1, int[,] matris2)
        {
            int satir1 = matris1.GetLength(0);
            int sutun1 = matris1.GetLength(1);
            int satir2 = matris2.GetLength(0);
            int sutun2 = matris2.GetLength(1);

            if (sutun1 != satir2)
            {
                throw new InvalidOperationException("Matrislerin çarpılabilmesi için 1. matrisin sütun sayısı ile 2. matrisin satır sayısı eşit olmalıdır.");
            }

            int[,] sonuc = new int[satir1, sutun2];

            for (int i = 0; i < satir1; i++)
            {
                for (int j = 0; j < sutun2; j++)
                {
                    sonuc[i, j] = 0;
                    for (int k = 0; k < sutun1; k++)
                    {
                        sonuc[i, j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            return sonuc;
        }

        static void YazdirMatris(int[,] matris)
        {
            int satir = matris.GetLength(0);
            int sutun = matris.GetLength(1);

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
