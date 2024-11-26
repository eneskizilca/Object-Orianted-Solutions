using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_2
{
    //Farklı Şekillerin Alanını Hesaplayan Bir Fonksiyon
    //Bir fonksiyon yazın:
    //-Aynı adla ama farklı parametrelerle farklı şekillerin alanını hesaplasın.
    //-İlk sürüm, bir karenin alanını hesaplasın(bir kenar uzunluğu verilerek).
    //-İkinci sürüm, bir dikdörtgenin alanını hesaplasın(iki kenar uzunluğu verilerek).
    //-Üçüncü sürüm, bir dairenin alanını hesaplasın(yarıçap verilerek).
    class Program
    {
        static void Main(string[] args)
        {
            int kareAlani = AlanHesapla(5);
            double dikdortgenAlani = AlanHesapla(2, 3);
            double daireAlani = AlanHesapla(7.4);
            Console.WriteLine(kareAlani);
            Console.WriteLine(dikdortgenAlani);
            Console.WriteLine(daireAlani);

            Console.Read();
        }
        static int AlanHesapla(int kenarUzunlugu)
        {
            return kenarUzunlugu * kenarUzunlugu;
        }
        static double AlanHesapla(double kisaKenar, double uzunKenar)
        {
            return kisaKenar * uzunKenar;
        }
        static double AlanHesapla(double yaricap)
        {
            return Math.PI * yaricap * yaricap;
        }
    }
}
