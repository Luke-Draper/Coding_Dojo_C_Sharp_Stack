using System;

namespace Wiz_Nin_Sam
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
		protected static Random rnd = new Random();

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

		public Human(string name, int strength=3, int intelligence=3, int dexterity=3, int health=100)
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

		public void RecieveHealth(int healthRecieved)
		{
			_health = Health + healthRecieved;
		}

	}

	public class Wizard : Human
	{

		public Wizard(string name) : base(name, 3, 25, 3, 50) {}

		public new void Attack(Human target)
		{
			target.DealDamage(5*Intelligence);
			RecieveHealth(5*Intelligence);
		}

		public void Heal(Human target)
		{
			target.RecieveHealth(10*Intelligence);
		}

	}

	public class Ninja : Human
	{

		public Ninja(string name) : base(name, 3, 3, 175, 100) {}

		public new void Attack(Human target)
		{
			int dmg = 5*Dexterity;
			if (rnd.Next(5) < 1)
			{
				dmg += 10;
			}
			target.DealDamage(dmg);
		}

		public void Steal(Human target)
		{
			target.DealDamage(5);
			RecieveHealth(5);
		}

	}

	public class Samurai : Human
	{

		public Samurai(string name) : base(name, 3, 3, 3, 200) {}

		public new void Attack(Human target)
		{
			base.Attack(target);
			if (target.Health < 50)
			{
				target.DealDamage(target.Health);
			}
		}

		public void Meditate()
		{
			RecieveHealth(100-Health);
		}

	}
}
