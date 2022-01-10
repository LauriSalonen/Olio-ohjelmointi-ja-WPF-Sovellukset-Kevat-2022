using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 koira1 = new Class1();
            Class1 koira2 = new Class1();

            koira1.nimi = "Tapsa";
            koira1.ikä = 6;
            koira1.rotu = "Kultainen noutaja";
            koira2.nimi = "Luca";
            koira2.ikä = 6;
            koira2.rotu = "Shih Zhu";
            koira2.TulostaData();
            koira2.Hauku();
            koira1.TulostaData();
            koira1.Hauku();

            
        }
    }
}
