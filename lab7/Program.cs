using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double _minCost = 0.2;
            //Creating products
            Product pr1 = new Product("Молоко", "Деревенское", 1.2);
            Product pr2 = new Product("Газированная вода", "Дарида", 0.8);
            Product pr3 = new Product("Лотерейный билет", "Счастливый", 0.4);
            Product pr4 = new Product("Хлеб", "Пряный", 1);
            Product pr5 = new Product("Чай", "Greenfield", 2.3);
            Product pr6 = new Product("Конфеты", "Roshen", 5.5);
            //Creating people
            Person pers1 = new Person("Артём", "Дембовский");
            Person pers2 = new Person("Бронеслав", "Гданьск-й");
            //Adding products 
            Shop.AddProduct(pr1);
            Shop.AddProduct(pr2);
            Shop.AddProduct(pr3);
            Shop.AddProduct(pr4);
            Shop.AddProduct(pr5);
            Shop.AddProduct(pr6);
            //Adding clients
            Shop.AddClient(pers1);
            Shop.AddClient(pers2);
            //Buying products
            pers1.BuyProduct(pr1);
            pers2.BuyProduct(pr2);
            pers2.BuyProduct(pr5);
            //Linq
            Shop.PrintSortedProducts();
            Console.WriteLine();
            Console.WriteLine(Shop.Profit());
            Console.WriteLine();
            pers2.SumList();
            Console.WriteLine();
            Console.WriteLine($"There are {Shop.CountClientsPayedMoreThanMinCost(_minCost)} people that payed more than {_minCost}$");
            Console.WriteLine();
            Console.WriteLine($"Name of the richest client: {Shop.TheRichestClient()}");
            Console.WriteLine();
            Console.WriteLine($"{pers2.GetName} {pers2.GetSurname} spent {pers2.GetTotalCost()}$");
        }
    }
}
