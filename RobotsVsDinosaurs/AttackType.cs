using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class AttackType
	{
		// Member Variables
		public double bite;
		public double charge;
		public double claws;
		public double tailSwipe;

		public double attackPower;
		public Random randomizer = new Random();

		// Constructor
		public AttackType(string newInstance)
		{
			bite = 1;
			charge = 4;
			claws = 3;
			tailSwipe = 2;
			Console.WriteLine("A new attack combo '{0}' has been created!", newInstance);
		}

		// Member Methods

	}
}
