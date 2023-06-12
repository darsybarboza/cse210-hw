using System;


public class Activity
{
    //Atributos
    private string _activityName;
    private int _activityDuration;

    private static List<string> animationString = new List<string> {
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };

    // Constructors
    public Activity(string activityName, int activityDuration)
    {
        _activityName = activityName;
        _activityDuration = activityDuration;
    }

    public void GetActivityName()
    {
        Console.Clear();
        Console.WriteLine($"\n***Welcome to the {_activityName} Activity!!***\n");
    }


    public int SetActivityDuration()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityDuration = userSeconds;
        return userSeconds;
    }

    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    public void SetActivityTime(int activityDuration)
    {
        _activityDuration = activityDuration;
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        AnimateLoad(5);
    }

    public void EndActivity()
    {
        Console.WriteLine("Well done!!");
        AnimateLoad(5);
        Console.WriteLine($"You have completed another {_activityDuration} seconds of the {_activityName} Activity.");
        AnimateLoad(5);
    }

    public void AnimateLoad(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

    public void BeginCountdown()
    {
        Console.Write("You may begin in: ");
        for (int i = 4; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}