using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHaftaSorular_1
{
    class Program
    {
        // Spiral matris

        static void Main()
        {
            // kullanicidan matris boyutu al
            Console.Write("Matris boyutunu giriniz (N): ");
            int n = int.Parse(Console.ReadLine());

            // matris olustur
            int[,] matris = new int[n, n];

            // spiral matris doldur
            SpiralMatrisDoldur(matris, n);

            // matris yazdir
            MatrisYazdir(matris, n);
        }

        static void SpiralMatrisDoldur(int[,] matris, int n)
        {
            int sayi = 1; // ilk sayi
            int ust = 0, alt = n - 1, sol = 0, sag = n - 1;

            while (sayi <= n * n)
            {
                // ust satir
                for (int i = sol; i <= sag; i++)
                    matris[ust, i] = sayi++;
                ust++;

                // sag sutun
                for (int i = ust; i <= alt; i++)
                    matris[i, sag] = sayi++;
                sag--;

                // alt satir
                for (int i = sag; i >= sol; i--)
                    matris[alt, i] = sayi++;
                alt--;

                // sol sütun
                for (int i = alt; i >= ust; i--)
                    matris[i, sol] = sayi++;
                sol++;
            }
        }

        static void MatrisYazdir(int[,] matris, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matris[i, j].ToString().PadLeft(4)); // pad dedigimiz yer hizali yazmayi sagliyor
                }
                Console.WriteLine();
            }
        }
    }
}

