using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru12
{
    //Örnek 3: Şirket ve Çalışan(Ödev)
    //Bir şirkette birden fazla çalışan olabilir, ancak çalışanlar bağımsız bir şekilde yaşamaya devam
    //edebilirler, şirket yok olduğunda da varlıklarını sürdürebilirler.
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Sirket
    {
        public string Ad { get; set; }
        public List<Calisan> Calisanlar { get; set; }
        public Sirket(string ad)
        {
            Ad = ad;
            Calisanlar = new List<Calisan>();
        }
        public void CalisanEkle(Calisan calisan)
        {
            Calisanlar.Add(calisan);
        }
    }
    class Calisan
    {
        public string Ad { get; set; }
        public string Pozisyon { get; set; }
        public Calisan(string ad, string pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }
        public void CalisanBilgisi()
        {
            Console.WriteLine($"Ad: {Ad}, Pozisyon: {Pozisyon}");
        }
    }
}
