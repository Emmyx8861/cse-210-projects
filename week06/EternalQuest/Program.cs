using System;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements and show creativity, this program includes 
        // custom status checks and persistent tracking of comprehensive user 
        // scores across sessions using factory-pattern style loading
        // I was able to shorten the main program to emphasize abstraction and encapsulation by creating a GoalManager class that handles all goal-related operations, including creation, listing, saving, loading, and recording events.
        
        GoalManager manager = new GoalManager();
        manager.Start();
}
    }
