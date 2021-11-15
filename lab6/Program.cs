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
            Journal journal = new Journal();
            MyCustomCollections<int> cl = new MyCustomCollections<int>();
            cl.Add(1);
            cl.Add(2);
            cl.Add(3);
            Person pers1 = new Person("Артём", "Швахин");
            Person pers2 = new Person("Альфред", "Дубинин");
            Product pr1 = new Product("Молоко", "Деревенское", 1.2);
            Shop.NewClient += journal.AddEvent;
            Shop.NewProduct += journal.AddEvent;
            Shop.AddClient(pers1);
            Shop.AddClient(pers2);
            Shop.AddProduct(pr1);
            pers1.NewPurchase += journal.AddEvent;
            pers1.BuyProduct(pr1);
            journal.PrintEvents();
        }
    }
}