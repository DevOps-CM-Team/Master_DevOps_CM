using CalculatorApp.Interfaces;
using CalculatorApp.Operations;
using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IAddition adder = new Addition();
            ISubtraction subtractor = new Subtraction();
            IMultiplication multiplier = new Multiplication();
            IDivision divider = new Division();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- Calculator Menu ---");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("0. Exit");
                Console.Write("\nEnter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("\nExiting...");
                    break;
                }

                double a, b;
                try
                {
                    a = GetNumber("Enter first number: ");
                    b = GetNumber("Enter second number: ");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Pause();
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Result: {a} + {b} = {adder.Add(a, b)}");
                        break;

                    case "2":
                        Console.WriteLine($"Result: {a} - {b} = {subtractor.Subtract(a, b)}");
                        break;

                    case "3":
                        Console.WriteLine($"Result: {a} * {b} = {multiplier.Multiply(a, b)}");
                        break;

                    case "4":
                        try
                        {
                            Console.WriteLine($"Result: {a} / {b} = {divider.Divide(a, b)}");
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select from 0-4.");
                        break;
                }

                Pause();
            }
        }

        private static double GetNumber(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            throw new FormatException("Invalid input. Please enter a valid number.");
        }

        private static void Pause()
        {
            Console.Write("\nPress Enter to return to the menu...");
            Console.ReadLine();
        }
    }
}