using System;

/*
Create a Human class with five fields: name, strength, intelligence, dexterity, and health

Give a default value of 3 for strength, intelligence, and dexterity. Health should have a default of 100.

When an object is constructed from this class it should have the ability to pass a name

Let's create an additional constructor that accepts 5 parameters, so we can set custom values for every field.

Now add a new method called attack, which when invoked, should attack another Human object that is passed as a parameter.
The damage done should be 5 * strength (5 points of damage to the attacked, for each 1 point of strength of the attacker).
*/

namespace Human_Program
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}


	public class Human
	{
		private string _name;

		public string Name { get { return _name; } }

		private int _strength;

		public int Strength { get { return _strength; } }
		
		private int _intelligence;

		public int Intelligence { get { return _intelligence; } }

		private int _dexterity;

		public int Dexterity { get { return _dexterity; } }

		private int _health;

		public int Health { get { return _health; } }

		public Human(string name)
		{
			_name = name;

			_strength = 3;
			_intelligence = 3;
			_dexterity = 3;

			_health = 100;
		}

		public Human(string name, int strength, int intelligence, int dexterity, int health)
		{
			_name = name;

			_strength = strength;
			_intelligence = intelligence;
			_dexterity = dexterity;

			_health = health;
		}

		public void Attack(Human target)
		{
			target.DealDamage(5*Strength);
		}

		public void DealDamage(int damageDealt)
		{
			_health = Health - damageDealt;
		}
	}
}
