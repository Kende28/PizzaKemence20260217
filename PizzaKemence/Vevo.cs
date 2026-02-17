using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class Vevo
	{
		private List<Pizza> elozmeny = new List<Pizza>();
		private Kiszallitas kiszallitas;
		private Rendeles rendeles;

		public Vevo( Kiszallitas kiszallitas, Rendeles rendeles)
		{
			this.kiszallitas = kiszallitas;
			this.rendeles = rendeles;
		}

		public void AtveszPizza()
		{
			while (true)
			{
				Pizza pizza = kiszallitas.AtveszPizza();
				elozmeny.Add(pizza);
				Console.WriteLine($"Vevő átvette: {pizza}");
				Console.WriteLine($"A vevő eddigi rendeléseinek száma: {elozmeny.Count()}");
			}
		}

		public void RendelPizza()
		{
			while (true)
			{
				rendeles.RendelPizza(true);
				Console.WriteLine($"Vevő rendelt pizzát");
				Thread.Sleep(5000);
			}
		}
	}
}
