using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    //Örnek 2: Doktor ve Hasta(Ödev)
    //Bir doktor birden fazla hastaya sahip olabilir ve her hasta bir doktora bağlıdır.
    class Program
    {
        static void Main(string[] args)
        {
            // Hastalar oluştur
            Hasta hasta1 = new Hasta("Ahmet Yılmaz", "12345678901");
            Hasta hasta2 = new Hasta("Ali Demir", "98765432100");

            // Doktorlar oluştur
            Doktor doktor1 = new Doktor("Dr. Mehmet Kara", "Kardiyoloji");
            Doktor doktor2 = new Doktor("Dr. Ayşe Yıldız", "Nöroloji");

            // Hastaları doktorlara atama
            hasta1.DoktorAtama(doktor1);
            hasta2.DoktorAtama(doktor2);
            hasta1.DoktorAtama(doktor1); // Zaten atanmış kontrolü yapılır

            Console.WriteLine();

            // Doktorların hastalarını göster
            doktor1.HastalariGoster();
            Console.WriteLine();

            doktor2.HastalariGoster();

            Console.Read();
        }
    }
}
