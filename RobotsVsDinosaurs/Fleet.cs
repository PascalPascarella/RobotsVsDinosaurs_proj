using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Fleet
	{
		// Member Variables
		public string name;
		public Robot[] robots;
		public Random randomizer = new Random();

		// Constructor
		public Fleet(string newInstance)
		{
			name = newInstance;
			Console.WriteLine("A new fleet, '{0},' has been created!", newInstance);
			Robot robot1 = new Robot("00000001");
			Robot robot2 = new Robot("00000010");
			Robot robot3 = new Robot("00000011");
			RobotsIntoFleet(robot1, robot2, robot3);

			Robot robot4 = new Robot("00000100");
			Robot robot5 = new Robot("00000101");
			Robot robot6 = new Robot("00000110");
			RobotsIntoFleet(robot4, robot5, robot6);



		}

		// Member Methods
		// Add Robots to Fleet
		public Robot[] RobotsIntoFleet(Robot robot1, Robot robot2, Robot robot3)
		{
			robots = new Robot[] {robot1, robot2, robot3 };

			Console.WriteLine("Loading {0}, {1}, and {2} into the {6} fleet! \n{0} has {3} units of integrity." +
				"\n{1} and {2} have {4} and {5} Wh of power respectively.",
				robot1.name, robot2.name, robot3.name, robot1.integrity, robot2.powerLevel, robot3.powerLevel, name);

			return robots;

		}
	}
}
