using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
       
            DortIslem toplama = new DortIslem();
            toplama.Topla(5, 6);

            DortIslem cikarma = new DortIslem();
            cikarma.Cikar(10, 5);

            DortIslem carp = new DortIslem();
            carp.Carp(5, 10);

            DortIslem bol = new DortIslem();
            bol.Bol(10, 5);
        }
    }
}
