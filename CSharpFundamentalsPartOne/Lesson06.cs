namespace Lesson06
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

		// If you do not write default constructor and do not write any Constructor Overloading,
		// Compiler will create it automaticlly!
		// Default Constructor!
		public Person() // Constructors do not have any return value!
		{
			Age = 20;
			FullName = "";
		}

		// Constructor Overloading!
		public Person(int age) // Constructors do not have any return value!
		{
			Age = age;
			FullName = "";
		}

		// Constructor Overloading!
		public Person(string fullName) // Constructors do not have any return value!
		{
			Age = 20;
			FullName = fullName;
		}

		// Constructor Overloading!
		public Person(string fullName, int age) // Constructors do not have any return value!
		{
			Age = age;
			FullName = fullName;
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
			Person P = new Person();

			Person P0 = new Person();
			P0.Age = 32;
			P0.FullName = "Bahram Shafagh";
			P0.ShowInfo();

			System.Console.WriteLine("\n");

			Person P1 = new Person(27);
			P1.FullName = "Ali Ravanbod";
			P1.ShowInfo();

			System.Console.WriteLine("\n");

			Person P2 = new Person("Armo Aghajanian");
			// P2.Age = 15;
			P2.ShowInfo();

			System.Console.WriteLine("\n");

			Person P3 = new Person("Kourosh Irani", 33);
			P3.ShowInfo();

			System.Console.WriteLine("\n");

			System.Console.ReadLine();
		}
	}
}
