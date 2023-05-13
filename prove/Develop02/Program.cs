using System;
using System.IO;

class Program
{

    static void Main(string[] args)
    {
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;

        Console.Write ("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write($"\n--- {first} Welcome to the Journal App ---\n");
       

       
        Journal journal = new Journal();
        PromptGenerator jp = new PromptGenerator();

        while (action != 5)
        {
            // Ask for user input (1-5)
            
            action = Choices();

            switch (action)
            {
                case 1:
                    // Write Journal Entry
                    string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    Entry entry = new Entry();
                    entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._promptGenerator = prompt;

                    Console.Write($"{prompt}\n");
                    Console.Write(">>");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);

                    // Console.WriteLine("Success Choice 1!");
                    break;
                case 2:
                    // Display Journal Entries
                    journal.Display();
                    // Console.WriteLine("Success Choice 2!");
                    break;
                case 3:
                    // Load text file
                    journal.LoadFile();
                    // Console.WriteLine("Success Choice 3!");
                    break;
                case 4:
                    // Save to text file
                    journal.CreateJournalFile();
                    // Console.WriteLine("Success Choice 4!");
                    break;
                case 5:
                    // Quite
                    Console.WriteLine("\nThank you for using the Journal App!\n");
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is not valid.");
                    break;
            }
        }
    }

    static int Choices()
    
    {
        string choices = @"
Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.Write(choices);
        string userInput = Console.ReadLine();
        int action = 0;
        
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return action;
    }

    static string GetDateTime()
    
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        
        return currentDateTime;
    }
    static void AddJournalEntry()
  
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuidAsString = entryuuid.ToString();

        return entryuuidAsString;
    }


}

 
