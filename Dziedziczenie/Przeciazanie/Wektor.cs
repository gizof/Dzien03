using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Przeciazanie
{
    class Wektor
    {

        public double x;
        public double y;

        public Wektor(double x, double y)
        {
            this.x = x;
            this.y = y;

        }

        public void Print()
        {
            Console.WriteLine("x={0}, y={1}", x, y);
        }

        public Wektor Add(Wektor wektor) // dodawanie wartosci jednego wektora do drugiego
        {
            return new Wektor(x+wektor.x, y+wektor.y);

        }

        public static Wektor operator +(Wektor w1, Wektor w2) // przeciażanie operatora dodawania, chcmey aby mozna dodawac dwie liczby
        {
            return new Wektor(w1.x + w2.x, w1.y + w2.y);
        }
        public static Wektor operator +(Wektor w1, double liczba) // przeciażanie operatora dodawania, pozwala na dodawnaie wartosci skalarnej do wektora
        {
            return new Wektor(w1.x + liczba, w1.y + liczba);
        }


    }
}
