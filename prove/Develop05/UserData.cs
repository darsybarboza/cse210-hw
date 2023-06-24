using System;

public class UserData
{
    public List<GoalData> goalData { get; set; }
    public int totalPoints { get; set; }
    public void AddGoal(GoalData data)
    {
        goalData.Add(data);
    }
}
