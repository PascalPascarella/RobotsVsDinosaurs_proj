using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Herd
	{
		// Member Variables
		public string name;
		public Dinosaur[] dinosaurs;
		public Random randomizer = new Random();

		// Constructor
		public Herd(string newInstance)
		{
			name = newInstance;
			Console.WriteLine("A new herd, '{0},' has been created!", newInstance);
			Dinosaur dinosaur1 = new Dinosaur("Agilitholus");
			Dinosaur dinosaur2 = new Dinosaur("Kentrocanthus");
			Dinosaur dinosaur3 = new Dinosaur("Ceratosaura");
			DinosaursIntoHerd(dinosaur1, dinosaur2, dinosaur3);

			Dinosaur dinosaur4 = new Dinosaur("Spinoraptor");
			Dinosaur dinosaur5 = new Dinosaur("Thecogryphus");
			Dinosaur dinosaur6 = new Dinosaur("Deinotrachelomoloch");
			DinosaursIntoHerd(dinosaur1, dinosaur2, dinosaur3);
		}

		// Member Methods
		public Dinosaur[] DinosaursIntoHerd(Dinosaur dinosaur1, Dinosaur dinosaur2, Dinosaur dinosaur3)
		{
			// Add Dinosaurs to Herds
			dinosaurs = new Dinosaur[] { dinosaur1, dinosaur2, dinosaur3 };
			Console.WriteLine("Loading {0}, {1}, and {2} into the {6} herd! \n{0} has {3} units of health." +
				"\n{1} and {2} have {4} and {5} units of energy respectively.",
				dinosaur1.name, dinosaur2.name, dinosaur3.name, dinosaur1.health, dinosaur2.energy, dinosaur3.energy, name);

			return dinosaurs;
		}

	}
}
