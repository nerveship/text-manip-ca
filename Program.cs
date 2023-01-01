using System;

public class Program
{
    public static void Main()
    {
        int choiceMax = 4;

        Console.WriteLine("Please pick how you would like to modify your text.\n" +
            "1. Reverse\n" +
            "2. Capitalise\n" +
            "3. Lowercase\n" +
            "4. Remove spaces\n");

        int usrChoice = Convert.ToInt32(Console.ReadLine());
        
        //makes sure the input is within 1 - Maximum choice
        while (usrChoice > choiceMax || usrChoice < 1)
        {
            Console.WriteLine($"Please choose a number between 1 and {choiceMax}");
            usrChoice = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Please input the text you would like to modify.\n");
        string usrString = Console.ReadLine();

        //Initialises array of user input + an empty string for later use
        char[] charArray = usrString.ToCharArray();
        string reversedString = String.Empty;

        if (usrString == "")
        {
            Console.WriteLine("Invalid input, please enter something next time.\n");
            return;
        }

        if (usrChoice == 1)
        {
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reversedString += charArray[i];
            }
            Console.WriteLine(reversedString);
        }

        else if (usrChoice == 2)
        {
            Console.WriteLine(usrString.ToUpper());
        }

        else if (usrChoice == 3)
        {
            Console.WriteLine(usrString.ToLower());
        }
    }
}