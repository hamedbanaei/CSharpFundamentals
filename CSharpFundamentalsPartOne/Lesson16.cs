namespace Lesson16
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Class1
	{
		private int _a;
		private int _b;
		private int _c;
		private int _d;

		public int E;
		public readonly int F;

		public int A // Property <-> Read And Write Property!
		{
			get
			{
				return (_a);
			}
			set
			{
				_a = value;
			}
		}

		public int B // Write Only Property!
		{
			set
			{
				_b = value;
			}
		}

		public int C // Read Only Property!
		{
			get
			{
				return (_a);
			}
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			int intTemp = 0;
			Class1 object1 = new Class1();

			object1.A = 1;
			intTemp = object1.A;

			object1.B = 2;
			// Wrong Usage!
			// intTemp = object1.B;

			// Wrong Usage!
			// object1.C = 3;
			intTemp = object1.C;

			object1.E = 4;
			intTemp = object1.E;

			// Wrong Usage!
			// object1.F = 5;
			intTemp = object1.F;

			System.Console.ReadLine();
		}
	}
}
