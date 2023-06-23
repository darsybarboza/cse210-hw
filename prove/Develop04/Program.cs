using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            
            Console.WriteLine("\n" +
             "\n 1. Start breathing activity" +
             "\n 2. Start reflecting activity" +
             "\n 3. Start listing activity" +
             "\n 4. Quit \n");
            Console.Write("Select a choice from the menu: ");
            option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    breathing.SetActivityDuration();
                    breathing.GetReady();
                    breathing.StartActivity();
                    breathing.EndActivity();
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0);
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    reflecting.SetActivityDuration();
                    reflecting.GetReady();
                    reflecting.StartActivity();
                    reflecting.EndActivity();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity("Listing", 0);
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    listing.SetActivityDuration();
                    listing.GetReady();
                    listing.StartActivity();
                    listing.EndActivity();
                    break;

                case 4:
                    Console.Write("Thank you for using the Mindfulness Program");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(".");
                        Thread.Sleep(1000);
                    }
                    Console.Write("Goodbye!");
                    Thread.Sleep(500);
                    break;


                default:
                    Console.WriteLine("Enter a valid option!");
                    break;
            }
        } while (option != 4);


    }
}