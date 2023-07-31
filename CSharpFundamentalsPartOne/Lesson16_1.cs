namespace Lesson16_1
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
		private int _salary;
		private string _fullName;

		public int Age
		{
			get
			{
				return (_age);
			}
			set
			{
				if ((value >= 1) && (value <= 20))
					_age = value;
			}
		}

		public int Salary
		{
			get
			{
				return (_salary);
			}
			private set
			{
				_salary = value;
			}
		}

		public string FullName
		{
			get
			{
				return (_fullName);
			}
			set
			{
				_fullName = value;
			}
		}

		public Person()
		{
			Age = 0;
			Salary = 1_000;
			FullName = string.Empty;
		}

		public Person(int age, int salary)
			: this()
		{
			// _age = age;

			//if ((age >= 1) && (age <= 20))
			//    _age = age;

			Age = age;
			Salary = salary;
		}

		public Person(string fullName)
		{
			FullName = fullName;
		}

		public Person(string fullName, int age)
			: this(fullName)
		{
			Age = age;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("I'm {0} years old.", Age);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Person P1 = new Person();
			P1.Age = 10;
			P1.ShowInfo();

			P1.Age = 30;
			P1.ShowInfo();

			Person P2 = new Person(30, 10000);
			P2.ShowInfo();

			Person P3 = new Person("Hamed", 42);
			P3.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
