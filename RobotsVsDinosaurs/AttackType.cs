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
		public double attackCombo;
		public double[] attackPower;      // Creates a new attack combo by combining 2 attacks from an array
		public Random randomizer = new Random();

		// Constructor
		public AttackType(string newInstance)
		{
			bite = 1;
			charge = 4;
			claws = 3;
			tailSwipe = 2;
			AttackPowerCombo(bite, charge, claws, tailSwipe);
			attackCombo = randomizer.Next(1, attackPower.Length) + randomizer.Next(1, attackPower.Length);

			Console.WriteLine("A new attack combo '{0}' has been created with an attack power of {1}!", newInstance, attackCombo);

		}

		// Member Methods
		// Attack Power Calculator
		public void AttackPowerCombo(double attack1, double attack2, double attack3, double attack4)
		{
			attackPower = new double[] { attack1, attack2, attack3, attack4 };
		}
	}
}
