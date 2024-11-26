using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_3
{
    // GPS Konum Mesafesi

    // Bir struct oluşturun :
    // -Enlem ve boylam (Latitude ve Longitude) bilgilerini tutsun.
    // -İki GPS konumu arasındaki mesafeyi kilometre olarak
    //        hesaplayan bir metot ekleyin (Haversine Formülü).
    class Program
    {
        static void Main(string[] args)
        {
            GPSLocation location1 = new GPSLocation(41.0082, 28.9784); // İstanbul
            GPSLocation location2 = new GPSLocation(40.7128, -74.0060); // New York

            // İki konum arasındaki mesafeyi hesaplama
            double distance = location1.CalculateDistance(location2);

            Console.WriteLine($"İki nokta arasındaki mesafe: {distance:F2} km");
            Console.Read();
        }
    }
    struct GPSLocation
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public double CalculateDistance(GPSLocation otherLocation)
        {
            const double R = 6371.0; // Dünya'nın yarıçapı (kilometre)

            // Dereceleri radyana çevirme
            double lat1Rad = DegreeToRadian(this.Latitude);
            double lon1Rad = DegreeToRadian(this.Longitude);
            double lat2Rad = DegreeToRadian(otherLocation.Latitude);
            double lon2Rad = DegreeToRadian(otherLocation.Longitude);

            // Enlem ve boylam farklarını hesaplama
            double deltaLat = lat2Rad - lat1Rad;
            double deltaLon = lon2Rad - lon1Rad;

            // Haversine formülü
            double a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return R * c; // Mesafe (kilometre)
        }
        private static double DegreeToRadian(double degree)
        {
            return degree * Math.PI / 180;
        }
    }
}
