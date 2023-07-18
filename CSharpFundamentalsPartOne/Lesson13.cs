namespace Lesson13
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	
	// Enumeration
	public enum PersonGenders // It's better you define enumorations in Namespace! Default type [int]
	{
		Male, // Male = 0,
		Female // Female = 1
	}

	public enum MarriageSituations : byte // It's better you define enumorations in Namespace!
	{
		Single = 10,
		Married = 20,
		Divorced = 30
	}
	
	public enum SomeEnums // It's better you define enumorations in Namespace!
	{
		x = 10,
		y, // y = 11,
		z, // z = 12,
		t // t = 13
	}

	public class Person
	{
		public int Age;
		public string FullName;

		public PersonGenders Gender;
		public MarriageSituations Marriage;

		public Person()
		{
		}

		public Person(string fullName, int age, PersonGenders gender, MarriageSituations marriage)
		{
			Age = age;
			Gender = gender;
			Marriage = marriage;
			FullName = fullName;
		}

		public Person(Person person) // Copy Constructor!
		{
			Age = person.Age;
			Gender = person.Gender;
			Marriage = person.Marriage;
			FullName = person.FullName;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("\n: Full Name: {0}, Age: {1}, Gender: {2}, Marriage: {3}", FullName, Age, Gender, Marriage);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Person P0 = new Person();
			P0.Marriage = MarriageSituations.Married;

			Person P1 = new Person("Ali Ravanbod", 27, PersonGenders.Male, MarriageSituations.Single);
			P1.ShowInfo();

			System.Console.WriteLine("\n----------");

			Person P2 = new Person(P1);
			P2.ShowInfo();

			System.Console.WriteLine("\n----------");

			if (P1.Gender == PersonGenders.Male)
				System.Console.WriteLine("He is male.");
			else
				System.Console.WriteLine("She is female.");

			switch (P1.Marriage)
			{
				case MarriageSituations.Single:
				{
					System.Console.WriteLine("Single.");
					break;
				}

				case MarriageSituations.Married:
				{
					System.Console.WriteLine("Married.");
					break;
				}

				case MarriageSituations.Divorced:
				{
					System.Console.WriteLine("Divorced.");
					break;
				}
			}

			System.Console.ReadLine();
		}
	}
}
