public class CyclingActivity : Activity
{
    public CyclingActivity (DateTime date, int length, float distance) : base (date , length , distance)
    {
        this.distance = distance;
        _name = "Cycling";
    }

    public override float getDistance()
    {
        return distance;
    }

    public override float GetPace()
    {
        return   _length/distance;
    }

    public override float GetSpeed()
    {
         return (distance/_length)*60;
    }
}