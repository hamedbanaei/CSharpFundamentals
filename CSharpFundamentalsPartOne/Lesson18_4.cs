namespace Lesson18_4
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
		private Factory _jobPlace;

		public int Age
		{
			get
			{
				return (_age);
			}
			set
			{
				if ((value >= 1) && (value <= 99))
					_age = value;
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

		public Factory JobPlace
		{
			get
			{
				return (_jobPlace);
			}
			set
			{
				_jobPlace = value;
			}
		}

		public Person(string fullName)
		{
			FullName = fullName;
			// _fullName = fullName;
		}

		// public Person(string fullName, int age)
		// {
		// 	Age = age;
		// 	FullName = fullName;
		// }

		public Person(string fullName, int age)
			: this(fullName)
		{
			Age = age;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("\n--------------------");
			System.Console.WriteLine("Full Name: {0}", FullName);
			System.Console.WriteLine("Age      : {0}", Age);

			if (JobPlace != null)
				System.Console.WriteLine("Job Place: {0}", JobPlace.Name);

			System.Console.WriteLine("--------------------");
		}
	}

	public class Factory
	{
		private string _name;
		private Person _manager;

		public string Name
		{
			get
			{
				return (_name);
			}
			set
			{
				_name = value;
			}
		}

		public Person Manager
		{
			get
			{
				return (_manager);
			}
			set
			{
				_manager = value;

				_manager.JobPlace = this;
			}
		}

		public Factory(string name)
		{
			Name = name;
		}

		public Factory(string name, Person manager)
		{
			Name = name;
			Manager = manager;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("Factory Name: " + Name);

			if (Manager != null)
				Manager.ShowInfo();
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			System.Console.WriteLine("\n----------");

			Person oManager = new Person("Kourosh", 14);
			oManager.ShowInfo();

			Factory oFactory = new Factory("Iran Khodro Co.", oManager);

			oManager.ShowInfo();

			System.Console.WriteLine("\n----------");

			System.Console.ReadLine();
		}
	}
}
