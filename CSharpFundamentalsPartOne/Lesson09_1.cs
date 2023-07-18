namespace Lesson09_1
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class SomeClass
	{
		public int X;
		private int _y;

		public static int M;
		private static int _n;
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			SomeClass.M = 10;
			// SomeClass._n = 20; // Wrong Usage!

			SomeClass obj = new SomeClass();
			obj.X = 10;
			// obj._y = 10; // Wrong Usage!
		}
	}
}
