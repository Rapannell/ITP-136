namespace Module3AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double oilChange, tires, inspection;
            double total;
            string inputString;
            double tax;

            Console.WriteLine("Thank you for visiting Reynolds Repair Shop!");

            Console.WriteLine("Enter the total for oil change:");
            inputString = Console.ReadLine();
            oilChange = Convert.ToDouble(inputString);

            Console.WriteLine("Enter the total for tires:");
            inputString = Console.ReadLine();
            tires = Convert.ToDouble(inputString);

            Console.WriteLine("Enter the total for inspection:");
            inputString = Console.ReadLine();
            inspection = Convert.ToDouble(inputString);

            total = oilChange + tires + inspection;
            Console.WriteLine("Your subtotal is $" + total.ToString("F2"));

            tax = total * 0.06;
            Console.WriteLine("Tax: $" + tax.ToString("F2"));

            total = total + tax;
            Console.WriteLine("Your grand total is $" + total.ToString("F2"));

            Console.ReadKey();


        }
    }
}
