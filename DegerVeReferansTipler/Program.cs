using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("-------");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            Console.WriteLine(sayi1);
            Console.WriteLine("-------");

            int[] sayilar1 = new int[] { 100, 200, 300 };
            int[] sayilar2 = new int[] { 200, 500, 600 };

            sayilar1 = sayilar2;
            sayilar2[0] = 55;
            Console.WriteLine(sayilar1[0]);
        }
    }
}
