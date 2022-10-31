namespace Pizzas.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public List<string>? Toppings { get; set; }
    }
}
