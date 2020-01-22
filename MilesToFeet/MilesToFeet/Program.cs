using System;

/*
 1 mile = 5280 feet
 1 mile =   63360 inches

    */
namespace MilesToFeet
{
    class Program
    {
        static void Main(string[] args)
        {
            int mileToFeet = 5280;
            int mileToInches = 63360;

            Console.WriteLine("Would you like to convert miles to inches or feet? Please use i for inches and f for feet");

            string userInput = Console.ReadLine();
            
            Console.WriteLine(userInput);

        }


    }
}
