using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Dinosaur
	{
		// Member
		public string name;									// Assigned to dinosaur at new class instance
		public double health;								// Health bar that decreases upon taking hit
		public double energy;               // Energy bar that decreases with each attack exertion
		public double attackCombo;					// Creates random attack
		public Random randomizer = new Random();

		// Constructor
		public Dinosaur(string newInstance)
		{
			name = newInstance;
			health = 10 + RandomHealth();
			energy = 10 +RandomEnergy();
			AttackType attackType1 = new AttackType("Hidden Lily Kick");
			attackCombo = attackType1.attackCombo;

			// --> TODO: Build list to draw random attack names from

			//AttackType attackType2 = new AttackType("Sealed Giant Thrust");
			//AttackType attackType3 = new AttackType("Brilliant Daydream Stab");

			//AttackType attackType4 = new AttackType("Devouring Magma Fists");
			//AttackType attackType5 = new AttackType("Winding Earth Method");
			//AttackType attackType6 = new AttackType("Hollow Rainbow Clap");
			Console.WriteLine("A new dinosaur, '{0},' has been created with health of {1} and {2} energy!", newInstance, health, energy);
		}

		// Member Methods
		// Small Randomizer
		public int RandomHealth()
		{
			return randomizer.Next(1, 10);			// Returns random integer value between 1 and 10 (inclusive)
		}

		// Large Randomizer
		public int RandomEnergy()
		{
			return randomizer.Next(1, 50);      // Returns random integer value between 1 and 50 (inclusive)
		}

		// Attack Damage
		public void Attack(Robot robot)
		{
			if (health > 0 && energy > 0)
			{
				robot.integrity -= attackCombo;
				energy -= attackCombo;
			}

		}
	}
}
