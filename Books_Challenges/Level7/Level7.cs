namespace F.Books_Challenges.Level7
{
    public class Level7Challenge : ILevel
    {
        public int Number => 7;

        public void Run()
        {
            Console.WriteLine("Level 7 Challenge Running...");
            Console.WriteLine("*Triangle Area Calculator*");
            Console.Write("Input the base: ");
            double baseLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double area = 0.5 * baseLength * height;
            Console.WriteLine($"The area of the triangle is: {area}");

            Program.WaitForKeyAndReturnToMenu();
        }
    }
}