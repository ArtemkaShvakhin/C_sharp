using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            string s;
            MyCustomCollections<int> cl = new MyCustomCollections<int>();
            cl.Add(1);
            cl.Add(2);
            cl.Add(3);
            Console.WriteLine(cl[10]);
            //Person p1 = new Person("Артём", "Дембовский");
            //Person p2 = new Person("Святослав", "Швахин");
            ////Adding products to store
            //Shop.AddProduct("Молоко", "Из коровы", 1.5);
            //Shop.AddProduct("Конфеты", "Радость диабетика", 6.20);
            //Shop.AddProduct("Лотерейный билет", "Честный", 0.2);
            //Shop.AddProduct("Картошка", "Белорусская", 1.5);
            //Shop.AddProduct("Газированная вода", "Coca-Cola", 1.84);
            //Shop.AddProduct("Мороженое", "Ленинградское", 1.3);
            ////Actions of person 1
            //p1.BuyProduct("Молоко", "Из коровы", 1.5);
            //p1.BuyProduct("Огурцы", "Свежие", 1.1);
            //p1.BuyProduct("Газированная вода", "Coca-Cola", 1.84);
            //p1.ShowPurchases();
            //p1.TotalCost();
            ////Actions of person 2
            //p2.BuyProduct("Молоко", "Из коровы", 1.5);
            //p2.BuyProduct("Картошка", "Белорусская", 1.5);
            //p2.BuyProduct("Лотерейный билет", "Честный", 0.2);
            //p2.ShowPurchases();
            //p2.TotalCost();
            Shop.NewClient += journal.AddEvent;
        }
    }
}