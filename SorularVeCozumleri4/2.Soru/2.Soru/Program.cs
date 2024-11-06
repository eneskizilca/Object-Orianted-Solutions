using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Soru
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Urun macbookPro = new Urun("Macbook Pro M3", 74000);
                macbookPro.Indirim = 80;
                decimal indirimliFiyat = macbookPro.IndirimliFiyat();
                Console.WriteLine($"Eski fiyat: {macbookPro.Fiyat}, Yeni fiyat: {indirimliFiyat}");
            } catch(ArgumentException)
            {
                Console.WriteLine("Indirim 0-50 arası olmalıdır.");
            }
            
            Console.Read();
        }

        class Urun
        {
            private decimal indirim;
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }
            public decimal Indirim
            {

                get { return indirim; }
                set
                {
                    if (value >= 0 && value <= 50)
                        indirim = value;
                    else
                        throw new ArgumentException();
                }
            }

            public Urun(string ad, decimal fiyat)
            {
                Ad = ad;
                Fiyat = fiyat;
            }

            public decimal IndirimliFiyat()
            {
                return Fiyat - Fiyat * Indirim / 100;
            }
        }
    }
}
