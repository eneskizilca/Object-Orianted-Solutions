using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru8
{
    //Örnek 4: Şirket ve Çalışan(Ödev)
    //Bir şirket birden fazla çalışana sahip olabilir ve her çalışanın bir şirketi vardır.
    class Program
    {
        static void Main(string[] args)
        {
            // Şirketler oluştur
            Sirket sirket1 = new Sirket("TechCorp", "İstanbul");
            Sirket sirket2 = new Sirket("DesignHub", "Ankara");

            // Çalışanlar oluştur
            Calisan calisan1 = new Calisan("Ahmet Yılmaz");
            Calisan calisan2 = new Calisan("Elif Demir");
            Calisan calisan3 = new Calisan("Mehmet Kara");

            // Çalışanları şirketlere atama
            calisan1.SirketAtama(sirket1);
            sirket1.CalisanEkle(calisan1);

            calisan2.SirketAtama(sirket1);
            sirket1.CalisanEkle(calisan2);

            calisan3.SirketAtama(sirket2);
            sirket2.CalisanEkle(calisan3);

            Console.Read();
        }
    }
}
