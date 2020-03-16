using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class SoftDrink:Product
    {
		private int amount;

		public int Amount
		{
			get { return amount; }
			set { amount = value; }
		}
		private string container;

		public string Container
		{
			get { return container; }
			set { container = value; }
		}
		public SoftDrink(string name, int number, double price, string container)
		{
			this.Name = name;
			this.Number = number;
			this.Price = price;
			this.Container = container;
		}
	}
}
