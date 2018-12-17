using System;
using System.Collections.Generic;

/*
Three Basic Arrays
Create an array to hold integer values 0 through 9
Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
Create an array of length 10 that alternates between true and false values, starting with true

List of Flavors
Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
Output the length of this list after building it
Output the third flavor in the list, then remove this value
Output the new length of the list (It should just be one fewer!)

User Info Dictionary
Create a dictionary that will store both string keys as well as string values
For each name in the array of names you made previously, add it as a new key in this dictionary with value null
For each name key, select a random flavor from the flavor list above and store it as the value
Loop through the dictionary and print out each user's name and their associated ice cream flavor
*/


namespace Collections_Practice
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();

			int[] arr1 = new int[] {0,1,2,3,4,5,6,7,8,9};
			string[] arr2 = new string[] {"Tim", "Martin", "Nikki", "Sara"};
			bool[] arr3 = new bool[] {true,false,true,false,true,false,true,false,true,false};

			List<string> list1 = new List<string>();
			list1.Add("Vanilla");
			list1.Add("Chocolate");
			list1.Add("Strawberry");
			list1.Add("Neopolitan");
			list1.Add("Mint");
			Console.WriteLine(list1.Count);
			Console.WriteLine(list1[2]);
			list1.RemoveAt(2);
			Console.WriteLine(list1.Count);

			Dictionary<string,string> dict1 = new Dictionary<string,string>();
			foreach (string name in arr2) {
				dict1.Add(name,list1[rnd.Next(4)]);
			}
			foreach (var entry in dict1) {
				Console.WriteLine("Name: "+entry.Key+", Favorite Flavor: "+entry.Value);
			}
		}
	}
}
