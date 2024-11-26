using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_2
{
    // Karmaşık Sayı Hesaplama

    // Bir struct oluşturun :
    // -Karmaşık sayıları temsil etsin (Real ve Imaginary özellikleri).
    // -Toplama ve çıkarma işlemlerini gerçekleştiren iki metot ekleyin.
    // -Sonucu (a + bi) formatında döndüren bir ToString() metodu yazın.
    class Program
    {
        static void Main(string[] args)
        {
            KarmasikSayi sayi1 = new KarmasikSayi(2, -3);
            KarmasikSayi sayi2 = new KarmasikSayi(1, 5);

            Console.WriteLine(sayi1.ToString());
            Console.WriteLine(sayi2.ToString());

            sayi1.Topla(sayi2);
            sayi1.Cikar(sayi2);

            Console.Read();
        }
    }
    struct KarmasikSayi
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public KarmasikSayi(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;

        }
        public void Topla(KarmasikSayi toplanacakSayi)
        {
            int toplamReal = this.Real + toplanacakSayi.Real;
            int toplamImaginary = this.Imaginary + toplanacakSayi.Imaginary;

            Console.Write($"[{this.ToString()}] + [{toplanacakSayi.ToString()}] = ");
            if (toplamImaginary < 0)
                Console.WriteLine($"{toplamReal}{toplamImaginary}i");

            else
                Console.WriteLine($"{toplamReal}+{toplamImaginary}i");
        }
        public void Cikar(KarmasikSayi cikarilacakSayi)
        {
            int toplamReal = this.Real - cikarilacakSayi.Real;
            int toplamImaginary = this.Imaginary - cikarilacakSayi.Imaginary;

            Console.Write($"[{this.ToString()}] - [{cikarilacakSayi.ToString()}] = ");
            if(toplamImaginary < 0)
                Console.WriteLine($"{toplamReal}{toplamImaginary}i");

            else
                Console.WriteLine($"{toplamReal}+{toplamImaginary}i");
        }
        public override string ToString()
        {
            if (Imaginary < 0)
                return $"{Real}{Imaginary}i";
            else
                return $"{Real}+{Imaginary}i";
        }
    }
}
