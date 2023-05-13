using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    
    public List<Entry> _journal = new List<Entry>();
    // private string fileName = "MyJournal.txt";
    private string _userFileName;


    
    public Journal()
    {
    }

   
    public void Display()
    {
        Console.WriteLine("\n--------- Journal Entries----------\n");
        foreach (Entry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("\n-------------- End ---------------\n");
    }

    public void CreateJournalFile()
    // Method to check if txt file is created if not create one
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n--- {_userFileName} has been created! ---\n");
            Console.Write("---  Your journal entries have been saved. ---\n");
            SaveFile(_userFileName);
            CreateJSON(userInput);
        }
        else
        {
            Console.Write($"\n--- {_userFileName} already exits. ---\n");
            Console.Write("---  Your journal entries have been added. ---\n");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveFile(string _userFileName)
    // Method to save journal to txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (Entry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._promptGenerator}; {journalEntry._journalEntry}");
            }
        }
    }

    public void AppendJournalFile(string _userFileName)
    // Method to save a new entry to journal txt file 
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (Entry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._promptGenerator}; {journalEntry._journalEntry}");
            }
        }
    }

    public void LoadFile()
    // Method to check if txt file is created and load it into the list.  
    // This should replace any current info in the list
    {
        Console.Write("What your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                Entry entry = new Entry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._promptGenerator = entries[2];
                entry._journalEntry = entries[3];

                _journal.Add(entry);
            }
        }
    }


    public void CreateJSON(string userInput)
    // Method to create a JSON file 
    {
        string fileName = userInput + ".json";
        List<JsonItem> _data = new List<JsonItem>();

        foreach (Entry journalEntry in _journal)
        {
            _data.Add(new JsonItem()
            {
                ID = journalEntry._entryNumber,
                Date = journalEntry._dateTime,
                Prompt = journalEntry._promptGenerator,
                Entry = journalEntry._journalEntry
            });
        }

        string json = JsonSerializer.Serialize(_data);
        File.WriteAllText(fileName, json);
    }

}