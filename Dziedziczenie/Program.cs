﻿using Dziedziczenie.Figury;
using Dziedziczenie.KlasaAbstrakcyjna;
using Dziedziczenie.KlasaStatyczna;
using Dziedziczenie.MetodyWirtualne;
using Dziedziczenie.Pojazdy;
using Dziedziczenie.Przeciazanie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prostokat prostokat = new Prostokat(2.5, 3);
            //double pole = prostokat.obliczPole();
            //Console.WriteLine("Pole prostokat={0}",pole);

            //Kwadrat kwadrat = new Kwadrat(5);
            //pole = kwadrat.obliczPole();            
            //Console.WriteLine("Pole kwadratu={0}", pole);
            //Console.WriteLine("Czy kwadrat={0}", kwadrat.czyKwadrat());

            Samochod samochod = new Samochod();
            samochod.Zatanku();
            samochod.Uruchom();
            samochod.Zatrzymaj();


            Samochod audi = new Samochod();
            audi.Zatanku();
            audi.Uruchom();
            audi.Zatrzymaj();

            Console.WriteLine("Nazwa hosta: {0}",Utils.hostname);
            Console.WriteLine("Nazwa hosta: {0}", Utils.GetMaxValue(-10,10,20,30,3,-4));

            Product ap = new Product("Mleko", 2.99);
            ap.ShowPrice();

            Wektor wektor1 = new Wektor(2, -4);
            Wektor wektor2 = new Wektor(-2,3);
            //Wektor wektor = wektor1.Add(wektor2);
            //Wektor wektor = wektor1 + wektor2;
            Wektor wektor = wektor1 + 2;


            wektor.Print();

            Kot kot = new Kot();
            Console.WriteLine(kot);


            Console.ReadKey();
        }
    }
}
