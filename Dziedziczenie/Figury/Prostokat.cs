using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    class Prostokat : Figura, Ifigura, IfiguraStat //najpierw podajemy klase po której dziedziczymy a potem interfejs.
    {
        private double bokA;
        private double bokB;

        public Prostokat(double bokA, double bokB)
        {
            this.bokA = bokA;
            this.bokB = bokB;
            liczbaBokow = 2;
        }

        //public double obliczPole()
        //{
        //    return bokA * bokB;
        //}

        public bool czyKwadrat()
        {
            return bokA == bokB;
        }

        public double obliczObwod()
        {
            return 2 * bokA * bokB;
        }

        public double obliczPole()
        {
            return bokA * bokB;
        }

        public int podajLiczbeBokow()
        {
            return 2;
        }
    }
}
