using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Person
    {
        private List<Product> products = new List<Product>();
        private string _name, _surname;
        private double _totalCost;
        public Person(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
        public string GetName
        { 
            get { return _name; }
        }
        public string GetSurname
        {
            get { return _surname; }
        }
        public void BuyProduct(Product pr)
        {
            if(!Shop.FindClient(this))
            {
                Console.WriteLine("You're not a client of this shop. You can't buy anything!");
            }
            else if(Shop.FindProduct(pr))
            {
                Console.WriteLine("Purchase finish successfully!");
                Shop.RemoveProduct(pr);
                products.Add(pr);
                _totalCost += pr.GetProductCost;
            }
            else
            {
                Console.WriteLine($"Unfortunately there isnt {pr.GetProduct} \"{pr.GetProductName}\" in our shop(");
            }
        }
        public double GetTotalCost()
        {
            return products.Sum(pr => pr.GetProductCost);
        }
        public void PrintProducts()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"\nClient: {GetName} {_surname}:" + "\n\t" + $"Product {i + 1}:\t" + 
                    $"{products[i].GetProduct} {products[i].GetProductName} {products[i].GetProductCost}$");
            }
        }
        public void SumList()
        {
            var result = products.GroupBy(pr => pr.GetProductCost);
            Console.WriteLine($"Sumlist of {GetName} {_surname}:");
            foreach (var i in result)
            {
                Console.WriteLine($"{i.Key}$");
            }
        }
    }
}
