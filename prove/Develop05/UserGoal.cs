using System;

public class UserGoal
{
    private List <Goal> _goals = new List<Goal>();
    private int _totalPoints;


    //Constructors

    public UserGoal()
    {
        _totalPoints = 0;
    }

    public void AddGoal (Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;

    }

    
    public void AddPoints (int points)
    {
        _totalPoints += points;
    }
    public void AddBonus (int bonusPoints)
    {
        _totalPoints += bonusPoints;

    }

    public void SetTotalPoints (int  totalPoints)
    {
        _totalPoints = totalPoints;
    }

    public List <Goal> GetGoalsList()
    {
        return _goals;
    }


    // Methods

    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine ("\nYour Goals are:");
            
            int index = 1;
            //Loop
            foreach (Goal goal in _goals)
            {
                goal.ListGoal (index);
                index = index + 1;
            }
        }

        else
        {
            Console.WriteLine ("\nYou currently have no goals!");

        }
    }

    public void RecordGoalEvent()
    {
        ListGoals();
        Console.Write ("\n Which goal did you accomplished?");
        int select = int.Parse (Console.ReadLine()) -1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints (goalPoints);


        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");

    }

    public void SaveGoals()
    {
        Console.Write ("\nWhat is the name for this goal file?");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter (userFileName))
        {
            //save total points

            outputFile.WriteLine(GetTotalPoints());
            

            //save goals list
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }

        }



    }

    public void LoadGoals()
    {
        
    }
}