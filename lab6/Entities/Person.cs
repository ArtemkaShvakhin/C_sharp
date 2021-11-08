using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Person
    {
        private MyCustomCollections<Product> purchases = new MyCustomCollections<Product>();
        private string _name, _surname;
        private uint PurchaseAmount = 0;
        private double _totalCost;
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public void BuyProduct(string product, string name, double cost)
        {
            if (Shop.Availability(product, name, cost))
            {
                Product temp = new Product(product, name, cost);
                Console.WriteLine($"Покупка {product} {name} стоимостью {cost}$ успешно совершена!");
                purchases.Add(temp);
                PurchaseAmount++;
            }
            else
            {
                Console.WriteLine($"К сожалению товар \"{product} {name}\" отсутствует на нашем складе(");
            }
        }
        public void ShowPurchases()
        {
            Console.WriteLine($"Текущие покупки {_surname} {_name}: " + "\n");
            for (int i = 0; i < PurchaseAmount; ++i)
            {
                purchases[i].ProductInfo();
            }
        }
        public void TotalCost()
        {
            for (int i = 0; i < PurchaseAmount; ++i)
            {
                _totalCost += purchases[i].GetProductCost();
            }
            Console.WriteLine("\n" + $"Итоговая сумма всех заказов {_surname} {_name}: {_totalCost}$" + "\n");
        }

    }
}