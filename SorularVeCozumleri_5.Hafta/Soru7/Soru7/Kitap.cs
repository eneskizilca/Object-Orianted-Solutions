using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru7
{
    class Kitap
    {
        public string Baslik { get; set; }
        public DateTime YayinTarihi { get; set; }
        public Yazar Yazar { get; set; }

        public Kitap(string baslik, DateTime yayinTarihi)
        {
            Baslik = baslik;
            YayinTarihi = yayinTarihi;
        }
        public void YazarAtama(Yazar yazar)
        {
            Yazar = yazar;
        }
    }
}
