using System;

class Program
{
    static void Main(string[] args)
    {
        string keepGoing = "yes";
        string guessCount = "0";

        while (keepGoing == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            string magicNumber = number.ToString();

        string guess="";
        do
        {
            Console.Write("What is the magic number? ");
            guess = Console.ReadLine();
            guessCount = (int.Parse(guessCount) + 1).ToString();

            if (int.Parse(guess) > int.Parse(magicNumber))
          {
             Console.WriteLine("Lower");
          }
            else if (int.Parse(guess) < int.Parse(magicNumber))
           {
              Console.WriteLine("Higher");
           }
        
            
        }
        while (guess != magicNumber);
        if (guess == magicNumber)
        {
            Console.WriteLine($"You guessed it! The magic number is {magicNumber}");
            Console.WriteLine($"It took you {guessCount} guesses to find the magic number.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not guess the magic number.");
        }

    }   
}}