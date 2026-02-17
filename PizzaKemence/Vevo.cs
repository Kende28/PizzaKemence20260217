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


		public Vevo( Kiszallitas kiszallitas)
		{
			this.kiszallitas = kiszallitas;
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
	}
}
