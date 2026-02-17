using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class Kiszallitas
	{
		SzinkronPuffer<Pizza> puffer;

		public Kiszallitas(int max) 
		{
			this.puffer = new SzinkronPuffer<Pizza>(max);
		}

		public void AtadPizza(Pizza pizza) 
		{
			puffer.Hozzaad(pizza);
		}

		public Pizza AtveszPizza()
		{
			return puffer.Kivesz();
		}
	}
}
