using System;

// A code template for the category of things known as 
public class Entry
{
    // The C# convention is to start member variables with an underscore _
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _promptGenerator = "";
    public string _journalEntry = "";
    public string _journalFile = "";


    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Entry()
    {
    }

    // A method that displays 
    public void Display()
    {
        
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_promptGenerator}");
        Console.WriteLine($"Entry: {_journalEntry}\n");
    }

}