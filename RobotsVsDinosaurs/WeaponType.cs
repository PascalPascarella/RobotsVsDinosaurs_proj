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

		// Constructor
		public WeaponType(string newInstance)
		{
			Console.WriteLine("A new weapon combo, '{0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
