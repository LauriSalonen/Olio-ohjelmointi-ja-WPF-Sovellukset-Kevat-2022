using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ajoneuvo1 = new Class1();
            Class1 ajoneuvo2 = new Class1();
            ajoneuvo1.tyyppi = "Auto";
            ajoneuvo1.ajoneuvo = "Mercedes Benz C63 AMG";
            ajoneuvo1.nopeus = "324 KM/H";
            ajoneuvo1.renkaat = 4;
            ajoneuvo1.hepat = 426;
            ajoneuvo2.tyyppi = "Vene";
            ajoneuvo2.ajoneuvo = "Bugatti Niniette 66";
            ajoneuvo2.nopeus = "80 KM/h";
            ajoneuvo2.renkaat = 0;
            ajoneuvo2.hepat = 960;

            ajoneuvo1.AjoneuvoData();
            Console.WriteLine();
            ajoneuvo2.AjoneuvoData();
        }
    }
}
