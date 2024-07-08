using System.Timers;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, List<string> prompts, List<string> questions) : base (name, description)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(6);

        Console.Clear();
        DisplayQuestion();
        DisplayEndingMessage();
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string randomString = _prompts[randomIndex];
        return randomString;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int questionIndex = random.Next(_questions.Count);
        string randomString = _questions[questionIndex];
        return randomString;   
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:" + "\n");

        Console.WriteLine($" >>> {GetRandomPrompt()} <<<");
    }

    public void DisplayQuestion()
    {
        int questionIndex = 0;
        int elapsed = 0;

        while (elapsed < base.GetDuration())
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"> {question}");
            ShowSpinners(10);
            elapsed += 3;
            questionIndex++;
        }
    }
}