using System;       // this is required to access the system built-in class.

namespace MyFirstProgram
{
    class MathClass
    {
        static void Main(string[] args)
        {
            // In C#, the Math Class is a built-in class in the System namespace that provides advanced mathematical functions and constants.
            // Math.Abs(x)  - returns the absolute value of a number (always positive)
            int a = Math.Abs(-10);
            int b = Math.Abs(5);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);

            // Math.Sqrt(x) - returns the square root of a number.
            double c = Math.Sqrt(25);
            System.Console.WriteLine(c);

            // Math.Pow(x, y)   - returns x raised to the power of y.
            double d = Math.Pow(2, 5);
            System.Console.WriteLine(d);

            // Math.Round(x)    - rounds to the nearest whole number.
            double e = Math.Round(3.5);
            double f = Math.Round(2.3);
            System.Console.WriteLine(e);
            System.Console.WriteLine(f);

            // Math.Ceiling(x)  - always rounds UP to the nearest whole number.
            double g = Math.Ceiling(5.01);
            double h = Math.Ceiling(5.99);
            System.Console.WriteLine(g);
            System.Console.WriteLine(h);

            // Math.Floor(x)    - always round DOWN to the nearest whole number.
            double i = Math.Floor(8.99);
            double j = Math.Floor(8.01);
            System.Console.WriteLine(i);
            System.Console.WriteLine(j);

            // Math.Max(a, b)   - returns the largest of two numbers.
            double k = Math.Max(10, 20);
            System.Console.WriteLine(k);

            // Math.Min(a, b)   - returns the smallest of two numbers.
            double l = Math.Min(8, 29);
            System.Console.WriteLine(l);
        }
    }
}