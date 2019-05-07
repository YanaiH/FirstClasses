using System;



class Die
{
    private int num;
    Random r = new Random();
    public Die() // constructor
    {
        num = r.Next(1, 7);
    }

    public void Roll()  //to roll again
    {
        num = r.Next(1, 7);
    }

    public int GetNum()
    {
        return num;
    }

}

