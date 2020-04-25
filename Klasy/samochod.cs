using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class samochod
    {
        private string marka;
        private int predkoscMax;



        //deklaracja wlasciowsi lasy (property) piszemy "prop" i klikamy tab i robi nam snippet property
        public int Predkosc 
        {
            get
            {
                return predkoscMax;
            }
            set
            {
                if (value <=0)
                {
                    Console.WriteLine("Predkosc >=0");
                }
                else
                {
                    predkoscMax = value;
                }
                
            }
        }

        public int LiczbaDrzwi { get; set; }

        public samochod(string marka, int predkosc)
        {
            this.marka = marka;
            predkoscMax = predkosc;
        }


        /// <summary>
        /// Metoda zmienia predkosc maks
        /// </summary>
        /// <param name="predkosc">nowa predkosc maksymalna</param>
        public void UstawPredkoscMax(int predkosc)
        {
            predkoscMax = predkosc;
        }

        public int PodajPredkoscMax()
        {
            return predkoscMax;
        }

    }
}
