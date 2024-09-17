using System;

class Program
{
    static void Main()
    {
        string userInput;
        do
        {
            Console.Write("\tTask 1. \nPlease input a number from 0 to 9: \n\t>>> ");
            userInput = Console.ReadLine();

            if (!IsNumberBetween0And9(userInput))
            {
                Console.WriteLine("ERROR! Please enter a number between 0 and 9.");
            }
        }
        while (!IsNumberBetween0And9(userInput));

        Console.WriteLine("Nice! :) You passed task 1!");
        string stringInput;

        do
        {
            Console.WriteLine("---------------------------------\n\tTask 2\nPlease input a string (min 3 characters, no digits):\n\t>>> ");
            stringInput = Console.ReadLine();

            if (!IsValidString(stringInput))
            {
                Console.WriteLine("ERROR! The string must be at least 3 characters long and contain no digits.");
            }
        }
        while (!IsValidString(stringInput));

        Console.WriteLine("You passed task 2! ");
    }

    static bool IsNumberBetween0And9(string input)
    {
        return int.TryParse(input, out int number) && number >= 0 && number <= 9;
    }
    static bool IsValidString(string input)
    {
        return input.Length >= 3 && !input.Any(char.IsDigit);
    }
}
