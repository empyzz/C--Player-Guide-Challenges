using System;

namespace F.Books_Challenges.Level10
{
    public class Level10Challenge : ILevel
    {
        public int Number => 10;
        public void Run()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("The following items are available:");

            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("What number do you want to see the price of? ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (name == "Rafael")
                        Console.WriteLine("Rope costs 5 gold.");
                    else
                        Console.WriteLine("Rope costs 10 gold.");           
                    break;
                case 2:
                    if (name == "Rafael")
                        Console.WriteLine("Torches cost 7.5 gold.");
                    else
                        Console.WriteLine("Torches cost 15 gold.");
                    break;
                case 3:
                    if (name == "Rafael")
                        Console.WriteLine("Climbing Equipment costs 12.5 gold.");
                    else
                        Console.WriteLine("Climbing Equipment costs 25 gold.");
                    break;
                case 4:
                    if (name == "Rafael")
                        Console.WriteLine("Clean Water costs 0.5 gold.");
                    else
                        Console.WriteLine("Clean Water costs 1 gold.");
                    break;
                case 5:
                    if (name == "Rafael")
                        Console.WriteLine("Machete costs 10 gold.");
                    else
                        Console.WriteLine("Machete costs 20 gold.");
                    break;
                case 6:
                    if (name == "Rafael")
                        Console.WriteLine("Canoe costs 100 gold.");
                    else
                        Console.WriteLine("Canoe costs 200 gold.");
                    break;
                case 7:
                    if (name == "Rafael")
                        Console.WriteLine("Food Supplies cost 0.5 gold.");
                    else
                        Console.WriteLine("Food Supplies cost 1 gold.");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't know that item.");
                    break;
            }
        }
    }
}