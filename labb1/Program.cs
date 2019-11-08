using System;

namespace labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            var menuChoice = "0";

            do
            {
                Console.WriteLine("\nMAIN MENU\n1. Add two numbers\n" +
                    "2. Multiply two numbers\n" +
                    "3. Sum the numbers between two numbers.\n" +
                    "4. Add number to memory\n" +
                    "5. Clear memory\n" +
                    "6. Print calculator contents.\n" +
                    "7. Quit\n\n" +
                    "Enter a number to choose:"
                    );

                menuChoice = Console.ReadLine();

                switch (menuChoice) {
                    case "0":
                        break;
                    case "1":
                        Console.WriteLine("Enter two numbers to sum them:");
                        WriteFirstAndSecondNumber(calc);
                        Console.WriteLine("\nSum:" + calc.SumNumbers());
                        break;
                    case "2":
                        Console.WriteLine("Enter two numbers to multiply them:");
                        WriteFirstAndSecondNumber(calc);
                        Console.WriteLine("\nProduct:" + calc.MultiplyNumbers());
                        break;
                    case "3":
                        Console.WriteLine("Enter two numbers to sum all of the numbers in between:");
                        WriteFirstAndSecondNumber(calc);
                        Console.WriteLine("\nSum in between:" + calc.SumInBetween());
                        break;
                    case "4":
                        Console.WriteLine("Enter a number to add it to memory:");
                        WriteNumberToMemory(calc);
                        Console.WriteLine("\nNumber successfully added to memory");
                        break;
                    case "5":
                        calc.NumberInMemory = 0;
                        Console.WriteLine("Number in memory cleared");
                        break;
                    case "6":
                        Console.WriteLine(calc);
                        break;
                    case "7":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Not a valid menu option!");
                        break;
                }


            } while (menuChoice != "7");
        }

        private static void WriteNumberToMemory(Calculator calc)
        {
            var successful = false;
            while (!successful)
            {
                try
                {
                    calc.NumberInMemory = double.Parse(Console.ReadLine());
                    successful = true;
                }
                catch
                {
                    Console.WriteLine("You didnt enter a correct number value, try again!");
                }
            }
            
        }

        private static void WriteFirstAndSecondNumber(Calculator calc)
        {
            var successful = false;
            while (!successful)
            {
                try
                {
                    calc.FirstNumber = double.Parse(Console.ReadLine());
                    calc.SecondNumber = double.Parse(Console.ReadLine());
                    successful = true;
                }
                catch
                {
                    Console.WriteLine("You didnt enter a correct number value, try again!");
                }
            }
        }

    }
}
