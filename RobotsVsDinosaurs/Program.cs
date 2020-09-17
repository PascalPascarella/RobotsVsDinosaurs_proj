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
		}
	}
}
