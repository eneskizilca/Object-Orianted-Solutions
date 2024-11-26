using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_1
{
    //Matematiksel İşlemleri Çeşitlendiren Bir Fonksiyon

    //Bir fonksiyon yazın:
    //-Aynı adla ama farklı parametrelerle toplam işlemi yapacak.
    //-İlk sürümü iki tam sayıyı toplasın.
    //-İkinci sürümü üç tam sayıyı toplasın.
    //Üçüncü sürümü bir dizi (array) tam sayıyı toplasın.
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 8, 1, 4, 5, 76 };

            int ikiTamSayiToplami = Add(1, 8);
            int ucTamSayiToplami = Add(1, 8, 3);
            int diziElemanlariToplami = Add(numbers);

            Console.WriteLine(ikiTamSayiToplami);
            Console.WriteLine(ucTamSayiToplami);
            Console.WriteLine(diziElemanlariToplami);

            Console.Read();
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static int Add(int[] array)
        {
            int result = 0;
            foreach(int num in array)
            {
                result += num;
            }
            return result;
        }

    }
}
