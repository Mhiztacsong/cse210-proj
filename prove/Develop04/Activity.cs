public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}." + "\n");
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        ShowSpinners(6);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!" +"\n");
        ShowSpinners(6);
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        ShowSpinners(6);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowSpinners(int seconds)
    {
        List<string> animations =
        [
            "/",
            "-",
            "\\",
            "/",
            "-",
            "\\",
        ];

        foreach (string s in animations)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}