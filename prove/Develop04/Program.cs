using System;

class Program
{
    static void Main(string[] args)
    {
        int opcion = 0;
        do
        { 
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine ("\n" +
             "\n 1. Start breathing activity" +
             "\n 2. Start reflecting activity" +
             "\n 3. Start listing activity" +
             "\n 4. Quit \n");
            Console.Write("Select a choice from the menu:");
            opcion = Convert.ToInt32(Console.ReadLine());
            

            switch(opcion)
            {
                case 1:
                
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0);
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    breathing.GetActivityDuration();
                   

                    

                    
                    
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting",0 );
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    reflecting.GetActivityDuration();



                

                    
                    break;   

                case 3:
                    ListingActivity  listing = new ListingActivity ("Listing",0 );
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    listing.GetActivityDuration();
                    
                    
                    break; 

                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness Program");
                    break;     


                default:
                    Console.WriteLine ("Enter a valid option");
                    break;
            }

            Console.ReadKey();
        

        }  while (opcion !=4);
    
        
    }
}