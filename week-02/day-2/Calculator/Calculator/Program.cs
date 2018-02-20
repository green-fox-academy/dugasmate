using System;
using System.Collections.Generic;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations,
            // reate a method named "Calculate()":
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit
            Console.WriteLine("Please type in the expression:");
            Console.WriteLine(Calculate());
            Console.ReadLine();
        }
        static double Calculate()
        {
            var operationList = new List<string>
            {
                "+",
                "-",
                "*",
                "/",
                "%"
            };
            string operation = Console.ReadLine();
            string input = Console.ReadLine();
            double operand = Int32.Parse(input);
            string input2 = Console.ReadLine();
            double operand2 = Int32.Parse(input2);
            double output = 0;
            if (operationList.Contains(operation))
            {
                if (operation == "+")
                {
                    output = operand + operand2;
                }
                else if (operation == "-")
                {
                    output = operand - operand2;
                }
                else if (operation == "*")
                {
                    output = operand * operand2;
                }
                else if (operation == "/")
                {
                    output = operand / operand2;
                }
                else if (operation == "%")
                {
                    output = (operand / operand2) * 100;
                }
            }
            return output;
        }
    }
}