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
			dinosaurs = new Dinosaur[3];
			Console.WriteLine("A new herd, '{0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
