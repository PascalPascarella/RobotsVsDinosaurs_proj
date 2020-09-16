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


			// Class Instantiation
			Random randomizer = new Random();

			Battlefield battlefield1 = new Battlefield(2, 2, "Marathon");


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


			WeaponType weaponType1 = new WeaponType("Fire Slam");
			WeaponType weaponType2 = new WeaponType("Justice Smash");
			WeaponType weaponType3 = new WeaponType("Dishonor Slash");

			WeaponType weaponType4 = new WeaponType("Blackout Strike");
			WeaponType weaponType5 = new WeaponType("Destruction Rip");
			WeaponType weaponType6 = new WeaponType("Cunning Force");

			AttackType attackType1 = new AttackType("Hidden Lily Kick");
			AttackType attackType2 = new AttackType("Sealed Giant Thrust");
			AttackType attackType3 = new AttackType("Brilliant Daydream Stab");

			AttackType attackType4 = new AttackType("Devouring Magma Fists");
			AttackType attackType5 = new AttackType("Winding Earth Method");
			AttackType attackType6 = new AttackType("Hollow Rainbow Clap");


			// Program Start

			// Prepare User For Battle Statistics
			Console.WriteLine("Battle commencing shortly...");

			// Add Robots to Fleet
			Robot[] roboArray1 = new Robot[] { robot1, robot2, robot3 };
			Console.WriteLine("Loading {0}, {1}, and {2} into a fleet! \n{0} has {3} units of integrity. \n{1} and {2} have {4} and {5} Wh of power respectively.", robot1.name, robot2.name, robot3.name, robot1.integrity, robot2.powerLevel, robot3.powerLevel);

			Robot[] roboArray2 = new Robot[] { robot4, robot5, robot6 };
			Console.WriteLine("Loading {0}, {1}, and {2} into a fleet! \n{0} has {3} units of integrity. \n{1} and {2} have {4} and {5} Wh of power respectively.", robot4.name, robot5.name, robot6.name, robot4.integrity, robot5.powerLevel, robot6.powerLevel);

			// Add Dinosaurs to Herds
			Dinosaur[] dinoArray1 = new Dinosaur[] { dinosaur1, dinosaur2, dinosaur3 };
			Console.WriteLine("Loading {0}, {1}, and {2} into a fleet! \n{0} has {3} units of health. \n{1} and {2} have {4} and {5} units of energy respectively.", dinosaur1.name, dinosaur2.name, dinosaur3.name, dinosaur1.health, dinosaur2.energy, dinosaur3.energy);

			Dinosaur[] dinoArray2 = new Dinosaur[] { dinosaur4, dinosaur5, dinosaur6 };
			Console.WriteLine("Loading {0}, {1}, and {2} into a fleet! \n{0} has {3} units of health. \n{1} and {2} have {4} and {5} units of energy respectively.", dinosaur4.name, dinosaur5.name, dinosaur6.name, dinosaur4.health, dinosaur5.energy, dinosaur6.energy);
		}
	}
}
