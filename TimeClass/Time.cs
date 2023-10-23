using System;

namespace TimeClass;
class Time
{

    private int hour, minute, second;

    public Time(int hour, int minute, int second)
    {
        setHour(hour);
        setMinute(minute);
        setSecond(second);
    }
    public int getHour()
    {
        return hour;
    }
    public void setHour(int value)
    {
        if (value < 0 || value > 23)
        {
            Console.WriteLine("Zadej platné číslo 0-23");
        }
        else
        {
            hour = value;
        }
    }
    public int getMinute()
    {
        return minute;
    }
    public void setMinute(int value)
    {
        if (value < 0 || value > 59)
        {
            Console.WriteLine("Zadej platné číslo 0-59");
        }
        else
        {
            minute = value;
        }
    }
    public int getSecond()
    {
        return second;
    }
    public void setSecond(int value)
    {
        if (value < 0 || value > 59)
        {
            Console.WriteLine("Zadej platné číslo 0-59");
        }
        else
        {
            second = value;
        }
    }
    public void SetTime(int hour, int minute, int second)
    {
        setHour(hour);
        setMinute(minute);
        setSecond(second);
    }

    public void nextSecond()
    {
        second += 1;
        if (second >= 60)
        {
            second = 0;
            minute += 1;
            if (minute >= 60)
            {
                minute = 0;
                hour += 1;
                if (hour >= 24)
                {
                    hour = 0;
                }
            }
        }
    }

    public void previousSecond()
    {
        second -= 1;
        if (second < 0)
        {
            second = 59;
            minute -= 1;
            if (minute < 0)
            {
                minute = 59;
                hour -= 1;
                if (hour < 0)
                {
                    hour = 23;
                }
            }
        }
    }

    public override string ToString()
    {
        string cas = $"{hour:D2}:{minute:D2}:{second:D2}";
        return cas;
    }


}