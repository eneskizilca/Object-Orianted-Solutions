using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Hasta
    {
        public string Ad { get; set; }
        public string TCNo { get; set; }
        public Doktor Doktor { get; private set; } // Hastanın atandığı doktor

        public Hasta(string ad, string tcNo)
        {
            Ad = ad;
            TCNo = tcNo;
        }

        // Hastaya doktor atama metodu
        public void DoktorAtama(Doktor doktor)
        {
            if (Doktor != null)
            {
                Console.WriteLine($"{Ad} zaten {Doktor.Ad} isimli doktora atanmış.");
                return;
            }

            Doktor = doktor;
            doktor.HastaEkle(this); // Doktor sınıfında hastayı ekle
            Console.WriteLine($"{Ad} isimli hasta, {doktor.Ad} isimli doktora atandı.");
        }
    }
}
