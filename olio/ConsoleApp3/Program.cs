using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 oppilas1 = new Class1("Lauri", "260705", 24);
            oppilas1.TulostaData();
            oppilas1.MuokkaaOpintopisteitä(10); 
            oppilas1.MuokkaaOpintopisteitä(15); 
            oppilas1.TulostaData(); 
        }
    }
}
