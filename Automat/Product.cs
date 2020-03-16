using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat
{
    class Product
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string brand;

		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}
		private int number;

		public int Number
		{
			get { return number; }
			set { number = value; }
		}
		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; }
		}
		public Product()
		{

		}


	}
}
