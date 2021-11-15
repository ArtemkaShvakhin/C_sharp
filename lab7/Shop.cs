using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    static class Shop
    {
        private static double _profit = 0;
        private static Dictionary<string, Product> shopProducts = new Dictionary<string, Product>();
        private static List<Person> clients = new List<Person>();
        public static void AddProduct(Product pr)
        {
            shopProducts.Add(pr.GetProduct, pr);
        }
        public static void RemoveProduct(Product pr)
        {
            shopProducts.Remove(pr.GetProduct);
        }
        public static int GetShopProductsCount()
        {
            return shopProducts.Count;
        }
        public static bool FindProduct(Product pr)
        {
            return shopProducts.ContainsKey(pr.GetProduct);
        }
        public static void PrintProducts()
        {
            foreach (var pr in shopProducts)
            {
                Console.WriteLine($"{pr.Key}:" + "\t" + $"{pr.Value.GetProductName} " + $"{pr.Value.GetProductCost}$");
            }
        }        
        public static void AddClient(Person pers)
        {
            clients.Add(pers);
        }
        public static void RemoveClient(Person pers)
        {
            clients.Remove(pers);
        }
        public static bool FindClient(Person pers)
        {
            return clients.Contains(pers);
        }
        public static void PrintClients()
        {
            for (int i = 0; i < clients.Count; i++)
            {
                Console.WriteLine($"Client {i + 1}:" + "\n" + "\t" + $"Name: {clients[i].GetName}" + "\n" + "\t" + $"Surname: {clients[i].GetSurname}");
            }
        }
        public static void PrintSortedProducts()
        {
            var result = from temp in shopProducts  
                         orderby temp.Value.GetProductCost    
                         select temp;                         

            foreach (var i in result)
            {
                Console.WriteLine($"{i.Value.GetProduct}");
            }
        }
        public static double Profit()
        {
            var result = from cur in clients
                         select cur;
            foreach(var i in result)
            {
                _profit += i.GetTotalCost();
            }
            return _profit;
        }
        public static string TheRichestClient()
        {
            string name = null;
            var result = clients.OrderByDescending(pers => pers.GetTotalCost()).Take(1);
            foreach (var i in result)
            {
                name = i.GetName;
            }
            
            return name;
        }
        public static uint CountClientsPayedMoreThanMinCost(double min)
        {
            return (uint) (from i in clients where i.GetTotalCost() > min select i).Count();
        }
    }
}
    