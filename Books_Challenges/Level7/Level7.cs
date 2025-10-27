namespace F.Books_Challenges.Level7
{
    public class Level7Challenge : ILevel
    {
        public int Number => 7;

        public void Run()
        {
            Console.WriteLine("Level 7 Challenge Running...");
            Triangle();
            Thread.Sleep(500);
            FourSisters();
            Thread.Sleep(500);
            DominionOfKings();
            Program.WaitForKeyAndReturnToMenu();
        }

        public static void Triangle()
        {
            Console.WriteLine("*Triangle Area Calculator*");
            Console.Write("Input the base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseLength * height;
            Console.WriteLine($"The area of the triangle is: {area}");
        }

        public static void FourSisters()
        {
            Console.WriteLine("*The Four Sisters Problem*");
            Console.Write("Enter the total number of chocolate eggs gathered today: ");

            int totalEggs = Convert.ToInt32(Console.ReadLine());

            int eggsPerSister = totalEggs / 4;
            int duckbearEggs = totalEggs % 4;

            Console.WriteLine($"\nEach sister gets {eggsPerSister} egg(s).");
            Console.WriteLine($"The duckbear gets {duckbearEggs} egg(s).");

            Program.WaitForKeyAndReturnToMenu();
        }

        public static void DominionOfKings()
        {
            Console.WriteLine("*Dominion of Kings Problem*");

            Console.Write("Enter the number of Provinces: ");
            int provinces = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of Duchies: ");
            int duchies = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of Estates: ");
            int estates = Convert.ToInt32(Console.ReadLine());

            int score = (provinces * 6) + (duchies * 3) + (estates * 1);

            Console.WriteLine($"\nThe number of total points: {score}");
        }
    }
}
