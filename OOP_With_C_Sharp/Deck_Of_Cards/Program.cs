using System;
using System.Collections.Generic;

/*
string[] base_arr = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
			for (int i=0; i<base_arr.Length-1; ++i)
			{
				string temp = base_arr[i];
				int target = rnd.Next(i+1,base_arr.Length);
				base_arr[i] = base_arr[target];
				base_arr[target] = temp;
			}
*/

namespace Deck_Of_Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}

	public class Card
	{
		public enum CardName {Ace=1, Two=2, Three=3, Four=4, Five=5, Six=6, Seven=7, Eight=8, Nine=9, Ten=10, Jack=11, Queen=12, King=13};

		public static CardName getNameFromValue(int value)
		{
			CardName output = CardName.Ace;
			switch (value)
			{
				case 2:
					output = CardName.Two;
					break;
				case 3:
					output = CardName.Three;
					break;
				case 4:
					output = CardName.Four;
					break;
				case 5:
					output = CardName.Five;
					break;
				case 6:
					output = CardName.Six;
					break;
				case 7:
					output = CardName.Seven;
					break;
				case 8:
					output = CardName.Eight;
					break;
				case 9:
					output = CardName.Nine;
					break;
				case 10:
					output = CardName.Ten;
					break;
				case 11:
					output = CardName.Jack;
					break;
				case 12:
					output = CardName.Queen;
					break;
				case 13:
					output = CardName.King;
					break;
				case 1:
				default:
					break;
			}
			return output;
		}
		public enum CardSuit {Clubs=1, Diamonds=2, Hearts=3, Spades=4};
		
		public static CardSuit getSuitFromValue(int value)
		{
			CardSuit output = CardSuit.Clubs;
			switch (value)
			{
				case 2:
					output = CardSuit.Diamonds;
					break;
				case 3:
					output = CardSuit.Hearts;
					break;
				case 4:
					output = CardSuit.Spades;
					break;
				case 1:
				default:
					break;
			}
			return output;
		}
		private CardName _name;

		private CardSuit _suit;

		public string Name
		{ get {
			if ((int)_name == 1 || (int)_name > 10)
			{
				return _name.ToString();
			}
			else
			{
				return ((int)_name).ToString();
			}
		} }

		public int Value { get { return (int)_name; } }

		public string Suit { get { return _suit.ToString(); } }

		public Card(CardName name, CardSuit suit)
		{
			_name = name;
			_suit = suit;
		}
	}

	
	public class Deck
	{
		static Random rnd = new Random();
		
		List<Card> _cards;

		public void Shuffle()
		{
			Card[] shuffler = _cards.ToArray();
			for (int i=0; i<shuffler.Length-1; ++i)
			{
				Card temp = shuffler[i];
				int target = rnd.Next(i+1,shuffler.Length);
				shuffler[i] = shuffler[target];
				shuffler[target] = temp;
			}
			_cards = new List<Card>(shuffler);
		}

		public void Reset()
		{
			Card[] new_deck = new Card[52];
			int idx = 0;
			for (int s = 1; s <= 4; ++s)
			{
				for (int n = 1; n <= 13; ++n)
				{
					new_deck[idx] = new Card(Card.getNameFromValue(n),Card.getSuitFromValue(s));
					idx++;
				}
			}
			_cards = new List<Card>(new_deck);
		}

		public Card Draw()
		{
			Card output = _cards[_cards.Count-1];
			_cards.RemoveAt(_cards.Count-1);
			return output;
		}

		public Deck()
		{
			_cards = new List<Card>();
			Reset();
			Shuffle();
		}
	}

	public class Player
	{
		private string _name;

		public string Name { get { return _name; } }

		List<Card> _cards;

		public Card Draw(Deck DrawPile)
		{
			Card output = DrawPile.Draw();
			_cards.Add(output);
			return output;
		}

		public Card Discard(int index)
		{
			Card output = null;
			if (index >= 0 && index < _cards.Count)
			{
				output = _cards[index];
				_cards.RemoveAt(index);
			}
			return output;
		}

		public Player(string name)
		{
			_name = name;
			_cards = new List<Card>();
		}

	}


}
