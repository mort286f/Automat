using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Snack:Product
    {
		private int amount;

		public int Amount
		{
			get { return amount; }
			set { amount = value; }
		}
		private string type;

		public string Type
		{
			get { return Type; }
			set { type = value; }
		}
		public Snack(string name, int number, double price, string type)
		{
			this.Name = name;
			this.Number = number;
			this.Price = price;
			this.Type = type;
		}
	}
}
