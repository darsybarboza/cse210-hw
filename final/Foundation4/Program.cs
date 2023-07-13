using System;

class Program
{
    static void Main(string[] args)
    {
       List <Activity> activity = new List<Activity> ();

       RunningActivity runningActivity = new RunningActivity (DateTime.Now , 25 , 4.8f);
       SwimmingActivity swimmingActivity = new SwimmingActivity (DateTime.Now , 33 , 10);
       CyclingActivity  cyclingActivity = new CyclingActivity (DateTime.Now , 25 , 10);

       activity.Add (runningActivity);
       activity.Add (swimmingActivity);
       activity.Add (cyclingActivity);

       foreach (Activity a in activity)
       {
        Console.WriteLine (a.GetSummary());
       }
    }


}