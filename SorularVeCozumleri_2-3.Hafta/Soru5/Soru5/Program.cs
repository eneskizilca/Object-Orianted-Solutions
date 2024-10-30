using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Birinci polinomu girin (çıkmak için 'exit' yazın): ");
                string polinom1 = Console.ReadLine();
                if (polinom1.ToLower() == "exit")
                    break;

                Console.Write("İkinci polinomu girin (çıkmak için 'exit' yazın): ");
                string polinom2 = Console.ReadLine();
                if (polinom2.ToLower() == "exit")
                    break;

                var polinom1Terimleri = PolinomuAyristir(polinom1);
                var polinom2Terimleri = PolinomuAyristir(polinom2);

                var toplamSonuc = PolinomTopla(polinom1Terimleri, polinom2Terimleri);
                var farkSonuc = PolinomCikar(polinom1Terimleri, polinom2Terimleri);

                Console.WriteLine("Toplam: " + PolinomuYazdir(toplamSonuc));
                Console.WriteLine("Fark: " + PolinomuYazdir(farkSonuc));
            }
        }

        static Dictionary<int, int> PolinomuAyristir(string polinom)
        {
            Dictionary<int, int> terimler = new Dictionary<int, int>();
            var matches = Regex.Matches(polinom.Replace(" ", ""), @"([+-]?\d*)x\^(\d+)|([+-]?\d*)x|([+-]?\d+)");

            foreach (Match match in matches)
            {
                int katsayi = 0;
                int derece = 0;

                if (match.Groups[1].Success) // Dereceli terimler, ör: 3x^2
                {
                    katsayi = int.Parse(string.IsNullOrEmpty(match.Groups[1].Value) || match.Groups[1].Value == "+" ? "1" : match.Groups[1].Value == "-" ? "-1" : match.Groups[1].Value);
                    derece = int.Parse(match.Groups[2].Value);
                }
                else if (match.Groups[3].Success) // x terimi, ör: 4x
                {
                    katsayi = int.Parse(string.IsNullOrEmpty(match.Groups[3].Value) || match.Groups[3].Value == "+" ? "1" : match.Groups[3].Value == "-" ? "-1" : match.Groups[3].Value);
                    derece = 1;
                }
                else if (match.Groups[4].Success) // Sabit terim, ör: -5
                {
                    katsayi = int.Parse(match.Groups[4].Value);
                    derece = 0;
                }

                if (terimler.ContainsKey(derece))
                    terimler[derece] += katsayi;
                else
                    terimler[derece] = katsayi;
            }

            return terimler;
        }

        static Dictionary<int, int> PolinomTopla(Dictionary<int, int> polinom1, Dictionary<int, int> polinom2)
        {
            var sonuc = new Dictionary<int, int>(polinom1);

            foreach (var terim in polinom2)
            {
                if (sonuc.ContainsKey(terim.Key))
                    sonuc[terim.Key] += terim.Value;
                else
                    sonuc[terim.Key] = terim.Value;
            }

            return sonuc;
        }

        static Dictionary<int, int> PolinomCikar(Dictionary<int, int> polinom1, Dictionary<int, int> polinom2)
        {
            var sonuc = new Dictionary<int, int>(polinom1);

            foreach (var terim in polinom2)
            {
                if (sonuc.ContainsKey(terim.Key))
                    sonuc[terim.Key] -= terim.Value;
                else
                    sonuc[terim.Key] = -terim.Value;
            }

            return sonuc;
        }

        static string PolinomuYazdir(Dictionary<int, int> polinom)
        {
            var sonuc = "";
            foreach (var terim in polinom)
            {
                int derece = terim.Key;
                int katsayi = terim.Value;

                if (katsayi == 0) continue;

                if (!string.IsNullOrEmpty(sonuc) && katsayi > 0)
                    sonuc += "+";

                if (derece == 0)
                    sonuc += katsayi;
                else if (derece == 1)
                    sonuc += katsayi == 1 ? "x" : katsayi == -1 ? "-x" : $"{katsayi}x";
                else
                    sonuc += katsayi == 1 ? $"x^{derece}" : katsayi == -1 ? $"-x^{derece}" : $"{katsayi}x^{derece}";
            }
            return string.IsNullOrEmpty(sonuc) ? "0" : sonuc;
        }
    }
}
