using System;

namespace F.Books_Challenges.Level4
{
    public class Level4Challenge : ILevel
    {
        public int Number => 4;

        public void Run()
        {
            Console.WriteLine("Level 4 Challenge Running...");

            Console.WriteLine("What kind of thing are we talking about?");
            string Thing = Console.ReadLine() ?? "Thing"; // The object that we are talking about
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string Describe = Console.ReadLine() ?? "Big"; // The Adjective
            string Doom = "Doom"; // Of Doom or something
            string Number = "3000"; // Big number
            Console.WriteLine("The " + Describe + " " + Thing + " of " + Doom + " " + Number + "!");

            Program.WaitForKeyAndReturnToMenu();
        }
    }
}