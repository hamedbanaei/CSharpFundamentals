namespace Lesson08
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Person
	{
		/// <summary>
		/// اين شاخص مربوط به سن شخص می باشد
		/// </summary>
		/// <example>
		/// Person P = new Person();
		/// P.Age = 20;
		/// </example>
		/// <remarks>
		/// Kourosh - Date: 1385/08/18 - Version 1.0.0
		/// </remarks>
		public int Age;

		/// <summary>
		/// اين فيلد مربوط به نام خانوادگی شخص می باشد
		/// </summary>
		/// <example>
		/// FullName = "Mehdi Parsaei"
		/// </example>
		public string FullName;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public Person()
		{
			Age = 20;
		}

		/// <summary>
		/// Constructor Overloading with Full Name and Age.
		/// </summary>
		/// <param name="fullName">نام و نام خانوادگی</param>
		/// <param name="age">سن</param>
		public Person(string fullName, int age)
		{
			Age = age;
			FullName = fullName;
		}

		/// <summary>
		/// Constructor Overloading with Full Name.
		/// </summary>
		/// <param name="FullName"></param>
		/// <example>
		/// Person P = new Person("Kourosh Irani");
		/// </example>
		public Person(string FullName)
		{
			// Wrong Usage!
			// FullName = FullName;

			this.FullName = FullName;
		}

		/// <summary>
		/// اين تابع مشخصات شخص را چاپ می کند
		/// </summary>
		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
		}
	}

	/// <summary>
	/// The startup class.
	/// </summary>
	class MainClass
	{
		/// <summary>
		/// The main of class!
		/// </summary>
		static void Main(string[] args)
		{
			// This is a inline comment!

			/*
			 * This is a comment.
			 * This is a comment.
			 * This is a comment.
			 */

			Person P1 = new Person();
			P1.ShowInfo();

			System.Console.WriteLine("\n");

			Person P2 = new Person();
			P2.FullName = "Hamid Gorji";
			P2.ShowInfo();

			System.Console.WriteLine("\n");

			Person P3 = new Person("Ali Ravanbod");
			P3.ShowInfo();

			System.Console.WriteLine("\n");

			Person P4 = new Person("Kourosh Irani", 33);
			P4.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
