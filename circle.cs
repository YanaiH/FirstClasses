using System;


class Circle
{
    private string color;
    private double radius;

    //constructor
    public Circle(string color, double radius)
    {
        if (color.Length > 2)
        {
            this.color = color;
        }
        else
        {
            Console.WriteLine("Enter a color.");
        }
        this.radius = Math.Abs(radius);
    }

    //calculate perimeter
    public double Perimeter()
    {
        return 2 * Math.PI * radius;
    }

    //calculate area
    public double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    // print color
    public void PrintColor()
    {
        Console.WriteLine(color);
    }

    // print radius 
    public void PrintRadius()
    {
        Console.WriteLine(radius);
    }

}

