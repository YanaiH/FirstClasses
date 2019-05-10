using System;


class Car
{
    private int numOldOwners;
    private int value;
    private double yearsOnRoad;
    private int totalKMage;

    public Car(int numOldOwners, int value, double yearsOnRoad, int totalKMage)
    {
        if (numOldOwners>0)
        {
            this.numOldOwners = numOldOwners;
        }
        if (value> 0)
        {
            this.value = value;
        }
        if (yearsOnRoad> 0)
        {
            this.yearsOnRoad = yearsOnRoad;
        }
        if (totalKMage> 0)
        {
            this.totalKMage = totalKMage;
        }
    }

    public double YearlyAvg()
    {
        return totalKMage / yearsOnRoad;
    }

    public bool IsGood()
    {
        if (numOldOwners == 1 && yearsOnRoad <= 5 && YearlyAvg() < 10000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool Isdecent()
    {
        if (yearsOnRoad < 8 && YearlyAvg() < 15000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

