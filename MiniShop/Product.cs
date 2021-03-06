﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Product
    {
        private int id;
        private string name;
        private double price;
        private string descr = string.Empty;//inicjuje pusty sting i jest to samo co =""
        private UInt16 version = 0;
        private bool promo = false;
        private bool active = true;

        public double Price { get { return price; } }
        //ustawianie parametrow
        public Product (int id, string name, double price, string descr="")
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.descr = descr;
        }

        public void ChangePrice(double newPrice)//podlaczona kolekcja wartosci. mechanizm logowania starych cen. podbijana jest wersja
        {
            
        }

        public void ChangeDescription(string newDescr)
        {

        }
        public void SetActive(bool isActive)
        {
            this.active = isActive; //ustawia czy produkt jest dostepny czy nie
        }

        public override string ToString()
        {
            return name;
        }

    }
}
