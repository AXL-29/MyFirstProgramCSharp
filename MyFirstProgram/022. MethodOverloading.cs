using System;

class MethodOverloading
{
    static void Main(string[] args)
    {
        /*
            Method overloading - multiple methods with the same name, as long as their parameter list are different.
            This lets you reuse a clear meaningful method name while handling different outputs
        */

        int sumOfTwo = Add(12, 23);         // calls Add(int, int)
        int sumOfThree = Add(1, 2, 3);      // calls Add(int, int, int)

        Console.WriteLine(sumOfTwo);
        Console.WriteLine(sumOfThree);

        double productOfDouble = Multiply(14.32, 12.32);
        int productOfInt = Multiply(12, 34);
        // C# decides which method use based on the arguments
        
        Console.WriteLine(productOfDouble);
        Console.WriteLine(productOfInt);

        Console.ReadKey();
    }

    // basic example:
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b;
    }

    // Overloading with different parameter types
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    // C# decides which method to use based on the arguments

    /*
        Why method overloading is useful?
            - Cleaner API design
            - Easier to remember method names
            - Common in real-world libraries
            - Important for OOP and algorithms
    */
}