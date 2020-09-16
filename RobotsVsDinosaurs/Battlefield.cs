using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Battlefield
	{
		// Member Variables
		public Fleet fleet;
		public Herd herd;
		public int fleetBonus;
		public int herdBonus;
		public int fleetCount;
		public int herdCount;

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
