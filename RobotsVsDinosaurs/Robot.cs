using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Robot
	{
		// Member Variables
		public string name;											// Assigned to robot object at new class instance
		public double integrity;								// Health bar that decreases upon taking hit
		public double powerLevel;								// Energy bar that decreases with each attack exertion
		public List<WeaponType> weaponType;     // Creates random attack combinations
		public Random randomizer = new Random();

		// Constructor
		public Robot(string newInstance)
		{
			name = newInstance;
			integrity = 10 + RandomIntegrity();
			powerLevel = 100 + RandomPowerLevel();
			Console.WriteLine("A new robot, 'Servitor {0},' has been created with integrity of {1} and {2} Watt-hours of power!", newInstance, integrity, powerLevel);
		}

		// Member Methods
		// Small Randomizer
		public int RandomIntegrity()
		{
			return randomizer.Next(1, 10);      // Returns random integer value between 1 and 10 (inclusive)
		}
		// Large Randomizer
		public int RandomPowerLevel()
		{
			return randomizer.Next(1, 50);      // Returns random integer value between 1 and 50 (inclusive)
		}
	}
}
