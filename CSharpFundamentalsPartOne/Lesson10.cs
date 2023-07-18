namespace Lesson10
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person
	{
		public int Age;
		public string FullName;

		private static int _instanceCount;

		/// <summary>
		/// 1- This method will be called only once.
		/// 2- This method does not have any Access Identifier.
		/// 3- This method never return value.
		/// 4- This method is used when you want to initialize static varialbes.
		/// 5- This method will be called:
		///   a. When you call the first Static Method.
		///   OR
		///   b. When you make first new object.
		/// </summary>
		static Person() // Static Constructor!
		{
			_instanceCount = 0;
		}

		public static void ShowInstanceCount()
		{
			// Wrong Usage:
			// Note: In static methods you never access to
			// none static fields or methods except static fields or static methods!
			// For example: Age = 20; OR FullName = "Ali Reza Alavi"; are wrong!
			System.Console.WriteLine("\n Number of instances is: {0}", _instanceCount);
		}

		public Person()
		{
			_instanceCount++;
		}

		public Person(string fullName, int age)
		{
			Age = age;
			FullName = fullName;

			_instanceCount++;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Person P0 = new Person();

			Person.ShowInstanceCount();

			// Wrong Usage!
			// Person.Age = 20;
			// Person.FullName = "Amin Moradian";
			// Person.ShowInfo();
			// Person.InstanceCount = 5; // It's OK, If you change InstanceCount Access Identifier to Public.

			Person P1 = new Person();
			P1.Age = 30;
			P1.FullName = "Afshin Sadeghi";

			Person P2 = new Person("Mehdi Ghadimi", 34);
			Person P3 = new Person("Bardia Salehi", 22);

			// Wrong Usage!
			// P1.InstanceCount = 5; // If even you change InstanceCount Access Identifier to Public, You never access to it!
			// P1.ShowInstanceCount();

			Person.ShowInstanceCount();

			System.Console.ReadLine();
		}
	}
}
