using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class Rendeles
	{
		SzinkronPuffer<bool> puffer;
		public Rendeles(int max)
		{
			this.puffer = new SzinkronPuffer<bool>(max);
		}

		public void RendelPizza(bool rendel)
		{
			puffer.Hozzaad(rendel);
		}

		public bool FelveszPizza()
		{
			return puffer.Kivesz();
		}
	}
}
