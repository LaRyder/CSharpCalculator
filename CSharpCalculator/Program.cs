using System;
using System.Drawing;

namespace CSharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int number1;
                int number2 = 0;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Welcome to Lauren's Calculator");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;

                Console.WriteLine("Enter first integer > Press Enter");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second integer > Press Enter");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How would you like me to calculate?");
                Console.WriteLine(" - Add + ");
                Console.WriteLine(" - Subtract - ");
                Console.WriteLine(" - Multiply * ");
                Console.WriteLine(" - Divide / ");

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($" Your answer = " + (number1 + number2));
                        break;
                    case "-":
                        Console.WriteLine($" Your answer = " + (number1 - number2));
                        break;
                    case "*":
                        Console.WriteLine($" Your answer = " + (number1 * number2));
                        break;
                    case "/":
                        Console.WriteLine($" Your answer = " + (number1 / number2));
                        break;
                }

                Console.ReadKey();
            }

            catch (FormatException e)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  :(  Oops, this calculator uses numbers only!  :(  ");
                
            }
        }
    }
}