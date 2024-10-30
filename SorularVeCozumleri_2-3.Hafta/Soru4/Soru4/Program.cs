using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matematiksel ifadeyi girin (örneğin, 3 + 4 * 2 / (1 - 5) ^ 2 ^ 3): ");
            string ifade = Console.ReadLine();

            try
            {
                double sonuc = HesaplaVeAcikla(ifade);
                Console.WriteLine($"\nSonuç: {sonuc}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
            }
            Console.ReadLine();
        }

        static double HesaplaVeAcikla(string ifade)
        {
            // Parantezleri çözümler
            while (ifade.Contains("("))
            {
                int sonParantez = ifade.LastIndexOf("(");
                int kapanisParantez = ifade.IndexOf(")", sonParantez);
                string altIfade = ifade.Substring(sonParantez + 1, kapanisParantez - sonParantez - 1);
                double altSonuc = HesaplaVeAcikla(altIfade);

                Console.WriteLine($"Parantez içi ({altIfade}) = {altSonuc}");
                ifade = ifade.Substring(0, sonParantez) + altSonuc + ifade.Substring(kapanisParantez + 1);
            }

            // Üs alma işlemleri (^) yapılır
            Regex usRegex = new Regex(@"(-?\d+(\.\d+)?|\d+)\s*\^\s*(-?\d+(\.\d+)?|\d+)");
            while (usRegex.IsMatch(ifade))
            {
                Match match = usRegex.Match(ifade);
                double taban = double.Parse(match.Groups[1].Value);
                double us = double.Parse(match.Groups[3].Value);
                double sonuc = Math.Pow(taban, us);

                Console.WriteLine($"İşlem: {taban}^{us} = {sonuc}");
                ifade = ifade.Replace(match.Value, sonuc.ToString());
            }

            // Çarpma ve bölme işlemleri (*, /) yapılır
            Regex carpmaBolmeRegex = new Regex(@"(-?\d+(\.\d+)?|\d+)\s*([\*/])\s*(-?\d+(\.\d+)?|\d+)");
            while (carpmaBolmeRegex.IsMatch(ifade))
            {
                Match match = carpmaBolmeRegex.Match(ifade);
                double sol = double.Parse(match.Groups[1].Value);
                double sag = double.Parse(match.Groups[4].Value);
                double sonuc = match.Groups[3].Value == "*" ? sol * sag : sol / sag;

                Console.WriteLine($"İşlem: {sol} {match.Groups[3].Value} {sag} = {sonuc}");
                ifade = ifade.Replace(match.Value, sonuc.ToString());
            }

            // Toplama ve çıkarma işlemleri (+, -) yapılır
            Regex toplamaCikarmaRegex = new Regex(@"(-?\d+(\.\d+)?|\d+)\s*([\+\-])\s*(-?\d+(\.\d+)?|\d+)");
            while (toplamaCikarmaRegex.IsMatch(ifade))
            {
                Match match = toplamaCikarmaRegex.Match(ifade);
                double sol = double.Parse(match.Groups[1].Value);
                double sag = double.Parse(match.Groups[4].Value);
                double sonuc = match.Groups[3].Value == "+" ? sol + sag : sol - sag;

                Console.WriteLine($"İşlem: {sol} {match.Groups[3].Value} {sag} = {sonuc}");
                ifade = ifade.Replace(match.Value, sonuc.ToString());
            }

            return double.Parse(ifade);
        }
    }
}
