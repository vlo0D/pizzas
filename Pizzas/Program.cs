using Pizzas;
using Pizzas.Models;
using System.Configuration;

string fileName = ConfigurationManager.AppSettings["path"];  //From File Pizzas.dll.config

Orders orders = new Orders();

orders.Pizzas = await Serializator.DeserializeFromFile(fileName);       //deserialize

Analyzator analyz = new Analyzator(orders);

analyz.GivePizzasName();    //Give for all pizzas name (first 2 letters)

var topPizzas = analyz.GetTopTen();         //Get top 10 pizzas dictionary. (key - Pizza obj, val - count)

ConsoleUI.ShowTopTen(topPizzas);        //Show pizzas on Console