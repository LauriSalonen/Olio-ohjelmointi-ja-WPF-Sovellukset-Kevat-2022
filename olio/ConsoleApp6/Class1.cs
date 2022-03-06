using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Class1
    {
        private int alinKerros; // hissi alin kerros
        private int ylinKerros; // hissin ylin kerros

        private int nykynenKerros; // hissin nykyinen kerros (private)

        public Class1(int alinKerros, int ylinKerros) // Hissin konstruktori
        {
            this.alinKerros = alinKerros;
            this.ylinKerros = ylinKerros;

            NykynenKerros = alinKerros; // alussa asetetaan nykyiseksi kerrokseksi alin kerros (minKerros)
        }

        public int NykynenKerros // Nykyisen kerroksen aksessori
        {
            get => nykynenKerros; // Palautetaan nykyinenKerros hakijalle (program ohjelmassa)
            set // Yritetään asettaa uusi kerros
            {
                // Jos käyttäjän antama kerros on suurempi kuin maxKerros (ylin kerros)
                // TAI (|| merkit) pienempi kuin minKerros (alin kerros) niin annetaan virhe viesti
                if (value > ylinKerros || value < alinKerros)
                {
                    Console.WriteLine("Tuota kerrosta ei ole olemassa!");
                }
                else
                {
                    // Jos kerros on min ja max:in välillä niin siirrytään kerrokseen
                    nykynenKerros = value;
                }
            }
        }
    }

}