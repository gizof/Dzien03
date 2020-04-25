using System;
using System.Collections.Generic;
using System.Linq;
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

        //metody
        public bool AddProduct(Product product, int qnty)
        {
            //if ktory sprawdza czy mozna dodac czy nie bazujac na etykiecie, np przy shipped nie mozna dodac produktu
            //akcja dodania produktu do listy ptoduktow
            //products.Add(product);
            if (status == OrderStatus.NewOrder && qnty >=0)
            {
                items.Add(new OrderItem(product, qnty));
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
            foreach (var item in items)
            {
                amount += item.ProductPrice * item.Qnty;
            }
            if (discount>0 && discount <= 100)
            {
                amount *= (100 - discount) / 100.0;
            }
            
            
            return amount;
        }


        public void Print()
        {
            Console.WriteLine("Elelmenty zamówienia: ");
            foreach (var item in items)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    
                    "",item.Qnty,item.ProductPrice,item.ProductPrice*item.Qnty);

            }
            Console.WriteLine("Do zapłaty : {0}", CalcTotalAmount());
        }
    }
}
