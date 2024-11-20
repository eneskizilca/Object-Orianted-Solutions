using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru10
{
    class Araba
    {
        public string Model { get; set; }
        public List<Tekerlek> Tekerlekler { get; set; }

        public Araba(string model)
        {
            Model = model;
            Tekerlekler = new List<Tekerlek>();
        }
        public void TekerlekEkle(Tekerlek tekerlek)
        {
            Tekerlekler.Add(tekerlek);
        }
        public void ArabaBilgisi()
        {
            Console.WriteLine($"Araba Modeli: {Model}");
            Console.WriteLine("Tekerlek Bilgileri:");
            foreach (var tekerlek in Tekerlekler)
            {
                tekerlek.TekerlekBilgisi();
            }
        }
    }
}
