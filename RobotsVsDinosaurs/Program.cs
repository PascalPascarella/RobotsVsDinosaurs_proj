using System;

namespace RobotsVsDinosaurs
{
	class Program
	{
		static void Main(string[] args)
		{
			// Class Instantiation

			Battlefield battlefield1 = new Battlefield(2, 2, "Marathon");
			battlefield1.Main();


			Console.WriteLine("\n");



			

			Console.WriteLine("\n");

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
			Console.WriteLine("\n\nBattle commencing shortly...\n\n");


			Console.WriteLine("\n");




		}
	}
}
