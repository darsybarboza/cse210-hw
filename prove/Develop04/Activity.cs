using System;


public class Activity
{
    //Atributos
    private string _activityName;

   

    private int _activityDuration;

    
    // Constructors
    public  Activity (string activityName,  int activityDuration ) 
    {
        _activityName = activityName;
        _activityDuration = activityDuration;
        
        
    }

    public void GetActivityName()
    {
        Console.WriteLine($"\n***Welcome to the { _activityName} Activity!!***\n");
    }


    public int GetActivityDuration()
    { 
        Console.WriteLine ("\nHow long, in seconds, would you like for your sesion?\n");
        int userSeconds = Int32.Parse (Console.ReadLine());
        _activityDuration = userSeconds;
        return userSeconds;
    
    }

    public void SetActivityTime (int activityDuration)
    {
        _activityDuration = activityDuration;
    }

    public void GetReady ()
    {
        Console.Clear();
        Console.WriteLine ("Get Ready");
        
    }


    
}