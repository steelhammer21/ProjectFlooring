using System;

namespace ProjectFlooring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is the room rectangle or triangle (R/T) :");
            string roomShape = Console.ReadLine();

            if (roomShape == "R")
            {
                Console.Write("Enter the width of the floor in foot: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the length of the floor in foot: ");
                double length = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the area of a single tile in square foot: ");
                double tileArea = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the cost per tile in dollars: ");
                double tileCost = Convert.ToDouble(Console.ReadLine());

                double floorArea = width * length;
                double tilesNeeded = floorArea / tileArea;
                double totalCost = tilesNeeded * tileCost;

                Console.WriteLine($"You need {tilesNeeded} tiles to cover the floor");
                Console.WriteLine($"The total cost of tiles is ${totalCost}");
            }
            else
            {
                Console.Write("Enter the base of the floor in foot: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the height of the floor in foot: ");
                double height = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the area of a single tile in square foot: ");
                double tileArea = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the cost per tile in dollars: ");
                double tileCost = Convert.ToDouble(Console.ReadLine());

                double floorArea = 0.5 * width * height;
                double tilesNeeded = floorArea / tileArea;
                double totalCost = tilesNeeded * tileCost;

                Console.WriteLine($"You need {tilesNeeded} tiles to cover the floor");
                Console.WriteLine($"The total cost of tiles is ${totalCost}");


            }
        }
    }
}