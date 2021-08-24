using System;

namespace CSharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Animated console window*/
            for (int i = 1; i <40; i++)
            { 
                Console.SetWindowSize(i, i);
<<<<<<< HEAD
                System.Threading.Thread.Sleep(10);
=======
                System.Threading.Thread.Sleep(15);
>>>>>>> a28f1083076ddb08d4a91be7ae08f92e40fdab13
            }

            try
            {
                int number1;
                int number2 = 0;

                /* Setting Colors and creating title*/
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Welcome to Lauren's Calculator");

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;

                /* Creating calculator input*/
                Console.WriteLine("Enter first integer > Press Enter");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second integer > Press Enter");
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How would you like me to calculate?");
                Console.WriteLine(" - Add + ");
                Console.WriteLine(" - Subtract - ");
                Console.WriteLine(" - Multiply * ");
                Console.WriteLine(" - Divide / ");

                /* Creating a switch case for calculator output*/
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
            /* Creating exception for non-numnerical characters*/
            catch (FormatException e)

            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  :(  Oops, this calculator uses numbers only!  :(  ");
            }
        }
    }
}