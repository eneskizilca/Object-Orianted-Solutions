using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indeksleyiciler_1
{
    //Özel Bir Kitaplık Yönetim Sistemi
    //Bir sınıf oluşturun:
    // -Sınıf, bir kitap koleksiyonunu(dizi) depolasın.
    // -Kullanıcı, indeksleyici aracılığıyla belirli bir indekste hangi kitabın olduğunu
    //  öğrenebilsin ve kitap adını değiştirebilsin.
    // -Eğer kullanıcı geçersiz bir indeks ile erişim yaparsa uygun bir hata mesajı döndürsün.
    class Program
    {
        static void Main(string[] args)
        {
            Kitaplik kitaplik = new Kitaplik();
            kitaplik[0] = "Marslı";
            kitaplik[3] = "Harry Potter";
            kitaplik[6] = "Nutuk";

            Console.WriteLine(kitaplik[0]);
            Console.WriteLine(kitaplik[3]);
            Console.WriteLine(kitaplik[7]);

            Console.ReadLine();
        }
    }
    class Kitaplik
    {
        private string[] kitaplar = new string[5];
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= kitaplar.Length)
                    throw new IndexOutOfRangeException($"Geçersiz index değeri girdiniz! {index}. index getirilemedi!");
                return kitaplar[index];
            }
            set
            {
                if (index < 0 || index >= kitaplar.Length)
                    throw new IndexOutOfRangeException($"Geçersiz index değeri girdiniz! {value} değeri atanmadı!");
                kitaplar[index] = value;
            }
        }
    }
}
