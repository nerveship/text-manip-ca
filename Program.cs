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
        
        while (usrChoice > choiceMax || usrChoice < 1)
        {
            Console.WriteLine($"Please choose a number between 1 and {choiceMax}");
            usrChoice = Convert.ToInt32(Console.ReadLine());
        }
    }
}