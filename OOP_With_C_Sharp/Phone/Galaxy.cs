using System;

namespace Phone
{
	public class Galaxy : Phone, IRingable
	{
		public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}

		public string Ring() 
		{
			string output = "... ";
			output += RingTone;
			output += " ...";
			return output;
		}

		public string Unlock() 
		{
			string output = "Galaxy ";
			output += VersionNumber;
			output += " unlocked with fingerprint scanner";
			return output;
		}
		public override void DisplayInfo() 
		{
			Console.WriteLine();
			Console.WriteLine("####################");
			Console.WriteLine("Galaxy "+VersionNumber);
			Console.WriteLine("Battery Percentage: "+BatteryPercentage);
			Console.WriteLine("Carrier: "+Carrier);
			Console.WriteLine("Ring Tone: "+RingTone);
			Console.WriteLine("####################");
			Console.WriteLine();
		}
	}
}