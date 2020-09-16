using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Battlefield
	{
		// Member Variables
		public Fleet fleet;					// Array of n Robots objects
		public Herd herd;						// Array of n Dinosaur objects
		public int fleetBonus;			// A multiplier that is only applied as long as n% Robots remain in local fleet
		public int herdBonus;				// A multiplier that is only applied as long as n% Dinosaurs remain in local herd
		public int fleetCount;      // Number of fleets participating in battle
		public int herdCount;       // Number of herds participating in battle

		// Constructor
		public Battlefield(int fleetCount, int herdCount, string nameTheNewInstance)
		{
			this.fleetCount = fleetCount;
			this.herdCount = herdCount;
			fleetBonus = 2;
			herdBonus = 2;

			Console.WriteLine("The battle will take place at {2}! {0} robot fleets will engage {1} saurian herds.", fleetCount, herdCount, nameTheNewInstance);
		}

		// Member Methods

	}
}
