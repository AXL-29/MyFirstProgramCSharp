using System;

namespace MyFirstProgram
{
    class CodingExercise001
    {
        static void Main(string[] args)
        {
            // TODO: Ask the user to enter one number
            // TODO: Read the user's input using Console.ReadLine()
            // TODO: Convert the input string into a double (typecasting)
            // TODO: Declare a constant called MULTIPLIER with a value of 2.5
            // TODO: Multiply the user's number by MULTIPLIER and store the result

            // TODO: Calculate the square of the number using arithmetic (number * number)
            // TODO: Calculate the square root of the number using Math.Sqrt()

            // TODO: Round the number normally using Math.Round()
            // TODO: Round the number up using Math.Ceiling()
            // TODO: Round the number down using Math.Floor()

            // TODO: Display all results using Console.WriteLine()

            const double MULTIPLIER = 2.5;

            System.Console.Write("Please enter a number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            double multipleResult = number * MULTIPLIER;
            double squareResult = number * number;
            double squareRootResult = Math.Sqrt(squareResult);

            double roundNumber = Math.Round(number);
            double ceilingNumber = Math.Ceiling(number);
            double floorNumber = Math.Floor(number);

            System.Console.WriteLine("\n------------------ RESULTS ------------------\n");
            System.Console.WriteLine("Multiplied Result: " + multipleResult);
            System.Console.WriteLine("Square Result:  " + squareResult);
            System.Console.WriteLine("Square Root Result: " + squareRootResult);
            System.Console.WriteLine("Round Number Result: " + roundNumber);
            System.Console.WriteLine("Ceiling Number Result: " + ceilingNumber);
            System.Console.WriteLine("Floor Number Result: " + floorNumber);
                       
        }
    }
}