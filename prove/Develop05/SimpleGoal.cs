using System;

public class SimpleGoal : Goal
{
    //Constructors

    public SimpleGoal(string name, string description, int points, int type = 1, bool status = false) : base(name, description, points, type, status) { }


}