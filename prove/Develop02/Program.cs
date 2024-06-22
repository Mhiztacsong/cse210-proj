using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;

// i created conditional statements for when the user selects an option that's outside the journal program, or tries
// to display an empty list of entries, also when the user tries to load a file that doesn't exist, and i added an option
// that allows the user o delete a saved file of his/her choosing. 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");
        List<string> journalProgram = new List<string>
        {"Write", "Display Entry", "Load File", "Save Entry", "Delete File", "Quit"};
        
        int option = 0;
        
        Journal myJournal = new Journal();

        while (option != 6)
        {
            Console.WriteLine("Please select one of the following choices:");
            
            for (int i = 0; i < journalProgram.Count; i++)
            {        
                Console.WriteLine($"{i + 1}. {journalProgram[i]}");
            }

            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            while (option > journalProgram.Count)
            {
                Console.WriteLine("Wrong Choice");
                Console.WriteLine();
                Console.Write("What would you like to do? ");
                option = int.Parse(Console.ReadLine());

            }

            if (option == 1)
            {
                promptGenerator prompt = new promptGenerator
                {
                    _prompts = new List<string>
                    {
                        "Who was the most interesting person i interacted with today?",
                        "What are my most grateful for today?",
                        "What was the strongest emotion i felt today?",
                        "How did i see the Lord's hand in your life today?",
                        "What was the best part of my day?",
                        "If i could change anything today what would it be?",
                        "Were there any moments of frustration or sadness? How did i cope?",
                        "How did i take care of myself today?",
                        "Is there anything that is still on my mind?",
                        "What am i looking forward to tomorrow?",
                        "Did i do something kind for someone today?",
                        "Did i spend my time wisely today?",
                        "What challenges did i face today, and how did i handle them?",
                        "Did i achieve the goals i set for today? If not, why?"
                    }
                };

                string randomPrompt = prompt.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                Console.Write(">> ");
                string userResponse = Console.ReadLine();  

                Console.WriteLine();  

                DateTime theCurrentTime = DateTime.Now;
                Entry newEntry = new Entry
                {
                    _date = theCurrentTime.ToShortDateString(),
                    _promptText = randomPrompt,
                    _entryText = userResponse
                };

                myJournal.AddEntry(newEntry);
            }

            else if (option == 2)
            {
                myJournal.DisplayAll();
            }

            else if (option == 3)
            {
               myJournal.LoadFromFile(); 
            }

            else if (option == 4)
            {
                myJournal.SaveToFile(myJournal._entries);              
            }

            else if (option == 5)
            {
                myJournal.DeleteFile();
            }
        }  
       
    }
}