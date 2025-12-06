using System;

namespace MyFirstProgram
{
    class CodingExercise003
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side A: ");
            double sideA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side B: ");
            double sideB = Convert.ToDouble(Console.ReadLine());
            
            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
            hypotenuse = Math.Round(hypotenuse, 2);

            Console.WriteLine("The hypotenuse of a triangle is: " + hypotenuse);
            
            Console.ReadKey();
        }
    }
}