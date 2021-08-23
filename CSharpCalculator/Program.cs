using System;

namespace CSharpCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1; int number2 = 0;

            Console.WriteLine("Welcome to Lauren's Calculator");

            Console.WriteLine("Enter first variable > Press Enter");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Variable > Press Enter");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Option?");
            Console.WriteLine("\t+ - To Add");
            Console.WriteLine("\t- - To Subtract");
            Console.WriteLine("\t* - To Multiply");
            Console.WriteLine("\t/ - To Divide");

            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($" = " + (number1 + number2));
                    break;
                case "-":
                    Console.WriteLine($" = " + (number1 - number2));
                    break;
                case "*":
                    Console.WriteLine($" = " + (number1 * number2));
                    break;
                case "/":
                    Console.WriteLine($" = " + (number1 / number2));
                    break;

                    Console.ReadKey();
            }
        }
    }
}