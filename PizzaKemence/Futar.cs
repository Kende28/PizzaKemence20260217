using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class Futar
	{
		private PizzaKemence pizzaKemence;

		public Futar(PizzaKemence pizzaKemence) 
		{
			this.pizzaKemence = pizzaKemence;
		}

		public void KiveszPizza()
		{
			while (true)
			{
				Pizza pizza = pizzaKemence.KiveszPizza();
				Console.WriteLine($"Futár szállította: {pizza}");
				Thread.Sleep(pizza.Meret * 100);
			}
		}
	}
}
