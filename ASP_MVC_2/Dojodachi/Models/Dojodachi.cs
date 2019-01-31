using System;

namespace Dojodachi.Models
{
	public class Dachi
	{
		public Dachi() {
			_rand = new Random();
			_alive = true;
			_happiness = 20;
			_fullness = 20;
			_energy = 50;
			_meals = 3;
		}

		private Random _rand;

		private bool _alive;
		public bool Alive
		{
			get {return _alive;}
			set {_alive = value;}
		}

		private int _happiness;
		public int Happiness
		{
			get {return _happiness;}
			set 
			{
				if (value > 0)
				{
					_happiness = value;
				}
				else
				{
					Alive = false;
					_happiness = 0;
				}
			}
		}

		private int _fullness;
		public int Fullness
		{
			get {return _fullness;}
			set 
			{
				if (value > 0)
				{
					_fullness = value;
				}
				else
				{
					Alive = false;
					_fullness = 0;
				}
			}
		}

		private int _energy;
		public int Energy
		{
			get {return _energy;}
			set 
			{
				if (value > 0)
				{
					_energy = value;
				}
				else
				{
					_energy = 0;
				}
			}
		}

		private int _meals;
		public int Meals
		{
			get {return _meals;}
			set 
			{
				if (value > 0)
				{
					_meals = value;
				}
				else
				{
					_meals = 0;
				}
			}
		}

		public Dachi Feed() {
			if(this.Meals > 0)
			{
				if(_rand.Next(0,4)!=0)
				{
					this.Fullness += _rand.Next(5,11);
				}
				this.Meals--;
			}
			return this;
		}

		public Dachi Play() {
			if(this.Energy >= 5)
			{
				if(_rand.Next(0,4)!=0)
				{
					this.Happiness += _rand.Next(5,11);
				}
				this.Energy-=5;
			}
			return this;
		}

		public Dachi Work() {
			if(this.Energy >= 5)
			{
				this.Meals+=_rand.Next(1,4);
				this.Energy-=5;
			}
			return this;
		}

		public Dachi Sleep() {
			this.Fullness-=5;
			this.Happiness-=5;
			this.Energy+=15;
			return this;
		}

		public bool HasWon() {
			if (this.Fullness >= 100 && this.Energy >= 100 && this.Happiness >= 100)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		

	}
}