using System;

class Program
{
    static void Main(string[] args)
    {
    
      int option = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("***Welcome to the Eternal Quest Program ***");
            Console.WriteLine ();
            Console.WriteLine ("Menu Options:");
            Console.WriteLine("\n" +
             "\n 1. Create New Goal" +
             "\n 2. List Goals" +
             "\n 3. Save Goals" +
             "\n 4. Load Goals" +
             "\n 5. Quit \n");
            Console.Write("Select a choice from the menu: ");
            

            switch (option)
            {
                case 1:
                
                Console.WriteLine ("What is the name of your goal?");
                Console.WriteLine("What is a short description of your goal?  ");
                Console.Write("What is the amount of points associated with this goal?");
                break;

                case 2:
                
                Console.WriteLine ("What is the name of your goal?");
                Console.WriteLine("What is a short description of your goal?  ");
                Console.Write("What is the amount of points associated with this goal?");

                break;

                case 3:
                
                Console.WriteLine("What is a short description of your goal?  ");
                Console.Write("What is the amount of points associated with this goal?  ");
                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");


                break;

                default:
                  Console.Write ($"\nSorry the option you entered is not valid.");
                  break;

            }
        } while (option != 6);
    }
}


      
    


    
            
                








        




        

