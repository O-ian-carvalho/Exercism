using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if(year % 100 == 0)
        {
            return (year % 400 == 0);
        }
        else
        {
            return (year % 4 == 0);
        }
    }
}