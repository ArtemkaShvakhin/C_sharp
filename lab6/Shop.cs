using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    static class Shop
    {
        private static uint _productAmount;
        private static MyCustomCollections<Product> store = new MyCustomCollections<Product>();
        private static MyCustomCollections<Person> clientList = new MyCustomCollections<Person>();
        public delegate void ChangeClientsList(string name, string description);
        public delegate void ChangeProductList(string name, string description);
        public static event ChangeClientsList NewClient;
        public static event ChangeProductList NewProduct;
        public static void AddProduct(Product pr)
        {
            store.Add(pr);
            _productAmount++;
            NewProduct?.Invoke("New product", $"{pr.GetProduct} {pr.GetProductName} {pr.GetProductCost}");
        }
        public static void RemoveProduct(Product pr)
        {
            store.Remove(pr);
            _productAmount--;
        }
        public static bool Availability(Product pr)
        {
            for (int i = 0; i < _productAmount; ++i)
            {
                if (store[i].GetProduct == pr.GetProduct && store[i].GetProductName == pr.GetProductName && store[i].GetProductCost == pr.GetProductCost)
                {
                    return true;
                }
            }
            return false;
        }
        public static void AddClient(Person pers)
        {
            clientList.Add(pers);
            NewClient?.Invoke("New client", $"{pers.Name} {pers.Surname} was added to client list");
        }
        public static uint Amount()
        {
            return _productAmount;
        }
    }
}