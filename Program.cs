global using System;
global using System.Reflection;
using F.Books_Challenges;

namespace F
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("Choose a Level to run:");

            var levels = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(ILevel).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(t => (ILevel)Activator.CreateInstance(t)!)
                .ToDictionary(l => l.Number);

            foreach (var number in levels.Keys.OrderBy(n => n))
                Console.WriteLine($"Level {number}");

            if (int.TryParse(Console.ReadLine(), out int choice) &&
                levels.TryGetValue(choice, out var selected))
            {
                Console.WriteLine($"Running Level {choice}...\n\n\n\n");
                selected.Run();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Invalid level number.");
            }
        }

        public static void WaitForKeyAndReturnToMenu()
        {
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            Main();
        }
    }
}
