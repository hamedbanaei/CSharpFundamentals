namespace Lesson07_1
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person
	{
		private int _age;
		private string _fullName;

		public Person(string fullName, int age)
		{
			_age = age;
			_fullName = fullName;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0}, Age: {1}", _fullName, _age);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Person P = new Person("Amin Ravanbod", 26);
			P.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
