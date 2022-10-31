using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas
{
    public static class ConsoleUI
    {
        public static void ShowTopTen(Dictionary<Pizza, int> topPizzas)
        {
            Console.WriteLine("Top 10 Pizzas:\n");

            foreach (var pizza in topPizzas)
            {
                Console.WriteLine($"Name: '{pizza.Key.Name}'. Orders: {pizza.Value}");
                Console.WriteLine("Toppings:");
                foreach (var top in pizza.Key.Toppings)
                {
                    Console.WriteLine(top);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
