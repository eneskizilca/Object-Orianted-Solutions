using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gelenSayi;
            int alinacakSayiSayisi;
            int aranacakSayi;
            List<int> sayilar = new List<int>();

            Console.Write("Kac adet sayi girmek istersiniz?: ");
            alinacakSayiSayisi = Convert.ToInt32(Console.ReadLine());

            while (alinacakSayiSayisi > 0)
            {
                Console.Write("Pozitif sayi giriniz: ");
                gelenSayi = Convert.ToInt32(Console.ReadLine());
                if (gelenSayi == 0)
                    break;
                if(gelenSayi > 0)
                {
                    sayilar.Add(gelenSayi);
                    alinacakSayiSayisi--;
                }    
            }

            Console.Write("Dizinin içinde aramak istediğiniz sayiyi giriniz: ");
            aranacakSayi = Convert.ToInt32(Console.ReadLine());

            sayilar.Sort();
            Console.Write("Sayilar: ");
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine("");

            bool sayiBulundu = false;
            for (int i = 0; i < sayilar.Count; i++)
            {
                if(aranacakSayi == sayilar[i])
                {
                    Console.WriteLine("Aradiginiz sayi dizide vardır!");
                    sayiBulundu = true;
                    break;
                }
            }
            if(!sayiBulundu)
                Console.WriteLine("Aradiginiz sayi dizide yoktur!");

            Console.Write("Çıkış için enter'a basın...");
            Console.ReadLine();
        }
    }
}
