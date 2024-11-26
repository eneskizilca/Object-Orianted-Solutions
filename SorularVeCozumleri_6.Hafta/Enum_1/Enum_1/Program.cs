using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_1
{
    // Trafik Işığı Durumu
    // Bir enum oluşturun :
    // -Trafik ışıkları(Red, Yellow, Green) için durumları temsil etsin.
    // -Bir sınıf oluşturun ve enum’a göre hangi durumda ne yapılması gerektiğini döndüren
    //     bir metot yazın.
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLightController controller = new TrafficLightController();

            // Enum değerlerini döngüyle kontrol et
            foreach (TrafficLight light in Enum.GetValues(typeof(TrafficLight)))
            {
                string action = controller.GetAction(light);
                Console.WriteLine($"{light}: {action}");
            }

            Console.Read();
        }
    }
    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }
    class TrafficLightController
    {
        public string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Dur!";
                case TrafficLight.Yellow:
                    return "Hazırlan! Yeşil için hazır ol.";
                case TrafficLight.Green:
                    return "Geç!";
                default:
                    return "Bilinmeyen trafik ışığı durumu.";
            }
        }
    }
}
