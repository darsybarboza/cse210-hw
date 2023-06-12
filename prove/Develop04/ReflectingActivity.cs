using System;
using System.Diagnostics;
public class ReflectingActivity : Activity

{
    //Atributes
    private string _prompt;
    private string _question;
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";


    public ReflectingActivity(string activityName, int activityDuration) : base(activityName, activityDuration) { }


    private List<string> _promptList = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you failed at something."
    };


    private List<string> _questionList = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?",
    "What was your motivation?"
    };

    private List<string> _questionsAskedList = new List<string>();

    //Methods
    public void StartActivity()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {_promptList[index]} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");

        BeginCountdown();

        Console.Clear();

        // Stack Overflow - Implementing a loop using a timer in C#
        // https://stackoverflow.com/questions/17418820/implementing-a-loop-using-a-timer-in-c-sharp
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed < TimeSpan.FromSeconds(GetActivityDuration()))
        {
            Random randomTwo = new Random();
            int indexTwo = randomTwo.Next(_questionList.Count);
            if (!(_questionsAskedList.Contains(_questionList[indexTwo])))
            {
                _questionsAskedList.Add(_questionList[indexTwo]);
                Console.Write($"> {_questionsAskedList[_questionsAskedList.Count - 1]} ");
                AnimateLoad(6);
            }
            else
            {
                randomTwo = new Random();
            }
        }

        Console.WriteLine();
    }

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

}
