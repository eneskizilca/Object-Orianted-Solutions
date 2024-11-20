using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru9
{
    //Örnek 5: Ebeveyn ve Çocuk(Ödev)
    //Bir ebeveynin birden fazla çocuğu olabilir ve her çocuk bir ebeveynle ilişkilidir.
    class Program
    {
        static void Main(string[] args)
        {
            // Ebeveyn oluştur
            Ebeveyn ebeveyn1 = new Ebeveyn("Enes", 33);

            // Çocuk oluştur
            Cocuk cocuk1 = new Cocuk("Deniz", 3);
            Cocuk cocuk2 = new Cocuk("Kayra", 1);

            // Çocukları ebeveyne ekle
            ebeveyn1.CocukEkle(cocuk1);
            ebeveyn1.CocukEkle(cocuk2);

            Console.Read();    
        }
    }
}
