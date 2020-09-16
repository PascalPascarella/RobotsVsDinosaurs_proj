using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Robot
	{
		// Member Variables
		public string name;
		public double integrity;
		public double powerLevel;
		public WeaponType weaponType;

		// Constructor
		public Robot(string newInstance)
		{
			Console.WriteLine("A new robot, 'Servitor {0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
