using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class WeaponType
	{
		// Member Variables
		public double gun;
		public double grenade;
		public double swordEnergizedFast;
		public double swordBusterHuge;

		public double attackPower;
		public Random randomizer = new Random();

		// Constructor
		public WeaponType(string newInstance)
		{
			gun = 1;
			grenade = 4;
			swordBusterHuge = 3;
			swordEnergizedFast = 2;
			Console.WriteLine("A new weapon combo, '{0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
