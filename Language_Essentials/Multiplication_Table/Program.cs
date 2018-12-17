using System;

namespace Multiplication_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] xValues = new int[] {1,2,3,4,5,6,7,8,9,10};
			int[] yValues = new int[] {1,2,3,4,5,6,7,8,9,10};
			int[,] mult_table = new int[xValues.Length,yValues.Length];
			for (int x = 0; x < xValues.Length; ++x)
			{
				for (int y = 0; y < yValues.Length; ++y)
				{
					mult_table[x,y] = xValues[x]*yValues[y];
				}
			}
			for (int x = 0; x < xValues.Length; ++x)
			{
				Console.Write("[\t");
				for (int y = 0; y < yValues.Length; ++y)
				{
					Console.Write(mult_table[x,y]);
					if (y != yValues.Length-1)
					{
						Console.Write(",");
					}
					Console.Write("\t");
				}
				Console.WriteLine("]");
			}
		}
	}
}
