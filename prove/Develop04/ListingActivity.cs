using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity (string name, string description, List<string> prompts) : base (name, description)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        DisplayListCount();
       
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");

        Console.WriteLine($" >>> {prompt} <<<");
        Console.Write("You may begin in: ");
        ShowCountDown(6);
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        int elapsed = 0;
        int duration = base.GetDuration();

        Console.WriteLine($"You have {duration} seconds to list items.");
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write(">> ");
            string item = Console.ReadLine();
            items.Add(item);
            elapsed += 5;
        }
        return items;
    }

    public void DisplayListCount()
    {
        Console.WriteLine();
        List<string> list = GetListFromUser();
        int length = list.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {length} items.");

        DisplayEndingMessage();
        Console.Clear();
    }
}