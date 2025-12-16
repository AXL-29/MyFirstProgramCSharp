using System;

class CalculatorProgram
{
    static void Main(string[] args)
    {
        bool isCalculatorOn = true;
        string mathOperator = "";
        double result;
        
        while (isCalculatorOn)
        {
            Console.Write("Enter a first number: ");
            double firstNum = Convert.ToInt32(Console.ReadLine());

            while(true)
            {       
                Console.Write("Enter an operator (+, -, *, /, or %): ");
                mathOperator = Console.ReadLine();

                if (
                    (mathOperator == "+") ||
                    (mathOperator == "-") ||
                    (mathOperator == "*") ||
                    (mathOperator == "/") ||
                    (mathOperator == "%"))
                {
                    break;
                }
                Console.WriteLine("Please typed (+, -, * /, or %) only.");  
            }

            Console.Write("Enter a second number: ");
            double secondNum = Convert.ToInt32(Console.ReadLine());

            switch (mathOperator)
            {
                case "+":
                result = firstNum + secondNum;
                Console.WriteLine("The sum of two numbers is: " + Math.Round(result, 2));
                break;

                case "-":
                result = firstNum - secondNum;
                Console.WriteLine("The difference of two numbers is: " + Math.Round(result, 2));
                break;

                case "*":
                result = firstNum * secondNum;
                Console.WriteLine("The product of two numbers is: " + Math.Round(result, 2));
                break;

                case "/":
                    if (secondNum == 0)
                    {
                        Console.WriteLine("Sorry, the first number cannot be divided by zero");
                        break;
                    }
                    else
                    {
                        result = firstNum + secondNum;
                        Console.WriteLine("The sum of two numbers is: " + Math.Round(result, 2));
                        break;                        
                    }
                
                case "%":
                result = firstNum % secondNum;
                Console.WriteLine("The remainder of two numbers is: " + Math.Round(result, 2));
                break;
            }
            
            Console.WriteLine();

            while (true)
            {
                Console.Write("Do you want to calculate again? (y/n): ");
                string calculateAgain = Console.ReadLine().ToLower();

                if (calculateAgain == "y")
                {
                    break;
                }
                else if (calculateAgain == "n")
                {
                    Console.WriteLine("Thank you for using our calculator app!");
                    isCalculatorOn = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose between 'y' or 'n' only!");
                }
            }
            
        Console.WriteLine();

        }

        Console.ReadKey();
    }
}
