namespace F.Books_Challenges.Level8
{
    public class Level8Challenge : ILevel
    {
        public int Number => 8;
        public void Run()
        {
            Console.WriteLine("Level 8 Challenge Running...");

            DefenseOfConsolas();

            Program.WaitForKeyAndReturnToMenu();
        }

        public static void DefenseOfConsolas()
        {
            Console.WriteLine("*Defense of Consolas Problem*");

            Console.Title = "Defense of Consolas";

            int row = ReadIntFromUser("Target Row? ");

            int col = ReadIntFromUser("Target Column? ");

            var positions = new (int r, int c)[]
            {
                (row, col - 1), // left
                (row - 1, col), // up
                (row, col + 1), // right
                (row + 1, col)  // down
            };

            Console.WriteLine();
            var previous = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Deploy to:");
            foreach (var p in positions)
            {
                Console.WriteLine($"({p.r}, {p.c})");
            }

            Console.ForegroundColor = previous;

            Console.Beep(800, 200);
            Console.Beep(1000, 200);
            Console.Beep(1200, 200);

            Console.WriteLine();
        }

        static int ReadIntFromUser(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    return value;
                }
                Console.WriteLine("Please enter a valid integer.");

            }
        }
    }
}