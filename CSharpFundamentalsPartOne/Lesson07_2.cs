namespace Lesson07_2
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Father
	{
		public int Age;
		public string FullName;

		public bool Angry = false;
		private int _criticalAmount = 5000;

		public void GiveMeMoney(int amount)
		{
			if (amount >= _criticalAmount)
				Angry = true;
			else
				Angry = false;
		}

		public Father(string fullName, int age)
		{
			Age = age;
			FullName = fullName;
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
			Father F1 = new Father("Hamid Gorji", 32);

			System.Console.WriteLine("Is F1 angry? {0}", F1.Angry);
			F1.GiveMeMoney(1000);
			System.Console.WriteLine("Is F1 angry. {0}", F1.Angry);
			F1.GiveMeMoney(5500);
			System.Console.WriteLine("Is F1 angry. {0}", F1.Angry);

			System.Console.ReadLine();
		}
	}
}
