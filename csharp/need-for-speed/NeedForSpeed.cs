using System;

class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class

    private readonly int speed;
    private readonly int batteryDrain;
    private int battery = 100;
    private int mDriven;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battery < batteryDrain;
    }

    public int DistanceDriven()
    {
        return mDriven;
    }

    public void Drive()
    {
        if(BatteryDrained())return;
        mDriven += speed;
        battery = battery - batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);

    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class

    private int distante;
    public RaceTrack(int distance)
    {
        this.distante = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do{
            car.Drive();
            if(car.DistanceDriven() >= distante) return true;
        } 
        while(!car.BatteryDrained());

        return false;
    }
}
