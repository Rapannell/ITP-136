namespace Module4AssignmentHW
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome! Please select your reason for this visit");
            Console.WriteLine("a. Doctor - Sick Appointment");
            Console.WriteLine("b. Doctor - Check-up");
            Console.WriteLine("Please type either a or b:");
            char choice = Console.ReadLine().ToLower()[0];

            switch (choice)
            {
                case 'a':
                    SickAppointment();
                    break;
                case 'b':
                    Checkup();
                    break;
            }
        }
        static void SickAppointment()
        {
            Console.WriteLine("Is the patient a child or an adult? (Enter 'child' or 'adult'):");
            string patientType = Console.ReadLine().ToLower();
            int baseVisitCost;
            if (patientType == "child")
            {
                baseVisitCost = 50;
            }
            else
            {
                baseVisitCost = 75;
            }

            Console.WriteLine("Were labs done during the appointment? (yes/no):");
            string labsDone = Console.ReadLine().ToLower();
            int labsCost;
            if (labsDone == "yes")
            {
                labsCost = 25;
            }
            else
            {
                labsCost = 0;
            }

            int totalCost = baseVisitCost + labsCost;
            Console.WriteLine($"Total cost for the sick appointment: ${totalCost}.00");
        }

        static void Checkup()
        {
            Console.Write("Is the patient a child or an adult? (Enter 'child' or 'adult'): ");
            string patientType = Console.ReadLine().ToLower();
            int checkupCost;
            if (patientType == "child")
            {
                checkupCost = 75;
            }
            else
            {
                checkupCost = 100;
            }

            Console.WriteLine($"Total cost for the check-up: ${checkupCost}.00");
        }
    }
}
