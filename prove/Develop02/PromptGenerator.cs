using System;

// A code template for the category of things known as Journal Prompts
public class PromptGenerator
{
    // The C# convention is to start member variables with an underscore _

    public static string[] _prompt = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the best idea you had today?",
            "List the 3 things you are grateful for today and why.",
            "Who made you feel good today?",
            "What did you learn today?",
            "What is the funniest thing that happened today?",
            "If you could become an expert in any subject or activity, what would it be?",
            "What would you buy today if money were no object?",
            "How did you procrastinate on important tasks today?",
            "What scripture just popped into your head right now?",
            "What is something that made you laugh today?",
            "Who made your day better today?",
            "What is one thing you want to remember from today?",
            "How would you describe your spirituality today?",
            "Identify three times that you felt challenged today.",
            "What do I need to let go of today?",
            "What do you need the most right now?",
            "What was the most peaceful moment during the day?",
            
            
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    public PromptGenerator()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        
        return journalPrompt;
    }
}