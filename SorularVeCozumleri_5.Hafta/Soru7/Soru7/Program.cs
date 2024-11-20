using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    //Örnek 3: Yazar ve Kitap(Ödev)
    //Bir yazar birden fazla kitap yazabilir ve her kitap bir yazarla ilişkilidir.
    class Program
    {
        static void Main(string[] args)
        {
            Yazar yazar1 = new Yazar("Orhan Pamuk", "Türkiye");
            Yazar yazar2 = new Yazar("J.K. Rowling", "İngiltere");

            // Kitaplar oluştur
            Kitap kitap1 = new Kitap("Kar", new DateTime(2002, 1, 1));
            Kitap kitap2 = new Kitap("Masumiyet Müzesi", new DateTime(2008, 1, 1));
            Kitap kitap3 = new Kitap("Harry Potter ve Felsefe Taşı", new DateTime(1997, 6, 26));

            // Kitapları yazarlara atama
            kitap1.YazarAtama(yazar1);
            kitap2.YazarAtama(yazar1);
            kitap3.YazarAtama(yazar2);

            Console.Read();
        }
    }
}
