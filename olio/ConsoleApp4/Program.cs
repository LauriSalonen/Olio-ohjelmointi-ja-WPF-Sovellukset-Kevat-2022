using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 harvia = new Class1("Harvia", 90, 50); 

            harvia.NäytäTiedot();
            harvia.Tila = true; 
            harvia.NäytäTiedot(); 
            harvia.SäädäLämpötila(100);
            harvia.SäädäLämpötila(60); 
            harvia.NäytäTiedot(); 
            harvia.Tila = false; 
        }
    }
}
