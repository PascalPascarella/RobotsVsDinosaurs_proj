using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Dinosaur
	{
		// Member
		public string name;
		public double health;
		public double energy;
		public AttackType attackType;

		// Constructor
		public Dinosaur(string newInstance)
		{
			Console.WriteLine("A new dinosaur, '{0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
