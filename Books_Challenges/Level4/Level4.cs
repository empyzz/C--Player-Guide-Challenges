using System;

namespace Book_Challenges.Level4
{
    public class Level4Challenge
    {
        public static void Run()
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string Thing = Console.ReadLine(); // The object that we are talking about
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string Describe = Console.ReadLine(); // The Adjective
            string Doom = "Doom"; // Of Doom or something
            string Number = "3000"; // Big number
            Console.WriteLine("The " + Describe + " " + Thing + " of " + Doom + " " + Number + "!");
        }
    }
}