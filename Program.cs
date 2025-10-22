using System;
using Book_Challenges;

class Program
{
		static void Main()
		{
				Console.WriteLine("Starting...");
				Console.WriteLine("Choose a Level to run.");
				var choice = Console.ReadLine();

				switch (choice)
				{
						case "1":
								Book_Challenges.Level1.Level1Challenge.Run();
								break;
						default:
								Console.WriteLine("Invalid");
								break;
				}
				
		}
}

