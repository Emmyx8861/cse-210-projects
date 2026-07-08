using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
       List<int> numbers = new List<int>();
        
        int usernumber = -1;
        String userresponse = "";
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            userresponse = Console.ReadLine();
            usernumber = int.Parse(userresponse);
            if (usernumber != 0)
            {
                numbers.Add(usernumber);
            }
        }
        while (usernumber != 0);
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("The sum of the numbers is: " + sum);

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is: {average}");
        
        int max = numbers.Max();
        Console.WriteLine($"The Largest of the numbers is: {max}");

        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {if (number > 0 && number < smallestPositive)
       {
          smallestPositive = number;
       }
        }
         Console.WriteLine($"The smallest positive number is: {smallestPositive}");

         numbers.Sort();
         Console.WriteLine("The sorted list of numbers is: ");
         foreach (int number in numbers)
        {
           Console.WriteLine(number);
         }
    }
}