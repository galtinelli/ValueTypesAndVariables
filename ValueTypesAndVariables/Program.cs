using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {

            // Value types veri türleri RAMin stack bölümünde barındırılır. Value types veri türleri için verilen değerlerin kendisi tutulur.
            //Value Types veri türlerinde değişkenler arası kopyalama işleminde verinin kendisi kopyalanır.

            // Value types veri türlerinden bazıları:
            // byte, sbyte, short, ushort, int, uint, long, ulong, float, double, decimal, char, bool gibi türler RAM'in STACK bölümünde saklanır. Yani değerlerin kendileri saklanır.


            int sayi1 = 10;

            int sayi2 = 25;

            int sayi3 = sayi1 + sayi2;

            sayi1 = sayi2 + sayi3;

            int sayi4 = sayi1;

            sayi2 = sayi4;

            Console.WriteLine("Sayı 1: "+sayi1); //60
            Console.WriteLine("Sayı 2: " + sayi2);//60
            Console.WriteLine("Sayı 3: " + sayi3);//35
            Console.WriteLine("Sayı 4: " + sayi4);//60


            //REFERENCE Types

            //Reference types türler RAM'in Heap bölümünde tutulur. Bu ür veilerin işaretçilri RAM'in STACK bölümünde tutulur.


            string metinsel1 = "Bilge Adam";
            string metinsel2 = metinsel1;

            metinsel2 = "Bilge Kadın";

            Console.WriteLine("Metin 1: "+metinsel1);
            Console.WriteLine("Metin 2: "+metinsel2);
            Console.WriteLine("Metin 1: " + metinsel1);

            // class seviyesinde oluşturulan değişkenler heapte oluşur.
            Console.ReadKey();



        }
    }
}
