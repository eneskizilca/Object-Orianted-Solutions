using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_2
{
    // Hava Durumu Tahmini

    // Bir enum oluşturun :
    // -Hava durumu tiplerini(Sunny, Rainy, Cloudy, Stormy) temsil etsin.
    // -Enum’a göre tavsiye veren bir metot yazın (örneğin, yağmurluysa şemsiye alın).
    enum Weather
    {
        Sunny,
        Rainy,
        Cloudy,
        Stormy
    }
    class WeatherAdviser
    {
        public string GetAdvise(Weather weather)
        {
            switch (weather)
            {
                case Weather.Sunny:
                    return "Gunes gozlugunu unutma!";
                case Weather.Rainy:
                    return "Semsiye almayi unutma!";
                case Weather.Cloudy:
                    return "Kulakligini almayi unutma!";
                case Weather.Stormy:
                    return "Sıkı giyin!";
                default:
                    return "Bilinmeyen hava durumu!";
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            WeatherAdviser adviser = new WeatherAdviser();
            
            foreach(Weather weather in Enum.GetValues(typeof(Weather)))
            {
                string advise = adviser.GetAdvise(weather);
                Console.WriteLine($"Hava durumu {weather}! {advise}");
            }

            Console.Read();
        }
    }
}
