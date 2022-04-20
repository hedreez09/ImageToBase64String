using System;

namespace ImageToBase64String
{
	class Program
	{
		static void Main(string[] args)
		{
			string imagePath = @"C:\Projects\factory.png";
			string imgBase64String = GetBase64StringForImage(imagePath);
			Console.WriteLine(imgBase64String);
		}
		protected static string GetBase64StringForImage(string imgPath)
		{
			byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
			string base64String = Convert.ToBase64String(imageBytes);
			return base64String;
		}
	}
}
