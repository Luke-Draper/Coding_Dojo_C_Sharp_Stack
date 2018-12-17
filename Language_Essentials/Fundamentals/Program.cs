using System;

namespace Fundamentals
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Printing 1-255");
			for (int i = 1; i < 256; i++)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("Printing 1-100 where divisible by 3 or 5");
			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0 && i % 5 != 0)
				{
					Console.WriteLine(i);
				}
				else if (i % 5 == 0 && i % 3 != 0)
				{
					Console.WriteLine(i);
				}
			}

			Console.WriteLine("Loop FizzBuzz");
			for (int i = 1; i < 101; i++)
			{
				if (i % 3 == 0)
				{
					Console.Write("Fizz");
				}
				if (i % 5 == 0)
				{
					Console.Write("Buzz");
				}
				if (i % 3 == 0 || i % 5 == 0)
				{
					Console.WriteLine();
				}
			}
		}
	}
}
