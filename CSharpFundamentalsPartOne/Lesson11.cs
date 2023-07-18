namespace Lesson11
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Utilities
	{
		// Wrong Usage!
		// public const int a;
		public const int a = 1;

		public int b;
		public readonly int c;
		public readonly int d = 2;
		public readonly int e = 7;

		public Utilities()
		{
			c = 1;
		}

		public Utilities(int constant1, int constant2)
		{
			c = constant1;
			e = constant2;
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			int intNumber;
			Utilities SomeObject = new Utilities();

			// Wrong Usage!
			// Utilities.a = 2;
			intNumber = Utilities.a;

			// Wrong Usage!
			// SomeObject.a = 2;
			// int intNumber = SomeObject.a;

			SomeObject.b = 1;
			intNumber = SomeObject.b;

			// Wrong Usage!
			// SomeObject.c = 2; // [c] field is ReadOnly!, So you should not change it!
			intNumber = SomeObject.c;
		}
	}
}
