using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_1
{
    // Zaman İşlemleri

    // Bir struct oluşturun :
    // -Saat ve dakikayı tutacak şekilde tasarlansın (Hour ve Minute özellikleri).
    // -Kullanıcı bir zaman nesnesi oluşturduğunda, eğer girilen saat/dakika geçersizse
    //    otomatik olarak 0 yapılmalı.
    // -Zamanın toplam dakika değerini döndüren bir metot ekleyin.
    // -İki zaman nesnesi arasındaki farkı (dakika olarak) hesaplayan bir metot ekleyin.
    class Program
    {
        static void Main(string[] args)
        {
            Time zaman1 = new Time(14, 45); // Geçerli değer
            Time zaman2 = new Time(25, 70); // Geçersiz değer, saat ve dakika 0 yapılır

            // Zamanları yazdırma
            Console.WriteLine($"Zaman 1: {zaman1}");
            Console.WriteLine($"Zaman 2: {zaman2}");

            // Toplam dakika değerini alma
            Console.WriteLine($"Zaman 1'in toplam dakika değeri: {zaman1.ToplamDakika()}");

            // İki zaman arasındaki fark
            int fark = Time.Fark(zaman1, zaman2);
            Console.WriteLine($"Zaman 1 ile Zaman 2 arasındaki fark: {fark} dakika");

            Console.Read();
        }
    }
    struct Time
    {
        private int hour;
        private int minute;
        public int Hour
        {
            get
            { return hour; }
            set
            {
                if (value <= 23 && value >= 0)
                {
                    hour = value;
                }
                else
                {
                    hour = 0;
                    Console.WriteLine("Geçersiz saat değeri girildi. Otomatik atama: Hour = 0");
                }
            }
        }
        public int Minute
        {
            get
            { return minute; }
            set
            {
                if (value <= 60 && value >= 0)
                {
                    minute = value;
                }
                else
                {
                    minute = 0;
                    Console.WriteLine("Geçersiz dakika değeri girildi. Otomatik atama: Minute = 0");
                }
            }
        }
        public Time(int hour, int minute)
        {
            this.hour = 0; // struct'larda ilk deger gerekir
            this.minute = 0; // struct'larda ilk deger gerekir
            Hour = hour;
            Minute = minute;
        }
        public int ToplamDakika()
        {
            return (Hour * 60) + Minute;
        }
        public static int Fark(Time time1, Time time2)
        {
            return Math.Abs(time1.ToplamDakika() - time2.ToplamDakika());
        }
        public override string ToString()
        {
            return $"{Hour:D2}:{Minute:D2}";
        }
    }
}
