namespace Lesson19
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

		public Person()
		{
		}

		public Person(string fullName, int age)
		{
			Age = age;
			FullName = fullName;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("\n--------------------");
			System.Console.WriteLine("Full Name: {0}", FullName);
			System.Console.WriteLine("Age      : {0}", Age);
			System.Console.WriteLine("--------------------");
		}
	}

	public class Factory
	{
		private int _index;
		public string Name;
		public Person[] Persons;

		public Factory(string name, int size)
		{
			_index = -1;
			Name = name;
			Persons = new Person[size];
		}

		public bool Add(Person person)
		{
			bool blnResult = false;

			if (_index < Persons.Length - 1)
			{
				_index++;
				Persons[_index] = person;

				blnResult = true;
			}

			return (blnResult);
		}

		public bool Add(string fullName, int age)
		{
			bool blnResult = false;

			Person oPerson = new Person(fullName, age);

			blnResult = Add(oPerson);

			return (blnResult);
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("Factory Name: " + Name);
		}

		public void ShowPersons()
		{
			foreach (Person oPerson in Persons)
				oPerson.ShowInfo();
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			Factory oFactory = new Factory("Iran Khodro Co.", 3);

			Person P1 = new Person();
			P1.Age = 27;
			P1.FullName = "Ali Ravanbod";
			oFactory.Add(P1);

			Person P2 = new Person("Afshin Sadeghi", 30);
			oFactory.Add(P2);

			oFactory.Add(new Person("Bahram Shafagh", 32));

			oFactory.Add("Behzad Salehi", 22);

			oFactory.ShowPersons();

			System.Console.WriteLine("\n----------");

			oFactory.Persons[0].ShowInfo();
			oFactory.Persons[1].ShowInfo();
			oFactory.Persons[2].ShowInfo();

			System.Console.ReadLine();
		}
	}
}
