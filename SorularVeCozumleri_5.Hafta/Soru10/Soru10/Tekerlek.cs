using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru10
{
    class Tekerlek
    {
        public string Boyut { get; set; }
        public string Tip { get; set; }
        public Tekerlek(string boyut, string tip)
        {
            Boyut = boyut;
            Tip = tip;
        }
        public void TekerlekBilgisi()
        {
            Console.WriteLine($"Tekerlek Boyutu: {Boyut}, Tip: {Tip}");
        }
    }
}
