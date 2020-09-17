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
			AttackPhase();
		}

		// Order Of Battle
		public void AttackPhase()
		{
			while ((fleet1.CanFight() || fleet2.CanFight()) && (herd1.CanFight() || herd2.CanFight()))
			{
				Console.WriteLine("A clash!");
				// Fleet 1 Attacks Herd 1
				for (int r1 = 0; r1 < fleet1.robots.Length; r1++)
				{
					fleet1.robots[r1].Attack(herd1.dinosaurs[r1]);
					Console.WriteLine("Robot {0} iteration.", r1);
				}
				Console.WriteLine("Robo Fleet 1 finishes their attack.");
				// Herd 1 Attacks Fleet 1
				for (int d1 = 0; d1 < herd1.dinosaurs.Length; d1++)
				{
					herd1.dinosaurs[d1].Attack(fleet1.robots[d1]);
					Console.WriteLine("Dino {0} iteration.", d1);
				}
				Console.WriteLine("Dino Herd 1 finishes their attack.");
				//Fleet 2 Attacks Herd 2
				for (int r2 = 0; r2 < fleet2.robots.Length; r2++)
				{
					fleet2.robots[r2].Attack(herd2.dinosaurs[r2]);
					Console.WriteLine("Robot {0} iteration.", r2);
				}
				Console.WriteLine("Robo Fleet 2 finishes their attack.");
				// Herd 2 Attacks Fleet 2
				for (int d2 = 0; d2 < herd1.dinosaurs.Length; d2++)
				{
					herd1.dinosaurs[d2].Attack(fleet2.robots[d2]);
					Console.WriteLine("Dino {0} iteration.", d2);
				}
				Console.WriteLine("Dino Herd 2 finishes their attack.");
			}
			if(fleet1.CanFight() || fleet2.CanFight())
			{
				Console.WriteLine("Synthetic Victory!");
			}
			else if (herd1.CanFight() || herd2.CanFight())
			{
				Console.WriteLine("Organic Victory!");
			}
			else
			{
				Console.WriteLine("An error has occurred, buddy.");
			}
		}
	}
}
