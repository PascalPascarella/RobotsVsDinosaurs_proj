using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Fleet
	{
		// Member Variables
		public string name;
		public Robot[] robots;
		public Random randomizer = new Random();

		// Constructor
		public Fleet(string newInstance)
		{
			name = newInstance;
			Console.WriteLine("A new fleet, '{0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
