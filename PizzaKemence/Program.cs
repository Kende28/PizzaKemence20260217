namespace PizzaKemence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaKemence pizzaKemence = new PizzaKemence(5);
            Kiszallitas kiszallitas = new Kiszallitas(3);

            Sef sef1 = new Sef(pizzaKemence);
			Sef sef2 = new Sef(pizzaKemence);
			Futar futar = new Futar(pizzaKemence, kiszallitas);
            Vevo vevo1 = new Vevo(kiszallitas);
			Vevo vevo2 = new Vevo(kiszallitas);

			Thread sefSzal1 = new Thread(sef1.KiveszPizza);
			Thread sefSzal2 = new Thread(sef2.KiveszPizza);
			Thread futarSzal = new Thread(futar.KiviszPizza);
            Thread vevoSzal1 = new Thread(vevo1.AtveszPizza);
			Thread vevoSzal2 = new Thread(vevo2.AtveszPizza);

			sefSzal1.Start();
			sefSzal2.Start();
            futarSzal.Start();
            vevoSzal1.Start(); 
            vevoSzal2.Start();
		}
    }
}
