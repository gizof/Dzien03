using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class Samochod : Pojazd// Ipojazd - interfejs nie wyrzuca bledu bo metody interfejsu sa juz dziedziczone z kalsy pojazd ktora dziedzicyz po interfejsie
    {
        public void Uruchom()
        {
            Console.WriteLine("Silnik Start");
        }

        public void Zatanku()
        {
            Console.WriteLine("Zalej PB/ON/LPG");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("Silnik Stop");
        }
    }
}
