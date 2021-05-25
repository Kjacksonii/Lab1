using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double width;
            double length;
            double paint;
            double carpet;
            Console.WriteLine("Would you like to use the room detail generator? y/n");

            string userInput = Console.ReadLine().ToLower();
            while (userInput == "y")
            {
                Console.WriteLine("Enter a length: ");
                length = (double)decimal.Parse(Console.ReadLine());
                Console.Write("Enter a width ");
                width = (double)decimal.Parse(Console.ReadLine());
                Console.WriteLine("Perimeter: " + ((width + length) * 2));
                Console.WriteLine("Area: " + (width * length));
                paint = ((width + length) * 2 / 5);
                Console.WriteLine("Cans of paint needed: " + paint);
                carpet = ((width * length) / 5);
                Console.WriteLine("Tiles of carpet needed: " + carpet);
                Console.WriteLine("Would you like to use again? y/n");
                userInput = Console.ReadLine();

                if (userInput != "y")
                {
                    Console.WriteLine();
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
