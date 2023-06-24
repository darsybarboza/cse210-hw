using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class UserGoal
{
    private List<Goal> _goals;
    private int _totalPoints;


    //Constructors

    public UserGoal()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    // Methods

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public List<Goal> GetGoals()
    {
        return _goals;
    }

    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;

    }

    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public void SetGoals(List<Goal> goals)
    {
        _goals = goals;
    }

    public List<Goal> GetGoalsList()
    {
        return _goals;
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:" +
            "\n 1. Simple Goal" +
            "\n 2. Eternal Goal" +
            "\n 3. Checklist Goal"
        );
        Console.Write("Which type of goal would you like to create? ");
        int goalOption = Int32.Parse(Console.ReadLine());
        switch (goalOption)
        {
            case 1:
                Console.Write("What is the name of your goal? ");
                string simpleName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string simpleDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int simplePoints = Int32.Parse(Console.ReadLine());

                SimpleGoal simpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints);
                this.AddGoal(simpleGoal);

                break;
            case 2:
                Console.Write("What is the name of your goal? ");
                string eternalName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string eternalDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int eternalPoints = Int32.Parse(Console.ReadLine());

                EternalGoal eternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints);
                this.AddGoal(eternalGoal);

                break;
            case 3:
                Console.Write("What is the name of your goal? ");
                string checklistName = Console.ReadLine();
                Console.Write("What is a short description of your goal? ");
                string checklistDescription = Console.ReadLine();
                Console.Write("What is the amount of points associated with this goal? ");
                int checklistPoints = Int32.Parse(Console.ReadLine());
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int checklistNumTimes = Int32.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int checklistBonusPoints = Int32.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, checklistNumTimes, checklistBonusPoints);
                this.AddGoal(checklistGoal);

                break;
            default:
                Console.WriteLine("Apologies, that option is not available. Returning to the main menu.");
                break;
        }
    }

    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nYour Goals are:");

            int index = 1;
            //Loop
            foreach (Goal goal in _goals)
            {
                string check = goal.GetStatus() == true ? "X" : " ";
                Console.Write($" {index}. [{check}] {goal.GetName()} ({goal.GetDescription()})");
                if (goal.GetGoalType() == 3)
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    Console.Write($" -- Currently completed: {checklistGoal.GetCount()}/{checklistGoal.GetNumberTimes()}");
                }
                Console.WriteLine();
                index = index + 1;
            }
        }

        else
        {
            Console.WriteLine("You currently have no goals!");
        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplished? ");
        int select = Int32.Parse(Console.ReadLine());

        Goal selectedGoal = this.GetGoalsList()[select - 1];

        AddPoints(selectedGoal.GetPoints());

        if (selectedGoal.GetGoalType() == 1)
        {
            selectedGoal.SetStatus(true);
        }
        else if (selectedGoal.GetGoalType() == 3)
        {
            ChecklistGoal selectedChecklistGoal = (ChecklistGoal)selectedGoal;
            selectedChecklistGoal.SetCount(selectedChecklistGoal.GetCount() + 1);
            if (selectedChecklistGoal.GetCount() == selectedChecklistGoal.GetNumberTimes())
            {
                selectedChecklistGoal.SetStatus(true);
                _totalPoints += selectedChecklistGoal.GetBonusPoints();
            }
        }

    }

    public void SaveGoals()
    {
        Console.Write("\nWhat is the name for this goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput;

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // 
            // Using JSON to save goals to file
            // https://www.techiedelight.com/write-to-json-file-csharp/
            UserData userData = new UserData() { totalPoints = this._totalPoints, goalData = new List<GoalData>() };
            foreach (Goal goal in _goals)
            {
                if (goal.GetGoalType() == 1)
                {
                    SimpleGoal simpleGoal = (SimpleGoal)goal;
                    userData.AddGoal(
                        new GoalData
                        {
                            type = simpleGoal.GetGoalType(),
                            name = simpleGoal.GetName(),
                            description = simpleGoal.GetDescription(),
                            points = simpleGoal.GetPoints(),
                            status = simpleGoal.GetStatus()
                        }
                    );
                }
                else if (goal.GetGoalType() == 2)
                {
                    EternalGoal eternalGoal = (EternalGoal)goal;
                    userData.AddGoal(
                        new GoalData
                        {
                            type = eternalGoal.GetGoalType(),
                            name = eternalGoal.GetName(),
                            description = eternalGoal.GetDescription(),
                            points = eternalGoal.GetPoints(),
                            status = eternalGoal.GetStatus()
                        }
                    );
                }
                else
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    userData.AddGoal(
                        new GoalData
                        {
                            type = checklistGoal.GetGoalType(),
                            name = checklistGoal.GetName(),
                            description = checklistGoal.GetDescription(),
                            points = checklistGoal.GetPoints(),
                            status = checklistGoal.GetStatus(),
                            numberTimes = checklistGoal.GetNumberTimes(),
                            bonusPoints = checklistGoal.GetBonusPoints(),
                            count = checklistGoal.GetCount()
                        }
                    );
                }

            }

            // Serialize the object to JSON and output to file 
            string json = JsonSerializer.Serialize(userData);
            outputFile.WriteLine(json);
        }

    }

    public void LoadGoals()
    {
        Console.Write("\nWhat is the name for this goal file? ");
        string userInput = Console.ReadLine();
        string userFileName = userInput;

        // Serializing and Deserializing JSON files with System.Text.Json
        // https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/how-to?pivots=dotnet-8-0
        using (FileStream inputFile = File.OpenRead(userFileName))
        {
            UserData userData = JsonSerializer.Deserialize<UserData>(inputFile);
            List<Goal> tempGoals = new List<Goal>();
            foreach (GoalData data in userData.goalData)
            {
                if (data.type == 1)
                    tempGoals.Add(new SimpleGoal(data.name, data.description, data.points, data.type, data.status));
                else if (data.type == 2)
                    tempGoals.Add(new EternalGoal(data.name, data.description, data.points, data.type, data.status));
                else
                    tempGoals.Add(new ChecklistGoal(data.name, data.description, data.points, data.numberTimes, data.bonusPoints, data.count, data.type, data.status));
            }

            // Set goals and total points from JSON data
            this.SetGoals(tempGoals);
            this.SetTotalPoints(userData.totalPoints);
        }

    }

    public void RemoveGoal()
    {
        ListGoals();
        Console.Write("Which goal would like to remove from the list? ");
        int selection = Int32.Parse(Console.ReadLine());
        _goals.RemoveAt(selection - 1);
        Console.WriteLine("The item has been successfully removed.");
    }
}