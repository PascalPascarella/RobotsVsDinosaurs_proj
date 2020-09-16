using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Dinosaur
	{
		// Member
		public string name;								// Assigned to dinosaur at new class instance
		public double health;							// Health bar that decreases upon taking hit
		public double energy;							// Energy bar that decreases with each attack exertion
		public AttackType[] attackType;     // Creates random attack
		public Random randomizer = new Random();

		// Constructor
		public Dinosaur(string newInstance)
		{
			name = newInstance;
			health = 10 + RandomHealth();
			energy = 100;
			Console.WriteLine("A new dinosaur, '{0},' has been created with health of {1}!", newInstance);
		}

		// Member Methods
		// Small Randomizer
		public int RandomHealth()
		{
			return randomizer.Next(1, 10);
		}

		// Large Randomizer
		public void RandomEnergy()
		{

		}
	}
}
