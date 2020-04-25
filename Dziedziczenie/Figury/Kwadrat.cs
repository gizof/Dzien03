using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Kwadrat : Prostokat
    {

        public Kwadrat (double bok) : base(bok, bok) // base - odwołanie sie do klasy bazowej z ktorej dziedziczymy
        {

        }

        public bool czyKwadrat()
        {
            //return true; w tym wypadku przysłaniamy metode rodzica
            return base.czyKwadrat(); //zwraca wartośc z klasy rodzica. słówko kluczowe base
        }

    }
}
