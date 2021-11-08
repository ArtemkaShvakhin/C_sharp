using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    static class Shop
    {
        private static uint _productAmount;
        private static MyCustomCollections<Product> store = new MyCustomCollections<Product>();
        public static void AddProduct(string product, string name, double cost)
        {
            Product pr = new Product(product, name, cost);
            store.Add(pr);
            _productAmount++;
        }
        public static void RemoveProduct(string product, string name, double cost)
        {
            Product pr = new Product(product, name, cost);
            store.Remove(pr);
            _productAmount--;
        }
        public static bool Availability(string product, string name, double cost)
        {
            Product temp = new Product(product, name, cost);
            for (int i = 0; i < _productAmount; ++i)
            {
                if (store[i].GetProduct() == product && store[i].GetProductName() == name && store[i].GetProductCost() == cost)
                {
                    store.Remove(store[i]);
                    _productAmount--;
                    return true;
                }
            }
            return false;
        }
        public static uint Amount()
        {
            return _productAmount;
        }
    }
}