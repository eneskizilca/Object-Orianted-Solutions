using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            KiralikArac hondaCivic = new KiralikArac("23 ACF 143", 1000);
            hondaCivic.AracKirala();
            hondaCivic.AracTeslimEt();
            Console.ReadLine();
        }
    }

    class KiralikArac
    {
        public string Plaka { get; set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitMi { get; set; }

        public KiralikArac(string plaka, decimal gunlukUcret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukUcret;
            MusaitMi = true;
        }

        public void AracKirala()
        {
            if (MusaitMi)
            {
                Console.WriteLine(Plaka + " plakali arac kiralandi. " + "Gunluk ucreti: " + GunlukUcret);
                MusaitMi = false;
            }
        }
        public void AracTeslimEt()
        {
            if (!MusaitMi)
            {
                Console.WriteLine(Plaka + " plakali arac teslim edildi.");
                MusaitMi = true;
            }
        }
    }
}
