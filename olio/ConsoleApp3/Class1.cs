using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class1
    {
        private string nimi;
        private string opiskelijaID;
        private int oppisteet;


        public Class1(string _nimi, string _opiskelijaID, int _oppisteet)
        {
            nimi = _nimi;
            opiskelijaID = _opiskelijaID;
            oppisteet = _oppisteet;
        }

        public void TulostaData() 
        {
            Console.WriteLine(nimi + ". Oppilasnumero: " + opiskelijaID + ". Opintopisteet: " + oppisteet);
        }

        public void MuokkaaOpintopisteitä(int määrä)
        {
            
            oppisteet += määrä;
        }
    }
}
