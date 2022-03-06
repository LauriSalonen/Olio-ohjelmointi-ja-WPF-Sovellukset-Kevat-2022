using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Class3.montako(); 
            Class2.montako(); 
            Class1.montako(); 
            Class3 koira1 = new Class3("Shih Tzu", 4);
            Class3 koira2 = new Class3("Kultainen noutaja", 6);
            Class2 kissa1 = new Class2("Keltainen", 2);
            Class2 kissa2 = new Class2("Valkoinen", 5);
            kissa1.Ääntele();
            koira1.Ääntele();
            Class3.montako();
            Class2.montako(); 
            Class1.montako(); 
            koira2.Ääntele();
            kissa2.Ääntele();
        }
    }
}
