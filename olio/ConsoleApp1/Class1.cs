using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Class1
    {
        public string nimi;
        public int ikä;
        public string rotu;

        public Class1(string _nimi, int _ikä, string _rotu)
        {
            nimi = _nimi;
            ikä = _ikä;
            rotu = _rotu;

        }

        public void TulostaData()
        {
            Console.WriteLine("Koiran nimi: " + nimi + " Ikä: " + ikä + " Rotu :" + rotu);
        }
        public void Hauku()
        {
            Console.WriteLine("Hau Hau");
        }
    }
}
