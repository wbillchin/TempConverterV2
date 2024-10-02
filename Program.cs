/*
 * INFO 350 - Temperature Converter V2
 * 
 */

using System;

class TemperatureConverter
{

    // TODO: implement function to convert fahrenheit to celsius


    // TODO: implement function to convert celsius to fahrenheit


    // Function to display the menu and return the user's choice
    static int GetMenuChoice()
    {
        Console.Clear();
        Console.WriteLine("Temperature Converter");
        Console.WriteLine("---------------------");
        Console.WriteLine("1. Convert Fahrenheit to Celsius");
        Console.WriteLine("2. Convert Celsius to Fahrenheit");
        Console.WriteLine("3. Exit");
        Console.Write("Please select an option: ");

        // Try to parse the user input into an integer
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }
        else
        {
            // Return an invalid choice if the input is not an integer
            return -1;
        }
    }

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            // Get the user's menu choice
            int choice = GetMenuChoice();

            switch (choice)
            {
                case 1:
                    // Fahrenheit to Celsius conversion
                    Console.Write("Enter temperature in Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                    {

                        // TODO - implement Fahrenheit to Celsius conversion
                        //Console.WriteLine($"{fahrenheit} Fahrenheit is {celsius:F2} Celsius.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case 2:
                    // Celsius to Fahrenheit conversion
                    Console.Write("Enter temperature in Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out double celsiusTemp))
                    {
                        // TODO - implement Celsius to Fahrenheit conversion
                        //Console.WriteLine($"{celsiusTemp} Celsius is {fahrenheitTemp:F2} Fahrenheit.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case 3:
                    // Exit the program
                    exit = true;
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    // Handle invalid menu choice
                    Console.WriteLine("Invalid option. Please choose 1, 2, or 3.");
                    break;
            }

            // Pause before the next loop, unless exiting
            if (!exit)
            {
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
