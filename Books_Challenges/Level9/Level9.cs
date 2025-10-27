using System;

namespace F.Books_Challenges.Level9
{
    public class Level9Challenge : ILevel
    {
        public int Number => 9;
        public void Run()
        {
            Console.WriteLine("Level 9 Challenge Running...");
            ClockTower();
            Watchtower();
            Program.WaitForKeyAndReturnToMenu();
        }

        public static void ClockTower()
        {
            Console.WriteLine("*Repairing the ClockTower*");

            Console.WriteLine("Input a Number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("Tick");
            else
                Console.WriteLine("Tock");
        }
        
        public static void Watchtower()
            {
                Console.WriteLine("*Watchtower*");

                Console.Write("Enter the X coordinate of the enemy: ");
                int x = int.Parse(Console.ReadLine() ?? "0");

                Console.Write("Enter the Y coordinate of the enemy: ");
                int y = int.Parse(Console.ReadLine() ?? "0");

                Console.WriteLine();

                if (x == 0 && y == 0)
                {
                    Console.WriteLine("The enemy is here!");
                }
                else if (x == 0 && y > 0)
                {
                    Console.WriteLine("The enemy is to the north!");
                }
                else if (x == 0 && y < 0)
                {
                    Console.WriteLine("The enemy is to the south!");
                }
                else if (x > 0 && y == 0)
                {
                    Console.WriteLine("The enemy is to the east!");
                }
                else if (x < 0 && y == 0)
                {
                    Console.WriteLine("The enemy is to the west!");
                }
                else if (x > 0 && y > 0)
                {
                    Console.WriteLine("The enemy is to the northeast!");
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("The enemy is to the northwest!");
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("The enemy is to the southeast!");
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("The enemy is to the southwest!");
                }

            }
    }
}