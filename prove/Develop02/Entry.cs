using System;

public class Entry
{
    
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _promptGenerator = "";
    public string _journalEntry = "";
    public string _journalFile = "";


   
    public Entry()
    {
    }

   
    public void Display()
    {
        
        Console.WriteLine($"Date: {_dateTime}");
        Console.WriteLine($"Prompt: {_promptGenerator}");
        Console.WriteLine($"Entry: {_journalEntry}\n");
    }

}