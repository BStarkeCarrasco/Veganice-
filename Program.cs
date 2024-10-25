namespace _veg
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				//Variablen ingredient no veg
				int noVeg;
				string veg;
				double amount;

				//Variablen type of cooking
				int cookingMethod = 0;


				//Enter no veg ingredient
				Console.WriteLine("Enter the ingredient you want to replace:\n1. Milk \n2. Egg \n3. Egg White \n4. Honey \n5. Butter \n6. Cream \n7. Buttermilk");
				noVeg = int.Parse(Console.ReadLine());

				//Enter type of cooking
				Console.WriteLine("Enter the cooking method required for your recipe:\n1. hot \n2. cold");
				cookingMethod = int.Parse(Console.ReadLine());

				//Enter the amount of ingredient

				amount = IngredientAmount(noVeg);
                Console.WriteLine("\n");


				//Console.WriteLine("Enter the amount of ingredient that your recipe requires in \nUnits (egg, eggwhite) \nGrams (butter, cream) \nMililiters (milk, buttermilk, honey) ");
				//amount = int.Parse(Console.ReadLine());



				//Veg substitutes for Egg

				Vegan1 egg_01 = new Vegan1(1, "Spoon of grounded flaxseed", 3, "Spoons of water"); //cold
				Vegan2 egg_02 = new Vegan2(1, "Mashed Banana");										//hot
				Vegan2 egg_03 = new Vegan2(1, "Cup of Applesauce");									//hot
				Vegan2 egg_04 = new Vegan2(3, "Spoons of peanut butter");							//hot


				//Veg subtitues for Milk

				Vegan2 milk_01 = new Vegan2(1, "Mililiters of Soya milk");							//cold
				Vegan2 milk_02 = new Vegan2(1, "Mililiters of Almond milk");						//hot
				Vegan2 milk_03 = new Vegan2(1, "Mililiters of Rice milk");							//cold
				Vegan2 milk_04 = new Vegan2(1, "Mililiters of Oat milk");							//hot

				//Vegan substitutes for Butter

				Vegan2 butter_01 = new Vegan2(1, "Grams of Margarine");								//cold
				Vegan2 butter_02 = new Vegan2(0.5, "Grams of Olive oil");							//hot
				Vegan2 butter_03 = new Vegan2(0.5, "Grams of Nutbutter");							//hot


				//Vegan substitutes for Cream

				Vegan2 cream_01 = new Vegan2(1, "Grams of Silk tofu");								//hot-cold
				Vegan2 cream_02 = new Vegan2(1, "Grams of just the fat of Coconut cream");			//hot-cold


				//Vegan substitutes for Buttermilk

				Vegan1 buttermilk_01 = new Vegan1(1, "Mililiters of Soya milk", 2, "Spoons of Vinegar");	//hot-cold

				//Vegan substitutes for Eggwhite
				Vegan2 eggwhite_01 = new Vegan2(100, "Mililiters of Aquafaba");						//hot-cold

				//Vegan substitutes for Honey
				Vegan2 honey_01 = new Vegan2(1, "Mililiters of Agave syrup");						//hot
				Vegan2 honey_02 = new Vegan2(1, "Mililiters of Date syrup");						//hot
				Vegan2 honey_03 = new Vegan2(1, "Mililiters of Maple syrup");						//cold



				if (noVeg == 2 && cookingMethod != 1)
				{
					Console.WriteLine($"You can use: {egg_01.cantidad1 * amount} {egg_01.ingredient1} and {egg_01.cantidad2 * 3} {egg_01.ingredient2}");	
				}
				else if (noVeg == 2 && cookingMethod == 1)
				{
					Console.WriteLine($"You can use: {egg_02.cantidad1 * 0.5} {egg_02.ingredient1}");
					Console.WriteLine($"Or you can use: {egg_03.cantidad1 * 0.25} {egg_03.ingredient1}");
					Console.WriteLine($"Or you can use: {egg_04.cantidad1 * 3} {egg_04.ingredient1}");
				}
				else if (noVeg == 1 && cookingMethod != 1)
				{
					Console.WriteLine($"You can use: {milk_01.cantidad1 * amount} {milk_01.ingredient1}");
					Console.WriteLine($"Or you can use: {milk_03.cantidad1 * amount} {milk_03.ingredient1}");
				}
				else if (noVeg == 1 && cookingMethod == 1)
				{
					Console.WriteLine($"You can use: {milk_02.cantidad1 * amount} {milk_02.ingredient1}");
					Console.WriteLine($"Or you can use: {milk_04.cantidad1 * amount} {milk_04.ingredient1}");
				}
				else if (noVeg == 3)
				{
					Console.WriteLine($"You can use: {eggwhite_01.cantidad1 * amount} {eggwhite_01.ingredient1}");
				}
				else if (noVeg == 4 && cookingMethod != 1)
				{
					Console.WriteLine($"You can use: {honey_02.cantidad1 * amount} {honey_02.ingredient1}");
					Console.WriteLine($"Or you can use: {honey_03.cantidad1 * amount} {honey_03.ingredient1}");
				}
				else if (noVeg == 4 && cookingMethod == 1)
				{
					Console.WriteLine($"You can use: {honey_01.cantidad1 * amount} {honey_01.ingredient1}");
				}
				else if (noVeg == 5 && cookingMethod != 1)
				{
					Console.WriteLine($"You can use: {butter_01.cantidad1 * amount} {butter_01.ingredient1}");
				}
				else if (noVeg == 5 && cookingMethod == 1)
				{
					Console.WriteLine($"You can use: {butter_02.cantidad1 * amount} {butter_02.ingredient1}");
					Console.WriteLine($"Or you can use: {butter_03.cantidad1 * amount} {butter_03.ingredient1}");
				}
				else if (noVeg == 6)
				{
					Console.WriteLine($"You can use: {cream_01.cantidad1 * amount} {cream_01.ingredient1}");
					Console.WriteLine($"Or you can use: {cream_02.cantidad1 * amount} {cream_02.ingredient1}");
				}
				else if (noVeg == 7)
				{
					Console.WriteLine($"You can use: {buttermilk_01.cantidad1 * amount} {buttermilk_01.ingredient1} and {buttermilk_01.cantidad2} {buttermilk_01.ingredient2}");
				}

                Console.WriteLine("\n \n ---------------------------------------------- \n \n");
			}

        }
		static double IngredientAmount(int ingredientChoice)
		{
			double amount = 0;
			switch (ingredientChoice)
			{
				case 1:
				case 7:
				case 4:
                    Console.WriteLine("Enter the amount of ingredient in mililiters:");
					amount = double.Parse(Console.ReadLine());
					break;
				case 2:
				case 3:
					Console.WriteLine("Enter the amount of ingredient in units:");
					amount = double.Parse(Console.ReadLine());
					break;
				case 5:
				case 6:
					Console.WriteLine("Enter the amount of ingredient in grams:");
					amount = double.Parse(Console.ReadLine());
					break;
				default:
                    Console.WriteLine("Invalid choice. Please enter a valid amount.");
					break;
			}
			return amount;	
		}
	
		
	}
}
