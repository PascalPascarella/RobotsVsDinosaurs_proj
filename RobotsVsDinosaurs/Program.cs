using System;

namespace RobotsVsDinosaurs
{
	class Program
	{
		static void Main(string[] args)
		{
			// Have Robot Fleets and Dinosaur Herds fight on Battlefield
			//	Create 3 Robots and store in Fleet
			//		--> Extra TODO: Arm Robots
			//			--> Extra TODO: Randomize Weapon draw
			//	Create 3 Dinosaurs and store in Herd
			//		--> Extra TODO: Arm Dinosaurs
			//			--> Extra TODO: Randomize Attack use
			// Decide Victor after complete Fleet/Herd wiped out

			Battlefield battlefield1 = new Battlefield(2, 3, "Marathon");


			Fleet fleet1 = new Fleet("The Shadow");
			Fleet fleet2 = new Fleet("The Curators");

			Herd herd1 = new Herd("Obsidian");
			Herd herd2 = new Herd("Collapse");


			Robot robot1 = new Robot("00000001");
			Robot robot2 = new Robot("00000010");
			Robot robot3 = new Robot("00000011");

			Robot robot4 = new Robot("00000100");
			Robot robot5 = new Robot("00000101");
			Robot robot6 = new Robot("00000110");

			Dinosaur dinosaur1 = new Dinosaur("Agilitholus");
			Dinosaur dinosaur2 = new Dinosaur("Kentrocanthus");
			Dinosaur dinosaur3 = new Dinosaur("Ceratosaura");

			Dinosaur dinosaur4 = new Dinosaur("Spinoraptor");
			Dinosaur dinosaur5 = new Dinosaur("Thecogryphus");
			Dinosaur dinosaur6 = new Dinosaur("Deinotrachelomoloch");


			AttackType attackType1 = new AttackType("Fire Slam");
			AttackType attackType2 = new AttackType("Justice Smash");
			AttackType attackType3 = new AttackType("Dishonor Slash");

			AttackType attackType4 = new AttackType("Blackout Strike");
			AttackType attackType5 = new AttackType("Destruction Rip");
			AttackType attackType6 = new AttackType("Cunning Force");

		}
	}
}
