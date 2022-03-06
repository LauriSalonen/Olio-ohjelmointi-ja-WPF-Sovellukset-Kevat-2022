using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    abstract class Class1 
    {
        private static int instanssit = 0;

        public Class1()
        {
            instanssit++; 
        }
        public static void montako()
        {
            Console.WriteLine("Eläimiä on Talossa: " + instanssit);
        }

        public abstract void Ääntele(); 
    }
}