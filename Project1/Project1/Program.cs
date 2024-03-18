namespace Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, address, dateOfTravel;
            int subTotal;
            double taxFee, grandTotal;
            double tax = 0.05;

            Console.Write("Welcome to Reynolds Airline! Please enter your name: ");
            name = Console.ReadLine();

            Console.Write("Please enter your address: ");
            address = Console.ReadLine();

            Console.Write("Please enter your date of travel: ");
            dateOfTravel = Console.ReadLine();

            int baggageTotal = BagData();
            int seatsTotal = SeatsData();

            subTotal = baggageTotal + seatsTotal;
            taxFee = (subTotal * tax);
            grandTotal = subTotal + taxFee;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********* Receipt *********");
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Date of travel: {dateOfTravel}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Subtotal: $" + subTotal);
            Console.WriteLine("Tax: $" + taxFee);
            Console.WriteLine("Grand total: $" + grandTotal);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Thank you for flying with Reynolds Airline, we hope you enjoy your trip!");
        }

        static int BagData()
        {
            int bagNumber, baggageTotal;
            int pricePerBag = 25;
            bool checkBags;

            Console.Write("Will you be checking any bags with us today? yes/no: ");
            string yesNo = Console.ReadLine();
            if (yesNo.ToLower() == "yes")
                checkBags = true;
            else checkBags = false;

            if (checkBags)
            {
                Console.Write("How many bags will you be checking?: ");
                bagNumber = Convert.ToInt32(Console.ReadLine());
                baggageTotal = (bagNumber * pricePerBag);
                Console.WriteLine("Your total baggage fee is $" + baggageTotal);
                return baggageTotal;
            }
            else 
            {
                Console.WriteLine("Your baggage fee is 0");
                return 0;
            }
        }

        static int SeatsData() 
        {
            int seatsNumber, seatsTotal;
            int pricePerSeat = 30;
            bool ifSeats;

            Console.Write("Will you be purchasing any seats with us today? yes/no: ");
            string yesNo = Console.ReadLine();
            if (yesNo.ToLower() == "yes")
                ifSeats = true;
            else ifSeats = false;

            if (ifSeats)
            {
                Console.Write("How many seats will you be purchasing?: ");
                seatsNumber = Convert.ToInt32(Console.ReadLine());
                seatsTotal = (seatsNumber * pricePerSeat);
                Console.WriteLine("Your total seats fee is $" + seatsTotal);
                return seatsTotal;
            }
            else
            {
                Console.WriteLine("Your seat fee is 0");
                return 0;
            }
        }
    }
}
