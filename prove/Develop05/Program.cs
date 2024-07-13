using System;
// I added the Habit goal to the program.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(new List<Goal>(), 0);
        goalManager.Start();
    }
}