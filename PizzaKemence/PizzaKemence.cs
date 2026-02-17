using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class PizzaKemence
	{
		private SzinkronPuffer<Pizza> puffer;

		public PizzaKemence(int maximalis)
		{
			this.puffer = new SzinkronPuffer<Pizza>(maximalis);
		}

		public void HozzaadPizza(Pizza p)
		{
			puffer.Hozzaad(p);
		}

		public Pizza KiveszPizza()
		{
			return puffer.Kivesz();
		}
	}
}
