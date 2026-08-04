public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
            0)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine();
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine("Reflect on these questions:");
        GetRandomQuestions();
        DisplayEndingMessage();
        Program.reflectingCount++;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        return prompt;
    }

    public string GetRandomQuestions()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        string question = _questions[index];
        Console.WriteLine(question);
        return question;
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine(question);
        }
    }

    public void DisplayPrompts()
    {
        foreach (string prompt in _prompts)
        {
            Console.WriteLine(prompt);
        }
    }
}