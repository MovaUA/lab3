using System;

namespace lab3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var strategy = new Strategy();

			try
			{
				strategy.Create(args);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
