using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _veg
{
	 class Vegan1

	{
		public string ingredient1;
		public string ingredient2;
		public double cantidad1 { get; }
		public double cantidad2 { get; }
		

		public Vegan1(double acantidad1, string aingredient1, double acantidad2, string aingredient2)
		{
			ingredient1 = aingredient1;
			ingredient2 = aingredient2;
			cantidad1 = acantidad1;
			cantidad2 = acantidad2;

		}
	}
}
