using System;

namespace Phone
{
	public class Nokia : Phone, IRingable
	{
		public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}

		public string Ring() 
		{
			string output = "... ";
			output += RingTone;
			output += " ...";
			return output;
		}

		public string Unlock() 
		{
			string output = "Nokia ";
			output += VersionNumber;
			output += " unlocked with passcode";
			return output;
		}
		public override void DisplayInfo() 
		{
			Console.WriteLine();
			Console.WriteLine("$$$$$$$$$$$$$$$$$$$$");
			Console.WriteLine("Nokia "+VersionNumber);
			Console.WriteLine("Battery Percentage: "+BatteryPercentage);
			Console.WriteLine("Carrier: "+Carrier);
			Console.WriteLine("Ring Tone: "+RingTone);
			Console.WriteLine("$$$$$$$$$$$$$$$$$$$$");
			Console.WriteLine();
		}
	}
}