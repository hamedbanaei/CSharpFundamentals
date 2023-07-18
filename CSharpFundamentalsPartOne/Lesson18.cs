namespace Lesson18
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public class Stack
	{
		private int _index;
		private int[] _numbers;

		public Stack(int size)
		{
			_index = -1;
			_numbers = new int[size];
		}

		public bool Push(int number)
		{
			bool blnResult = false;

			if (_index < _numbers.Length - 1)
			{
				_index++;
				_numbers[_index] = number;

				blnResult = true;
			}

			return (blnResult);
		}

		public bool Pop(out int result)
		{
			bool blnResult = false;
			result = 0; // [result] variable must be initialized in this method anyway!

			if (_index != -1)
			{
				result = _numbers[_index];
				_index--;

				blnResult = true;
			}

			return (blnResult);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			int intTemp;

			Stack S1 = new Stack(3);
			Stack S2 = new Stack(20);
			Stack S3 = new Stack(50);

			System.Console.WriteLine("Result of S1.Push(1): {0}", S1.Push(1));
			System.Console.WriteLine("Result of S1.Push(2): {0}", S1.Push(2));
			System.Console.WriteLine("Result of S1.Push(3): {0}", S1.Push(3));
			System.Console.WriteLine("Result of S1.Push(4): {0}", S1.Push(4));

			System.Console.WriteLine("\n----------");

			if (S1.Pop(out intTemp))
				System.Console.WriteLine("Result of S1.Pop(ref intTemp): True, Result: {0}", intTemp);
			else
				System.Console.WriteLine("S1 does not have any number for poping!");

			if (S1.Pop(out intTemp))
				System.Console.WriteLine("Result of S1.Pop(ref intTemp): True, Result: {0}", intTemp);
			else
				System.Console.WriteLine("S1 does not have any number for poping!");

			if (S1.Pop(out intTemp))
				System.Console.WriteLine("Result of S1.Pop(ref intTemp): True, Result: {0}", intTemp);
			else
				System.Console.WriteLine("S1 does not have any number for poping!");

			if (S1.Pop(out intTemp))
				System.Console.WriteLine("Result of S1.Pop(ref intTemp): True, Result: {0}", intTemp);
			else
				System.Console.WriteLine("S1 does not have any number for poping!");

			System.Console.ReadLine();
		}
	}
}
