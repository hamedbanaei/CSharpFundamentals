namespace Lesson05
{
	/// <summary>
	/// Last Review Date: 26 July 2023
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person // It's a Class!
	{
		public int Age; // It's a Field!, It's a member!
		public string FullName; // It's a Field!, It's a member!

		public void ShowInfo() // It's a Method!, It's a member!
		{
			string str1 = "Full Name: " + FullName + ", Age: " + Age;
            System.Console.WriteLine(str1);

			string str2 = string.Format("Full Name: {0}, Age: {1}", FullName, Age);
            System.Console.WriteLine(str2);
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);

			string str3 = $"Full Name {FullName}, Age: {Age}";
            System.Console.WriteLine(str3);
            System.Console.WriteLine($"Full Name {FullName}, Age: {Age}");
        }
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			// Wrong Usage!
			// Person P;
			// P.Age = 20;
			// P.FullName = "Ali Reza Alavi";
			// P.ShowInfo();

			Person P1;
			P1 = new Person();
			P1.Age = 31;
			P1.FullName = "Hossein Niasari";
			P1.ShowInfo();

			System.Console.WriteLine("\n");

			Person P2 = new Person();
			P2.Age = 30;
			P2.FullName = "Afshin Sadeghi";
			P2.ShowInfo();

			System.Console.WriteLine("\n");

			Person P3;
			P3 = P1;
			P3.ShowInfo();

			System.Console.WriteLine("\n");

			Person P4 = P2;
			P4.ShowInfo();

			System.Console.WriteLine("\n");

			Person P5 = P1;
			P5.Age = 21;
			P5.ShowInfo();
			P1.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
