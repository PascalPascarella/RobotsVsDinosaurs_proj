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

		// Constructor
		public AttackType(string newInstance)
		{
			Console.WriteLine("A new attack combo '{0}' has been created!", newInstance);
		}

		// Member Methods

	}
}
