using System;

namespace MyFirstProgram
{
    class WhileLoops
    {
        static void Main(string[] args)
        {
            /*
                A while loop is a control structure that repeats a block of code as long as a condition is true.

                basic syntax:
                    while (condition)
                    {
                        // Code to repeat
                    }
                
                - The condition is checked before each loop iteration
                - If the condition is true, the loops runs.
                - If it becomes false, the loop stops.

                When to use a while loop?

                Use a while loop when:
                    - You don't know in advance how many times the loop should run.
                    - The loop depends on a condition changing during execution.
            */

            String name = "";

            while (string.IsNullOrEmpty(name))
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);
        }
    }
}
