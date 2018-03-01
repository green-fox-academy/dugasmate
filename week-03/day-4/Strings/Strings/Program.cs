using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ConvertToY(input));
            Console.ReadLine();
        }
        static string ConvertToY(string input)
        {
            if (input.Length == 1)
            {
                if (input[0] == 'x')
                {
                    return input = "y";
                }
                else
                {
                    return input;
                }

            }
            else
            {
                if (input[0] == 'x')
                {

                    return input = "y" + ConvertToY(input.Substring(1));
                }
                else
                {
                    return input = input[0] + ConvertToY(input.Substring(1));
                }
                
            
            }
        }

    }
}
