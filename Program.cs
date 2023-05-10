using System;

namespace ProjectFlooring
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Is the room rectangle or triangle (R/T) :");
            string roomShape = Console.ReadLine();

            double width = 0;
            double length = 0;
            double floorArea = 0;

            if (roomShape == "R")
            {
                Console.Write("Enter the width of the floor in foot: ");
                width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the floor in foot: ");
                length = Convert.ToDouble(Console.ReadLine());

                floorArea = width * length;

            }
            else if (roomShape == "T")
            {
                Console.Write("Enter the height of the floor in foot: ");
                width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the floor in foot: ");
                length = Convert.ToDouble(Console.ReadLine());

                floorArea = 0.5 * width * length;
            }
            else
            {
                Console.WriteLine("Invalid room shape entered!");
            }

            Console.Write("Enter the area of a single tile in square foot: ");
            double tileArea = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the cost per tile in dollars: ");
            double tileCost = Convert.ToDouble(Console.ReadLine());

            double tilesNeeded = floorArea / tileArea;
            double totalCost = tilesNeeded * tileCost;

            Console.WriteLine($"The room size is {floorArea} square feet");
            Console.WriteLine($"You need {tilesNeeded} tiles to cover the floor");
            Console.WriteLine($"The total cost of tiles is ${totalCost}");


        }
    }
}