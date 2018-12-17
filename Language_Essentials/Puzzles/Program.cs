using System;
using System.Collections.Generic;

namespace Puzzles
{
	class Program
	{

		static Random rnd = new Random();

		static void Main(string[] args)
		{
			RandomArray();
			TossCoin();
			Console.WriteLine(TossMultipleCoins(10));
			Names();
		}

		static int[] RandomArray()
		{
			int[] numbers = new int[10];
			for (int i=0; i<10; ++i)
			{
				numbers[i] = rnd.Next(5,26);
			}
			int minimum = numbers[0];
			int maximum = numbers[0];
			int accumulator = numbers[0];
			for (int i = 1; i < numbers.Length; i++)
			{
				if (minimum > numbers[i])
				{
					minimum = numbers[i];
				}
				if (maximum < numbers[i])
				{
					maximum = numbers[i];
				}
				accumulator += numbers[i];
			}
			Console.WriteLine("Minimum: "+minimum);
			Console.WriteLine("Maximum: "+maximum);
			Console.WriteLine("Sum: "+accumulator);
			return numbers;
		}

		static string TossCoin()
		{
			Console.WriteLine("Tossing a Coin!");
			int num = rnd.Next(2);
			if (num==0) {
				Console.WriteLine("Tails");
				return "Tails";
			}
			else
			{
				Console.WriteLine("Heads");
				return "Heads";
			}
		}

		static double TossMultipleCoins(int tosses)
		{
			int heads=0;
			for (int i=0; i<tosses; ++i)
			{
				string coin = TossCoin();
				if (coin == "Heads")
				{
					heads++;
				}
			}
			return (double)heads/(double)tosses;
		}

		static string[] Names()
		{
			string[] base_arr = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
			for (int i=0; i<base_arr.Length-1; ++i)
			{
				string temp = base_arr[i];
				int target = rnd.Next(i+1,base_arr.Length);
				base_arr[i] = base_arr[target];
				base_arr[target] = temp;
			}
			List<string> long_enough = new List<string>();
			foreach (string name in base_arr)
			{
				Console.WriteLine(name);
				if (name.Length > 5)
				{
					long_enough.Add(name);
				}
			}
			return long_enough.ToArray();
		}
	}
}
