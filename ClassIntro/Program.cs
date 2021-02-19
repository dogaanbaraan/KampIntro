using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            kurs kurs1 = new kurs();

            kurs1.kursadi = "C#";
            kurs1.isim = "Baran";
            kurs1.izlenme_orani = 58;

            kurs kurs2 = new kurs();

            kurs2.kursadi = "Python";
            kurs2.isim = "Erno";
            kurs2.izlenme_orani = 10;

            kurs kurs3 = new kurs();

            kurs3.kursadi = "C++";
            kurs3.isim = "Tayf";
            kurs3.izlenme_orani = 36;

            kurs[] kurslar = new kurs[] {kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.isim);
            }
        }
    }

    class kurs
    {
        public string kursadi { get; set; }
        public string isim { get; set; }
        public int izlenme_orani { get; set; }
    }
}
