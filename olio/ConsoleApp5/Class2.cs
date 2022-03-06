using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class2 : Class1
    {
        public string Väri;
        public int Ikä;
        public static int instanssit = 0;
        public Class2(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            instanssit++;
        }
        public static new void montako() 
        {
            Console.WriteLine("Kissoja talossa: " + instanssit);
        }
        public override void Ääntele()
        {
            Console.WriteLine("Miau");
        }
    }
}
