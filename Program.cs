using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter hour, then minute, then how many minutes to advance.");
        int hour = int.Parse(Console.ReadLine()), minute = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine());
        Time test = new Time(hour,minute);
        Console.Write("You entered:   ");
        test.PrintTime();
        for (int i = 0; i < k; i++)
        {
            test.Increment();
        }
        test.PrintTime();
        Console.ReadKey();
    }
}



class Time
{
    private int min;
    private int hour;

    public Time(int hour1, int min1)
    {
        min = min1; hour = hour1;
    }

    public void PrintTime()
    {
        Console.WriteLine(hour + ":" + min);
    }

    public bool IsSchoolTime()
    {
        if (hour >= 8 && hour <= 16) return true; else return false;
    }

    public void Increment()
    {
        if (min==59)
        {
            min = 0;
            if (hour == 23)
            {
                hour = 0;
            }
            else
            {
                hour++;
            }
        }
        else
        {
            min++;
        }
    }
}
