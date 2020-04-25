using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            samochod samochod = new samochod("FIAT", 180);
            //samochod.UstawPredkoscMax(200);
            samochod.Predkosc = -10;
            samochod.LiczbaDrzwi = 3;
            Console.WriteLine(samochod.Predkosc);
            
            Console.ReadKey();
        }
    }
}
