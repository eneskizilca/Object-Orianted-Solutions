using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_3
{
    //Zaman Farkını Farklı Formatlarda Hesaplama
    //Bir fonksiyon yazın:
    //-Aynı adla ama farklı parametrelerle iki tarih arasındaki farkı hesaplasın.
    //-İlk sürüm, gün cinsinden farkı döndürsün.
    //-İkinci sürüm, saat cinsinden farkı döndürsün.
    //-Üçüncü sürüm, iki tarih arasında yıl, ay ve gün cinsinden farkı ayrı ayrı döndürsün.
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int ZamanFarkiHesapla(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }
        public static int ZamanFarkiHesapla(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }
        public static int ZamanFarkiHesapla(DateTime date1, DateTime date2)
        {
            return (date2 - date1).Days;
        }
    }
}
