using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Robot
	{
		// Member Variables
		public string name;								// Assigned to robot object at new class instance
		public double integrity;					// Health bar that decreases upon taking hit
		public double powerLevel;					// Energy bar that decreases with each attack exertion
		public WeaponType weaponType;     // Creates random attack combinations
		public Random randomizer = new Random();

		// Constructor
		public Robot(string newInstance)
		{
			name = newInstance;
			integrity = 10;
			powerLevel = 100;
			Console.WriteLine("A new robot, 'Servitor {0},' has been created!", newInstance);
		}

		// Member Methods
		// Small Randomizer
		public void RandomIntegrity()
		{
		}
		// Large Randomizer
		public void RandomPowerLevel()
		{

		}
	}
}
