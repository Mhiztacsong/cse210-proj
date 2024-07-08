// Made sure no random propmts/questions are selected until they have all been used at least once  in that session

using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program" + "\n");
        List<string> mindfulnessProgram = new List<string>
        {"Start breathing activity", "Start reflecting activity", "Start listing activity", "Quit"};

        int choice = 0;

        while (choice!= 4)
        {
            Console.WriteLine("Menu Options:");           
            for (int i = 0; i < mindfulnessProgram.Count; i++)
            {        
                Console.WriteLine($"  {i + 1}. {mindfulnessProgram[i]}");
            }

            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breahing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.Run();
            }

            else if (choice == 2)
            {
                List<string> reflectionPrompts = new List<string>
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truly selfless.",
                };

                List<string> reflectionQuestions = new List<string>
                {
                    "Why was this experience meaningful to you?",
                    "Have you ever done anything like this before?",
                    "How did you get started?",
                    "How did you feel when it was complete?",
                    "What made this time different than other times when you were not successful?",
                    "What is you favorite thing about this experience?",
                    "What could you learn from this experience that applies to other situation?",
                    "What did you learn about yourself through this experience?",
                    "How can you keep this experience in mind in the future?"
                };
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognise the power you have and how yo can use it in other aspect of your life.", reflectionPrompts, reflectionQuestions);
                reflecting.Run();
            }

            else if (choice == 3)
            {
                List<string> listingPrompts = new List<string>
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this moneth?",
                    "Who are some of your personal heroes?"
                };
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingPrompts);
                listing.Run();
            }
        }
    }
}