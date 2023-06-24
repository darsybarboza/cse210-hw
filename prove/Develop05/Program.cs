using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        UserGoal user = new UserGoal();

        Console.Clear();
        Console.WriteLine("***Welcome to the Eternal Quest Program ***");

        int option = 0;
        while (option != 7)
        {
            Console.WriteLine($"\nYou have {user.GetTotalPoints()} points.\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(
             "\n 1. Create New Goal" +
             "\n 2. List Goals" +
             "\n 3. Save Goals" +
             "\n 4. Load Goals" +
             "\n 5. Record Event" +
             "\n 6. Remove Goal" +
             "\n 7. Quit" +
             "\n"
            );
            Console.Write("Select a choice from the menu: ");
            option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    user.CreateGoal();
                    break;

                case 2:
                    user.ListGoals();
                    break;

                case 3:
                    user.SaveGoals();
                    break;

                case 4:
                    user.LoadGoals();
                    break;

                case 5:
                    user.RecordGoalEvent();
                    break;

                case 6:
                    user.RemoveGoal();
                    break;

                case 7:
                    Console.WriteLine("\nThank you for using the program! We hope you enjoyed your quest!\n");
                    break;

                default:
                    Console.Write($"\nSorry the option you entered is not valid.");
                    break;

            }
        }
    }
}
