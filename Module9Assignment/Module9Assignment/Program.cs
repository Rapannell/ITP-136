using System;
using static System.Console;

namespace Module9Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] makeOfCar = new string[5];
            string[] modelOfCar = new string[5];
            double[] costOfCar = new double[5];
            string[] carNum = { "first", "second", "third", "fourth", "fifth" };

            for (int x = 0; x < 5; x++)
            {
                WriteLine($"Please enter the make of your {carNum[x]} car:");
                makeOfCar[x] = ReadLine();

                WriteLine($"Please enter the model of your {carNum[x]} car:");
                modelOfCar[x] = ReadLine();

                WriteLine($"Please enter the cost of your {carNum[x]} car:");
                costOfCar[x] = Convert.ToDouble(ReadLine());
            }

            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("{0,10}{1,10}{2,10}", "Make", "Model", "Price");
            ForegroundColor = ConsoleColor.Gray;

            for (int y = 0; y < makeOfCar.Length; y++)
            {
                WriteLine("{0,10}{1,10}{2,10}", makeOfCar[y], modelOfCar[y], "$"+costOfCar[y]);
            }


            double mostExpensive = costOfCar.Max();
            int p = Array.IndexOf(costOfCar, mostExpensive);

            WriteLine($"The most expensive car is the {makeOfCar[p]} {modelOfCar[p]} which costs ${costOfCar[p]}");

        }
    }
}
