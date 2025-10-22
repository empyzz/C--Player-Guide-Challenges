using System;


namespace F.Books_Challenges.Level3
{
    public class Level3Challenge : ILevel
    {
        public int Number => 3;

        public void Run() 
        {
            Console.WriteLine("Level 3 Challenge Running...");
            Console.WriteLine("Hello World!");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");

            Console.WriteLine("Bread is Ready");
            Console.WriteLine("Who is the bread for?");
            Console.WriteLine(">>>");
            string x  = Console.ReadLine();
            Console.WriteLine($"Noted: {x} got bread"); 
        }
    }
}


/* 
using System;

namespace Book_Challenges.Level$
{
    public class Level$Challenge
    {
        public static void Run()
        {
        }
    }
}
*/