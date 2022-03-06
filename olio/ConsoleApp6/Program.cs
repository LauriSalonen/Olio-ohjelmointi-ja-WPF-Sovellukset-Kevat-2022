using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 hissi = new Class1(1, 6); 
            string syöte;

            while (true) 
            {
                Console.WriteLine("Kerros: " + hissi.NykynenKerros);
                Console.WriteLine("Valitse kerros:");
                syöte = Console.ReadLine(); 

                
                if (syöte == "lähde")
                {
                    Console.WriteLine("Lähdit Hissistä");
                    break;
                }
                else
                {
                    
                    hissi.NykynenKerros = int.Parse(syöte);
                }

                
            }
        }
    }
}
