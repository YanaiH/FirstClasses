using System;


class Program
{
    static void Main1(string[] args)
    {
        for (int i = 0; i < 2000; i++)
        {
            if (Numtests.IsPrime(i))
            {
                Console.WriteLine(i + "is a prime number");
            }
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Circle c1 = new Circle("red", 5);
        Circle c2 = new Circle("Yellow", 7);
        double c1Area = c1.Area();
        double c2Area = c2.Area();
        if (c1Area>c2Area)
        {
            c1.PrintColor();
        }
        else if (c2Area>c1Area)
        {
            c2.PrintColor();
        }
        else
        {
            Console.WriteLine("equal areas");
        }
        Console.ReadKey();
    }
}


class Numtests
{
    public static bool IsDual(int num)
    {
        if (num < 100 && num >= 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool ProBSum(int a, int b)
    {
        int sum = a + b, product = a * b;
        if (product > sum)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int SumDigits(int num)
    {
        int sumDigits = 0;
        while (num != 0)
        {
            int dig = num % 10;
            sumDigits = sumDigits + dig;
            num = num / 10;
        }
        return sumDigits;
    }


    public static bool IsPrime(int num)
    {
        bool isPrime = true;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                isPrime = false;
            }
        }
        if (num<2)
        {
            isPrime = false;
        }
        return isPrime;
    }
}

