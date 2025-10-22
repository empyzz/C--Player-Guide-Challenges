using System;

namespace Book_Challenges.Level6
{
    public class Level6Challenge
    {
        public static void Run()
        {

        byte a = 25;
        short b = -1500;
        int c = 35000;
        long d = 5000000000L;
        sbyte e = -50;
        ushort f = 60000;
        uint g = 4000000000;
        ulong h = 9000000000000000000;
        float i = 3.14f;
        double j = 123.456;
        decimal k = 9876.54321m;
        char l = 'A';
        string m = "Hello, world!";
        bool n = true;

        Console.WriteLine("=== Original Values ===");
        Console.WriteLine($"byte: {a}");
        Console.WriteLine($"short: {b}");
        Console.WriteLine($"int: {c}");
        Console.WriteLine($"long: {d}");
        Console.WriteLine($"sbyte: {e}");
        Console.WriteLine($"ushort: {f}");
        Console.WriteLine($"uint: {g}");
        Console.WriteLine($"ulong: {h}");
        Console.WriteLine($"float: {i}");
        Console.WriteLine($"double: {j}");
        Console.WriteLine($"decimal: {k}");
        Console.WriteLine($"char: {l}");
        Console.WriteLine($"string: {m}");
        Console.WriteLine($"bool: {n}");

        Console.WriteLine("\n=== Updated Values ===");

        a = 200;
        b = 12345;
        c = -987654321;
        d = 1234567890123456789;
        e = 100;
        f = 32000;
        g = 1234567890;
        h = 9876543210987654321;
        i = 9.81f;
        j = -0.000123;
        k = 42.42m;
        l = 'Z';
        m = "Updated text!";
        n = false;

        Console.WriteLine($"byte: {a}");
        Console.WriteLine($"short: {b}");
        Console.WriteLine($"int: {c}");
        Console.WriteLine($"long: {d}");
        Console.WriteLine($"sbyte: {e}");
        Console.WriteLine($"ushort: {f}");
        Console.WriteLine($"uint: {g}");
        Console.WriteLine($"ulong: {h}");
        Console.WriteLine($"float: {i}");
        Console.WriteLine($"double: {j}");
        Console.WriteLine($"decimal: {k}");
        Console.WriteLine($"char: {l}");
        Console.WriteLine($"string: {m}");
        Console.WriteLine($"bool: {n}");

        }
    }
}