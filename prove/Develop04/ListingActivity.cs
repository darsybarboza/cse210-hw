using System;
using System.Diagnostics;


public class ListingActivity : Activity
{
    //Atributes
    private List <string> _promptList = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    private List <string> _userList = new List<string>();

    private string _description1 = "This activity  will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    private string _message = "You may begin in: ";

    //constructor
    public ListingActivity (string activityName , int activityDuration) : base (activityName , activityDuration)
    {
        
    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description1);
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList [index];
    }

    public void ReturnPrompt( int seconds)
    {
        
    }




}