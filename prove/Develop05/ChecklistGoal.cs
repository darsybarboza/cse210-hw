using System;

public class ChecklistGoal : Goal
{
    //Atributes
    private int _numberTimes;
    private int _bonusPoints;
    private int _count;


    // Constructors

    public ChecklistGoal(string name, string description, int points, int numberTimes, int bonusPoints, int type = 3, bool status = false) : base(name, description, points, type, status)
    {
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string name, string description, int points, int numberTimes, int bonusPoints, int count, int type = 3, bool status = false) : base(name, description, points, type, status)
    {
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }


    // Methods


    public int GetBonusPoints()
    {
        return _bonusPoints;
    }

    public int GetNumberTimes()
    {
        return _numberTimes;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

}