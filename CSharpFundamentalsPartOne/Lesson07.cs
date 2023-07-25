namespace Lesson07
{
	/// <summary>
	/// Last Review Date: 26 July 2023
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person
	{
		public int Age;
		public string FullName;

		private int _somePrivateField1;
		int _somePrivateField2; // If you do not write any access modifiers, Default access modifier is Private!

		// We do not have default constructor!
		// So if we write this: Person P = new Person(); We will get an error!

		public Person(string fullName, int age)
		{
			Age = age;
			FullName = fullName;
		}

		public void ShowInfo()
		{
			_somePrivateField1 = 20;
			System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			// Wrong Usage!
			// Person P = new Person();
			// P.Age = 20;
			// P.FullName = "Ali Reza Alavi";
			// P.ShowInfo();

			Person P = new Person("Afshin Sadeghi", 30);
			P.ShowInfo();
			//P._somePrivateField1;

			System.Console.ReadLine();
		}
	}
}
