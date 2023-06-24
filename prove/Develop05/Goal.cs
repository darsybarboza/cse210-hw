using System;

public class Goal
{
    //Atributes

    private int _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalPoints;
    private bool _goalStatus;



    //Constructors

    public Goal(string name, string description, int points, int type, bool status)
    {
        _goalType = type;
        _goalName = name;
        _goalDescription = description;
        _goalPoints = points;
        _goalStatus = status;
    }

    //Methods

    public int GetGoalType()
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

    public bool GetStatus()
    {
        return _goalStatus;
    }

    public void SetStatus(bool status)
    {
        _goalStatus = status;
    }

}