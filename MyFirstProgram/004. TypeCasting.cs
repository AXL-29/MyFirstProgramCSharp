namespace MyFirstProgram
{
    class TypeCasting
    {
        static void Main(string[] args)
        {
            // Typecasting in C# means converting one data type into another.
            // It's also called type conversion.

            // Major Types of Typecasting.
            // 1. Implicit Typecasting (Automatic)
            //  - Happens automatically
            //  - No data loss
            //  - Converts smaller -> larger data type.

            int num = 10;
            double result = num;    // int automatically becomes double

            System.Console.WriteLine(result);

            // 2. Explicit Typecasting (Manual)
            //  - You must tell C# to convert
            //  - May cause data loss
            //  - Converts larger -> smaller data type

            double value = 9.90;
            int result1 = (int)value;    // result = 9, the .99 is lost.

            System.Console.WriteLine(result1);

            // 3. Convert Class
            //  - Built-in class for converting between types(int, double, bool, string, etc.)
            //  - Can round numbers, convert booleans, and parse strings.

            string str = "25";
            int a = Convert.ToInt32(str);       // string -> int
            System.Console.WriteLine(a + 5);

            double b = 3.7;
            int rounded = Convert.ToInt32(b);   // rounds to 4
            System.Console.WriteLine(rounded);

            bool c = true;
            int boolInt = Convert.ToInt32(c);   // true -> 1, false -> 0
            System.Console.WriteLine(boolInt);

            // Other convert methods:
            System.Console.WriteLine(Convert.ToDouble("3.14"));
            System.Console.WriteLine(Convert.ToBoolean(1));
            System.Console.WriteLine(Convert.ToString(123));

            // Additionally we can use the .GetType() to print what is the data type of the variable.
            System.Console.WriteLine(boolInt.GetType());

            System.Console.ReadKey();

        }
    }
}
