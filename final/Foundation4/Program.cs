using System;

class Program
{
    static void Main(string[] args)
    {
          // Create some activities
        Activity running = new Running(new DateTime(2024, 11, 3), 30, 3.0);
        Activity cycling = new Cycling(new DateTime(2024, 11, 4), 60, 15.0);
        Activity swimming = new Swimming(new DateTime(2024, 11, 5), 45, 20);

        // Store the activities in a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display activity summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine("================================");
        }
    }
}