using System;

namespace LostInTheWoods.Models
{
	public class Trail
	{
		public static int idIncrement;

		public Trail()
		{
			if (idIncrement == null)
			{
				Random rnd = new Random();
				idIncrement = rnd.Next(1,50000);
			}
			idIncrement++;
			this.trail_id = idIncrement;
		}
		public long trail_id { get; set; }

		public string name { get; set; }

		public string description { get; set; }

		public int length { get; set; }

		public int elevation { get; set; }

		public int longitude { get; set; }

		public int latitude { get; set; }

	}
}