using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class WeaponType
	{
		// Member Variables
		public double gun;
		public double grenade;
		public double swordEnergizedFast;
		public double swordBusterHuge;
		public double attackCombo;
		public List<double> attackPower;			// Creates a new attack combo by combining 2 attacks from a list
		public Random randomizer = new Random();

		// Constructor
		public WeaponType(string newInstance)
		{
			gun = 1;
			grenade = 4;
			swordBusterHuge = 3;
			swordEnergizedFast = 2;
			AttackPowerCombo(grenade, gun, swordBusterHuge, swordEnergizedFast);
			attackCombo = randomizer.Next(attackPower.Count) + randomizer.Next(attackPower.Count);

			Console.WriteLine("A new weapon combo, '{0},' has been created with an attack power of {1}", newInstance, attackCombo);
		}

		// Member Methods
		// Attack Power Calculator
		public List<double> AttackPowerCombo(double attack1, double attack2, double attack3, double attack4)
		{
			attackPower = new List<double>() { attack1, attack2, attack3, attack4 };
			return attackPower;
		}
	}
}
