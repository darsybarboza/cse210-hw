public class Address

{
    private string street;
    private string city;
    private string state;
    private int zip;


    public Address(string street ,string city , string state , int zip)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zip = zip;


    }

    public string GetAddress(){
        return $"{street}, {city}, {state} {zip}";
    }

    

}
