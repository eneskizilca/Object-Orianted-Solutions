using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru10
{
    //Örnek 1: Araba ve Tekerlek
    //Bir araba sınıfı, bir veya daha fazla tekerlek sınıfına sahip olabilir.Ancak tekerlekler, araba yok
    //olduğunda yok olmaz.
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba = new Araba("BMW X5");

            // Tekerlek nesneleri oluştur
            Tekerlek tekerlek1 = new Tekerlek("19 inç", "Kışlık");
            Tekerlek tekerlek2 = new Tekerlek("19 inç", "Kışlık");
            Tekerlek tekerlek3 = new Tekerlek("19 inç", "Kışlık");
            Tekerlek tekerlek4 = new Tekerlek("19 inç", "Kışlık");

            // Tekerlekleri arabaya ekle
            araba.TekerlekEkle(tekerlek1);
            araba.TekerlekEkle(tekerlek2);
            araba.TekerlekEkle(tekerlek3);
            araba.TekerlekEkle(tekerlek4);

            // Araba bilgilerini yazdır
            araba.ArabaBilgisi();

            Console.ReadLine();
        }
    }
}
