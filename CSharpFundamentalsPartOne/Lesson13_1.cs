namespace Lesson13_1
{
	/// <summary>
	/// Last Review Date: 11 April 2018
	/// Version 2.0.0 (14 April 2015)
	/// Written By Hamed Banaei
	/// EMail: kouroshishere@gmail.com
	/// </summary>
	public enum FileAttributes
	{
		Readonly = 1,
		Hidden = 2,
		Archive = 4,
		Compressed = 8,
		System = 16
	}

	public class File
	{
		public string FileName;
		public FileAttributes Attribute;

		public File(string fileName)
		{
			FileName = fileName;
		}

		public File(string fileName, FileAttributes attribute)
		{
			FileName = fileName;
			Attribute = attribute;
		}

		public void ShowInfo()
		{
			System.Console.WriteLine("\n Filename: {0}, Attribute: {1}.", FileName, Attribute);
		}
	}

	class MainClass
	{
		static void Main(string[] args)
		{
			File oFile = new File("Temp.tmp");

			oFile.Attribute = FileAttributes.Readonly;
			oFile.Attribute = FileAttributes.Readonly | FileAttributes.Hidden | FileAttributes.Archive;

			if (oFile.Attribute == FileAttributes.Hidden)
				System.Console.WriteLine("This file is Hidden");
			else
				System.Console.WriteLine("This file is not Hidden");

			// Wrong Usage!
			// if (oFile.Attribute & FileAttributes.Hidden == FileAttributes.Hidden)
			if ((oFile.Attribute & FileAttributes.Hidden) == FileAttributes.Hidden)
				System.Console.WriteLine("This file is Hidden");
			else
				System.Console.WriteLine("This file is not Hidden");

			if ((oFile.Attribute & FileAttributes.Compressed) == FileAttributes.Compressed)
				System.Console.WriteLine("This file is Compressed");
			else
				System.Console.WriteLine("This file is not Compressed");

			oFile.ShowInfo();

			System.Console.ReadLine();
		}
	}
}
