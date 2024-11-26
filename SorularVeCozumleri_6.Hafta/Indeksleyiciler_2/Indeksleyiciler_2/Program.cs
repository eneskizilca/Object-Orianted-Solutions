using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksleyiciler_2
{
    // Bir Öğrenci Not Sistemi
    // Bir sınıf oluşturun:
    // -Öğrencilerin aldığı derslerin notlarını depolasın.
    // -Kullanıcı indeksleyici aracılığıyla ders adına göre notlara erişebilsin.
    // -Eğer ders yoksa bir hata mesajı döndürsün.
    class Program
    {
        static void Main(string[] args)
        {
            NotBilgiSistemi notSistemi = new NotBilgiSistemi();
            
            notSistemi.DersVeNotEkle("Matematik", 85);
            notSistemi.DersVeNotEkle("Fizik", 90);
            notSistemi.DersVeNotEkle("Kimya", 78);
            
            notSistemi.DersVeNotlariListele();

            // Ders adına göre notlara erişim
            try
            {
                Console.WriteLine($"Fizik dersi notu: {notSistemi["Fizik"]}");
                Console.WriteLine($"Biyoloji dersi notu: {notSistemi["Biyoloji"]}"); // Hata dönecek
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // Not güncelleme
            notSistemi["Fizik"] = 95;
            Console.WriteLine($"Fizik dersi notu güncellendi: {notSistemi["Fizik"]}");

            // Hatalı güncelleme denemesi
            try
            {
                notSistemi["Biyoloji"] = 88; // Hata dönecek
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
    class NotBilgiSistemi
    {
        private Dictionary<string, double> dersNotlari = new Dictionary<string, double>();

        public double this[string dersAdi]
        {
            get
            {
                if (!dersNotlari.ContainsKey(dersAdi))
                    throw new KeyNotFoundException($"'{dersAdi}' dersi bulunamadı.");
                return dersNotlari[dersAdi];
            }
            set
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    dersNotlari[dersAdi] = value;
                    Console.WriteLine($"'{dersAdi}' dersi için not {value} olarak güncellendi.");
                }
                else
                {
                    throw new KeyNotFoundException($"'{dersAdi}' dersi bulunamadı. Lütfen önce dersi ekleyin.");
                }
            }
        }
        public void DersVeNotEkle(string dersAdi, double not)
        {
            dersNotlari[dersAdi] = not;
            Console.WriteLine($"{dersAdi} adlı sınavın notu {not} olarak atandı.");
        }
        public void DersVeNotlariListele()
        {
            if (dersNotlari.Count == 0)
            {
                Console.WriteLine("Henüz ders eklenmedi.");
                return;
            }

            Console.WriteLine("Dersler ve Notlar:");
            foreach (var ders in dersNotlari)
            {
                Console.WriteLine($"Ders: {ders.Key}, Not: {ders.Value}");
            }
        }
    }
}
