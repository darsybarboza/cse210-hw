using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("Meet President Oaks","Devotional for Young Adults",DateTime.Now,TimeSpan.FromDays(2), new Address("Conference Center","SLC","Utah",83440),"Limited",100,"President Oaks");
        Console.WriteLine(lectures.GetStandardDetails());



        Receptions receptions = new Receptions ("Darsy & Diego Wedding" , "A small reception to celebrate our wedding",DateTime.Now,TimeSpan.FromDays(4), new Address("400 South Road","Miami","Florida",97240),"TheWedding@gmail.com");
        Console.WriteLine (receptions.GetFullDetails());


         Outdoor outdoor = new Outdoor("Young Men and Young Women Activity ","Come and spend a fun afternoon with us!",DateTime.Now,TimeSpan.FromDays(6), new Address("Rua 7 de Novembro","Santa Maria","Brazil",83440),"Sunny");
        Console.WriteLine(outdoor.ShortDescription());

    }
}