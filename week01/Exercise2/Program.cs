using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your score ?");
        string input = Console.ReadLine();
        int score = int.Parse(input);

        string letter = "";
        if (score >= 90)
        {
           letter="A";
        }
        
        else if (score >= 80)
        {
            letter="B";
        }
        else if (score >= 70)
        {
            letter="C";
        }
        else if (score >= 60)
        {
            letter="D";
        }
        else
        {
            letter="F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class.");
        }
        
        if (letter=="A" && score % 10 >= 7)
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (letter=="F")
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else if (score % 10 >= 7)
        {
            Console.WriteLine($"Your grade is {letter}+");
        }
        else if (score % 10 < 3)
        {
            Console.WriteLine($"Your grade is {letter}-");
        }
    }
}