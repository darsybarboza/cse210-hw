public abstract class Event
{
    private string title;
    private string description;
    private DateTime date;
    private TimeSpan time;


    private Address address;

    private string additionalInfo;

    private string name;

  

    public Event (string title , string description , DateTime date , TimeSpan time , Address address, string additionalInfo , string name )
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
        this.additionalInfo = additionalInfo;
        this.name = name;
        
        
    }


    public string GetStandardDetails()
    {
      return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime : {time}:\nOrador Name: {name}\nCapacity: {additionalInfo}\nAddress :{address.GetAddress()}\n";
    }

    public string GetFullDetails()
    {
      return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}\ne-mail:{additionalInfo}\n";
    } 

    public string ShortDescription()
    {
      return $"Title: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address.GetAddress()}\nWeather:{additionalInfo}\n";
    } 


}



