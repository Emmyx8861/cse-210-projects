using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUsername();
        int number = PromptUsernumber();
        int square = squareNumber(number);
        DisplayResult(name, square);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUsername()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUsernumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine();
        int usernumber = int.Parse(input);
        Console.WriteLine($"You entered: {usernumber}");
        return usernumber;
    }

    static int squareNumber(int usernumber)
    {
        int square = usernumber * usernumber;
        Console.WriteLine($"The square of {usernumber} is: {square}");
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Brother {name}, your number squared is {square}.");
    }
}