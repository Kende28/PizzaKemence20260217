namespace PizzaKemence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaKemence pizzaKemence = new PizzaKemence(5);

            Sef sef = new Sef(pizzaKemence);
            Futar futar = new Futar(pizzaKemence);

            
        }
    }
}
