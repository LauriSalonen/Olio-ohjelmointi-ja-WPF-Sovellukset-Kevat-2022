using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Class3 : Class1
    {
        public string Rotu;
        public int Ikä; 
        public static int instanssit = 0;
        public Class3(string rotu, int ikä)
        {
            Rotu = rotu;
            Ikä = ikä;

            instanssit++; 
        }
        public static new void montako() 
        {
            Console.WriteLine("Koiria on talossa: " + instanssit);
        }
        public override void Ääntele()
        {
            Console.WriteLine("Whuh Whuh");
        }
    }
}
