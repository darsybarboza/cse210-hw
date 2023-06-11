using System;
public class ReflectingActivity : Activity

{
    //Atributes
    private string _prompt;
    private string _question;
    private string _description= "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";


    public ReflectingActivity (string activityName ,int activityDuration)
    : base (activityName,activityDuration)

    {
    

    }


    private List <string> _prompList = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless.",
    "Think of a time when you failed at something."  
    };


    private List <string>  _questionList = new List<string>
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

    private List <string> _userQuestionsList = new List<string>();

    
    

    //Methods
    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    
   
    

           




}



