using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class Sef
	{
		private PizzaKemence pizzaKemence;
		private static Random r = new Random();
		private static string[] pizzak = { "Pepperoni", "Margherita", "Hawaii", "Prosciutto", "Frutti di mare"}; 
		private Rendeles rendeles;
		public Sef(PizzaKemence kemence, Rendeles rendeles)
		{
			this.pizzaKemence = kemence;
			this.rendeles = rendeles;
		}

		public void KiveszPizza()
		{
			while (true)
			{
				if (rendeles.FelveszPizza())
				{
					Console.WriteLine("Séf felvette a rendelést");
				} 
				Thread.Sleep(r.Next(2, 4) * 1000);
				string pizzaNev = pizzak[r.Next(pizzak.Length)];
				int meret = r.Next(20, 41);
				Pizza pizza = new Pizza(pizzaNev, meret);

				pizzaKemence.HozzaadPizza(pizza);
				Console.WriteLine($"Séf készítette: {pizza}");
			}
		}
	}
}
