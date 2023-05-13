using System;

public class Resume
{
    public string _name;
    public string _lastName;

    // Make sure to initialize your list to a new list before you use it.
    public List <Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine ($"Last name: {_lastName}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop

        foreach (Job job in _jobs)
        {
            //This calls the Display method on each job

            job.Display();
        }
    }

}