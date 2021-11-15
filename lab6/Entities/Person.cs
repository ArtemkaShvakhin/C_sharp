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
        public delegate void Buy(string name, string description);
        public event Buy NewPurchase;
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public string Name
        {
            get { return _name; }
        }

        public string Surname
        { 
            get { return _surname; }
        }
        public void BuyProduct(Product pr)
        {
            if (Shop.Availability(pr))
            {
                Console.WriteLine($"{pr.GetProduct} {pr.GetProductName} successfully finish for {pr.GetProductCost}$");
                purchases.Add(pr);
                PurchaseAmount++;
                NewPurchase?.Invoke("New purchase", $"{Name} {Surname} bought {pr.GetProduct} {pr.GetProductName} for {pr.GetProductCost}$");
            }
            else
            {
                Console.WriteLine($"Unfortunately there isn't \"{pr.GetProduct} {pr.GetProductName}\" in our store(");
            }
        }
        public void ShowPurchases()
        {
            Console.WriteLine($"Current purchases {_surname} {_name}: " + "\n");
            for (int i = 0; i < PurchaseAmount; ++i)
            {
                purchases[i].ProductInfo();
            }
        }
        public void TotalCost()
        {
            for (int i = 0; i < PurchaseAmount; ++i)
            {
                _totalCost += purchases[i].GetProductCost;
            }
            Console.WriteLine("\n" + $"Total sum of all purchases {_surname} {_name}: {_totalCost}$" + "\n");
        }

    }
}