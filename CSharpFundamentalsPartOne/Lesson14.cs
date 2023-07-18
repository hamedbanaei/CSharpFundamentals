namespace Lesson14
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Utilities
	{
		public static void IncrementValues1(Complex myObject)
		{
			myObject.x++;
			myObject.y++;
		}

		public static void IncrementValues2(Struct1 myType)
		{
			myType.x++;
			myType.y++;
		}

		public static void IncrementValues3(ref Struct1 myType)
		{
			myType.x++;
			myType.y++;
		}
	}

	public class Complex
	{
		public int x;
		public int y;

		public void ShowValues()
		{
			System.Console.WriteLine("X: {0}, Y: {1}", x, y);
		}
	}

	public struct Struct1
	{
		public int x;
		public int y;

		public void ShowValues()
		{
			System.Console.WriteLine("X: {0}, Y: {1}", x, y);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Complex object1 = new Complex();
			object1.x = 5;
			object1.y = 10;
			object1.ShowValues();

			Utilities.IncrementValues1(object1);
			object1.ShowValues();

			System.Console.WriteLine("\n----------");

			Struct1 type1;
			type1.x = 5;
			type1.y = 10;
			type1.ShowValues();

			Utilities.IncrementValues2(type1);
			type1.ShowValues();

			Utilities.IncrementValues3(ref type1);
			type1.ShowValues();

			System.Console.ReadLine();
		}
	}
}
