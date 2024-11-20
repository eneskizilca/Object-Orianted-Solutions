using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru15
{
    //Örnek 3: Otomobil ve Motor(Ödev)
    //Bir otomobilin motoru vardır.Eğer otomobil yoksa, motor da yok olacaktır. Motor, otomobilin
    //ayrılmaz bir parçasıdır.
    class Motor
    {
        private int Güc { get; set; }
        private string Tip { get; set; }

        public Motor(int güc, string tip)
        {
            Güc = güc;
            Tip = tip;
        }

        public void MotorBilgisi()
        {
            Console.WriteLine($"Motor Gücü: {Güc} HP");
            Console.WriteLine($"Motor Tipi: {Tip}");
        }
    }

    class Otomobil
    {
        public string Marka { get; set; }
        private Motor Motor { get; set; }

        public Otomobil(string marka, int motorGücü, string motorTipi)
        {
            Marka = marka;
            Motor = new Motor(motorGücü, motorTipi);
        }

        public void MotorOlustur()
        {
            Console.WriteLine($"Otomobil Markası: {Marka}");
            Motor.MotorBilgisi();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Otomobilin markasını girin: ");
            string marka = Console.ReadLine();

            Console.Write("Motor gücünü girin (HP): ");
            int güç = int.Parse(Console.ReadLine());

            Console.Write("Motor tipini girin: ");
            string tip = Console.ReadLine();

            Otomobil otomobil = new Otomobil(marka, güç, tip);
            otomobil.MotorOlustur();

            Console.WriteLine("Program sona erdi.");
            Console.ReadLine();
        }
    }
}
