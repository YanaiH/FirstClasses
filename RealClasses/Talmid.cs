using System;


// מתוך דף עבודה מהוואטסאפ "עצמים תרגילים" שאלה 5
class Talmid
{
    private string taz;
    private int lessonsNum = 0;
    private int testsNum = 0;
    private int minLessonsForTest;

    public Talmid(int minLessonsForTest, string taz)
    {
        if (minLessonsForTest>0)
        {
            this.minLessonsForTest = minLessonsForTest;
        }
        if (taz.Length == 9)
        {
            this.taz = taz;
        }
    }


    public void AddLessons (int numNewLessons)
    {
        if (numNewLessons >= 0)
        {
            lessonsNum = lessonsNum + numNewLessons;
        }
    }

    public void AddTest()
    {
        testsNum++;
    }

    public int LessonsLeftToTest()
    {
        return minLessonsForTest - lessonsNum;
    }

    public bool IsWeakStudent()
    {
        if (lessonsNum-20>=minLessonsForTest && testsNum == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int GetNumTests()
    {
        return testsNum;
    }

    public int GetNumLessons()
    {
        return lessonsNum;
    }
}

