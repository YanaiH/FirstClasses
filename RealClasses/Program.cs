using System;


class Program
{
    static void Main1()
    {
        //just playing with my first practice
        for (int i = 0; i < 2000; i++)
        {
            if (Numtests.IsPrime(i))
            {
                Console.WriteLine(i + "is a prime number");
            }
        }
        Console.ReadKey();

    }

    static void Main2(string[] args)
    {
        //circles
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

    static void Main3(string[] args)
    {
        //DiceGame
        Die d1 = new Die();
        Die d2 = new Die();
        int turnCount = 1;
        int num1 = d1.GetNum();
        int num2 = d2.GetNum();
        while (num1 != 6 || num2 != 6)
        {
            d1.Roll();
            d2.Roll();
            num1 = d1.GetNum();
            num2 = d2.GetNum();
            Console.WriteLine(num1 + " , " + num2);
            turnCount++;
        }
        Console.WriteLine($"It took {turnCount} turns to get to 6 , 6.");
        Console.ReadKey();
    }

    static void Main4(string[] args)
    {
        //driving teacher
        Console.WriteLine("New student: Please enter ID number and minimal amount of lessons to take a test.");
        string ID = Console.ReadLine();
        int minlessons = int.Parse(Console.ReadLine());
        Talmid firstTalmid = new Talmid(minlessons, ID);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Week {0}/5: Enter amount of lessons this week, and then write 'yes' if went to test or 'no' if not.", i + 1);
            int newLessons = int.Parse(Console.ReadLine());
            string tookTest = Console.ReadLine();
            firstTalmid.AddLessons(newLessons);
            if (tookTest.ToLower() == "yes")
            {
                firstTalmid.AddTest();
            }
        }
        Console.WriteLine("Overall amount of lessons: " + firstTalmid.GetNumLessons());
        if (firstTalmid.GetNumLessons()>minlessons)
        {
            if (firstTalmid.IsWeakStudent())
            {
                Console.WriteLine("weak student.");
            }
            else
            {
                Console.WriteLine("not a weak student.");
            }
        }
        else
        {
            Console.WriteLine(firstTalmid.LessonsLeftToTest() + " lessons left until test.");
        }
        Console.ReadKey();
    }

    static void Main()
    {
        //Car selling
        int value1 = 45000, value2 = 72000, value3 = 30000;
        Car toyota = new Car(2, value1, 4, 70000);
        Car corvette = new Car(1,value2,3,20000);
        Car fiat = new Car(4, value3, 7, 150000);
        // I decided this Main is too brute for me so Im not going to write it.
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

