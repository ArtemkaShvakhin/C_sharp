using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Product
    {
        private double _cost;
        private string _name, _product;
        public Product(string product, string name, double cost)
        {
            _product = product;
            _name = name;
            _cost = cost;
        }
        public string GetProduct()
        {
            return _product;
        }
        public string GetProductName()
        {
            return _name;
        }
        public double GetProductCost()
        {
            return _cost;
        }
        public void ProductInfo()
        {
            Console.WriteLine($"Product: {_product}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Cost: {_cost}$");
            Console.WriteLine();
        }
    }
}
