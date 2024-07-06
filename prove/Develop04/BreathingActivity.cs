public class BreathingActivity : Activity
{
    public BreathingActivity (string name, string description) : base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        int halfDuration = base.GetDuration() / 3;

        for (int i = 0; i < halfDuration; i++)
        {
            Console.WriteLine();
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Write("Now breath out...");
            ShowCountDown(4);
        }
        DisplayEndingMessage();
        Console.Clear();
    }
}