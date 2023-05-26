using System;

class Program
{
    static void Main(string[] args)
    {
        Person  persona1 = new Person ();
        persona1 ._Name = "Maria";
        persona1 ._Age = 21;


        Person person2 = new Person();
        person2 ._Name = "Antonio";
        person2 ._Age= 22;


        Console.WriteLine ($"Persona 1 se llama  {persona1._Name} y tiene  {persona1._Age}  años");
        Console.WriteLine ($"Persona 2 se llama  {person2._Name} y tiene  {person2._Age}  años");




        Console.WriteLine("Hello Learning04 World!");
    }
}