using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _veg
{
	internal class Vegan2
	{
		public string ingredient1;
		public double cantidad1 { get; }

		public Vegan2(double acantidad1, string aingredient1)
		{
			ingredient1 = aingredient1;
			cantidad1 = acantidad1;
		}
	}
}
