using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksleyiciler_4
{
    // Çok Katmanlı Bir Otopark Sistemi
    // Bir sınıf oluşturun:
    // Her katmanda bir dizi park yerini temsil etsin.
    // Kullanıcı, indeksleyici aracılığıyla belirli bir kat ve park yeri kombinasyonuna
    // erişebilsin.
    // Park yeri boşsa "Empty" döndürsün, doluysa araç plakasını göstersin.
    class Program
    {
        static void Main(string[] args)
        {
            OtoparkSistemi otopark = new OtoparkSistemi();
            otopark[1, 1] = "23 ACF 143";
            otopark[4,4] = "34 TM 825";
            otopark[2,2] = "06 SEK 018";

            Console.WriteLine(otopark[1, 1]);
            Console.WriteLine(otopark[4, 4]);
            Console.WriteLine(otopark[2, 2]);
            Console.WriteLine(otopark[3, 2]);

            Console.Read();
        }
    }
    class OtoparkSistemi
    {
        private string[,] otopark = new string[5, 5];
        public string this[int row, int col]
        {
            get
            {
                if (otopark[row, col] == null)
                    return $"[{row},{col}] konumu: Empty";
                return $"[{row},{col}] konumundaki araç: " + otopark[row, col];
            }          
            set
            {
                otopark[row, col] = value;
                Console.WriteLine($"[{row},{col}] konumuna park eden araç: " + value);
            }
        }
    }
}
