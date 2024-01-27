using System;


namespace HelloWorldCW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Your name is " + userName);

            Console.ReadKey();
        }
    }
}
