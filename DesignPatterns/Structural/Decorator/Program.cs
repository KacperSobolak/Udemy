namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var pizzaBase = new MediumPizza();
            var mediumPizzaWithCheese = new CheesePizzaDecorator(pizzaBase);

            Console.WriteLine($"Medium pizza with cheese = {mediumPizzaWithCheese.CalculatePrice()}");

            var p2 = new SalamiPizzaDecorator(mediumPizzaWithCheese);

            Console.WriteLine($"Medium pizza with cheese and salami = {p2.CalculatePrice()}");

            var doubleSalamiCheesePizza = new SalamiPizzaDecorator(p2);

            Console.WriteLine($"Medium pizza with double salami and cheese = {doubleSalamiCheesePizza.CalculatePrice()}");
        }
    }
}
