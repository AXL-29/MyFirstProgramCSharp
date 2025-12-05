using System;

namespace MyFirstProgram
{
    class CodingExercise002
    {
        static void Main(string[] args)
        {
            // Circle Measurements
            // Ask the user for the radius of a circle.
            // Convert the input to a double.
            // Use a constant PI = 3.14159.
            // Calculate and display:
                // Diameter (2 * radius)
                // Circumference (2 * PI * radius)
                // Area (PI * radius^2 using Math.Pow())

            const double PI = 3.14159;

            Console.WriteLine("Welcome to Circle Measurements Calculator.");

            Console.Write("Please enter the radius of a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            double diameter = Math.Round((2 * radius), 2);
            double circumference = Math.Round((2 * PI * radius), 2);
            double area = Math.Round((PI * Math.Pow(radius, 2)), 2);

            Console.WriteLine("\n---------------- CIRCLE MEASUREMENTS ----------------\n");
            Console.WriteLine("You entered radius: " + radius);
            Console.WriteLine("Diameter of a Circle: " + diameter);
            Console.WriteLine("Circumference of a Circle: " + circumference);
            Console.WriteLine("Area of a Circle: " + area);
            Console.WriteLine("\n--------------------- THANK YOU ---------------------");

            Console.ReadKey();
        }
    }
}