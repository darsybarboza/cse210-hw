public class SwimmingActivity: Activity
{

    private float laps;
 
    public SwimmingActivity (DateTime date , int length , float laps) : base (date , length ,laps)
    {
        this.laps = laps;
        _name =  "Swimming";
    }

    public override float getDistance()
    {
        return laps *50/1000;
    }

    public override float GetPace()
    {
        return _length/getDistance();
    }


    
}