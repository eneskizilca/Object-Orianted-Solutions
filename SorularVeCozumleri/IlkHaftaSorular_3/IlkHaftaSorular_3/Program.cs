using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHaftaSorular_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir sayı giriniz: ");
            int girilenSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplam: " + NSayisinaKadarAsalToplamHesapla(girilenSayi));

            Console.ReadLine();
        }
        
        static int NSayisinaKadarAsalToplamHesapla(int girilenSayi)
        {
            int toplam = 0;
           
            //burada döngüye girmeden yanlış cevapların ve istisna cevapların kontrolü yapılıyor
            if (girilenSayi < 0)
            {
                Console.WriteLine("Negatif değer girmeyiniz!");
                return 0;

            }
            if (girilenSayi < 2)
            {
                return 0;
            }
            
            //burada 2 ve daha büyük değerlerin kontrolü yapılıyor ve toplama ekleniyor uygun asallar
            for (int kontrolSayisi = 2; kontrolSayisi <= girilenSayi; kontrolSayisi++)
            {
                bool asalMi = true;
                for (int i = 2; i * i <= kontrolSayisi; i++)
                {
                    if (kontrolSayisi % i == 0)
                    {
                        asalMi = false;
                        break;
                    }
                }
                if (asalMi)
                {
                    toplam += kontrolSayisi;
                }
            }
            return toplam;
        }
    }
}
