using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru6
{
    class Doktor
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public List<Hasta> Hastalar { get; private set; }

        public Doktor(string ad, string brans)
        {
            Ad = ad;
            Brans = brans;
            Hastalar = new List<Hasta>();
        }

        // Doktorun hasta listesine hasta ekleme metodu
        public void HastaEkle(Hasta hasta)
        {
            if (!Hastalar.Contains(hasta))
            {
                Hastalar.Add(hasta);
            }
        }

        // Doktora atanmış hastaları yazdırma metodu
        public void HastalariGoster()
        {
            Console.WriteLine($"Doktor: {Ad}, Branş: {Brans}");
            Console.WriteLine("Hastalar:");
            foreach (var hasta in Hastalar)
            {
                Console.WriteLine($"- {hasta.Ad} (TC No: {hasta.TCNo})");
            }
        }
    }
}
