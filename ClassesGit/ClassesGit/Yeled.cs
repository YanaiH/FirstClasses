using System;


class Yeled
{
    private string adjective;
    private int age;
    

    //constructor
    public Yeled(string adjective, int age)
    {
        this.adjective = adjective.ToLower();
        if (age<18)
        {
            this.age = age;
        }
        else
        {
            Console.WriteLine("Not a Yeled, actually Zaken");
            this.age = int.MaxValue;
        }
    }

    public string Adjective()
    {
        return this.adjective;
    }
}
