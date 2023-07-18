namespace Lesson04
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	class MainClass
	{
		static void Main(string[] args)
		{
			// Goto
			goto Lable1;

		Lable1:
			System.Console.WriteLine("Hello World!");

			int intNumber1 = 10;

			switch (intNumber1)
			{
				case 1:
				// Do Something!
				break;

				case 2:
				// Do Something!
				break;

				default:
				// Do Something!
				break;
			}

			int intNumber2 = 10;
			switch (intNumber2)
			{
				case 1:
				// Do Something!
				goto case 3;

				case 2:
				// Do Something!
				goto case 6;

				case 3:
				// Do Something!
				break;

				case 4:
				case 5:
				// Do Something!
				break;

				case 6:
				// Do Something!
				break;

				default:
				// Do Something!
				break;
			}

			// Array, It will be created in Heap!

			int[] aryintNumbers1 = new int[5]; // Zero Based!
			aryintNumbers1[0] = 10;
			aryintNumbers1[1] = 20;
			//aryintNumbers1[2] = 30;
			//aryintNumbers1[3] = 40;
			aryintNumbers1[4] = 50;

			int[] aryintNumbers2 = { 10, 20, 30, 40, 50 };

			System.Console.WriteLine("\n");
			for (int intIndex = 0; intIndex <= 4; intIndex++)
				System.Console.WriteLine("Array[{0}]: {1}", intIndex, aryintNumbers1[intIndex]);

			System.Console.WriteLine("\n");
			for (int intIndex = 0; intIndex <= aryintNumbers2.Length - 1; intIndex++)
				System.Console.WriteLine("Array[{0}]: {1}", intIndex, aryintNumbers2[intIndex]);

			System.Console.WriteLine("\n");
			foreach (int intNumber in aryintNumbers2) // intNumber is ReadOnly!
				System.Console.WriteLine("Array Value is {0}", intNumber);

			System.Console.WriteLine("\n");
			for (int intIndex = 0; intIndex <= aryintNumbers2.Length - 1; intIndex++)
			{
				aryintNumbers2[intIndex]++;
				System.Console.WriteLine("Array[{0}]: {1}", intIndex, aryintNumbers2[intIndex]);
			}

			// Wrong Usage!
			// System.Console.WriteLine("\n");
			// foreach(int intNumber in aryintNumbers2) // intNumber is ReadOnly!
			// {
			//     intNumber++;
			//     System.Console.WriteLine("Array Value is {0}", intNumber);
			// }

			System.Console.ReadLine();
		}
	}
}
