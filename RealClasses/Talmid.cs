using System;


// מתוך דף עבודה מהוואטסאפ "עצמים תרגילים" שאלה 5
class Talmid
{
    private string taz;
    private int lessonsNum;
    private int testsNum;

    public Talmid(string taz, int lessonsNum, int testsNum)
    {
        if (taz.Length == 9)
        {
            this.taz = taz;
        }
        if (lessonsNum >= 0)
        {
            this.lessonsNum = lessonsNum;
        }
        if (testsNum >= 0)
        {
            this.testsNum = testsNum;
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

    public int LessonsLeftToTest(int minLessonsForTest)
    {
        return minLessonsForTest - lessonsNum;
    }

    public bool IsWeakStudent (int minLessonsForTest)
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
}

