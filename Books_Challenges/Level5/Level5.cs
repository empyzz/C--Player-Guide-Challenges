using System;

namespace F.Books_Challenges.Level5
{
    public class Level5Challenge : ILevel
    {
        public int Number => 5;

        public void Run()
        {
            Console.WriteLine("Level 5 Challenge Running...");

            int x = 1;
            string y = "tetete";
            char j = '7';
            float f = 2.5000001f;  
            double d = 2.5000000000000001; 
            decimal z = 2.0m; 

            // Print type and value
            Console.WriteLine($"x: Type = {x.GetType()}, Value = {x}");
            Console.WriteLine($"y: Type = {y.GetType()}, Value = {y}");
            Console.WriteLine($"j: Type = {j.GetType()}, Value = {j}");
            Console.WriteLine($"f: Type = {f.GetType()}, Value = {f}");
            Console.WriteLine($"d: Type = {d.GetType()}, Value = {d}");
            Console.WriteLine($"z: Type = {z.GetType()}, Value = {z}");

            Program.WaitForKeyAndReturnToMenu();
        }
    }
}