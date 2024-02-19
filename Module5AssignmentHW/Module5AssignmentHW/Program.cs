namespace Module5AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber, endNumber, counter;

            Console.WriteLine("Enter the start number:");
            startNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the end number:");
            endNumber = Convert.ToInt32(Console.ReadLine());

            counter = startNumber;

            while (counter <= endNumber)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.ReadKey();
        }
    }
}
