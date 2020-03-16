using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Machine
    {
		private string color;

		public string Color
		{
			get { return color; }
			set { color = value; }
		}
		private int size;

		public int Size
		{
			get { return size; }
			set { size = value; }
		}
		public Product[] products = new Product[20];

		public Machine()
		{
			products[0] = new SoftDrink("Coke", 1, 18, "Bottle"); 
			products[1] = new SoftDrink("Pepsi", 2, 18, "Bottle");
			products[2] = new SoftDrink("Faxe Kondi", 3, 18, "Can");
			products[3] = new SoftDrink("Fanta", 4, 18, "Bottle");
			products[4] = new SoftDrink("Mountain Dew", 5, 18, "Can");
			products[5] = new Snack("Kims Salted", 6, 15, "Chips");
			products[6] = new Snack("Kims Sour Cream & Onion", 7, 15, "Chips");
		}
	}
}
