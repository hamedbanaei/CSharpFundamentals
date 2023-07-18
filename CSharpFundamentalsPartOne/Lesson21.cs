namespace Lesson21
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public sealed class Supervisor // Singletone Pattern!, I will tell you about [sealed] later!
	{
		private static Supervisor _instance = null;

		public static Supervisor GetInstance()
		{
			if (_instance == null)
				_instance = new Supervisor();

			return (_instance);
		}

		private Supervisor()
		{
		}

		public int Age;
		public string FullName;

		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			// Supervisor S = new Supervisor();

			Supervisor.GetInstance().Age = 31;
			Supervisor.GetInstance().FullName = "Hossein Niasari";
			Supervisor.GetInstance().ShowInfo();

			Supervisor S = Supervisor.GetInstance();

			S.Age = 25;
			S.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
