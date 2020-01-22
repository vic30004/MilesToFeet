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
            bool end = false;
            int convertedValue = 0;

            askQuestion();

            string userInput = Console.ReadLine();


            do
            {
                if (userInput.ToLower() == "f" || userInput.ToLower() == "feet")
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
                else if (userInput.ToLower() == "i" || userInput.ToLower()=="inches")
                {
                    Console.WriteLine("Great! we will convert miles to inches! Please input the number you would like to convert.");
                    string userValue = Console.ReadLine();
                    int number;
                    bool value = int.TryParse(userValue, out number);
                    if (value)
                    {
                        convertedValue = convertToFeet(number);
                        Console.WriteLine("{0} miles is {1} inches", number, convertedValue);
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
                else if(userInput.ToLower()=="q" || userInput.ToLower() == "quit")
                {
                    Console.WriteLine("Sorry to see you go. We hope to see you soon!");
                    end = true;
                }
                else
                {
                    Console.WriteLine("Please Make sure you write either i for inches or f for feet");
                    askQuestion();
                    userInput = Console.ReadLine();

                    end = false;
                }
            }


            while (!end);

            

        }

        public static  void askQuestion()
        {
            Console.WriteLine("Would you like to convert miles to inches or feet? Please use i for inches and f for feet or write q to quit.");
        
        }

        public static int convertToFeet(int num)
        {
            int convertedValue = num * 5280;
            return convertedValue;
        }

        public static int convertToInches(int num)
        {
            int convertedValue = num * 63360;
            return convertedValue;
        }
       
    }
}
