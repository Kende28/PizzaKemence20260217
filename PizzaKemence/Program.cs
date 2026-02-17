namespace PizzaKemence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaKemence pizzaKemence = new PizzaKemence(5);
            Kiszallitas kiszallitas = new Kiszallitas(3);
            Rendeles rendeles = new Rendeles(2);

            Sef sef1 = new Sef(pizzaKemence, rendeles);
			Sef sef2 = new Sef(pizzaKemence, rendeles);
			Futar futar = new Futar(pizzaKemence, kiszallitas);
            Vevo vevo1 = new Vevo(kiszallitas, rendeles);
			Vevo vevo2 = new Vevo(kiszallitas, rendeles);

			Thread sefSzal1 = new Thread(sef1.KiveszPizza);
			Thread sefSzal2 = new Thread(sef2.KiveszPizza);
			Thread futarSzal = new Thread(futar.KiviszPizza);
            Thread vevoSzal1 = new Thread(vevo1.AtveszPizza);
			Thread vevoSzal2 = new Thread(vevo2.AtveszPizza);
            Thread vevoRendelSzal1 = new Thread(vevo1.RendelPizza);
			Thread vevoRendelSzal2 = new Thread(vevo2.RendelPizza);

			sefSzal1.Start();
			sefSzal2.Start();
            futarSzal.Start();
            vevoSzal1.Start(); 
            vevoSzal2.Start();
            vevoRendelSzal1.Start();
            vevoRendelSzal2.Start();
		}
    }
}
