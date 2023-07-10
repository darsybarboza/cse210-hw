public class Outdoor : Event

{

    public Outdoor (string title , string description , DateTime date , TimeSpan time , Address address ,string weather) 
    : base (title , description , date , time , address , weather , "Outdoor"){


        //this.weather = weather;
    }

}