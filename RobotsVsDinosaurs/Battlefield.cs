using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Battlefield
	{
		// Member Variables
		public Fleet fleet1;          // Array of n Robots objects
		public Fleet fleet2;          // Array of n Robots objects -- can make into heavy variant of robot later
		public Herd herd1;            // Array of n Dinosaur objects
		public Herd herd2;            // Array of n Dinosaur objects -- can make into heavy variant of dinos later
		public int fleetBonus;			// A multiplier that is only applied as long as n% Robots remain in local fleet
		public int herdBonus;				// A multiplier that is only applied as long as n% Dinosaurs remain in local herd
		public int fleetCount;      // Number of fleets participating in battle
		public int herdCount;       // Number of herds participating in battle
		public Random randomizer = new Random();

		// Constructor
		public Battlefield(int fleetCount, int herdCount, string nameTheNewInstance)
		{
			Console.WriteLine("The battle will take place at {2}! {0} robot fleets will engage {1} saurian herds.", fleetCount, herdCount, nameTheNewInstance);
			this.fleetCount = fleetCount;
			this.herdCount = herdCount;
			fleetBonus = 2;
			herdBonus = 2;
			fleet1 = new Fleet("The Shadow");
			fleet2 = new Fleet("The Curators");
			Console.WriteLine("\n");
			herd1 = new Herd("Obsidian");
			herd2 = new Herd("Collapse");
			Console.WriteLine("\n");

		}

		// Member Methods
		public void Main()
		{
			// Prepare User For Battle Statistics
			Console.WriteLine("\n\nBattle commencing shortly...\n\n");
			// Prepare User For Battle Statistics
			Console.WriteLine("\n\nThe {0} and {1} fleets unload their servitors. " +
				"The {2} and {3} herds charge at the invaders.\n\n",
				fleet1.name, fleet2.name, herd1.name, herd2.name);
			//AttackPhase();
		}

		// Order Of Battle
		//public void AttackPhase()
		//{
		//	while ((fleet1.CanFight() || fleet2.CanFight()) && (herd1.CanFight() || herd2.CanFight()))
		//	{
		//		Console.WriteLine("A clash!");
		//		for (int r = 0; r < fleet1.robots.Length; r++)
		//		{
		//			fleet1.robots[r].Attack(herd1.dinosaurs[r]);
		//		}
		//		for (int d = 0; d < herd1.dinosaurs.Length; d++)
		//		{
		//			herd1.dinosaurs[d].Attack(herd1.dinosaurs[r]);
		//		}
		//		for (int r = 0; r < fleet2.robots.Length; r++)
		//		{
		//			fleet2.robots[r].Attack(herd2.dinosaurs[r]);
		//		}
		//		for (int d = 0; d < herd1.dinosaurs.Length; d++)
		//		{
		//			herd1.dinosaurs[d].Attack(herd1.dinosaurs[r]);
		//		}
		//	}

		//}
	}
}
