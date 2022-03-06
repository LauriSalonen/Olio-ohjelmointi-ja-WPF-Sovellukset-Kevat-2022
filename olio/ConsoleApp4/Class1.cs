using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Class1
    {
            

        private string Nimi;
        private int Lämpötila;
        private int Kosteus;

        
        public bool Tila = true;

       
        public Class1(string _nimi, int _lämpötila, int _kosteus)
        {
            Nimi = _nimi;
            Lämpötila = _lämpötila;
            Kosteus = _kosteus;
        }


        public void NäytäTiedot()
        {
            
            if (Tila) 
            {
               
                Console.WriteLine("Kiuas " + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpötila);
                Console.WriteLine("Kosteus = " + Kosteus);
            }
            else
            {
              
                Console.WriteLine("Kiuas " + Nimi + " ei ole päällä");
            }
        }

        public void SäädäLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;
        }

   
        public void SäädäKosteutta(int uusiKosteus)
        {
            Kosteus = uusiKosteus;
        }
    }
}
