using System;
using static System.Console;

namespace Module12AssignmentHW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numParts;

            Write("How many parts would you like to enter?: ");

            numParts = Convert.ToInt32(ReadLine());

            Part[] partArray = new Part[numParts];

            for (int x = 0; x < partArray.Length; x++)
            {
                populatePart(ref partArray[x]);
            }

            WriteLine("Menu of parts:");
            for (int i = 0; i < partArray.Length; i++)
            {
                WriteLine($"{i + 1} - {partArray[i].PartName}");
            }

            Write("Please select the number of the part you would like to view: ");
            int choice = Convert.ToInt32(ReadLine()) - 1;

            if (choice >= 0 && choice < partArray.Length)
            {
                WriteLine($"Part Number: {partArray[choice].PartNumber}");
                WriteLine($"Part Name: {partArray[choice].PartName}");
                WriteLine($"Part Description: {partArray[choice].PartDescription}");
                WriteLine($"Part Cost: ${partArray[choice].Cost}");
            }

            static void populatePart(ref Part e)
            {
                Write("Enter part number: ");
                int partNum = Convert.ToInt32(ReadLine());

                Write("Enter part name: ");
                string partName = ReadLine();

                Write("Enter part description: ");
                string partDescription = ReadLine();

                Write("Enter part cost: ");
                decimal cost = Convert.ToDecimal(ReadLine());

                e = new Part(partNum, partName, partDescription, cost);
            }

        }
    }
}
