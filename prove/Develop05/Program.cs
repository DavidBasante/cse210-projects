using System;
namespace Develop05;

public class Program
{
    private static List<Goal> goals = new List<Goal>();

    public static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("----- Goal Tracker -----");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Show score");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    ShowScore();
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    public static void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter goal type number: ");
        string typeInput = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = Convert.ToInt32(Console.ReadLine());

        switch (typeInput)
        {
            case "1":
                SimpleGoal simpleGoal = new SimpleGoal(description, points);
                goals.Add(simpleGoal);
                Console.WriteLine("Simple Goal created successfully.");
                break;
            case "2":
                EternalGoal eternalGoal = new EternalGoal(description, points);
                goals.Add(eternalGoal);
                Console.WriteLine("Eternal Goal created successfully.");
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = Convert.ToInt32(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(description, points, targetCount, bonusPoints);
                goals.Add(checklistGoal);
                Console.WriteLine("Checklist Goal created successfully.");
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal creation failed.");
                break;
        }
    }

    public static void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet. Please create a goal first.");
            return;
        }

        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Description}");
        }

        Console.Write("Enter goal number: ");
        int goalNumber = Convert.ToInt32(Console.ReadLine());

        if (goalNumber < 1 || goalNumber > goals.Count)
        {
            Console.WriteLine("Invalid goal number. Event recording failed.");
            return;
        }

        Goal selectedGoal = goals[goalNumber - 1];
        selectedGoal.RecordEvent();
        Console.WriteLine("Event recorded successfully.");
    }

    public static void ShowGoals()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals created yet.");
            return;
        }

        Console.WriteLine("----- Goals -----");
        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string completionStatus = goal.IsCompleted ? "[X]" : "[ ]";
            string progressStatus = "";
            if (goal is ChecklistGoal checklistGoal)
            {
                progressStatus = $"Completed {checklistGoal.Progress}/{checklistGoal.TargetCount} times";
            }
            Console.WriteLine($"{i + 1}. {completionStatus} {goal.Description} {progressStatus}");
        }
    }

    public static void ShowScore()
    {
        int score = 0;
        foreach (Goal goal in goals)
        {
            if (goal.IsCompleted)
            {
                score += goal.Points;
            }
        }

        Console.WriteLine($"Total Score: {score}");
    }
}