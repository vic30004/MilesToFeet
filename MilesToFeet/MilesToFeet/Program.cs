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
            bool end = false;
            int convertedValue = 0;

            askQuestion();

            string userInput = Console.ReadLine();


            do
            {
                if (userInput.ToLower() == "f")
                {
                    Console.WriteLine("Great! we will convert miles to feet! Please input the number you would like to convert.");
                    string userValue = Console.ReadLine();
                    int number;
                    bool value = int.TryParse(userValue, out number);
                    if (value)
                    {
                        convertedValue = convertToFeet(number);
                        Console.WriteLine("{0} miles is {1} feet", number, convertedValue);
                        end = true;
                    }
                    else
                    {
                        Console.WriteLine("Please make sure your adding a number!");
                        askQuestion();
                        userInput = Console.ReadLine();

                        end = false;
                    }

                }
            }


            while (!end);

            

        }

        public static  void askQuestion()
        {
            Console.WriteLine("Would you like to convert miles to inches or feet? Please use i for inches and f for feet");
        
        }

        public static int convertToFeet(int num)
        {
            int convertedValue = num * 5280;
            return convertedValue;
        }

       
    }
}
