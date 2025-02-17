using System;
using Microsoft.VisualBasic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Select a choice from the menu:");
    }

    public void DisplayPlayerInfo()
    {   
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalName()
    {
        
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {   
        string status = goal.IsComplete() ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {goal.GetStringRepresentation()}");
        }
    }

    public void CreateGoal()
    {   
        int type = 0;
        string name = "";
        string description = "";
        string points = "";

        while (true)
        {   
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Which type of goal would you like to create?");
            type = int.Parse(Console.ReadLine());

            if (type == 1)
            {   
                Console.WriteLine("What is the name of your goal?");
                name = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated to this goal?");
                points = Console.ReadLine();
                bool isComplete = false;

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points, isComplete);
                _goals.Add(simpleGoal);
                break;
            }
            else if (type == 2)
            {   
                Console.WriteLine("What is the name of your goal?");
                name = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated to this goal?");
                points = Console.ReadLine();

                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
                break;
            }
            else if (type == 3)
            {   
                Console.WriteLine("What is the name of your goal?");
                name = Console.ReadLine();
                Console.WriteLine("What is a short description of it?");
                description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated to this goal?");
                points = Console.ReadLine();
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int bonus = int.Parse(Console.ReadLine());
                int amountCompleted = 0;

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(checklistGoal);
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please enter a number between 1 and 3.");
            }
        }
    }

    public void RecordEvent()
    {   
        Console.WriteLine("The goals are:");
    
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        Console.Write("\nWhich goal did you accomplish?: ");
        if (int.TryParse(Console.ReadLine(), out int goalIndex) && goalIndex > 0 && goalIndex <= _goals.Count)
        {   
            Goal selectedGoal = _goals[goalIndex - 1];
            int pointsEarned = int.Parse(selectedGoal.GetPoints());

            if (!selectedGoal.IsComplete()) 
            {
                _score += pointsEarned;
                selectedGoal.RecordEvent();

                Console.WriteLine($"\nCongratulations! You have earned {pointsEarned} points.");
                
            }
            else if (selectedGoal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                pointsEarned += checklistGoal.GetBonus();
                _score += pointsEarned;
            }
            else
            {
                Console.WriteLine("\nYou already finished that goal.");
            }
        }
        else
        {
            Console.WriteLine("Invalid selection. Please enter a valid goal number.");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {   
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {   
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"{simpleGoal.GetName()}, {simpleGoal.GetDescription()}, {simpleGoal.GetPoints()}, {simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"{eternalGoal.GetName()}, {eternalGoal.GetDescription()}, {eternalGoal.GetPoints()}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"{checklistGoal.GetName()}, {checklistGoal.GetDescription()}, {checklistGoal.GetPoints()}, {checklistGoal.GetBonus()}, {checklistGoal.GetTarget()}, {checklistGoal.GetAmountCompleted()}");
                }
            }
        }
        Console.WriteLine($"Goals saved to {fileName}");
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            _goals.Clear();
            foreach (var line in lines)
            {
                var parts = line.Split(",");
                if (parts.Length == 1)
                {
                    _score = int.Parse(parts[0].Trim());
                }
                else if (parts.Length == 4)
                {
                     _goals.Add(new SimpleGoal(
                        parts[0].Trim(),
                        parts[1].Trim(),
                        parts[2].Trim(),
                        bool.Parse(parts[3].Trim())
                     ));
                }
                else if (parts.Length == 3)
                {
                    _goals.Add(new EternalGoal(
                    parts[0].Trim(),
                    parts[1].Trim(),
                    parts[2].Trim()
                     ));
                }
                else if (parts.Length == 6)
                {
                     _goals.Add(new ChecklistGoal
                    (
                    parts[0].Trim(),
                    parts[1].Trim(),
                    parts[2].Trim(),
                    int.Parse(parts[4].Trim()),
                    int.Parse(parts[3].Trim()),
                    int.Parse(parts[5].Trim())
                    ));
                }
            }
            Console.WriteLine($"Goals loaded from {fileName}");
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
    
}