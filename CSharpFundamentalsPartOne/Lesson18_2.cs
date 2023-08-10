namespace Lesson18_2
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

		public void ShowInfo()
		{
			System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
		}
	}

	class MainClass
	{
		/// <summary>
		/// Working With Arrays
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			int[] aryintNumbers = new int[2];
			aryintNumbers[0] = 5;
			aryintNumbers[1] = 10;

			Person[] oPersons = new Person[2];

			// Wrong Usage!
			// You must first make a new person in array!
			//
			// oPersons[0].Age = 5;
			// oPersons[0].FullName = "Ali Reza Alavi";

			// ********************
			// *** Solution (1) ***
			// ********************
			oPersons[0] = new Person();
			oPersons[1] = new Person();

			// ********************
			// *** Solution (2) ***
			// ********************
			for (int intIndex = 0; intIndex < oPersons.Length; intIndex++)
				oPersons[intIndex] = new Person();

			oPersons[0].Age = 27;
			oPersons[0].FullName = "Ali Ravanbod";
			oPersons[0].ShowInfo();

			int[,] RectangularArray = new int[2, 3]; // Rectangular Array!

			RectangularArray[0, 0] = 1;
			RectangularArray[0, 1] = 2;
			RectangularArray[0, 2] = 3;

			for (int intX = 0; intX < 2; intX++)
			{
				for (int intY = 0; intY < 3; intY++)
				{
					RectangularArray[intX, intY] = intX * intY;
				}
			}

			int[][] JaggedArray = new int[3][]; // Jagged Array!

			JaggedArray[0] = new int[2];
			JaggedArray[1] = new int[5];
			JaggedArray[2] = new int[3];

			JaggedArray[0][0] = 1;
			JaggedArray[0][1] = 2;

			JaggedArray[1][0] = 3;
			JaggedArray[1][1] = 4;
			JaggedArray[1][2] = 5;
			JaggedArray[1][3] = 6;

			System.Console.ReadLine();
		}
	}
}
