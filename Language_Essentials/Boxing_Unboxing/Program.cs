using System;
using System.Collections.Generic;

namespace Boxing_Unboxing
{
	class Program
	{
		static void Main(string[] args)
		{
			List<object> list1 = new List<object>();
			list1.Add(7);
			list1.Add(28);
			list1.Add(-1);
			list1.Add(true);
			list1.Add("chair");

			int accumulator = 0;
			foreach (object item in list1)
			{
				Console.WriteLine(item);
				if (item is int)
				{
					accumulator += (int)item;
				}
			}
			Console.WriteLine("Sum: "+accumulator);
		}
	}
}
