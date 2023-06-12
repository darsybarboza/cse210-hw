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

    private List<string> _userList = new List<string>();

    private string _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

    //constructor
    public ListingActivity(string activityName, int activityDuration) : base(activityName, activityDuration) { }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }

    private void ReadResponses()
    {
        Console.Write("> ");
        Console.ReadLine();
    }

    public void StartActivity()
    {
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        BeginCountdown();
        Console.WriteLine();

        // Stack Overflow - Implementing a loop using a timer in C#
        // https://stackoverflow.com/questions/17418820/implementing-a-loop-using-a-timer-in-c-sharp
        int listedItems = 0;
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed < TimeSpan.FromSeconds(GetActivityDuration()))
        {
            ReadResponses();
            listedItems++;
        }
        timer.Stop();
        Console.WriteLine($"You listed {listedItems} items!\n");
    }

}