using System;

namespace Basic_13
{
	class Program
	{
		static void Main(string[] args)
		{
			PrintNumbers();
			PrintOdds();
			PrintSum();
			int[] arr1 = new int[] {1,2,3,4,5,6};
			LoopArray(arr1);
			FindMax(arr1);
			GetAverage(arr1);
			OddArray();
			GreaterThanY(arr1,3);
			SquareArrayValues(arr1);
			EliminateNegatives(arr1);
			MinMaxAverage(arr1);
			ShiftValues(arr1);
			NumToString(arr1);
		}
	
		public static void PrintNumbers()
		{
			// Print all of the integers from 1 to 255.
			Console.WriteLine("PrintNumbers");
			for (int i = 1; i < 256; i++)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine();
		}

		public static void PrintOdds()
		{
			// Print all of the odd integers from 1 to 255.
			Console.WriteLine("PrintOdds");
			for (int i = 1; i < 256; i+=2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine();
		}

		public static void PrintSum()
		{
			// Print all of the numbers from 0 to 255, 
			// but this time, also print the sum as you go. 
			// For example, your output should be something like this:
			
			// New number: 0 Sum: 0
			// New number: 1 Sum: 1
			// New Number: 2 Sum: 3
			Console.WriteLine("PrintSum");
			int accumulator = 0;
			for (int i = 1; i < 256; i++)
			{
				accumulator += i;
				Console.WriteLine("New Number: "+i+" Sum: "+accumulator);
			}
			Console.WriteLine();
		}

		public static void LoopArray(int[] numbers)
		{
			// Write a function that would iterate through each item of the given integer array and 
			// print each value to the console.
			Console.WriteLine("LoopArray");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}
			Console.WriteLine();
		}

		public static int FindMax(int[] numbers)
		{
			// Write a function that takes an integer array and prints and returns the maximum value in the array. 
			// Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
			// or even a mix of positive numbers, negative numbers and zero.
			Console.WriteLine("FindMax");
			int maximum = numbers[0];
			for (int i = 1; i < numbers.Length; i++)
			{
				if (maximum < numbers[i])
				{
					maximum = numbers[i];
				}
			}
			Console.WriteLine(maximum);
			Console.WriteLine();
			return maximum;
		}

		public static void GetAverage(int[] numbers)
		{
			// Write a function that takes an integer array and prints the AVERAGE of the values in the array.
			// For example, with an array [2, 10, 3], your program should write 5 to the console.
			Console.WriteLine("GetAverage");
			int accumulator = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				accumulator += numbers[i];
			}
			Console.WriteLine((float)accumulator/(float)numbers.Length);
			Console.WriteLine();
		}

		public static int[] OddArray()
		{
			// Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
			// When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
			Console.WriteLine("OddArray");
			int[] output = new int[128];
			for (int i = 0; i < output.Length; ++i)
			{
				output[i] = 2*i+1;
			}
			Console.WriteLine();
			return output;
		}

		public static int GreaterThanY(int[] numbers, int y)
		{
			// Write a function that takes an integer array, and a integer "y" and returns the number of array values 
			// That are greater than the "y" value. 
			// For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
			// (since there are two values in the array that are greater than 3).
			Console.WriteLine("GreaterThanY");
			int accumulator = 0;
			for (int i = 0; i < numbers.Length; i++)
			{
				if (y < numbers[i])
				{
					accumulator++;
				}
			}
			Console.WriteLine();
			return accumulator;
		}

		public static void SquareArrayValues(int[] numbers)
		{
			// Write a function that takes an integer array "numbers", and then multiplies each value by itself.
			// For example, [1,5,10,-10] should become [1,25,100,4]
			Console.WriteLine("SquareArrayValues");
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = numbers[i]*numbers[i];
			}
			Console.WriteLine();
		}

		public static void EliminateNegatives(int[] numbers)
		{
			// Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
			// When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
			Console.WriteLine("EliminateNegatives");
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i]<0)
				{
					numbers[i] = 0;
				}
			}
			Console.WriteLine();
		}

		public static void MinMaxAverage(int[] numbers)
		{
			// Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
			// the minimum value in the array, and the average of the values in the array.
			Console.WriteLine("FindMax");
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
			Console.WriteLine("Average: "+(float)accumulator/(float)numbers.Length);
			Console.WriteLine();
		}

		public static void ShiftValues(int[] numbers)
		{
			// Given an integer array, say [1, 5, 10, 7, -2], 
			// Write a function that shifts each number by one to the front and adds '0' to the end. 
			// For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
			// it should become [5, 10, 7, -2, 0].
			Console.WriteLine("ShiftValues");
			for (int i = 1; i < numbers.Length-1; i++)
			{
				numbers[i] = numbers[i+1];
			}
			numbers[numbers.Length-1] = 0;
			Console.WriteLine();
		}

		public static object[] NumToString(int[] numbers)
		{
			// Write a function that takes an integer array and returns an object array 
			// that replaces any negative number with the string 'Dojo'.
			// For example, if array "numbers" is initially [-1, -3, 2] 
			// your function should return an array with values ['Dojo', 'Dojo', 2].
			Console.WriteLine("NumToString");
			object[] output = new object[numbers.Length];
			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i]<0)
				{
					output[i] = "Dojo";
				}
				else
				{
					output[i] = numbers[i];
				}
			}
			Console.WriteLine();
			return output;
		}
	}
}