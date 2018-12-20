using System;

namespace Phone
{
	class Program
	{
		static void Main(string[] args)
		{
			Galaxy gs8 = new Galaxy("s8", 100, "T-Mobile", "Dooo do doo dooo");
			Nokia n1100 = new Nokia("1100", 60, "Metro PCS", "Ringgg ring ringgg");

			gs8.DisplayInfo();
			Console.WriteLine(gs8.Ring());
			Console.WriteLine(gs8.Unlock());
			Console.WriteLine();

			n1100.DisplayInfo();
			Console.WriteLine(n1100.Ring());
			Console.WriteLine(n1100.Unlock());
			Console.WriteLine();
		}
	}
}
