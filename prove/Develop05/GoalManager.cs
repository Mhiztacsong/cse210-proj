public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager(List<Goal> goals, int score)
    {
        _goals = goals;
        _score = score;
    }

    public void Start()
    {
        DisplayPlayerInfo();
    }

    public void DisplayPlayerInfo()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Eternal Quest Program" + "\n");
        List<string> eqProgram = new List<string>
        {"Create New Goal", "List Goals", "Save Goals", "Load Goals", "Record Event", "Quit"};

        int choice = 0;

        while (choice!= 6)
        {
            Console.WriteLine();
            Console.WriteLine($"You have {_score} points" + "\n");
            Console.WriteLine("Menu Options:");           
            for (int i = 0; i < eqProgram.Count; i++)
            {        
                Console.WriteLine($"  {i + 1}. {eqProgram[i]}");
            }

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoals();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)  
            {
                LoadGoals();
            }   
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.WriteLine("Quitting the program... Goodbye!!");
            }
            else
            {
                Console.WriteLine("Invalid choice, Please try again");
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your goals are:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {   
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Habit Goal");
        Console.Write("Which type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the goal: ");
        string name = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());
            
    
        Goal newGoal = null;

        if (choice == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        if (choice == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }
        if (choice == 3)
        { 
            Console.Write("Enter the target number of completions for the goal: ");
            int target = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the bonus points for completing the checklist: ");
            int bonus = int.Parse(Console.ReadLine());
                
            newGoal = new ChecklistGoal(name, description, points, target, bonus);   
        }
        if (choice == 4)
        {           
            Console.Write("Enter the bonus points for completing the checklist: ");
            int bonus = int.Parse(Console.ReadLine());
                
            newGoal = new HabitGoal(name, description, points, bonus);
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }
        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetShortName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        if (choice > 0 && choice <= _goals.Count)
        {
            Goal goal = _goals[choice -1];
            int points = goal.RecordEvent();
            _score += points;
            Console.WriteLine($"Event recorded successfully. You earned {points} points.");
        }

        Console.WriteLine($"Your current score is: {_score}");
    }

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save the goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");        
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load the goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    Goal goal = null;

                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]));
                            for (int i = 0; i < int.Parse(parts[4]); i++)
                            {
                                ((ChecklistGoal)goal).RecordEvent();
                            }
                            break;
                        case "HabitGoal":
                            goal = new HabitGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]));
                            for (int i = 0; i < int.Parse(parts[4]); i++)
                            {
                                ((HabitGoal)goal).RecordEvent();
                            }
                            break;
                    }

                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}  