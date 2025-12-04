namespace MyFirstProgram
{
    class ArithmeticOperators
    {
        static void Main(string[] args)
        {
            // Arithmetic operators in C# are symbols used to perform basic mathematical operations on numeric values. 
            // Here are the main ones:

            // addition(+)
            int a = 1 + 2;
            System.Console.WriteLine(a);
            
            // subtraction(-)
            int b = 6 - 1;
            System.Console.WriteLine(b);

            // multplication(*)
            int c = 7 * 2;
            System.Console.WriteLine(c);

            //  division(/)     Note: int division drops decimal values.
            int d = 5 / 2;
            System.Console.WriteLine(d);

            double e = 7.0 / 3;
            System.Console.WriteLine(e); 

            // modulus(remainder)(%)
            int f = 10 % 3;
            System.Console.WriteLine(f);
            
            // Increment & Decrement Operators
            // Increment(x++)   - add 1 to x
            int g = 6;
            g++;
            System.Console.WriteLine(g);

            // Decrement(x--)   - subtract 1 from  x
            int h = 7;
            h--;
            System.Console.WriteLine(h);

            // Incrementing and Decrementing by specific numnber
            int i = 10;
            i += 10;
            System.Console.WriteLine(i);

            i -= 5;
            System.Console.WriteLine(i); 
        }
    }
}