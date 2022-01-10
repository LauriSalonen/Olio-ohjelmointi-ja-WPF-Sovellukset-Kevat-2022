using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Class1
    {
        public string tyyppi;
        public string ajoneuvo;
        public string nopeus;
        public int renkaat;
        public int hepat;



        public void AjoneuvoData()
        {
            Console.WriteLine("Ajoneuvon tyyppi: " + tyyppi + " | Ajoneuvon malli: " + ajoneuvo + " | Nopeus: " + nopeus + " | Renkaat: " + renkaat + " | Hevosvoimat: " + hepat);
        }
    }
}
