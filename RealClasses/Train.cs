using System;


class Train
{
    private string trainNum;
    private string currentStation;
    private int totalDistance;
    private int engineDistance;
    private int numOveralls;

    public Train(string trainNum, string currentStation)
    {
        if (trainNum.Length >= 0)
        {
            this.trainNum = trainNum;
        }
        if (currentStation.Length >= 0)
        {
            this.currentStation = currentStation;
        }
    }

    public int GetTotalDistance()
    {
        return totalDistance;
    }

    public string GetTrainNum()
    {
        return trainNum;
    }

    public string  GetCurrentStation()
    {
        return currentStation;
    }

    public int GetEngineDistance()
    {
        return engineDistance;
    }

    public int GetNumOveralls()
    {
        return numOveralls;
    }

    public void SetStation(string stationName)
    {
        if (stationName.Length >= 0) 
        {
            currentStation = stationName;
        }
    }

    public void AddKm (int numOfKms)
    {
        totalDistance = totalDistance + numOfKms;
        engineDistance = engineDistance + numOfKms;
    }

    public bool IsMaintenanceNeeded()
    {
        if (engineDistance>100000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int DoMaintenance()
    {
        int lastEngineDistance = engineDistance;
        numOveralls++;
        engineDistance = 0;
        return lastEngineDistance;
    }

    public override string ToString()
    {
        return $"Train number: {trainNum} , Station name: {currentStation} ,Train distance: {totalDistance} , Current Engine Distance: {engineDistance} , Number of Overalls: {numOveralls} .";
    }
}

