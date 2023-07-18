namespace Lesson15
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person
	{
		public int X;

		private int _age;
		private string _firstName;
		private string _lastName;
		private string _fullName;

		// Default Constructor!
		public Person()
		{
		}

		// Constructor Overloading!
		public Person(string firstName, string lastName, int age)
		{
			Age = age;
			LastName = lastName;
			FirstName = firstName;

			//_age = age;
			//_lastName = lastName;
			//_firstName = firstName;

			//if(_firstName == "")
			//{
			//    if(_lastName == "")
			//        _fullName = "";
			//    else
			//        _fullName = _lastName;
			//}
			//else
			//{
			//    if(_lastName == "")
			//        _fullName = _firstName;
			//    else
			//        _fullName = _firstName + " " + _lastName;
			//}
		}

		// Property!
		public int Age
		{
			get
			{
				return (_age);
			}
			set
			{
				if ((value >= 0) && (value <= 99))
					_age = value;
			}
		}

		// Property!
		public string FirstName
		{
			get
			{
				return (_firstName);
			}
			set
			{
				_firstName = value;

				if (_lastName == "")
					_fullName = _firstName;
				else
					_fullName = _firstName + " " + _lastName;
			}
		}

		// Property!
		public string LastName
		{
			get
			{
				return (_lastName);
			}
			set
			{
				_lastName = value;

				if (_firstName == "")
					_fullName = _lastName;
				else
					_fullName = _firstName + " " + _lastName;
			}
		}

		public string FullName
		{
			get
			{
				return (_fullName);
			}
		}

		// Method!
		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0}, Age: {1}", _fullName, _age);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Person P0 = new Person();
			P0.Age = 20;
			System.Console.WriteLine("Age: {0}", P0.Age);

			Person P1 = new Person();
			P1.Age = 26;
			P1.FirstName = "Amin";
			P1.LastName = "Ravanbod";
			P1.ShowInfo();

			Person P2 = new Person("Ali", "Ravanbod", 27);
			P2.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
