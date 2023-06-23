using System;

public abstract class Goal 
{
    //Atributes

    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;



    //Constructors

    public Goal (string type , string name, string description, int points)
    {
        _goalType= type;
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
    }

    public string GetGoalType()
    {
        return _goalType;

    }

    public string GetName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _goalDescription;

    }

    public int GetPoints()
    {
        return _goalPoints;
    }

    //Methods

    public abstract void ListGoal (int i);
    public abstract string SaveGoal();
    public abstract string LoadGoal ();
    public abstract void RecordGoalEvent (List <Goal> goals);

}