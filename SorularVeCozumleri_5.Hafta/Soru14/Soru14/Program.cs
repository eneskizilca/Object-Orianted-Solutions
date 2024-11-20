using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru14
{
    //Örnek 2: Bilgisayar ve İşlemci(Ödev)
    //Bir bilgisayarın işlemcisi vardır.Eğer bilgisayar kapanırsa, işlemci de var olamaz çünkü işlemci
    //bilgisayarın bir parçasıdır.
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Bilgisayar
    {
        public string Model { get; set; }
        public Islemci Islemci { get; set; }
        public Bilgisayar(string model)
        {
            Model = model;
            Islemci = new Islemci(8, 5200);
        }
    }
    class Islemci
    {
        public int CekirdekSayisi { get; set; }
        public int Frekans { get; set; }
        public Islemci(int cekirdekSayisi, int frekans)
        {
            CekirdekSayisi = cekirdekSayisi;
            Frekans = frekans;
        }
        public void IslemciBilgisi()
        {
            Console.WriteLine("Cekirdek sayisi: " + CekirdekSayisi);
            Console.WriteLine("Frekans degeri: " + Frekans);
        }
    }
}
