// See https://aka.ms/new-console-template for more information
using _1909;
using System;

public class Program
{


    static void Main(String[] args)
    {
        Human human = new Human("Karel");
        Saint saint = new Saint("saint Francisc");
        Politician politician = new Politician("Boris");

        Console.WriteLine(String.Format("Human {0} said: {1} \n" +
            "Saint {2} said: {3} \n" +
            "Politician {4} said: {5}", human.getName(), human.isLying(), saint.getName(), saint.isLying(), politician.getName(), politician.isLying()));




    }

}
