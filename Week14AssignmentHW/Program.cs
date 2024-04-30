using System;
using static System.Console;

namespace Week14AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char anotherOrder = 'y';
            List<Orders> orders = new List<Orders>();

            WriteLine("Hello, welcome to Reynolds Bakery!");

            while (anotherOrder == 'y')
            {
                takeOrder(ref orders);
                Write("Would you like to order another cake? y/n: ");
                anotherOrder = Convert.ToChar(ReadLine());
            }

            WriteLine("Here is your order: ");
            WriteLine("{0,-15}{1,-20}{2,-20}", "NAME", "DECORATION", "DESIGN");

            foreach (Orders o in orders)
            {
                WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderDecoration, o.OrderDesign);
            }

            WriteLine("Thank you for shopping at Reynolds Bakery!");
            ReadKey();

            static void takeOrder(ref List<Orders> o)
            {
                var listOfDecorations = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();
                var listOfDesigns = File.ReadLines("Design.csv").Select(line => new Design(line)).ToList();

                Write("Can I get a name for the order?: ");
                string name = Console.ReadLine();

                WriteLine("What type of decoration would you like for your cake?");
                foreach (Decorations deco in listOfDecorations) 
                {
                    WriteLine($"{deco.DecorationID}\t{deco.DecorationName}");
                }

                int a = Convert.ToInt32(ReadLine());
                string decoration = listOfDecorations[a-1].DecorationName;

                WriteLine("What type of design would you like for your cake?");
                foreach (Design desi in listOfDesigns)
                { 
                    WriteLine($"{desi.DesignID}\t{desi.DesignName}");
                }

                int b = Convert.ToInt32(ReadLine());
                string design = listOfDesigns[b-1].DesignName;

                o.Add(new Orders(name, decoration, design));

            }
        }
    }
}
