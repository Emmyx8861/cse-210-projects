using System;

class Program
{
    static void Main(string[] args)
    {
       Journal myJournal = new Journal();

     string option = "";
         do
        {
         int currentStreak = myJournal.CalculateStreak();
          Console.WriteLine("Welcome to the Journal Program!");
          Console.WriteLine($"🔥 Current Daily Streak: {currentStreak} days 🔥");
          Console.WriteLine("Please select an option:");
          Console.WriteLine("1. Write a new entry");
          Console.WriteLine("2. Display all entries");
          Console.WriteLine("3. Save entries to a file"); 
          Console.WriteLine("4. Load entries from a file");
          Console.WriteLine("5. Exit");
          Console.WriteLine("What would you like to do? (1-5)");
          option = Console.ReadLine();
        

        if(option == "1")
        {
         PromptGenerator promptGen = new PromptGenerator();
         string randomPrompt = promptGen.GetRandomPrompt();

         Console.WriteLine(randomPrompt);
         Console.Write("> ");
         string userResponse = Console.ReadLine();

         Entry newEntry = new Entry();
         newEntry._date = DateTime.Now.ToShortDateString();
         newEntry._promptText = randomPrompt;
         newEntry._entryText = userResponse;

         myJournal.AddEntry(newEntry); 
        }
        else if (option == "2")
        {
            myJournal.DisplayEntries();
        }
        else if (option == "3")
        {
            Console.Write("Enter the filename to save to: ");
            string filename = Console.ReadLine();
            myJournal.SaveToFile(filename);
        }
        else if (option == "4")
        {
            Console.Write("Enter the filename to load from: ");
            string filename = Console.ReadLine();
            myJournal.LoadFromFile(filename);
        }
        else if (option == "5")
        {
            Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid option. Please select a number from 1 to 5.");
        }
    }
    while (option != "5");
}}