using Pizzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzas
{
    public class Analyzator
    {
        private Orders _orders;

        public Analyzator(Orders orders)
        {
            _orders = orders;
        }

        public void GivePizzasName()
        {
            var pizzas = _orders.Pizzas;
            
            if (pizzas != null)
            {
                foreach (var pizza in pizzas)
                {
                    var str = "";
                    foreach (var top in pizza.Toppings)
                    {
                        str += top.Substring(0, 2);
                    }

                    pizza.Name = str;
                }
            }
        }

        public Dictionary<Pizza, int> GetTopTen()
        {
            var pizzas = _orders.Pizzas;

            Dictionary<Pizza, int> topTenDict = new Dictionary<Pizza, int>();

            var topTenGroup = (from pizza in pizzas
                      group pizza by pizza.Name into g
                      orderby g.Count() descending
                      select new
                      {
                          Name = g.Key,
                          Count = g.Count(),
                      }).Take(10);

            foreach (var pizza in topTenGroup)
            {
                var tempPiz = pizzas.First(x => x.Name == pizza.Name);

                topTenDict.Add(tempPiz, pizza.Count);
            }

            return topTenDict;
        }
    }
}
