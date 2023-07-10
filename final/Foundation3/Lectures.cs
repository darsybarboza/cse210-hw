public class Lectures : Event
{


    public Lectures (string title , string description , DateTime date, TimeSpan time , Address address , string speaker , int capacity , string name ) : base (title , description, date , time , address , speaker + "," + capacity , name)
    {
        //_speaker = speaker;
        //_capacity = capacity;

        name = "Lectures";
        capacity = 50;
    }


}