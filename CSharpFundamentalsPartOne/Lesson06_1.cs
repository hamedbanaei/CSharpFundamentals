namespace Lesson06_1
{
	/// <summary>
	/// Last Review Date: 27 July 2023
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class SomeClass
	{
		public int A { get; set; }
		public int B { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public int X { get; set; }
		public int O { get; set; }

		public SomeClass(int a, int b)
		{
			A = a;
			B = b;
		}

		public SomeClass(int a, int b, int y)
		{
			A = a;
			B = b;
			Y = y;
		}

		public SomeClass(int a, int b, int y, int z)
		{
			A = a;
			B = b;
			Y = y;
			Z = z;
		}
	}

	public class SomeClass2
	{
		public SomeClass2()
		{
		}

		public int A { get; set; }
		public int B { get; set; }
		public int Y { get; set; }
		public int Z { get; set; }
		public int X { get; set; }
		public int O { get; set; }
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			SomeClass obj1 = new SomeClass(1, 2);

			// Object Initializer
			SomeClass obj2 = new SomeClass(2, 3)
			{
				O = 4
			};

			SomeClass2 obj3 = new SomeClass2
			{
				A = 10,
				B = 25,
				Z = 30,
			};

			System.Console.ReadLine();
		}
	}
}
