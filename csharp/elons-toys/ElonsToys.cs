using System;

class RemoteControlCar
{ 
    private int distance;
    private int batery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
    }

    public string BatteryDisplay()
    {
        if(batery == 0) return "Battery empty";
        return $"Battery at {batery}%";
    }

    public void Drive()
    {
        if(batery <= 0) return;
        batery--;
        distance += 20; 
    }
}
