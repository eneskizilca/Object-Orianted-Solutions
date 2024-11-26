using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_3
{
    // Çalışan Rolleri ve Maaş Hesaplama

    // Bir enum oluşturun :
    // -Çalışan rolleri(Manager, Developer, Designer, Tester) için maaşları belirlemek üzere.
    // -Enum’a göre maaşı hesaplayan bir metot yazın.
    public enum Position
    {
        Manager,
        Developer,
        Designer,
        Tester
    }
    public class MaasBirimi
    {
        public decimal MaasHesapla(Position position)
        {
            switch (position)
            {
                case Position.Manager:
                    return 150000;
                case Position.Developer:
                    return 100000;
                case Position.Designer:
                    return 60000;
                case Position.Tester:
                    return 90000;
                default:
                    return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MaasBirimi maasBirimi = new MaasBirimi();

            foreach(Position position in Enum.GetValues(typeof(Position)))
            {
                decimal maas = maasBirimi.MaasHesapla(position);
                Console.WriteLine($"Pozisyon: {position} -> Maas: {maas}");
            }

            Console.Read();
        }
    }
}
