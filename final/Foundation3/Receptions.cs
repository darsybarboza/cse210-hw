public class Receptions : Event
{
    //private string Email;

    public Receptions (string title , string description , DateTime date , TimeSpan time , Address address , string email )
    : base (title , description ,date , time ,address ,email , "Receptions")
    {
        //this.email = email ;
    }

}