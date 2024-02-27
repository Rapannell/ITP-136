using System;
using static System.Console;

namespace Week6AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double taxRate;

            welcomeStatement();

            magicNumber();

            findArea();

            taxRate = localTaxRate();

            WriteLine($"Your tax rate is {taxRate:F0}%");

            ReadKey();
        }

        static void welcomeStatement()
        {
            WriteLine("Welcome to My Method Examples");
        }

        static void magicNumber()
        {
            int secretNumber = 7;
            WriteLine("secret number is " + secretNumber);
        }

        static void findArea()
        {
            int a, b, c;

            WriteLine("Enter your first number: ");
            a = Convert.ToInt32(ReadLine());

            WriteLine("Enter your second number: ");
            b = Convert.ToInt32(ReadLine());

            c = a * b;
            WriteLine(a + " * " + b + " = " + c);
        }

        static double localTaxRate()
        {
            double taxRate;

            WriteLine("What is your tax rate? Please enter decimal value: ");
            taxRate = Convert.ToDouble(ReadLine());
            taxRate *= 100;

            return taxRate;
        }
    }
}
