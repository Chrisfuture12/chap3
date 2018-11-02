using System;

namespace chap3
{
	class class2
	{

		const int ftToInch = 12;
		const int yardToFeet = 3;

		public static main()
		{
			double inches = GetInput();
			double feet = InchToFeet();
			double feetval = InchToFeet(inchValue);
			double yardval = FeetToYard(feetVal);
			displayResults(feetval, yardval);
			Console.readkey();

		}
		public static GetInput()
		{
			string userInput;
            Console.WriteLine("\t Enter units of inches " + x + ".");
            userInput = Console.ReadLine( );
            double somenum = double.Parse(inputValue);
            retrun somenum; // or  return double.Parse(inputValue);
		}
		public static double InchToFeet(double x)
		{
			return x / ftToInch;
		}
		public static double FeetToYard(double z)
		{
			return feetVal / yardToFeet;
		}
		public static void displayResults(double a, double b)
		{
			Console.WriteLine("\t unit conversion {0:F2} " + a);
			Console.WriteLine("\t unit conversion {1:F2}" + b);

		}
		

	}
}
