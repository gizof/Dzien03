using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop
{
    public class Order
    {
        enum OrderStatus //tworzymy etykiety, które poźniej bedziemy używać. Do tego enumeracja bazuje na numerkach(Najedz myszką na etykiete).
        {
            NewOrder = 10, //w dowolny sposób można określać dowolne wartości. Domyślnie są zero.
            Complete = 20,
            Confirmed = 30,
            Shipped = 40,
            Returned = 50,
            Cancelled = 60
        }

        
        private string orderNumber;
        private List<OrderItem> items = new List<OrderItem>(); //utworzona pusta lista
        private byte discount = 0;
        private string customerName;//kto zamówił
        private string shipAddress;
        // wartosc zamowienia
        private DateTime orderDate;
        private OrderStatus status = OrderStatus.NewOrder; //ustawiamy ze domyslna wartosc to NewOrder

        private double totalAmount
        {
            get
            {
                return CalcTotalAmount();
            }
        }

        private int GetProductIndex(Product product)
        {
            int result = -1;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ProductName.Equals(product.ToString()))
                {
                    return i;
                }
                

            }



            return result;



        }

        //metody
        public bool AddProduct(Product product, int qnty)
        {
            //if ktory sprawdza czy mozna dodac czy nie bazujac na etykiecie, np przy shipped nie mozna dodac produktu
            //akcja dodania produktu do listy ptoduktow
            //products.Add(product);

            if (status == OrderStatus.NewOrder && qnty >= 0 && product != null)
            {
                int productIndex = items.FindIndex(x => x.ProductName.Equals(product.ToString())); //funckaj lambda to wyrazenie ktore nie ma nazwy
                //int productIndex = GetProductIndex(product);
                if (productIndex == -1)
                {
                    items.Add(new OrderItem(product, qnty));
                }
                else
                {
                    items[productIndex].Qnty += qnty;
                }
                return true;
            }
            else
            {
                return false;
            }

            //if (status == OrderStatus.NewOrder && qnty >=0)
            //{
            //    items.Add(new OrderItem(product, qnty));
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            
            
        }

        public bool RemoveProduct(Product product, int qnty=0)
        {
            if (status == OrderStatus.NewOrder && qnty >= 0 && product != null)
            {
                //int productIndex = GetProductIndex(product);
                int productIndex = items.FindIndex(x => x.ProductName.Equals(product.ToString()));
                if (productIndex == -1) return false;
                if (qnty > items[productIndex].Qnty) return false;

                if (qnty==0 || qnty == items[productIndex].Qnty)
                {
                    items.RemoveAt(productIndex);
                    return true;
                }
                items[productIndex].Qnty -= qnty;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Clear()
        {
            if (status == OrderStatus.NewOrder)
            {
                items.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private double CalcTotalAmount()
        {


            double amount = 0.0;
            items.ForEach(e => amount+=e.ProductPrice*e.Qnty); //funkcja lambda
            //foreach (var item in items)
            //{
            //    amount += item.ProductPrice * item.Qnty;
            //}
            if (discount>0 && discount <= 100)
            {
                amount *= (100 - discount) / 100.0;
            }
            
            
            return amount;
        }


        public void Print()
        {
            Console.WriteLine("Elelmenty zamówienia: ");
            items.ForEach(e => Console.WriteLine("{0,-40} {1,10} {2,10:0.00} {3,12:0.00}",
                     e.ProductName, e.Qnty, e.ProductPrice, e.ProductPrice * e.Qnty)) ;
            
            //foreach (var item in items)
            //{
            //    Console.WriteLine("{0,-40} {1,10} {2,10:0.00} {3,12:0.00}", //w palceholkderze po kropce dodajemy ilosc znakow jaka moze przybierac produkt. minus przed liczba sprawia, ze tekst jest justownay do lewej a nie prawej strony, :0.00 sprawia, że wynik bedzie pokazany do 2 miejsc po przecinku.

            //        item.ProductName,item.Qnty,item.ProductPrice,item.ProductPrice*item.Qnty);

            //}
            Console.WriteLine("Do zapłaty : {0}", CalcTotalAmount());
        }
    }
}
