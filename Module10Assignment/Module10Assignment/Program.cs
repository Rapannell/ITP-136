using System;
using static System.Console;

namespace Module10Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food();
            Food food2 = new Food();

            food1.FoodID = 1111;
            food1.Name = "Banana";
            food1.Description = "Yellow fruit";
            food1.Cost = 0.29;

            food2.FoodID = 1112;
            food2.Name = "Apple";
            food2.Description = "Red fruit";
            food2.Cost = 0.59;

            WriteLine("{0,20}{1,20}{2,20}{3,20}", "FoodID", "Name", "Description", "Cost");
            WriteLine("{0,20}{1,20}{2,20}{3,20}", food1.FoodID, food1.Name, food1.Description, "$" + food1.Cost);
            WriteLine("{0,20}{1,20}{2,20}{3,20}", food2.FoodID, food2.Name, food2.Description, "$" + food2.Cost);

        }
    }
}
