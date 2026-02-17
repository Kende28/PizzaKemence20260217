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
		private Kiszallitas kiszallitas;

		public Futar(PizzaKemence pizzaKemence, Kiszallitas kiszallitas) 
		{
			this.pizzaKemence = pizzaKemence;
			this.kiszallitas = kiszallitas;
		}

		public void KiviszPizza()
		{
			while (true)
			{
				Pizza pizza = pizzaKemence.KiveszPizza();
				kiszallitas.AtadPizza(pizza);
				Console.WriteLine($"Futár szállította: {pizza}");
				Thread.Sleep(pizza.Meret * 100);
			}
		}
	}
}
