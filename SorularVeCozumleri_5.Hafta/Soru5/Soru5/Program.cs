using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru5
{
    //Örnek 1: Öğrenci ve Kurs
    //Bir öğrenci birden fazla kursa kayıt olabilir ve her kurs birden fazla öğrenciye sahip olabilir.
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenciler oluştur
            Ogrenci ogrenci1 = new Ogrenci("Ahmet Yılmaz", 20);
            Ogrenci ogrenci2 = new Ogrenci("Veli Demir", 22);

            // Kurslar oluştur
            Kurs kurs1 = new Kurs("Matematik", "MAT101");
            Kurs kurs2 = new Kurs("Programlama", "CS102");

            // Öğrencileri kurslara ekle
            ogrenci1.KursEkle(kurs1);
            ogrenci1.KursEkle(kurs2);

            ogrenci2.KursEkle(kurs1);

            // Bilgileri yazdır
            ogrenci1.KurslariGoster();
            Console.WriteLine();

            ogrenci2.KurslariGoster();
            Console.WriteLine();

            kurs1.OgrencileriGoster();
            Console.WriteLine();

            kurs2.OgrencileriGoster();

            Console.Read();
        }
    }
}
