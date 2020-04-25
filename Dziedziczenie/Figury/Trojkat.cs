using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Trojkat : Figura
    {
        private double? bokA = null; //znak zapytania pozwala aby nasze zmienne mialy warotsci null. Dzieki temu mozemy srpawdzicz czy wartosc jest rozna od zera
        private double? bokB;
        private double? bokC;
        private double? wysokosc;

        private Int32 x;

        public Trojkat(double a, double b, double c)
        {
            bokA = a;
            bokB = b;
            bokC = c;
            liczbaBokow = 3;
        }

        public Trojkat(double a, double h)
        {
            bokA = a;
            wysokosc = h;
        }

        public double ObliczPole(double a, double h)
        {
            if (bokA != null && wysokosc != null)
            {
                //return 0.5 * bokA * wysokosc; tutaj pojawia sie problem bo kompialtor nie potrafi mnzoyc wartosci nullowych. Najlepiej wartosc null skonvertowac jak niżej.
                return 0.5 * (double)bokA * (double)wysokosc;
            }
            else 
            {
                double p = 0.5*((double)bokA + (double)bokB + (double)bokC);
                return Math.Sqrt(p * (p - (double)bokA) * (p - (double)bokB) * (p - (double)bokC));
            }
            
        }

        public double obliczObwod()
        {
            if (wysokosc != null)
            {
                return 0;
            }
            else
            {
                return (double)bokA + (double)bokB + (double)bokC;
            }
        }


    }
}
