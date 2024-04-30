using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;

namespace Week14CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Reynolds ice cream stand!");

            char moreItems = 'y';
            int counter = 0;
            List<Orders> orders = new List<Orders>();

            while (moreItems == 'y')
            {
                WriteLine("Let's get the items for order {0}", counter + 1);

                collectOrder(ref orders);
                counter++;
                Write("Would you like to add another order? y/n: ");
                moreItems = Convert.ToChar(ReadLine());
            }

            WriteLine("{0,-15}{1,-20}{2,-20}","NAME", "FLAVOR", "TOPPING");

            foreach (Orders o in orders)
            {
                WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderFlavor, o.OrderTopping);
            }

            ReadKey();

            static void collectOrder (ref List<Orders> o)
            {
                var listOfFlavors = File.ReadLines("Flavors.csv").Select(line => new Flavors(line)).ToList();
                var listOfToppings = File.ReadLines("Toppings.csv").Select(line => new Toppings(line)).ToList();

                Write("Please provide a name for this order: ");
                string name = ReadLine();

                WriteLine("Please select a flavor: ");
                foreach (Flavors f in listOfFlavors)
                {
                    WriteLine($"{f.FlavorID}\t{f.FlavorName}");
                }

                int a = Convert.ToInt32(ReadLine());
                string flavor = listOfFlavors[a-1].FlavorName;


                WriteLine("Please select a topping: ");
                foreach (Toppings t in listOfToppings)
                {
                    WriteLine($"{t.ToppingID}\t{t.ToppingName}");
                }

                int b = Convert.ToInt32(ReadLine());
                string topping = listOfToppings[b-1].ToppingName;

                o.Add(new Orders(name, flavor, topping));
            }
        }
    }
}
