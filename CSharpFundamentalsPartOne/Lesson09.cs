namespace Lesson09
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public sealed class Globals // Publics, Utilities
	{
		private Globals()
		{
		}

		// If you want to use Static fields or Methods, You do not need create object!
		public static string Author = "Hamed Banaei";
		public static string Support = "ha-banaei@agri-bank.com";
		public static string Homepage = "http://www.bki.com";
		public static string Version;

		public static void ShowApplicationInfo()
		{
			System.Console.WriteLine("\n: -----\n: Author: {0}\n: Support: {1}\n: Homepage: {2}\n: Version: {3}\n: -----", Author, Support, Homepage, Version);
		}

		public static int Sum(int a, int b)
		{
			//int intResult = a + b;
			//return (intResult);

			return (a + b);
		}

		public static int Sum(int a, int b, int c)
		{
			return (a + b + c);
		}

		public static float Sum(float a, float b)
		{
			return (a + b);
		}

		public static int Sum(int[] numbers)
		{
			int intSum = 0;

			//foreach (int intNumber in numbers)
			//    intSum += intNumber;

			for (int intIndex = 0; intIndex <= numbers.Length - 1; intIndex++)
				intSum += numbers[intIndex];

			return (intSum);
		}

		public static void Swap(ref int a, ref int b)
		{
			int intTemp = a;
			a = b;
			b = intTemp;
		}

		public static void Sum(int a, int b, out int c)
		{
			c = a + b;
		}

		public static int SomeFunction(int a, int b, out int c)
		{
			c = a * b;

			return (a + b);
		}

		public static int SomeFunction1(int param)
		{
			switch (param)
			{
				case 1:
				{
					return (10);
					// break; DO NOT WRITE!
				}

				case 2:
				{
					return (20);
					// break; DO NOT WRITE!
				}

				default:
				{
					return (0);
					// break; DO NOT WRITE!
				}
			}
		}

		//public static int SomeFunction1(int param)
		//{
		//    int intResult = 0;

		//    switch (param)
		//    {
		//        case 1:
		//            intResult = 10;
		//            break;

		//        case 2:
		//            intResult = 20;
		//            break;
		//    }

		//    return (intResult);
		//}

		public static void SomeFunction2(int param, out int outParam)
		{
			switch (param)
			{
				case 1:
				outParam = 10;
				break;

				case 2:
				outParam = 20;
				break;

				default:
				outParam = 0;
				break;
			}
		}

		//public static void SomeFunction2(int param, out int outParam)
		//{
		//    outParam = 0;

		//    switch (param)
		//    {
		//        case 1:
		//            outParam = 10;
		//            break;

		//        case 2:
		//            outParam = 20;
		//            break;
		//    }
		//}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			// Globals oGlobals = new Globals();

			Globals.Version = "1.0.1";
			Globals.ShowApplicationInfo();

			System.Console.WriteLine("\n");

			int A = 5, B = 10, C;
			C = Globals.Sum(A, B);
			System.Console.WriteLine("Sum of {0} and {1} is {2}", A, B, C);

			System.Console.WriteLine("\n");

			int intSum;
			int[] aryintNumbers = { 1, 2, 3, 4, 5 };
			intSum = Globals.Sum(aryintNumbers);
			System.Console.WriteLine("Sum of numbers is {0}", intSum);

			System.Console.WriteLine("\n");

			int M = 5, N = 10;
			System.Console.WriteLine("M: {0}, N: {1}", M, N);
			Globals.Swap(ref M, ref N);
			System.Console.WriteLine("M: {0}, N: {1}", M, N);

			// Wrong Usage!
			// You must initilize variables if you want to pass them by ref!
			// int P, Q;
			// Globals.Swap(ref P, ref Q);

			int X = 5, Y = 10, Add, Mul;
			Add = Globals.SomeFunction(X, Y, out Mul);

			int Temp = Mul + 1;

			System.Console.WriteLine("\n");

			X = 5;
			Y = 10;
			int Z;

			Globals.Sum(X, Y, out Z); // Z should be initialize or not!
			System.Console.WriteLine("Sum of {0} and {1} is {2}", X, Y, Z);

			System.Console.ReadLine();
		}
	}
}
