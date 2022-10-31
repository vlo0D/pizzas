using Pizzas.Models;
using System.Text.Json;

namespace Pizzas
{
    public static class Serializator
    {
        public static async Task<List<Pizza>> DeserializeFromFile(string fileName)
        {
            List<Pizza> allPizzas = new List<Pizza>();

            try
            {
                using FileStream openStream = File.OpenRead(fileName);
                allPizzas = await JsonSerializer.DeserializeAsync<List<Pizza>>(openStream);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return allPizzas;
        }
    }
}
