class Lasagna
{
    private int total{get;}
    // TODO: define the 'ExpectedMinutesInOven()' method
    public Lasagna(){
        total = 40;
    }

    public int ExpectedMinutesInOven() => total;

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int num) => total - num;
    
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int num) => num * 2;
    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int num1, int num2) => PreparationTimeInMinutes(num1) + num2; 
}
