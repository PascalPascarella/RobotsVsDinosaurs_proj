﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RobotsVsDinosaurs
{
	class Fleet
	{
		// Member Variables
		public Robot[] robots;
		public Random randomizer = new Random();

		// Constructor
		public Fleet(string newInstance)
		{
			robots = new Robot[3];
			Console.WriteLine("A new fleet, '{0},' has been created!", newInstance);
		}

		// Member Methods

	}
}
