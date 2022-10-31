using Pizzas;
using Pizzas.Models;

string fileName = @"..\..\..\Data\pizzas1.json";    //need use app config

Orders orders = new Orders();

orders.Pizzas = await Serializator.DeserializeFromFile(fileName);       //deserialize

Analyzator analyz = new Analyzator(orders);

analyz.GivePizzasName();    //Give for all pizzas name (first 2 letters)

var topPizzas = analyz.GetTopTen();         //Get top 10 pizzas dictionary. (key - Pizza obj, val - count)

Console.WriteLine("Top 10 Pizzas:\n");

foreach(var pizza in topPizzas)
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