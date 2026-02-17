namespace PizzaKemence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaKemence pizzaKemence = new PizzaKemence(5);

            Sef sef = new Sef(pizzaKemence);
			Futar futar = new Futar(pizzaKemence);

            Thread sefSzal1 = new Thread(sef.FeladPizza);
			Thread sefSzal2 = new Thread(sef.FeladPizza);
			Thread futarSzal = new Thread(futar.KiveszPizza);

            sefSzal1.Start();
			sefSzal2.Start();
            futarSzal.Start();
		}
    }
}
