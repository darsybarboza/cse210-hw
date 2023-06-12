using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    // Atributos
    private string _firstMessage = "Breathe in...";
    private string _secondMessage = "Now breathe out...";
    private string _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    public BreathingActivity(string activityName, int activityDuration) : base(activityName, activityDuration) { }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public void StartActivity()
    {
        // Stack Overflow - Implementing a loop using a timer in C#
        // https://stackoverflow.com/questions/17418820/implementing-a-loop-using-a-timer-in-c-sharp
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed < TimeSpan.FromSeconds(GetActivityDuration()))
        {
            for (int i = 4; i > 0; i--)
            {
                Console.Write($"{_firstMessage}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_firstMessage.Length + 2));  // Overwrite line
                Console.Write(blank);
            }
            Console.WriteLine($"{_firstMessage}  ");  // last prompt
            for (int i = 5; i > 0; i--)
            {
                Console.Write($"{_secondMessage}{i}");
                Thread.Sleep(1000);
                string blank = new string('\b', (_secondMessage.Length + 2));  // Overwrite line
                Console.Write(blank);
            }
            Console.WriteLine($"{_secondMessage}  ");  // last prompt
            Console.WriteLine();  //insert blank line to start
        }
    }
}
