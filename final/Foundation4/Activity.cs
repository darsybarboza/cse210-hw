public class Activity
{


    private DateTime date;

    protected int _length; //in minutes

    protected float distance;

    protected string _name;


// protected int _times;
   

   public Activity (DateTime date , int  length , float distance)
   {   
       this.date = date;
       _length = length;
       this.distance = distance;


       // _times = times;

   }

   public void setDate (DateTime date ){
        this.date = date;

    
   }

   public virtual float getDistance()
     {
           return distance *50/1000;

     }

    public virtual float GetPace()
    {
        return  _length/getDistance();
    }

    public virtual float GetSpeed()
    {
        return getDistance()/ _length;
    }

    public string GetSummary()
    {
         return ($"{date} {_name}:({_length}min),{getDistance()}km,Speed:{GetSpeed()},Pace:{GetPace()}");
          
    }










}

