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
		public double powerLevel;               // Energy bar that decreases with each attack exertion
		public double attackCombo;							// Creates random attack combinations
		public Random randomizer = new Random();

		// Constructor
		public Robot(string newInstance)
		{
			name = newInstance;
			integrity = 10 + RandomIntegrity();
			powerLevel = 100 + RandomPowerLevel();
			WeaponType weaponType1 = new WeaponType("Fire Slam");
			//WeaponType weaponType2 = new WeaponType("Justice Smash");
			//WeaponType weaponType3 = new WeaponType("Dishonor Slash");

			//WeaponType weaponType4 = new WeaponType("Blackout Strike");
			//WeaponType weaponType5 = new WeaponType("Destruction Rip");
			//WeaponType weaponType6 = new WeaponType("Cunning Force");
			//attackCombo = randomizer.Next(attackPower.Count) + randomizer.Next(attackPower.Count);
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

		// Attack Damage
		//public void Attack(Dinosaur dinosaur)
		//{
		//	if (integrity > 0)
		//		dinosaur.health -= 
		//}

	}
}
