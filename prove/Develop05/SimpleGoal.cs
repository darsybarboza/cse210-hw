using System;

public class SimpleGoal : Goal
{
    //Atributes

    private string _goalType = "Simple Goal:";

    private bool _status;


    //Constructors

    public SimpleGoal (string type, string name ,string description ,int points) : base (type , name , description , points)
    {
        _status = false;
    }


    
}