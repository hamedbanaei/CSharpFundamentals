namespace Lesson05_1
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person
	{
		// Note: Fields have Default Value
		// For example:
		// public int Age; is similar to public int Age = 0;
		// OR
		// public string FullName; is similar to public string FullName = null; (FullName is Reference Type!)
		// But I told you that Variables in some blocks do not have Default Values!
		public int Age;
		public string FullName;

		// Default Constructor!
		public Person() // Constructors do not have any return value!
		{
			Age = 20;
			FullName = "";
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
			P0.ShowInfo();

			Person P = new Person();
			P.FullName = "Bahram Shafagh";
			P.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
