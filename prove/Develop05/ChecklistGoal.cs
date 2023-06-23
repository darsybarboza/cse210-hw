using System ;

public class ChecklistGoal : Goal
{
    //Atributes

    private string _goalType = "Check List Goal:";
    private int _numberTimes;
    private int _bonusPoints;
    private bool _status;
    private int _count ;


    // Constructors
   
    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base( type, name, description, points)
    {
        _status = false;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(type, name, description, points)
    {
        _status = status;
        _numberTimes = numberTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    
}