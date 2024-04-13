using System;
using static System.Console;

namespace Module11AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num1, num2, result;
            int operation;
            result = 0;

            try
            {
                Write("Please enter your first number: ");
                num1 = decimal.Parse(ReadLine());

                Write("Please enter your second number: ");
                num2 = decimal.Parse(ReadLine());
            }
            catch (FormatException)
            {
                WriteLine("Error: Please enter a valid number");
                return;
            }


            try
            {
                WriteLine("Please select which operation you would like to perform. 1 - Addition, 2 - Multiplication, 3 - Subtraction, 4 - Division");
                operation = int.Parse(ReadLine());
                if (operation < 1 || operation > 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                WriteLine("Error: You must select a number 1-4");
                return;
            }
            catch (ArgumentOutOfRangeException)
            {
                WriteLine("Error: You must select a number 1-4");
                return;
            }

            try
            {
                switch (operation)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 * num2;
                        break;
                    case 3:
                        result = num1 - num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        result = num1 / num2;
                        break;
                }
            }
            catch (DivideByZeroException)
            {
                WriteLine("Error: You cannot divide by zero.");
                return;
            }

            WriteLine("Result: " + result);

            ReadKey();

        }
    }
}
