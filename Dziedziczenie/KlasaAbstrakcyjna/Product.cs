﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.KlasaAbstrakcyjna
{
    class Product : AbstractProduct // musimy zdeklarować konstruktor dziedziczacy po bazowym
    {

        public Product(string name, double price) : base(name, price)
        {

        }
        public override void ShowPrice()
        {
            Console.WriteLine("cena produktu = {0}", price);
        }
    }
}
