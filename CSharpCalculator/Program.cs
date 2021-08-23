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

                Console.WriteLine("Welcome to Lauren's Calculator");

                Console.WriteLine("Enter first integer > Press Enter", Color.Blue);
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second integer > Press Enter", Color.Blue);
                number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How would you like me to calculate?");
                Console.WriteLine(" - Add + ", Color.Blue);
                Console.WriteLine(" - Subtract - ", Color.Blue);
                Console.WriteLine(" - Multiply * ", Color.Blue);
                Console.WriteLine(" - Divide / ", Color.Blue);

                switch (Console.ReadLine())
                {
                    case "+":
                        Console.WriteLine($" Your answer = " + (number1 + number2) , Color.Green);
                        break;
                    case "-":
                        Console.WriteLine($" Your answer = " + (number1 - number2), Color.Green);
                        break;
                    case "*":
                        Console.WriteLine($" Your answer = " + (number1 * number2), Color.Green);
                        break;
                    case "/":
                        Console.WriteLine($" Your answer = " + (number1 / number2), Color.Green);
                        break;
                }

                        Console.ReadKey();
            }

            catch (FormatException e)
            {
                Console.WriteLine("Oops, this calculator is numbers only!", Color.Red);
            }
               
        }
    }
}