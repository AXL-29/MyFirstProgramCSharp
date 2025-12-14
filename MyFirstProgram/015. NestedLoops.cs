using System;

namespace MyFirstProgram
{
    class NestedLoops
    {
        static void Main(string[] args)
        {
            /*
                A nested loop is simply a loop inside another loop.
                    - The inner loop runs completely for every single iteration of the outer loop.
            */

            for (int i = 1; i <=3; i++)
            {
                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("i = " + i + ", j = " + j);
                }
            }

            /*
                How it runs:
                    - Outer loop (i) runs 3 times
                    - Inner loop (j) runs 2 times for each i
                    - Total executions: 3 x 2 = 6
            */

            // Create a rectangle, ask for the user how many rows, columns and symbol to use.

            int rows, col = 0;
            String symbol = "";

            Console.Write("How many rows?: ");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("How many column?: ");
            col = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What symbol to use: ");
            symbol = Console.ReadLine();

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }


}
