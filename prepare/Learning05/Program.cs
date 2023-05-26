using System;

class Program
{
    static void Main(string[] args)
    {
       Rectangle rectangle1 = new Rectangle();
       rectangle1 ._basis = 3;
       rectangle1 ._height = 7 ;

       Console.WriteLine(rectangle1.Area());



       Rectangle rectangle2 = new Rectangle();
       rectangle2 ._basis = 1.5;
       rectangle2 ._height = 4 ;
       Console.WriteLine(rectangle2.Area());


       Rectangle rectangle3 = new Rectangle();
       rectangle3 ._basis = 7;
       rectangle3 ._height = 10 ;
       Console.WriteLine(rectangle3.Area());


       Console.ReadKey();


    }
}