using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaKemence
{
	internal class SzinkronPuffer<T>
	{
		private Queue<T> sor;
		private int maximalis;
		private readonly object zar = new object();

		public SzinkronPuffer(int maximalis)
		{
			this.maximalis = maximalis;
			this.sor = new Queue<T>();
		}

		public void Hozzaad(T elem)
		{
			lock (zar)
			{
				while (sor.Count == maximalis)
				{
					Monitor.Wait(zar);
				}

				sor.Enqueue(elem);
				Monitor.PulseAll(zar);
			}
		}

		public T Kivesz()
		{
			lock (zar)
			{
				while (sor.Count == 0)
				{
					Monitor.Wait(zar);
				}

				T elem = sor.Dequeue();
				Monitor.PulseAll(zar);
				return elem;
			}
		}
	}
}
